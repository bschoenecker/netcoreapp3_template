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
