using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;


namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public UpdateCategoryCommandHandler(MovieContext movieContext)
        {
            _context = movieContext;
        }


        public async Task Handle(UpdateCategoryCommand command)
        {
            var value = await _context.Category.FindAsync(command.CategoryId);
            value.CategoryName = command.CategoryName;

            await _context.SaveChangesAsync();
        }
    }
}