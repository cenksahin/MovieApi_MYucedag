﻿using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;


namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;
        public UpdateMovieCommandHandler(MovieContext movieContext)
        {
            _context = movieContext;
        }


        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movie.FindAsync(command.MovieId);
            value.Title=command.Title;
            value.CoverImageUrl=command.CoverImageUrl;
            value.Rating = command.Rating;
            value.Description = command.Description;
            value.Duration = command.Duration;
            value.ReleaseDate = command.ReleaseDate;
            value.CreatedYear = command.CreatedYear;
            value.Status = command.Status;

            await _context.SaveChangesAsync();
        }
    }
}
