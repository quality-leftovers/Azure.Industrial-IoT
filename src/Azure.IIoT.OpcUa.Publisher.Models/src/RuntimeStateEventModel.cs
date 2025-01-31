﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Azure.IIoT.OpcUa.Publisher.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Model for reporting runtime state.
    /// </summary>
    [DataContract]
    public class RuntimeStateEventModel
    {
        /// <summary>
        /// Defines the message type that is sent.
        /// </summary>
        [DataMember(Name = "MessageType", Order = 0,
            EmitDefaultValue = true)]
        public RuntimeStateEventType MessageType { get; set; }

        /// <summary>
        /// Defines the message version.
        /// </summary>
        [DataMember(Name = "MessageVersion", Order = 1,
            EmitDefaultValue = true)]
        public int MessageVersion { get; set; }
    }
}
