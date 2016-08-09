using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using Shangri_La.EpiServer.SL.Web.Models.Blocks;

namespace Shangri_La.EpiServer.SL.Web.Models.Folders
{
    [ContentType(DisplayName = "CountryBlockContentFolder", GUID = "d8b58a6d-4233-4329-a0d6-43a3aa112208", Description = "")]
    [AvailableContentTypes(Availability.Specific, Include = new[] { typeof(CountryBlock) })]
    public class CountryBlockContentFolder : ContentFolder
    {
    }
}