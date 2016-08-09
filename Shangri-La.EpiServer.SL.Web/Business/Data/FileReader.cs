﻿using Shangri_La.EpiServer.SL.Web.Models.Media;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shangri_La.EpiServer.SL.Web.Business.Data
{
    public class FileReader
    {
        public static string GetFileSize(MediaData media)
        {
            if (media != null)
            {
                using (var stream = media.BinaryData.OpenRead())
                {
                    return (stream.Length / 1024) + " kB";
                }
            }
            return string.Empty;
        }
    }
}
