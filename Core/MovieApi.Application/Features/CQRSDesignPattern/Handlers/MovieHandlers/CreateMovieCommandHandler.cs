using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;


namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;
        public CreateMovieCommandHandler(MovieContext movieContext)
        {
            _context = movieContext;
        }


        public async Task Handle(CreateMovieCommand command)
        {
            _context.Movie.Add(new Movie
            {
                Title = command.Title,
                CoverImageUrl = command.CoverImageUrl,
                Rating = command.Rating,
                Description = command.Description,
                Duration = command.Duration,
                ReleaseDate = command.ReleaseDate,
                CreatedYear = command.CreatedYear,
                Status = command.Status
            });

            await _context.SaveChangesAsync();
        }
    }
}
