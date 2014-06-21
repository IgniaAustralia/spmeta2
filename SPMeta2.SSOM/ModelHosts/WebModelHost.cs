﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace SPMeta2.SSOM.ModelHosts
{
    public class WebModelHost : SSOMModelHostBase
    {
        #region contructors

        public WebModelHost()
        {

        }

        public WebModelHost(SPWeb web)
        {
            HostWeb = web;
        }

        #endregion

        #region properties

        public SPWeb HostWeb { get; set; }

        #endregion

        #region static

        public static WebModelHost FromWeb(SPWeb web)
        {
            return new WebModelHost(web);
        }

        #endregion
    }
}
