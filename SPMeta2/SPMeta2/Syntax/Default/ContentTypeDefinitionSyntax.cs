﻿using System;
using System.Collections.Generic;
using SPMeta2.Definitions;
using SPMeta2.Models;
using SPMeta2.Syntax.Default.Extensions;

namespace SPMeta2.Syntax.Default
{
    public class ContentTypeModelNode : TypedModelNode
    {

    }

    public static class ContentTypeDefinitionSyntax
    {
        #region consts

        private const string ContentTypeGuidFormatString = "N";

        #endregion

        #region methods

        public static SiteModelNode AddContentType(this SiteModelNode model, ContentTypeDefinition definition)
        {
            return AddContentType(model, definition, null);
        }

        public static SiteModelNode AddContentType(this SiteModelNode model, ContentTypeDefinition definition, 
            Action<ContentTypeModelNode> action)
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        public static WebModelNode AddContentType(this WebModelNode model, ContentTypeDefinition definition)
        {
            return AddContentType(model, definition, null);
        }

        public static WebModelNode AddContentType(this WebModelNode model, ContentTypeDefinition definition,
            Action<ContentTypeModelNode> action)
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

       

        public static SiteModelNode AddContentTypes(this SiteModelNode siteModel, IEnumerable<ContentTypeDefinition> definitions)
        {
            foreach (var definition in definitions)
                AddContentType(siteModel, definition);

            return siteModel;
        }

        public static WebModelNode AddContentTypes(this WebModelNode siteModel, IEnumerable<ContentTypeDefinition> definitions)
        {
            foreach (var definition in definitions)
                AddContentType(siteModel, definition);

            return siteModel;
        }


        public static bool IsChildOf(this ContentTypeDefinition childContentTypeDefinition,
            ContentTypeDefinition parentContentTypeDefinition)
        {
            return IsChildOf(childContentTypeDefinition.GetContentTypeId(), parentContentTypeDefinition.GetContentTypeId());
        }

        public static bool IsChildOf(this ContentTypeDefinition childContentTypeDefinition,
            string parentContentTypId)
        {
            return IsChildOf(childContentTypeDefinition.GetContentTypeId(), parentContentTypId);
        }

        public static bool IsChildOf(string childId, string parentId)
        {
            if (parentId.Length < childId.Length)
                return false;

            for (int i = 0; i < childId.Length; i++)
                if (childId[i] != parentId[i])
                    return false;

            return true;
        }

        public static string GetContentTypeId(this ContentTypeDefinition contentType)
        {
            if (contentType.Id != default(Guid))
            {
                // for content types like
                // 0x010100339210063E00144CBB5EFF79F55FE57400D05BFCF30398485FBBD6D5BB034AFF74
                // 0x010100339210063E00144CBB5EFF79F55FE57400D05BFCF30398485FBBD6D5BB034AFF74008FA22F0260524AF78AF78C349553F22E

                return contentType.ParentContentTypeId + "00" + contentType.Id.ToString(ContentTypeGuidFormatString).ToUpper();
            }

            if (!string.IsNullOrEmpty(contentType.IdNumberValue))
            {
                // for content types like
                // 0x010100339210063E00144CBB5EFF79F55FE574 
                // 0x010100339210063E00144CBB5EFF79F55FE57401 
                // 0x010100339210063E00144CBB5EFF79F55FE5740101

                return contentType.ParentContentTypeId + contentType.IdNumberValue;
            }

            // TODO
            // however, validation system for model definition are going to be implemented
            throw new ArgumentException("Either Id or IdNumberValue have to be specified for content type model");
        }

        #endregion

        #region add host

        public static ModelNode AddHostContentType(this ModelNode model, ContentTypeDefinition definition)
        {
            return AddHostContentType(model, definition, null);
        }

        public static ModelNode AddHostContentType(this ModelNode model, ContentTypeDefinition definition, Action<ModelNode> action)
        {
            return model.AddDefinitionNodeWithOptions(definition, action, ModelNodeOptions.New().NoSelfProcessing());
        }


        #endregion
    }
}
