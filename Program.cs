using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
{
    options.SerializerOptions.IncludeFields = true;
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/isMultipleOfEleven", (multiples number) => checkIsMultipleOfEleven.checkIsMultiple(number.numbers));

app.Run();