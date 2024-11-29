using ECourseMicroservice.Catolog.Api.Features.Categories;
using ECourseMicroservice.Catolog.Api.Features.Categories.Create;
using ECourseMicroservice.Catolog.Api.Options;
using ECourseMicroservice.Catolog.Api.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddOptiosExt();
builder.Services.AddDatabaseServiceExt();



var app = builder.Build();

app.AddCategoryGroupEndpointExt();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.Run();


