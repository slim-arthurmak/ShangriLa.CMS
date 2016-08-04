using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.DataAbstraction.Migration;

namespace Shangri_La.EpiServer.SL.Web.Business.Migration
{
    public class HotelHomepageContentBlockMigrationStep : MigrationStep
    {
        public override void AddChanges()
        {
            //RenameContentType();
            RenameProperty();
        }

        private void RenameContentType()
        {
            //The content type formerly known as "Velocipede" should hereby be known as "Bicycle".
            ContentType("Bicycle")
                .UsedToBeNamed("Velocipede");
        }

        private void RenameProperty()
        {
            ContentType("HotelHomepageContentBlockData")                  //On the content type "Bicycle"
                .Property("Heading")          //There is a property called "PneumaticTire"
                    .UsedToBeNamed("Title");   //That used to be called "WoodenTire"

            ContentType("HotelHomepageContentBlockData")                  //On the content type "Bicycle"
                .Property("IntroText")          //There is a property called "PneumaticTire"
                    .UsedToBeNamed("ShortDescription");   //That used to be called "WoodenTire"

            ContentType("HotelHomepageContentBlockData")                  //On the content type "Bicycle"
                .Property("MainText")          //There is a property called "PneumaticTire"
                    .UsedToBeNamed("LongDescription");   //That used to be called "WoodenTire"
            
        }
        
        
    }
}