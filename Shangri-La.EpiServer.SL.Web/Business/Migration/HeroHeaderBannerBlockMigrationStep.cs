using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.DataAbstraction.Migration;

namespace Shangri_La.EpiServer.SL.Web.Business.Migration
{
    public class HeroHeaderBannerBlockMigrationStep : MigrationStep
    {
        public override void AddChanges()
        {
            RenameContentType();
            //RenameProperty();
        }

        private void RenameContentType()
        {
            //The content type formerly known as "Velocipede" should hereby be known as "Bicycle".
            ContentType("HeroHeaderBannerBlock")
                .UsedToBeNamed("HeroBannerBlock");
        }

        private void RenameProperty()
        {
            //ContentType("HeroHeaderBannerBlock")                  //On the content type "Bicycle"
            //    .Property("Heading")          //There is a property called "PneumaticTire"
            //        .UsedToBeNamed("Title");   //That used to be called "WoodenTire"

            ContentType("HeroHeaderBannerBlock")                  //On the content type "Bicycle"
                .Property("Introduction")          //There is a property called "PneumaticTire"
                    .UsedToBeNamed("ShortDescription");   //That used to be called "WoodenTire"

            //ContentType("HeroHeaderBannerBlock")                  //On the content type "Bicycle"
            //    .Property("MainText")          //There is a property called "PneumaticTire"
            //        .UsedToBeNamed("LongDescription");   //That used to be called "WoodenTire"
            
        }
        
        
    }
}