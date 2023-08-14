﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SamCooks.API.DbContext;
using SamCooks.API.Entities;
using SamCooks.API.Entities.Config;
using SamCooks.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCooks.API
{
    public partial class Startup
    {
        public void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                       new OpenApiInfo
                       {
                           Title = "Samcooks API",
                           Version = "v1",
                           Description = "Sam cooks Platform",
                           Contact = new OpenApiContact
                           {
                               Name = "SAMCOOKS",
                               Email = "Info@samcooks.com"
                           },
                           License = new OpenApiLicense
                           {
                               Name = "MIT License",
                               Url = new Uri("https://en.wikipedia.org/wiki/MIT_Lincense")
                           }
                       });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using Bearer scheme. \r\n\r\n" +
                    "Enter 'Bearer' [space] and then your token in the input below.\r\n\r\n" +
                    "Example: \"Bearer 123456\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }

                });

                c.DescribeAllParametersInCamelCase();
            });
        }

        public void ConfigureEntityFrameworkDbContext(IServiceCollection services)
        {
            string dbConnectionString = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    dbConnectionString,
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        }

        public void AddIdentityProvider(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequiredLength = 7;
                options.Password.RequireNonAlphanumeric = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Password.RequiredUniqueChars = 1;

            }).AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.Configure<DataProtectionTokenProviderOptions>(options =>
            {
                options.TokenLifespan = TimeSpan.FromHours(24);
            });
        }

        public void ConfigureJWTAuthentication(IServiceCollection services)
        {
            var appSettingsSection = Configuration.GetSection("JWT");
            services.Configure<Jwt>(appSettingsSection);

            var appSettings = appSettingsSection.Get<Jwt>();
            var secret = Encoding.ASCII.GetBytes(appSettings.Secret);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = true;
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = appSettings.ValidIssuer,
                    ValidAudience = appSettings.ValidAudience,
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    RequireExpirationTime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secret)
                };

                o.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];

                        // If the request is for our hub...
                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) &&
                            (path.StartsWithSegments("/api")))
                        {
                            // Read the token out of the query string
                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };
            });
        }

        public void ConfigureDIService(IServiceCollection services)
        {
            //services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(HostingEnvironment.ContentRootPath, Configuration.GetValue<string>("FilePath"))));
            //services.AddSignalR();

            //services.AddTransient<DbContext, ApplicationDbContext>();
            services.AddScoped<IArtistService, ArtistService>();
            //services.AddScoped<INotificationService, NotificationService>();
            //services.AddScoped<IEmailService, EmailService>();
            //services.AddScoped<IBgJobService, BackgroundService>();
            //services.AddScoped<IAuthenticationService, AuthenticationService>();
            //services.AddScoped<IEncrypt, EncryptService>();
            //services.AddScoped<IDenominationService, DenominationService>();
            //services.AddScoped<ICountryService, CountryService>();
            //services.AddScoped<ITermsService, TermsService>();
            //services.AddScoped<ITransactionService, TransactionService>();
            //services.AddScoped<IPushNotificationService, PushNotificationService>();
            //services.AddScoped<IReceiptService, ReceiptService>();
            //services.AddScoped<ICardService, CardService>();
            //services.AddScoped<ICardSaleService, CardSaleService>();
            //services.AddScoped<IPrefixService, PrefixService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IDashboardService, DashboardService>();
            //services.AddScoped<ICloudinaryServices, CloudinaryUploadHelper>();
            //services.AddScoped<IFaqService, FaqService>();
            //services.AddScoped<IAdService, AdService>();
            //services.AddScoped<ISettingService, SettingService>();
            //services.AddScoped<IReferralService, ReferralService>();



            //services.Configure<SmtpConfigSettings>(Configuration.GetSection("SmtpConfig"));

            //services.Configure<FcmNotification>(Configuration.GetSection("FcmNotification"));

            //services.Configure<CloudinaryAccount>(Configuration.GetSection("Cloudinary"));

            //services.Configure<EmailLinkDTO>(options =>
            // Configuration.GetSection(nameof(EmailLinkDTO)).Bind(options));


            //// Setup PolicyBase Authorization
            //services.AddSingleton<IAuthorizationPolicyProvider, AuthorizationPolicyProvider>();
            //services.AddSingleton<IAuthorizationHandler, ActionRequirementHandler>();

            //services.AddHangfire(configuration => configuration
            //   .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
            //   .UseSimpleAssemblyNameTypeSerializer()
            //   .UseRecommendedSerializerSettings()
            //   .UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
            //   {
            //       CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
            //       SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
            //       QueuePollInterval = TimeSpan.Zero,
            //       UseRecommendedIsolationLevel = true,
            //       DisableGlobalLocks = true
            //   }));

            //services.AddHangfireServer();

        }
    }
}