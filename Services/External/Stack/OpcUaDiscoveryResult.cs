﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IoTSolutions.OpcTwin.Services.External {
    using Opc.Ua;
    using System.Collections.Generic;

    /// <summary>
    /// Endpoint information returned from discover
    /// </summary>
    public class OpcUaDiscoveryResult {

        /// <summary>
        /// Endpoint
        /// </summary>
        public EndpointDescription Description { get; set; }

        /// <summary>
        /// Capabilities of endpoint (server)
        /// </summary>
        public IEnumerable<string> Capabilities { get; set; }
    }
}