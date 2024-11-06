namespace DifferentWaysToGenerateLinksInAspNetCoreMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                // Assigning a unique name to the route for identification purposes.
                // This can be used later for URL generation.
                name: "ProductDetails",
                // Defining the URL pattern that will be matched for this route.
                // In this case, the URL will be of the form: "Products/Details/{id}".
                // "{id}" is a route parameter placeholder that will capture the product's ID from the URL.
                pattern: "Products/Details/{id}",
                // Specifying default route values that will be used if none are provided in the URL.
                // Here, the controller is set to "Products" and the action method is set to "Details".
                // This means that if a request matches the "Products/Details/{id}" pattern,
                // it will be directed to the ProductsController's Details action method.
                defaults: new { controller = "Products", action = "Details" }
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
