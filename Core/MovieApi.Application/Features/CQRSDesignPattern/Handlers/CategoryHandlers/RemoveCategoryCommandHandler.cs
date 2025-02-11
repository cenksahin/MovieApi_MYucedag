using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;


namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveCategoryCommandHandler(MovieContext movieContext)
        {
            _context = movieContext;
        }


        public async Task Handle(RemoveCategoryCommand command)
        {
            var value = _context.Category.Find(command.CategoryId)!;

            _context.Category.Remove(value);

            await _context.SaveChangesAsync();
        }
    }
}