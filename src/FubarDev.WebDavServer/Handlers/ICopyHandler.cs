﻿// <copyright file="ICopyHandler.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System;
using System.Threading;
using System.Threading.Tasks;

using JetBrains.Annotations;

namespace FubarDev.WebDavServer.Handlers
{
    /// <summary>
    /// Interface for the <code>COPY</code> handler
    /// </summary>
    public interface ICopyHandler : IClass1Handler
    {
        /// <summary>
        /// Copies from the source to the destination
        /// </summary>
        /// <param name="sourcePath">The source to copy</param>
        /// <param name="destination">The destination to copy to</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>The result of the operation</returns>
        [NotNull]
        [ItemNotNull]
        Task<IWebDavResult> CopyAsync([NotNull] string sourcePath, [NotNull] Uri destination, CancellationToken cancellationToken);
    }
}
