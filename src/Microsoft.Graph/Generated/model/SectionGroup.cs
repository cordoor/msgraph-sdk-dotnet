// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Section Group.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SectionGroup : OnenoteEntityHierarchyModel
    {
    
		///<summary>
		/// The SectionGroup constructor
		///</summary>
        public SectionGroup()
        {
            this.ODataType = "microsoft.graph.sectionGroup";
        }
	
        /// <summary>
        /// Gets or sets section groups url.
        /// The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sectionGroupsUrl", Required = Newtonsoft.Json.Required.Default)]
        public string SectionGroupsUrl { get; set; }
    
        /// <summary>
        /// Gets or sets sections url.
        /// The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sectionsUrl", Required = Newtonsoft.Json.Required.Default)]
        public string SectionsUrl { get; set; }
    
        /// <summary>
        /// Gets or sets parent notebook.
        /// The notebook that contains the section group. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentNotebook", Required = Newtonsoft.Json.Required.Default)]
        public Notebook ParentNotebook { get; set; }
    
        /// <summary>
        /// Gets or sets parent section group.
        /// The section group that contains the section group. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentSectionGroup", Required = Newtonsoft.Json.Required.Default)]
        public SectionGroup ParentSectionGroup { get; set; }
    
        /// <summary>
        /// Gets or sets section groups.
        /// The section groups in the section. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sectionGroups", Required = Newtonsoft.Json.Required.Default)]
        public ISectionGroupSectionGroupsCollectionPage SectionGroups { get; set; }
    
        /// <summary>
        /// Gets or sets sections.
        /// The sections in the section group. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sections", Required = Newtonsoft.Json.Required.Default)]
        public ISectionGroupSectionsCollectionPage Sections { get; set; }
    
    }
}

