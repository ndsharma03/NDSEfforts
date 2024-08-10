
using AltimerticCodeChallenge.DataAccess;
using AltimerticCodeChallenge.DataAccess.Dapper;
using AltimerticCodeChallenge.DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AltimerticCodeChallenge.DTO;
using Microsoft.OpenApi.Models;

namespace AltimerticCodeChallenge
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Logging configuration

            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.File($"Logs/{builder.Configuration["Logging:LogFileName"] +"-"+".txt"}", rollingInterval: RollingInterval.Day)
                 .WriteTo.Console()
                 .CreateLogger();
            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog();
            
            // Add services to the container.

            builder.Services.AddControllers();

            //********
            JWTOptions jwtOptions = new JWTOptions();
            builder.Configuration.GetSection(JWTOptions.JWTSettings).Bind(jwtOptions);
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer =jwtOptions.Issuer, 
                    ValidAudience = jwtOptions.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Key)),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true
                };
            });

            //**********
            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            
            builder.Services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo { Title = "DrugAPI", Version = "v1" });
                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter bearer token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "bearer"
                });
                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type=ReferenceType.SecurityScheme,
                                    Id="Bearer"
                                }
                            },
                            new string[]{}
                        }
                    });
            }

            );

            // EFCore configuration
            builder.Services.AddDbContext<DrugDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")!);
            });

            //Dapper Configuration
            builder.Services.AddSingleton<DapperDrugContext>();
            builder.Services.AddScoped<IDrugRepository, DrugReposiotry>();

            builder.Services.Configure<JWTOptions>(builder.Configuration.GetSection(JWTOptions.JWTSettings));

            //Using HTTP Logging middleware
            builder.Services.AddHttpLogging(o => { });

            var app = builder.Build();
            
            app.UseHttpLogging();//HTTP Logging middleware.

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                // app.UseDeveloperExceptionPage();
                app.UseExceptionHandler("/error");//testing
            }
            //else
            //{
            //    app.UseExceptionHandler("/error");
            //}
            
            app.UseHttpsRedirection();
            
            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}