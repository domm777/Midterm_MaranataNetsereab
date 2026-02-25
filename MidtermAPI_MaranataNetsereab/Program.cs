var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

app.Use(async (context, next) => {
    try {
        await next();
    } catch (Exception ex) {
        Console.WriteLine(ex.Message);
        context.Response.StatusCode = 500;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsJsonAsync(new {
            error = "ServerError",
            message = "An unexpected error occurred."
        });
    }
});

const string API_KEY = "MY_SECRET_KEY_123_MN";
app.Use(async (context, next) => {
    if (context.Request.Path.StartsWithSegments("/swagger")) {
        await next();
        return;
    }

    if (!context.Request.Headers.TryGetValue("X-Api-Key", out var key) || key != API_KEY) {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsJsonAsync(new {
            error = "Unauthorized",
            message = "INvalid or missing API key."
        });
        return;
    }

    await next();
});

app.MapControllers();

app.Run();
