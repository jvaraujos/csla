﻿#if NETSTANDARD2_0 || NETCOREAPP3_1 || NET5_0_OR_GREATER
//-----------------------------------------------------------------------
// <copyright file="WebConfiguration.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Implement extension methods for .NET Core configuration</summary>
//-----------------------------------------------------------------------
using System;
using Microsoft.AspNetCore.Builder;

namespace Csla.Configuration
{
  /// <summary>
  /// Implement extension methods for .NET Core configuration
  /// </summary>
  public static class WebConfigurationExtensions
  {
    /// <summary>
    /// Configures the application to use CSLA .NET
    /// </summary>
    /// <param name="app">ApplicationBuilder object</param>
    public static IApplicationBuilder UseCsla(this IApplicationBuilder app)
    {
      return UseCsla(app, null);
    }

    /// <summary>
    /// Configures the application to use CSLA .NET
    /// </summary>
    /// <param name="app">ApplicationBuilder object</param>
    /// <param name="config">Implement to configure CSLA .NET</param>
    public static IApplicationBuilder UseCsla(this IApplicationBuilder app, Action<CslaConfiguration> config)
    {
      config?.Invoke(CslaConfiguration.Configure());
      return app;
    }
  }
}
#endif