//Para Swagger
using System.Reflection;
//
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

        // Hack con Transient para usar solo un contexto
        services.AddTransient<TiendaContext>(_ =>
            new TiendaContext(Configuration.GetConnectionString("DefaultConnection")));


        // Cosa 1 de 2 añadida para Swagger
        //services.AddSwaggerGen();
        services.AddSwaggerGen(options =>
        {
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            options.IncludeXmlComments(xmlPath);
        });



        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new ProductoProfile());
            mc.AddProfile(new ProveedorProfile());
            mc.AddProfile(new TemporadaProfile());
            mc.AddProfile(new OpinionProfile());
            mc.AddProfile(new ProveeProfile());
            mc.AddProfile(new PerteneceProfile());

        });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);

        services.AddSingleton<IProductoService, ProductoService>();
        services.AddSingleton<IProveedorService, ProveedorService>();
        services.AddSingleton<ITemporadaService, TemporadaService>();
        services.AddSingleton<IOpinionService, OpinionService>();
        services.AddSingleton<IProveeService, ProveeService>();
        services.AddSingleton<IPerteneceService, PerteneceService>();

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            // Cosa 2 de 2 añadida para Swagger
            app.UseSwagger();
            app.UseSwaggerUI();
            //
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