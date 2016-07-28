using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Collections.Generic;
using System.Web.UI.WebControls;


using Shangri_La.EpiServer.SL.Web.Models.Blocks;

namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels
{
    public class HotelInformationSummaryViewModel
    {
        public HotelInformationSummaryViewModel()
        {

        }

        public HotelInformationSummaryViewModel(HotelBlock hotel)
        {
            if (hotel != null)
            {
                HotelName = hotel.HotelName;
                Title = string.Format("Contact {0}", HotelName);

                Address = hotel.Address;
                Phone = hotel.Phone;
                Fax = hotel.Fax;
                Email = hotel.Email;
                CheckInTime = hotel.CheckInTime;
                CheckOutTime = hotel.CheckOutTime;
                PaymentModeList = hotel.PaymentModeList;

                PaymentModelModels = new List<PaymentModelModel>();

                if (PaymentModeList != null)
                {
                    foreach (string payment in PaymentModeList)
                    {
                        string img = "";
                        int width = 24;
                        int height = 24;
                        string alt = "";

                        switch (payment)
                        {
                            case "AX":
                                img = "amex-logo";
                                width = 24;
                                height = 24;

                                break;

                            case "DC":
                                img = "diners-club-logo";
                                width = 30;
                                height = 22;

                                break;

                            case "JC":
                                img = "jcb-logo";
                                width = 28;
                                height = 22;

                                break;

                            case "MC":
                                img = "mastercard-logo";
                                width = 33;
                                height = 20;

                                break;

                            case "VA":
                                img = "visa-logo";
                                width = 39;
                                height = 14;

                                break;

                            /*
                        case "AP":
                            img = "amex-logo";
                            width = 24;
                            height = 24;

                            break;
                            */
                            case "UP":
                                img = "union-pay-logo";
                                width = 33;
                                height = 21;

                                break;
                                /*
                            case "TP":
                                img = "amex-logo";
                                width = 24;
                                height = 24;

                                break;
                                */
                        }

                        PaymentModelModel paymentModel = new PaymentModelModel();
                        paymentModel.Name = payment;
                        paymentModel.Code = payment;
                        paymentModel.Logo = new Image
                        {
                            ImageUrl = string.Format("/Content/img/content/{0}.png", img),
                            AlternateText = alt,
                            Width = width,
                            Height = height
                        };

                        PaymentModelModels.Add(paymentModel);

                    }
                }
            }
        }

        public string Title { get; set; }

        public string HotelName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string CheckInTime { get; set; }

        public string CheckOutTime { get; set; }

        public List<string> PaymentModeList { get; set; }

        public List<PaymentModelModel> PaymentModelModels { get; set; }
    }

    public class PaymentModelModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Image Logo { get; set; }
    }
}