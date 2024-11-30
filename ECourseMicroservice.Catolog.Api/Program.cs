using ECourseMicroservice.Catolog.Api;
using ECourseMicroservice.Catolog.Api.Features.Categories;
using ECourseMicroservice.Catolog.Api.Options;
using ECourseMicroservice.Catolog.Api.Repositories;
using ECourseMicroservice.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddOptiosExt();
builder.Services.AddDatabaseServiceExt();
builder.Services.AddCommonServiceExt(typeof(CatologAssembly));



var app = builder.Build();

app.AddCategoryGroupEndpointExt();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.Run();


