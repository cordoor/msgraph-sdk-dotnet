// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type SearchRequest.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SearchRequestObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestObject"/> class.
        /// </summary>
        public SearchRequestObject()
        {
            this.ODataType = "microsoft.graph.searchRequest";
        }

        /// <summary>
        /// Gets or sets contentSources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentSources", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ContentSources { get; set; }
    
        /// <summary>
        /// Gets or sets enableTopResults.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableTopResults", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableTopResults { get; set; }
    
        /// <summary>
        /// Gets or sets entityTypes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "entityTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<EntityType> EntityTypes { get; set; }
    
        /// <summary>
        /// Gets or sets fields.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fields", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Fields { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "from", Required = Newtonsoft.Json.Required.Default)]
        public Int32? From { get; set; }
    
        /// <summary>
        /// Gets or sets query.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "query", Required = Newtonsoft.Json.Required.Default)]
        public SearchQuery Query { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "size", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Size { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
