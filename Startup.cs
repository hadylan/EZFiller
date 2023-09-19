namespace EZFiller
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Cette méthode est utilisée pour configurer les services de l'application.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configurez vos services ici, par exemple, l'injection de dépendances, Entity Framework, etc.
        }

        // Cette méthode est utilisée pour configurer le pipeline de traitement des requêtes HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // Configurations spécifiques au développement
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
                // Configurations pour d'autres environnements (production, etc.)
            }

            // Configurations communes à tous les environnements
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication(); // Pour l'authentification
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}


