﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Xncf.XncfBuilder.Templates.Areas.Admin.Pages.MyApps
{
    public partial class DatabaseSample_cs : IXncfTemplatePage
    {
        public string RelativeFilePath => $"Areas/Admin/Pages/{XncfName}/DatabaseSample.cshtml.cs";

        public string OrgName { get; set; }
        public string XncfName { get; set; }
        public string MenuName { get; set; }


        public DatabaseSample_cs(string orgName, string xncfName, string menuName)
        {
            OrgName = orgName;
            XncfName = xncfName;
            MenuName = menuName;
        }
    }
}
