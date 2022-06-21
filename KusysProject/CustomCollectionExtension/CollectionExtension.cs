using FluentValidation;
using KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYSDemo.Entities.Concrete;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace KUSYSDemo.Web.CustomCollectionExtension
{
    public static class CollectionExtension
    {
        public static void AddIdentityConfigure(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
            })
                  .AddEntityFrameworkStores<PiccusCareContext>();

            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "IsTakipCookie";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                opt.Cookie.HttpOnly = true;
                opt.ExpireTimeSpan = TimeSpan.FromDays(20);
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                opt.LoginPath = "/Home/Index";
            });
        }
        public static void AddValidator(this IServiceCollection services)
        {
            //services.AddTransient<IValidator<AciliyetAddDto>, AciliyetAddValidator>();
            //services.AddTransient<IValidator<AciliyetUpdateDto>, AciliyetUpdateValidator>();

            //services.AddTransient<IValidator<AppUserAddDto>, AppUserAddValidator>();
            //services.AddTransient<IValidator<AppUserSignInDto>, AppUserSignInValidator>();

            //services.AddTransient<IValidator<GorevAddDto>, GorevAddValidator>();
            //services.AddTransient<IValidator<GorevUpdateDto>, GorevUpdateValidator>();

            //services.AddTransient<IValidator<RaporAddDto>, RaporAddValidator>();
            //services.AddTransient<IValidator<RaporUpdateDto>, RaporUpdateValidator>();
        }
    }
}
