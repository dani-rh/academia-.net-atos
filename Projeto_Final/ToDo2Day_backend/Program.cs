using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using System.Reflection;
using ToDo2Day.Repository;
using ToDo2Day.DataModels;
using ToDo2Day.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ToDo2Day
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Configure builder with command line arguments
            var builder = WebApplication.CreateBuilder(args);

            // Define a CORS policy
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            // Load JWT settings from app configuration and configure DI container
            builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

            // Uncomment the following lines if you want to use SQL Server and replace "DefaultConnection" with your connection string
            // builder.Services.AddDbContext<Context>(options =>
            //     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add authentication services to DI and configure JWT bearer
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                // Set options for token validation
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
                    ValidAudience = builder.Configuration["JwtSettings:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]))
                };
            });

            // Add authorization services to DI
            builder.Services.AddAuthorization();

            // Add repository services to DI
            builder.Services.AddScoped<ITagRepository, TagRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ITaskItemRepository, TaskItemRepository>();

            // Add controllers to DI
            builder.Services.AddControllers();

            // Add OpenAPI/Swagger services to DI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                // Set up Swagger doc and security definition
                c.SwaggerDoc("v1", new() { Title = "TaskManager", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer"
                });

                // Add security requirement for Swagger
                c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });

                // Include XML comments in Swagger
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            // Add database context to DI
            builder.Services.AddDbContext<Context>();

            // Build the application
            var app = builder.Build();

            // Use Swagger in development environment
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskManager API V1");
                });
            }

            // Use error handling middleware in production environment
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            // Use HTTPS redirection middleware
            app.UseHttpsRedirection();

            // Use authentication middleware
            app.UseAuthentication();

            // Use authorization middleware
            app.UseAuthorization();

            // Map controller routes
            app.MapControllers();

            // Use CORS policy
            app.UseCors(policy =>
            policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            // Run the application
            app.Run();
        }
    }
}