﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServer.ServiceLocation;

using ShangriLa.CMS.SL.Web.Models.Pages;
using ShangriLa.CMS.SL.Web.Models.ViewModels;
using ShangriLa.CMS.SL.Web.Models.Blocks;


namespace ShangriLa.CMS.SL.Web.Controllers.Pages
{
    public class HotelPageController : PageControllerBase<HotelPage>
    {
        public ActionResult Index(HotelPage currentPage)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

            HotelBlock hotelBlock = contentRepository.Get<HotelBlock>(currentPage.HotelBlock);

            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            PropertyPageViewModel<HotelPage> model = new PropertyPageViewModel<HotelPage>(currentPage);
            //PropertyPageViewModel model = new PropertyPageViewModel(currentPage);

            model.Hotel = hotelBlock;


            return View(model);
        }
    }
}