
using MediatR;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.Category.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, int>
    {
        private readonly ICategoryRepository _categoryRepository;
        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<int> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = await _categoryRepository.GetByIdAsync(request.CategoryId);
            await _categoryRepository.Delete(entity);
            return entity.CategoryId;
        }
    }
}
