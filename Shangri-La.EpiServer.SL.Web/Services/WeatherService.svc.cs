using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using log4net;
using Newtonsoft.Json;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace Shangri_La.EpiServer.SL.Web.Services
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class WeatherService : ServiceBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(WeatherService));

        private static Injected<ContentLocator> contentLocator { get; set; }

        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        [AspNetCacheProfile("CacheServiceWeatherService")]
        //[WebGet(UriTemplate = "/GetCurrentWeatherJSON/?hotelCode={hotelCode}&cityCode={cityCode}&lat={latitude}&lon={longitude}", ResponseFormat = WebMessageFormat.Json)]
        [WebGet(UriTemplate = "/GetCurrentWeatherJSON/?hotelCode={hotelCode}", ResponseFormat = WebMessageFormat.Json)]
        public WeatherRawData GetCurrentWeatherJSON(string hotelCode)
        {
            var hotelBlocks = contentLocator.Service.GetHotelBlocks() as List<HotelBlock>;
            HotelBlock hotelBlock = hotelBlocks.Where(h => h.HotelCode == hotelCode).FirstOrDefault();

            if (hotelBlock != null)
            {
                string output = GetWeatherJsonFunc(hotelBlock.Latitude, hotelBlock.Longitude);

                if (!string.IsNullOrEmpty(output))
                {
                    try
                    {
                        JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
                        jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                        WeatherRawData wrd = JsonConvert.DeserializeObject<WeatherRawData>(output, jsonSerializerSettings);
                        if (wrd != null && wrd.weather != null)
                        {
                            return wrd;
                        }
                    }
                    catch { }
                }
            }

            return new WeatherRawData();
            //return new List<string>() { "test", "testb", hotelCode, cityCode };

        }

        [OperationContract]
        //[AspNetCacheProfile("CacheServiceWeatherService")]
        [WebGet(UriTemplate = "/GetTimeZoneJSON/?hotelCode={hotelCode}&cityCode={cityCode}&lat={latitude}&lon={longitude}&timestamp={timestamp}", ResponseFormat = WebMessageFormat.Json)]
        public TimeZoneRawData GetTimeZoneJSON(string latitude, string longitude, string hotelCode, string cityCode, string timestamp)
        {
            string output = GetTimeZoneJsonFunc(latitude, longitude, timestamp);

            if (!string.IsNullOrEmpty(output))
            {
                try
                {
                    JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
                    jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                    TimeZoneRawData trd = JsonConvert.DeserializeObject<TimeZoneRawData>(output, jsonSerializerSettings);
                    if (trd != null && trd.timeZoneId != null)
                    {
                        return trd;
                    }
                }
                catch { }
            }

            return new TimeZoneRawData() { timeZoneId = "Asia/Shanghai" };

        }


        private string GetWeatherJsonFunc(string latitude, string longitude)
        {
            string resultString = string.Empty;

            try
            {
                string weatherInfoUrl = ConfigurationManager.AppSettings["WeatherInfoUrl"];
                int weatherInfoTimeout = 1000; // default 1sec
                int.TryParse(ConfigurationManager.AppSettings["WeatherInfoTimeout"], out weatherInfoTimeout);

                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                WebRequest request = (HttpWebRequest)WebRequest.Create(string.Format(weatherInfoUrl, latitude, longitude));
                request.Method = "GET";
                request.Timeout = weatherInfoTimeout;

                // get response
                using (var response = request.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        StreamReader streamReader = new StreamReader(responseStream);
                        resultString = streamReader.ReadToEnd();
                        //... clear the result if it contains error
                        if (string.IsNullOrWhiteSpace(resultString))
                        {
                            resultString = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Logger.Error(this, "error in getting Weather Info ", ex);
                resultString = string.Empty;
            }

            return resultString;
        }


        private string GetTimeZoneJsonFunc(string latitude, string longitude, string timestamp)
        {
            string resultString = string.Empty;

            try
            {
                string timeZoneInfoUrl = ConfigurationManager.AppSettings["TimeZoneInfoUrl"];
                int timeZoneInfoTimeout = 1000; // default 1sec
                int.TryParse(ConfigurationManager.AppSettings["TimeZoneInfoTimeout"], out timeZoneInfoTimeout);

                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                WebRequest request = (HttpWebRequest)WebRequest.Create(string.Format(timeZoneInfoUrl, latitude, longitude, timestamp));
                request.Method = "GET";
                request.Timeout = timeZoneInfoTimeout;

                // get response
                using (var response = request.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        StreamReader streamReader = new StreamReader(responseStream);
                        resultString = streamReader.ReadToEnd();
                        //... clear the result if it contains error
                        if (string.IsNullOrWhiteSpace(resultString))
                        {
                            resultString = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Logger.Error(this, "error in getting Weather Info ", ex);
                resultString = string.Empty;
            }

            return resultString;
        }

        public static bool ValidateServerCertificate(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }


        //public Stream GetWeatherJSON(string param)
        //{
        //    try
        //    {
        //        Parameter parameter = JsonConvert.DeserializeObject<Parameter>(param);
        //        //List<ExperienceViewModel> lstExperiences = ExperienceHelper.GetExperienceLists(parameter);

        //        //return CreateJsonResponse(lstExperiences, GlobalHelper.DoPrintableJson());

        //        List<string> testList = new List<string>();
        //        return CreateJsonResponse(testList);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.ErrorFormat("GetExperiencesJSON() : EXCEPTION   message='{0}' stack  {1}",
        //            /*1*/ ex.Message,
        //            /*2*/ ex.StackTrace);
        //    }

        //    return null;
        //}
    }

    // Add more operations here and mark them with [OperationContract]

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public int humudity { get; set; }
        public int pressure { get; set; }
        public string temp { get; set; }
        public string temp_max { get; set; }
        public string temp_min { get; set; }
    }

    public class Coord
    {
        public string lon { get; set; }
        public string lat { get; set; }
    }

    public class WeatherRawData
    {
        public string cod { get; set; }
        public long dt { get; set; }
        public Coord coord { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
    }    

    public class TimeZoneRawData
    {
        public string timeZoneId { get; set; }
    }

    //public class Parameter
    //{
    //    public string Latitude { get; set; }

    //    public string Longitude { get; set; }

    //}
}
