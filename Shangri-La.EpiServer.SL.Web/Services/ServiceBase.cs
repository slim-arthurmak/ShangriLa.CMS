using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using log4net;

namespace Shangri_La.EpiServer.SL.Web.Services
{
    public class ServiceBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ServiceBase));

        protected Stream CreateJsonResponse(object response, bool format = false)
        {
            try
            {
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                var jsonString = JsonConvert.SerializeObject(response, format ? Formatting.Indented : Formatting.None);
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                return stream;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("CreateJsonResponse: FAILED  message='{0}' stack was {1}",
                    /*0*/ ex.Message,
                    /*1*/ ex.StackTrace);

                return null;
            }
        }

        protected dynamic ReadJsonRequest(string request)
        {
            return ReadJsonRequestInternal(request);
        }

        protected dynamic ReadJsonRequest(Stream request)
        {
            using (var streamReader = new StreamReader(request))
            {
                var requestString = streamReader.ReadToEnd();

                return ReadJsonRequestInternal(requestString);
            }
        }

        /// <summary>
        ///     HTML encode before processing request. Restore quotes, because these are part of the JSON definition
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private dynamic ReadJsonRequestInternal(string request)
        {
            var encodedRequest = HttpUtility.HtmlEncode(request);
            encodedRequest = encodedRequest.Replace("&quot;", "\"");

            dynamic jsonObject = JObject.Parse(encodedRequest);
            return jsonObject;
        }

        /// <summary>
        ///     Sets content language to the language code that was sent in the accept-language HTTP header.
        ///     (If this where a CMS application, like EPiServer, then we would se the CMS language for this request)
        ///     NOTE that this SHOULD use .net and /or ISO locale (YBD)
        ///     short ==  .NET culture == ISO Locale
        ///     EN == en-HK  ==  en_HK = English (Hong Kong SAR China)"
        ///     ZH == zh-CN  ==  zh_Hans_CN = "Chinese (Simplified Han, China)",
        /// </summary>
        /// <param name="langOverride"> Ovverides the HTTP request header setting</param>
        //protected GlobalHelper.Language SetContentLanguage(string langOverride)
        //{
        //    var language = GlobalHelper.Language.EN;
        //    char[] DelimiterChars = { ',', ';' };
        //    var or = false;
        //    var found = false;

        //    try
        //    {
        //        var requestLanguage = HttpContext.Current.Request.Headers["accept-language"];
        //        if (!string.IsNullOrWhiteSpace(langOverride))
        //        {
        //            foreach (GlobalHelper.Language lang in Enum.GetValues(typeof(GlobalHelper.Language)))
        //            {
        //                foreach (var l in GlobalHelper.LanguageISOvariants[lang])
        //                {
        //                    if (langOverride.Equals(l, StringComparison.InvariantCultureIgnoreCase))
        //                    {
        //                        language = lang;
        //                        or = true;
        //                        log.DebugFormat("SetContentLanguage(): Override language to {0}",
        //                            language.ToString().ToLower());
        //                        break;
        //                    }
        //                }
        //                if (or) break;
        //            }
        //        }

        //        if (!or)
        //        {
        //            if (!string.IsNullOrEmpty(requestLanguage))
        //            {
        //                var languages = requestLanguage.Split(DelimiterChars, StringSplitOptions.RemoveEmptyEntries);

        //                foreach (GlobalHelper.Language lang in Enum.GetValues(typeof(GlobalHelper.Language)))
        //                {
        //                    foreach (var l in GlobalHelper.LanguageISOvariants[lang])
        //                    {
        //                        var index = Array.FindIndex(languages, x => x.ToLower() == l.ToString().ToLower());
        //                        if (index != -1)
        //                        {
        //                            language = lang;
        //                            found = true;
        //                            break;
        //                        }
        //                    }
        //                    if (found) break;
        //                }
        //                if (!found)
        //                    log.WarnFormat(
        //                        "SetContentLanguage(): 'accept-language' request header {0} does not contain GlobalHelper.Language value ",
        //                        requestLanguage);
        //            }
        //            else
        //            {
        //                log.DebugFormat("SetContentLanguage(): 'accept-language' request header not found ");
        //            }
        //        }
        //        WebOperationContext.Current.OutgoingResponse.Headers.Add("Content-Language",
        //            GlobalHelper.LanguageISOvariants[language][0]);
        //        HttpContext.Current.Items["ContentLanguage"] = GlobalHelper.LanguageISOvariants[language][0];

        //        log.DebugFormat("SetContentLanguage(): Added {0} to 'Content-Language'",
        //            GlobalHelper.LanguageISOvariants[language][0]);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.ErrorFormat("SetContentLanguage(): EXCEPTION message='{0}' stack was {1}",
        //            /*0*/ ex.Message,
        //            /*1*/ ex.StackTrace);
        //    }
        //    return language;
        //}

    }
}