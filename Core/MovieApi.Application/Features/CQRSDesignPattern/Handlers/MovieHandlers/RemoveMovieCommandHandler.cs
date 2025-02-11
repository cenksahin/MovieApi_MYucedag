using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;


namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveMovieCommandHandler(MovieContext movieContext)
        {
            _context = movieContext;
        }


        public async Task Handle(RemoveMovieCommand command)
        {
            var value = _context.Movie.Find(command.MovieId)!;

            _context.Movie.Remove(value);

            await _context.SaveChangesAsync();
        }
    }
}
