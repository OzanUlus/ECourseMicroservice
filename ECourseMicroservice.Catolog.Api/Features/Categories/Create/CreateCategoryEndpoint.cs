﻿using ECourseMicroservice.Shared.Extensions;
using ECourseMicroservice.Shared.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECourseMicroservice.Catolog.Api.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group ) 
        {
            group.MapPost("/", async (CreateCategoryCommand command, IMediator mediator) => (await mediator.Send(command)).ToGenericResult())
                 .AddEndpointFilter<ValidationFilter<CreateCategoryCommand>>();
            
            return group;
        }
    }
}
