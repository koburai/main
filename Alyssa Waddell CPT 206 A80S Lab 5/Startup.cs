namespace Alyssa_Waddell_CPT_206_A80S_Lab_5
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // error page doesn't exist yet but IF IT DID.
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseDefaultFiles(new DefaultFilesOptions
            {
                // default page when you run the program takes you to the database.
                DefaultFileNames = new List<string> { "statedata.html" }
            });
            app.UseStaticFiles();

            app.UseRouting();

            // i had this commented out during testing
            //i spent an hour wondering why the table wasn't populating
            // this. this is why. it updates the api w/ the request.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
