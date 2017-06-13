using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyQuotesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyQuotesAPI
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      var connectionString = "Server=tcp:ys5b7llk3o.database.windows.net,1433;Initial Catalog=myquotes;Persist Security Info=False;User ID=hamid;Password=myQ0u135;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=1200;";
      services.AddDbContext<QuoteInfoContext>(o => o.UseSqlServer(connectionString));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      loggerFactory.AddConsole();

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler();
      }

      app.UseStatusCodePages();
      app.UseMvc();

      //app.Run(async (context) =>
      //{
      //  await context.Response.WriteAsync("Hello World!");
      //});
    }
  }
}
