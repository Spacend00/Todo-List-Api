using AutoMapper;
using ToDoListApi.Application.DTOs.Category;
using ToDoListApi.Application.DTOs.ToDoItem;
using ToDoListApi.Application.Freatures.Category.Commands.CreateCategory;
using ToDoListApi.Application.Freatures.Category.Commands.DeleteCategory;
using ToDoListApi.Application.Freatures.Category.Commands.QueryCategoryById;
using ToDoListApi.Application.Freatures.Category.Commands.UpdateCategory;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.CraeteToDoItem;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.DeleteToDoItem;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.QueryToDoItemById;
using ToDoListApi.Application.Freatures.ToDoItem.Commands.UpdateToDoItem;
using ToDoListApi.Domain.Entities;

namespace ToDoListApi.Application.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            // ToDoItem Mappings
            //Result
            CreateMap<ToDoItem, ResultItemDto>().ReverseMap();

            //Create
            CreateMap<CreateItemDto, CreateToDoItemCommand>();
            CreateMap<CreateToDoItemCommand, ToDoItem>();

            //Update            
            CreateMap<UpdateItemDto, UpdateToDoItemCommand>();
            CreateMap<UpdateToDoItemCommand, ToDoItem>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) =>
                    srcMember != null && (srcMember is int i ? i > 0 : true)
                ));

            //Delete
            CreateMap<DeleteItemDto, DeleteToDoItemCommand>();

            //Query
            CreateMap<QueryToDoItemByIdDto, ToDoItemQueryById>();

            // Category Mappings
            //Result
            CreateMap<Category, ResultCategoryDto>().ReverseMap();

            //Create
            CreateMap<CreateCategoryDto, CreateCategoryCommand>();
            CreateMap<CreateCategoryCommand, Category>();

            //Update
            CreateMap<UpdateCategoryDto, UpdateCategoryCommand>();
            CreateMap<UpdateCategoryCommand, Category>();

            //Delete
            CreateMap<DeleteCategoryDto, DeleteCategoryCommand>();

            //QueryById
            CreateMap<QueryCategoryByIdDto, CategoryQueryById>();
            
        }
    }
}
