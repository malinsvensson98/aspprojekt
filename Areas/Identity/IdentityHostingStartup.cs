using System;
using aspprojekt.Areas.Identity.Data;
using aspprojekt.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(aspprojekt.Areas.Identity.IdentityHostingStartup))]
namespace aspprojekt.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<aspprojektIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("aspprojektIdentityDbContextConnection")));
            });
        }
    }
}

