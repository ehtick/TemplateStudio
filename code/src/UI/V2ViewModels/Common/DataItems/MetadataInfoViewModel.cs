﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Templates.Core;

namespace Microsoft.Templates.UI.V2ViewModels.Common
{
    public class MetadataInfoViewModel : BasicInfoViewModel
    {
        public MetadataInfoViewModel(MetadataInfo metadataInfo)
        {
            Name = metadataInfo.Name;
            Title = metadataInfo.DisplayName;
            Description = metadataInfo.Description;
            Author = metadataInfo.Author;
            Order = metadataInfo.Order;
        }
    }
}
