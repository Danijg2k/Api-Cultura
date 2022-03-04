using AutoMapper;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddSingleton<ProductoContext>(_ =>
            new ProductoContext(Configuration.GetConnectionString("DefaultConnection")));



        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new ProductoProfile());
            mc.AddProfile(new ProveedorProfile());
            mc.AddProfile(new TemporadaProfile());
            mc.AddProfile(new OpinionProfile());
        });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);

        services.AddSingleton<IProductoService, ProductoService>();
        services.AddSingleton<IProveedorService, ProveedorService>();
        services.AddSingleton<ITemporadaService, TemporadaService>();
        services.AddSingleton<IOpinionService, OpinionService>();

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());


        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}