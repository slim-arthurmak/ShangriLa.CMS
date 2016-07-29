using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.DataAbstraction.Migration;

namespace Shangri_La.EpiServer.SL.Web.Business.Migration
{
    public class RoomDetailPageMigrationStep : MigrationStep
    {
        public override void AddChanges()
        {
            RenameContentType();
            //RenameProperty();
            //RenameRoomSuiteBlockProperty();
        }

        private void RenameContentType()
        {
            //The content type formerly known as "Velocipede" should hereby be known as "Bicycle".
            ContentType("ExploreOtherRoomsListBlock")
                .UsedToBeNamed("ExploreOtherRoomsContentBlock");
        }

        private void RenameProperty()
        {
            ContentType("HotelPage")                  //On the content type "Bicycle"
                .Property("SectionContentArea")          //There is a property called "PneumaticTire"
                    .UsedToBeNamed("ModuleContentArea");   //That used to be called "WoodenTire"
        }

        private void RenameRoomSuiteBlockProperty()
        {
            ContentType("RoomSuiteBlock")                  //On the content type "Bicycle"
                .Property("RoomName")          //There is a property called "PneumaticTire"
                    .UsedToBeNamed("RoomType");   //That used to be called "WoodenTire"
        }
        
    }
}