﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Xncf.XncfBuilder.Templates
{
    public partial class Register : IXncfTemplatePage
    {
        /// <summary>
        /// 相对地址
        /// </summary>
        public string RelativeFilePath => "Register.cs";

        public string OrgName { get; set; }
        public string XncfName { get; set; }
        public string Uid { get; set; }
        public string Version { get; set; }
        public string MenuName { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string FunctionTypes { get; set; }

        public bool UseFunction { get; set; }
        public bool UseDatabase { get; set; }

        public bool UseSample { get; set; }
    }
}
