using System;
using CoreLogAndReg.Areas.Identity.Data;
using CoreLogAndReg.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CoreLogAndReg.Areas.Identity.IdentityHostingStartup))]
namespace CoreLogAndReg.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CoreLogAndRegContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CoreLogAndRegContextConnection")));

                services.AddDefaultIdentity<CoreLogAndRegUser>(options => { options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<CoreLogAndRegContext>();
            });
        }
    }
}