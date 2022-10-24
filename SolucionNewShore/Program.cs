using Microsoft.EntityFrameworkCore;
using SolucionNewShore.Contexto;
using SolucionNewShore.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Declaro el servicio y el dbcontext para que sea llamado el constructor
builder.Services.AddScoped<NewshoreService, NewshoreService>();
builder.Services.AddDbContext<DbContexto>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


//Doy los permisos nesesarios para  que angular pueda tener acceso a los datos
builder.Services.AddCors(options => options.AddPolicy(name: "VuelosOrenes",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("VuelosOrenes");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
