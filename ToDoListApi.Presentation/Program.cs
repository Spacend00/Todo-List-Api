using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using ToDoListApi.Application.DTOs.Category;
using ToDoListApi.Application.DTOs.ToDoItem;
using ToDoListApi.Application.Freatures.Category.Commands.CreateCategory;
using ToDoListApi.Application.Freatures.Category.Commands.DeleteCategory;
using ToDoListApi.Application.Freatures.Category.Commands.QueryCategory;
using ToDoListApi.Application.Freatures.Category.Commands.QueryCategoryById;
using ToDoListApi.Application.Freatures.Category.Commands.UpdateCategory;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.CraeteToDoItem;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.DeleteToDoItem;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.QueryToDoItem;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.QueryToDoItemById;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.UpdateToDoItem;
using ToDoListApi.Application.Interfaces;
using ToDoListApi.Application.Mappings;
using ToDoListApi.Infrastructure.Contexts;
using ToDoListApi.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(GeneralMapping).Assembly);
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateToDoItemCommand).Assembly));
builder.Services.AddDbContext<ToDoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IToDoItemRepository, ToDoItemRepository>();
builder.Services.AddOpenApi();



var app = builder.Build();
app.MapOpenApi();
app.MapScalarApiReference();

//Category Minimal Api
//GetAll.C
app.MapGet("api/GetAllCategory", async ([AsParameters] CategoryQuery query, IMapper mapper, IMediator mediator) =>
{
    var result = await mediator.Send(query);
    return Results.Ok(result);
});
//GetById.C
app.MapGet("api/GetCategoryById", async ([AsParameters] QueryCategoryByIdDto dto, IMapper mapper, IMediator mediator) =>
{
    var query = mapper.Map<CategoryQueryById>(dto);
    var result = await mediator.Send(query);
    return Results.Ok(result);
});
//Update.C
app.MapPut("api/UpdateCategory", async ([AsParameters] UpdateCategoryDto dto, IMapper mapper, IMediator mediator) =>
{
    var command = mapper.Map<UpdateCategoryCommand>(dto);
    var result = await mediator.Send(command);
    return Results.Ok(result);
});
//Delete.C
app.MapDelete("api/DeleteCategory", async ([AsParameters] DeleteCategoryDto dto, IMapper mapper, IMediator mediator) =>
{
    var command = mapper.Map<DeleteCategoryCommand>(dto);
    var result = await mediator.Send(command);
    return Results.Ok(result);
});
//Create.C
app.MapPost("api/CreateCategory", async ([AsParameters] CreateCategoryDto dto, IMapper mapper, IMediator mediator) =>
{
    var command = mapper.Map<CreateCategoryCommand>(dto);
    return Results.Ok(await mediator.Send(command));
});
//Item Minimal Api
//GetAll.I
app.MapGet("api/GetAllItems", async([AsParameters] ToDoItemQuery query, IMapper mapper, IMediator mediator) =>
{
    var result = await mediator.Send(query);
    return Results.Ok(result);
});
//GetById.I
app.MapGet("api/GetItemById", async ([AsParameters] QueryToDoItemByIdDto dto, IMapper mapper, IMediator mediator) =>
{
    var query = mapper.Map<ToDoItemQueryById>(dto);
    var entity = await mediator.Send(query);
    return Results.Ok(entity);
});
//Update.I
app.MapPut("api/UpdateItem", async ([AsParameters] UpdateItemDto dto, IMapper mapper, IMediator mediator) =>
{
    var command = mapper.Map<UpdateToDoItemCommand>(dto);
    var entity = await mediator.Send(command);
    return Results.Ok(entity);
});
//Delete.I
app.MapDelete("api/DeleteItem", async ([AsParameters] DeleteItemDto dto, IMapper mapper, IMediator meditor) =>
{
    var command = mapper.Map<DeleteToDoItemCommand>(dto);
    var entity = await meditor.Send(command);
    return Results.Ok(entity);
});
//Create.I
app.MapPost("api/Createitem", async ([AsParameters] CreateItemDto dto, IMapper mapper, IMediator mediator) =>
{
    var command = mapper.Map<CreateToDoItemCommand>(dto);
    var result = await mediator.Send(command);
    return Results.Ok(result);
});

app.Run();
