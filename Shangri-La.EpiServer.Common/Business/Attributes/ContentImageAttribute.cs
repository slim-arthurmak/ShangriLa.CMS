using EPiServer.DataAnnotations;
using System.Linq;

namespace Shangri_La.EpiServer.Common.Business.Attributes
{
    public class ContentImageAttribute : ImageUrlAttribute
    {
        public ContentImageAttribute() : base("~/Content/ContentIcons/default.png") { }

        public ContentImageAttribute(string path) : base((path.Contains('/')) ? path : "~/Content/ContentIcons/" + path) { }
    }
}