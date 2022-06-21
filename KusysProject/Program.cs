using KUSYSDemo.Business.AutoMapperProfile;
using KUSYSDemo.Business.DiContainer;
using KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYSDemo.Entities.Concrete;
using KUSYSDemo.Web;
using KUSYSDemo.Web.CustomCollectionExtension;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddContainerWithDependencies();

builder.Services.AddDbContext<PiccusCareContext>();

//builder.Services.AddDbContext<PiccusCareContext>(options =>
//        options.UseSqlServer(
//            builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentityConfigure();
builder.Services.AddValidator();

builder.Services.AddAutoMapper(typeof(MapProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/Home/StatusCode", "?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//IdentityInitializer.SeedData().Wait();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
        );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );
});

app.Run();
