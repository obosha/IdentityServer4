// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace QuickstartIdentityServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "IdentityServer";

            var host = new WebHostBuilder()
                .UseKestrel(
                            options =>
                            {
	                            options.UseHttps("localhost.pfx", "DominickRocks!");
	                            //options.UseConnectionLogging();
                            })
                .UseUrls("https://localhost:5443")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}