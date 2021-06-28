using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Turchik_Html_Intro.DAL.Data;
using Turchik_Html_Intro.DAL.Entities;

[assembly: HostingStartup(typeof(Turchik_Html_Intro.Areas.Identity.IdentityHostingStartup))]
namespace Turchik_Html_Intro.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}