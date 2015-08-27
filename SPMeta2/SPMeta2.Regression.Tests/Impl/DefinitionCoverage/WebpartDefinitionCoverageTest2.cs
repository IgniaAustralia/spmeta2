﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Containers;
using SPMeta2.Containers.Standard;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Base;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Regression.Tests.Impl.Scenarios.Base;
using SPMeta2.Standard.Services.Webparts;
using SPMeta2.Syntax.Default;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Enumerations;
using SPMeta2.Regression.Definitions;
using SPMeta2.Standard.Definitions;
using SPMeta2.Standard.Enumerations;
using SPMeta2.Containers.Extensions;
using SPMeta2.Containers.Services;
using SPMeta2.Extensions;
using SPMeta2.Models;
using SPMeta2.Regression.Definitions.Extended;
using SPMeta2.Containers.Consts;

namespace SPMeta2.Regression.Tests.Impl.DefinitionCoverage
{
    [TestClass]
    public class WebpartDefinitionCoverageTest : SPMeta2RegresionScenarioTestBase
    {
        #region internal

        [ClassInitializeAttribute]
        public static void Init(TestContext context)
        {
            InternalInit();
        }

        [ClassCleanupAttribute]
        public static void Cleanup()
        {
            InternalCleanup();
        }

        #endregion

        #region pre-generated tests

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_WebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<WebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_PageViewerWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<PageViewerWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_SilverlightWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<SilverlightWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_UserCodeWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<UserCodeWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ClientWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ClientWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ScriptEditorWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ScriptEditorWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ContentEditorWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ContentEditorWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ListViewWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ListViewWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_XsltListViewWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<XsltListViewWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ProjectSummaryWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ProjectSummaryWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_RefinementScriptWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<RefinementScriptWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ContactFieldControlDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ContactFieldControlDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ContentBySearchWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ContentBySearchWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ContentByQueryWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ContentByQueryWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_ResultScriptWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<ResultScriptWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_SiteFeedWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<SiteFeedWebPartDefinition>();
        }

