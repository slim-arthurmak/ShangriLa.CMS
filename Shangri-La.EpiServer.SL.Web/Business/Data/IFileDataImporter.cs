﻿using System;
namespace Shangri_La.EpiServer.SL.Web.Business.Data
{
    interface IFileDataImporter
    {
        string[] RetrieveAllData(string fullFileName);

        bool ImportFileExists(string fullFileName);

        string[] SplitByDelimiter(string row, char[] delimiter);
    }
}
