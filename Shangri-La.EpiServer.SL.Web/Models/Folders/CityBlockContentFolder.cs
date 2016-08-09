using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;


using Shangri_La.EpiServer.SL.Web.Models.Blocks;

namespace Shangri_La.EpiServer.SL.Web.Models.Folders
{
    [ContentType(DisplayName = "CityBlockContentFolder", GUID = "d9c729eb-b021-4bc7-8376-3ff89975ecde", Description = "")]
    [AvailableContentTypes(Availability.Specific, Include = new[] { typeof(CityBlock) })]
    public class CityBlockContentFolder : ContentFolder
    {
    }
}