using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public CreateCategoryCommandHandler(MovieContext movieContext)
        {
            _context = movieContext;
        }


        public async Task Handle(CreateCategoryCommand command)
        {
            _context.Category.Add(new Category
            {
                CategoryName = command.CategoryName
            });

            await _context.SaveChangesAsync();
        }
    }
}
