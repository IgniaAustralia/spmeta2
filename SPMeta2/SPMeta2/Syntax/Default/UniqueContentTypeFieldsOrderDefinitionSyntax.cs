﻿using System;
using SPMeta2.Definitions;
using SPMeta2.Definitions.ContentTypes;
using SPMeta2.Models;
using SPMeta2.Syntax.Default.Extensions;

namespace SPMeta2.Syntax.Default
{
    public static class UniqueContentTypeFieldsOrderDefinitionSyntax
    {
        #region methods


        public static ContentTypeModelNode AddUniqueContentTypeFieldsOrder(this ContentTypeModelNode model, UniqueContentTypeFieldsOrderDefinition definition)
        {
            return AddUniqueContentTypeFieldsOrder(model, definition, null);
        }

        public static ContentTypeModelNode AddUniqueContentTypeFieldsOrder(this ContentTypeModelNode model, UniqueContentTypeFieldsOrderDefinition definition, Action<ModelNode> action)
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion
    }
}
