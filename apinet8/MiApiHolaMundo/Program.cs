var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
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




app.MapGet("/saludo", () =>
{
    return "Hola mundo .net8 get";
})
.WithName("saludos")
.WithOpenApi();


app.MapPost("/saludo", () =>
{
    return "Hola mundo .net8 post";
})
.WithName("saludos1")
.WithOpenApi();


app.MapPut("/saludo", () =>
{
    return "Hola mundo .net put";
})
.WithName("saludos2")
.WithOpenApi();


app.MapDelete("/saludo", () =>
{
    return "Hola mundo .net delete";
})
.WithName("saludos3")
.WithOpenApi();




app.Run();


