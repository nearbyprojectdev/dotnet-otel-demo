using MWebApplication1.Repository;
using WebApplication1.Data;
using WebApplication1.Repository.Interface;
using WebApplication1;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new DateOnlyConverter());
});

builder.Services.AddTransient<DapperContext>();
builder.Services.AddTransient<IPersonsRepository, PersonsRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
