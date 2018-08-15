﻿using System.Collections.Generic;
using SPMeta2.Definitions;
using SPMeta2.Validation.Common;

namespace SPMeta2.Validation.Validators.Collections
{
    public class FieldCollectionValidator : CollectionValidatorBase
    {
        public override void Validate(IEnumerable<DefinitionBase> models, List<ValidationResult> result)
        {
            Validate<FieldDefinition>(models, model =>
            {
                CheckIfUnique(model, m => m.Id, result);
                CheckIfUnique(model, m => m.InternalName, result);
            });
        }
    }
}