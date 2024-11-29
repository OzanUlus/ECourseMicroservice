using ECourseMicroservice.Catolog.Api.Options;
using ECourseMicroservice.Catolog.Api.Repositories;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddOptiosExt();
builder.Services.AddDatabaseServiceExt();



var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.Run();


