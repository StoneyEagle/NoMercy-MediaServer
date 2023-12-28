using System.Text;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using NoMercy.Server.Helpers;
using NoMercy.Server.Logic;

namespace NoMercy.Server;

public class Startup
{
    public static ApiInfo? ApiInfo;
    
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors();
        services.AddSingleton<UserLogic>();
        services.AddAuthorizationBuilder().AddPolicy("api", policy =>
        {
            policy.RequireAuthenticatedUser();
            policy.AddAuthenticationSchemes(IdentityConstants.BearerScheme);
            policy.RequireClaim("scope", "api");
        });
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = "https://auth-dev2.nomercy.tv/realms/NoMercyTV"; // your keycloak address
                options.Audience = "nomercy-server";
                options.RequireHttpsMetadata = true; // For testing, you might want to set this to true in production
            });
        
        services.AddAuthorization();
        services.AddMvc(option => option.EnableEndpointRouting = false);
    }

    public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

        app.UseCors(options =>
        {
            options.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
        
        app.UseHttpsRedirection();
        
        app.UseAuthentication();
        app.UseAuthorization();
        
        app.UseMvcWithDefaultRoute();
        
        Console.WriteLine($@"Internal Address: {Networking.InternalAddress}");
        Console.WriteLine($@"External Address: {Networking.ExternalAddress}");
        
        await Task.Run(ElectronWindows.Start);

    }
}
