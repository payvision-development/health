﻿namespace Payvision.Diagnostics.Health
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// A health service that executes multiple health check policies.
    /// </summary>
    public interface IHealthService : IDisposable
    {
        /// <summary>
        /// Checks the health of the application executing asynchronously the configured health checks.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> of the asynchronous operation.</param>
        /// <returns>The <see cref="HealthReport"/> of the application at the calling time.</returns>
        Task<HealthReport> CheckAsync(CancellationToken cancellationToken);
    }
}
