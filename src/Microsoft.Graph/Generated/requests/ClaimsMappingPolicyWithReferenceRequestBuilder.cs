// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ClaimsMappingPolicyWithReferenceRequestBuilder.
    /// </summary>
    public partial class ClaimsMappingPolicyWithReferenceRequestBuilder : BaseRequestBuilder, IClaimsMappingPolicyWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new ClaimsMappingPolicyWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ClaimsMappingPolicyWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IClaimsMappingPolicyWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IClaimsMappingPolicyWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new ClaimsMappingPolicyWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the claimsMappingPolicy.
        /// </summary>
        /// <returns>The <see cref="IClaimsMappingPolicyReferenceRequestBuilder"/>.</returns>
        public IClaimsMappingPolicyReferenceRequestBuilder Reference
        {
            get
            {
                return new ClaimsMappingPolicyReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
