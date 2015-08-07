// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Microsoft.Azure.Management.Search.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines the SKU of an Azure Search Service, which determines price
    /// tier and capacity limits.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Gets or sets the SKU of the Search service. Possible values for
        /// this property include: 'free', 'standard', 'standard2'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public SkuType? Name { get; set; }

    }
}
