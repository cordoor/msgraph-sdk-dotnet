// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    /// <summary>
    /// GeneratedErrorConstants
    /// </summary>
    public static class GeneratedErrorConstants
    {
        /// <summary>
        /// GeneratedErrorConstants.Codes
        /// </summary>
        public static class Codes
        {
            /// <summary>
            /// GeneratedErrorConstants.Codes.NotAllowed
            /// </summary>
            public static string NotAllowed = "notAllowed";
        }

        /// <summary>
        /// GeneratedErrorConstants.Messages
        /// </summary>
        public static class Messages
        {
            /// <summary>
            /// GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate
            /// </summary>
            public static string ResponseObjectUsedForUpdate = "Do not use objects returned in a response for updating an object in Microsoft Graph. " +
                                                                 "Create a new {0} object and only set the updated properties on it.";
        }
    }
}
