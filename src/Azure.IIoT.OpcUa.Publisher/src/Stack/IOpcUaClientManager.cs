// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Azure.IIoT.OpcUa.Publisher.Stack
{
    using Azure.IIoT.OpcUa.Publisher.Stack.Models;
    using Azure.IIoT.OpcUa.Publisher.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Client managers manages clients connected to servers and provides
    /// access to session services.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOpcUaClientManager<T>
    {
        /// <summary>
        /// Connectivity state change events
        /// </summary>
        event EventHandler<EndpointConnectivityState> OnConnectionStateChange;

        /// <summary>
        /// Add certificate to trust list
        /// </summary>
        /// <param name="certificate"></param>
        /// <returns></returns>
        Task AddTrustedPeerAsync(byte[] certificate);

        /// <summary>
        /// Execute the service on the provided session and
        /// return the result.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="connection"></param>
        /// <param name="func"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<TResult> ExecuteAsync<TResult>(T connection,
            Func<ServiceCallContext, Task<TResult>> func,
            CancellationToken ct = default);

        /// <summary>
        /// Execute the functions from stack on the provided
        /// session and stream the results.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="connection"></param>
        /// <param name="stack"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        IAsyncEnumerable<TResult> ExecuteAsync<TResult>(T connection,
            Stack<Func<ServiceCallContext, ValueTask<IEnumerable<TResult>>>> stack,
            CancellationToken ct = default);

        /// <summary>
        /// Remove certificate from trust list
        /// </summary>
        /// <param name="certificate"></param>
        /// <returns></returns>
        Task RemoveTrustedPeerAsync(byte[] certificate);
    }
}
