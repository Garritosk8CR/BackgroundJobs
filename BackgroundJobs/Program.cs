using BackgroundJobs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

builder.Services.AddSingleton<SampleData>();
builder.Services.AddHostedService<BackgroundRefresh>();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/messages", (SampleData data) =>
{
    return data.Data.Order();
});

app.Run();