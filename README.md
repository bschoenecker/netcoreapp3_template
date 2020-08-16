# .NET Core 3.1.401 Starter Template

Base 'dotnet new web' template with the following actions performed:

- Added .gitignore file and included common exclusions
- Created the Models, Controllers, Views, Views/Home, Views/Shared, and wwwroot directories
- Added 'services.AddControllersWithViews();' to Startup.cs service configuration
- Adding the following to the Startup.cs configuration:
    - app.UseDeveloperExceptionPage(); (*detailed exceptions useful during development*)
    - app.UseStatusCodePages(); (*adds HTTP status codes*)
    - app.UseStaticFiles(); (*allows use of static content in 'wwwroot' directory*)
    - endpoints.MapDefaultControllerRoute(); (*register MVC as endpoints*)
- Added '_ViewImports.cshtml' in Views folder (*change namespace after renaming project*)
- Added '_ViewStart.cshtml' in Views folder
- Added '_Layout.cshtml' in Views/Shared folder
- Added 'HomeController.cs' in Controllers folder
- Added 'Index.cshtml' to Views/Home folder
- Installed package 'Microsoft.EntityFrameworkCore.Design' version 3.1.4
- Installed package 'Microsoft.EntityFrameworkCore.SqlServer' version 3.1.4
- Installed tool 'dotnet-ef' version 3.1.4 (*local global setting*)
- Added the following SQL connection string in 'appsettings.json':
            "ConnectionStrings:" {
            "netcoreapp3Connection": "Server=LOCALHOST\\SQLEXPRESS;Database=netcoreapp3;MultipleActiveResultSets=true"
            }
- Added 'DbContext.cs' class for Entity Framework
- Added Entity Framework configurations in 'Startup.cs':
    - Added 'using Microsoft.Extensions.Configuration;'
    - Added 'using Microsoft.EntityFrameworkCore;'
    - Added 'using netcoreapp3_template.Models;'
- Added constructor for Startup class and the following config:
            public Startup(IConfiguration config) {
            Configuration = config;
            }
            private IConfiguration Configuration {get; set;}
- Added service for Entity Framework in Startup.cs:
            services.AddDbContext<netcoreapp3Context>(opts => {
                opts.UseSqlServer(Configuration["ConnectionStrings:netcoreapp3Connection"]);
            })
            }