        [TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
        public void CanDeploy_SummaryLinkWebPartDefinition_To_AllPageTypes()
        {
            DeployWebpartOnSupportedHosts<SummaryLinkWebPartDefinition>();
        }

        #endregion

        #region utils

        private void DeployWebpartOnSupportedHosts<TWebpartType>()
            where TWebpartType : WebPartDefinitionBase, new()
        {
            var siteModel = SPMeta2Model.NewSiteModel(site =>
            {
                site.AddSiteFeature(BuiltInSiteFeatures.SharePointServerPublishingInfrastructure.Inherit(def =>
                {
                    def.Enable = true;
                }));

                site.AddSiteFeature(BuiltInSiteFeatures.EnableAppSideLoading.Inherit(def =>
                {
                    def.Enable = true;
                }));

                // for sandbx web parts and SSOM
                var sandboxSolution = ModelGeneratorService.GetRandomDefinition<SandboxSolutionDefinition>();
                site.AddSandboxSolution(sandboxSolution);

                site.AddSiteFeature(new FeatureDefinition()
                {
                    Id = DefaultContainers.Sandbox.WebPartFeatureId,
                    Enable = true,
                    Scope = FeatureDefinitionScope.Site
                });
            });

            var model = SPMeta2Model.NewWebModel(web =>
            {
                // always deploy to root web 
                FillWebWithTheTestwebPartSuite<TWebpartType>(web);

                // and then sub web too
                web.AddRandomWeb(subWeb =>
                {
                    FillWebWithTheTestwebPartSuite<TWebpartType>(subWeb);
                });
            });

            WithDisabledPropertyUpdateValidation(() =>
            {
                TestModel(siteModel, model);
            });
        }

        protected bool ShoudValidatePresenceOnListViews(WebPartDefinitionBase webPartDefinition)
        {
            var result = true;

            // Investigate 'ListViewWebPartDefinition' provision specifics on list views #646
            // https://github.com/SubPointSolutions/spmeta2/issues/646
            if (webPartDefinition is ListViewWebPartDefinition)
            {
                result = false;
            }

            return result;
        }

        protected bool ShoudValidatePresenceOnLibraryViews(WebPartDefinitionBase webPartDefinition)
        {
            var result = true;

            // Investigate 'ListViewWebPartDefinition' provision specifics on list views #646
            // https://github.com/SubPointSolutions/spmeta2/issues/646
            if (webPartDefinition is ListViewWebPartDefinition)
            {
                result = false;
            }

            return result;
        }

        protected virtual void FillWebWithTheTestwebPartSuite<TWebpartType>(WebModelNode currentWeb)
            where TWebpartType : WebPartDefinitionBase, new()
        {
            var initialDef = ModelGeneratorService.GetRandomDefinition(typeof(TWebpartType)) as TWebpartType;

            var wikiWebPartDef = initialDef.Clone<TWebpartType>();
            var webpartPageWebPartDef = initialDef.Clone<TWebpartType>();
            var publishingPageWebPartDef = initialDef.Clone<TWebpartType>();

            var listWebPartDef = initialDef.Clone<TWebpartType>();
            var docWebPartDef = initialDef.Clone<TWebpartType>();

            // ensure for the client web part
            currentWeb.AddRandomApp();

            currentWeb
                /// for the Pages lib & pubnlishing pages
                .AddWebFeature(BuiltInWebFeatures.SharePointServerPublishing.Inherit(def =>
                {
                    def.Enable = true;
                }))

                .AddHostList(BuiltInListDefinitions.SitePages, list =>
                {
                    var webpartPageName = string.Empty;
                    var wikiPageName = string.Empty;

                    list
                        // 1 - wiki pages
                        .AddRandomWikiPage(page =>
                        {
                            wikiPageName = (page.Value as WikiPageDefinition).FileName;
                            page.AddDefinitionNode(wikiWebPartDef);
                        })
                        // 2- web part pages
                        .AddRandomWebPartPage(page =>
                        {
                            webpartPageName = (page.Value as WebPartPageDefinition).FileName;
                            page.AddDefinitionNode(webpartPageWebPartDef);
                        });

                    ValidateWebPartPresenceForPage(list, wikiPageName, wikiWebPartDef);
                    ValidateWebPartPresenceForPage(list, webpartPageName, webpartPageWebPartDef);

                })
                // 3 - publishing pages
                .AddHostList(BuiltInListDefinitions.Pages, list =>
                {
                    var publishingPageName = string.Empty;

                    list
                        .AddRandomPublishingPage(page =>
                        {
                            (page.Value as PublishingPageDefinition).PageLayoutFileName =
                                BuiltInPublishingPageLayoutNames.BlankWebPartPage;
                            publishingPageName = (page.Value as PublishingPageDefinition).FileName;

                            page.AddDefinitionNode(publishingPageWebPartDef);
                        });

                    ValidateWebPartPresenceForPage(list, publishingPageName, publishingPageWebPartDef);
                })
                // 4 - list related routines - OOTB views, custom views & forms
                .AddRandomList(list =>
                {
                    // OOTB view
                    list.AddHostListView(BuiltInListViewDefinitions.Lists.AllItems, listView =>
                    {
                        listView.AddDefinitionNode(listWebPartDef.Inherit());
                    });

                    if (ShoudValidatePresenceOnListViews(initialDef))
                        ValidateWebPartPresenceForPage(list, BuiltInListViewDefinitions.Lists.AllItems.Url, listWebPartDef);

                    // custom view
                    var customView = ModelGeneratorService.GetRandomDefinition<ListViewDefinition>(def =>
                    {
                        def.Url = Rnd.AspxFileName();
                    });

                    list.AddListView(customView, listView =>
                    {
                        listView.AddDefinitionNode(listWebPartDef.Inherit());
                    });

                    if (ShoudValidatePresenceOnListViews(initialDef))
                        ValidateWebPartPresenceForPage(list, customView.Url, listWebPartDef);

                    // OOTB forms, new - edit - view
                    list.AddHostListView(BuiltInListViewDefinitions.Lists.NewForm, listView =>
                    {
                        listView.AddDefinitionNode(listWebPartDef.Inherit());
                    });

                    ValidateWebPartPresenceForPage(list, BuiltInListViewDefinitions.Lists.NewForm.Url, listWebPartDef);

                    list.AddHostListView(BuiltInListViewDefinitions.Lists.EditForm, listView =>
                    {
                        listView.AddDefinitionNode(listWebPartDef.Inherit());
                    });


                    ValidateWebPartPresenceForPage(list, BuiltInListViewDefinitions.Lists.EditForm.Url, listWebPartDef);

                    list.AddHostListView(BuiltInListViewDefinitions.Lists.DispForm, listView =>
                    {
                        listView.AddDefinitionNode(listWebPartDef.Inherit());
                    });


                    ValidateWebPartPresenceForPage(list, BuiltInListViewDefinitions.Lists.DispForm.Url, listWebPartDef);
                })

                // 5 - OOTB list view form on the library
                .AddRandomDocumentLibrary(list =>
                {
                    // OOTB view

                    list.AddHostListView(BuiltInListViewDefinitions.Libraries.AllItems, listView =>
                    {
                        listView.AddDefinitionNode(docWebPartDef.Inherit());
                    });

                    if (ShoudValidatePresenceOnLibraryViews(initialDef))
                        ValidateWebPartPresenceForPage(list, "Forms/" + BuiltInListViewDefinitions.Libraries.AllItems.Url, docWebPartDef);

                    // custom view
                    var customView = ModelGeneratorService.GetRandomDefinition<ListViewDefinition>(def =>
                    {
                        def.Url = Rnd.AspxFileName();
                    });

                    list.AddListView(customView, listView =>
                    {
                        listView.AddDefinitionNode(docWebPartDef.Inherit());
                    });

                    if (ShoudValidatePresenceOnLibraryViews(initialDef))
                        ValidateWebPartPresenceForPage(list, "Forms/" + customView.Url, docWebPartDef);

                    // OOTB new - edit - view forms
                    // upload, NOPE!
                    //list.AddHostListView(BuiltInListViewDefinitions.Libraries.Upload, listView =>
                    //{
                    //    listView.AddDefinitionNode(docWebPartDef.Inherit());
                    //});

                    //ValidateWebPartPresenceForPage(list, "Forms/" + BuiltInListViewDefinitions.Libraries.Upload.Url, docWebPartDef);

                    list.AddHostListView(BuiltInListViewDefinitions.Libraries.EditForm, listView =>
                    {
                        listView.AddDefinitionNode(docWebPartDef.Inherit());
                    });

                    ValidateWebPartPresenceForPage(list, "Forms/" + BuiltInListViewDefinitions.Libraries.EditForm.Url, docWebPartDef);

                    list.AddHostListView(BuiltInListViewDefinitions.Libraries.DispForm, listView =>
                    {
                        listView.AddDefinitionNode(docWebPartDef.Inherit());
                    });

                    ValidateWebPartPresenceForPage(list, "Forms/" + BuiltInListViewDefinitions.Libraries.DispForm.Url, docWebPartDef);
                });
            ;

            // all web parts chrom
            currentWeb.WithNodesOfType<WebPartDefinitionBase>(node =>
            {
                var wp = node.Value as WebPartDefinitionBase;

                wp.ChromeType = BuiltInPartChromeType.TitleAndBorder;
                wp.ChromeState = BuiltInPartChromeState.Normal;
            });
        }

        protected void ValidateWebPartPresenceForPage(ModelNode list, string pageName, WebPartDefinitionBase wp)
        {
            ValidateWebPartPresenceForPage(list, pageName, new[] { wp });
        }

        protected void ValidateWebPartPresenceForPage(ModelNode list, string pageName,
            IEnumerable<WebPartDefinitionBase> wps)
        {
            list.AddDefinitionNode(new WebpartPresenceOnPageDefinition
            {
                PageFileName = pageName,
                WebPartDefinitions = new List<WebPartDefinitionBase>(wps)
            }, def =>
            {
                def.RegExcludeFromEventsValidation();
            });
        }

        #endregion
    }

}
