using EightToTen_Endpoints.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Magic8BallServices>();
builder.Services.AddScoped<RestaurantPickerServices>();
builder.Services.AddScoped<GuessItEasyServices>();
builder.Services.AddScoped<GuessItMediumServices>();
builder.Services.AddScoped<GuessItHardServices>();

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
