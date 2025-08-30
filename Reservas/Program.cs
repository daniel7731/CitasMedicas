using Reservas.Repositorio;
using Reservas.Servicios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEspecialidadService,DefaultEspecialidadService>();
builder.Services.AddSingleton<IDoctorService,DefaultDoctorService>();
builder.Services.AddSingleton<IReservaService,DefaultReservaService>();
builder.Services.AddSingleton<IConsultaService,DefaultConsultaService>();
builder.Services.AddScoped<ILogService,DefaultLogServices>();
builder.Services.AddSingleton<INotificacionService,EmailNotificacionService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
