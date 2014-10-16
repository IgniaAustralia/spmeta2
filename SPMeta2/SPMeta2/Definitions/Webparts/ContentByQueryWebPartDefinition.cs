﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Attributes;
using SPMeta2.Attributes.Regression;
using SPMeta2.Definitions.Base;

namespace SPMeta2.Definitions.Webparts
{
    /// <summary>
    /// Allows to define and deploy 'Content by Query' web part.
    /// </summary>
    [SPObjectType(SPObjectModelType.SSOM, "System.Web.UI.WebControls.WebParts.WebPart", "System.Web")]
    [SPObjectType(SPObjectModelType.CSOM, "Microsoft.SharePoint.Client.WebParts.WebPart", "Microsoft.SharePoint.Client")]

    [DefaultRootHost(typeof(WebDefinition))]
    [DefaultParentHost(typeof(WebPartPageDefinition))]

    [Serializable]
    public class ContentByQueryWebPartDefinition : WebPartDefinition
    {
        #region properties

        public string DataMappings { get; set; }
        public string DataMappingViewFields { get; set; }

        public bool? PlayMediaInBrowser { get; set; }
        public bool? UseCopyUtil { get; set; }

        public int? ItemLimit { get; set; }

        public int? ServerTemplate { get; set; }

        public string WebUrl { get; set; }
        public Guid? ListGuid { get; set; }

        public string ItemStyle { get; set; }
        public string GroupStyle { get; set; }

        public bool? ShowUntargetedItems { get; set; }

        public string MainXslLink { get; set; }
        public string ItemXslLink { get; set; }

        #endregion
    }
}
