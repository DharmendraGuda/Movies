using FluentValidation;
using MoviesAPI.ApiContracts.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Validators
{
    public class RatingRequestValidator:AbstractValidator<RatingRequest>
    {
        public RatingRequestValidator()
        {
            RuleFor(t => t.MovieId).NotEqual(0).WithMessage("Moive Id is invalid");
            RuleFor(t => t.Rating).NotEqual(0).WithMessage("Rating should not be empty");
            RuleFor(t => t.Rating).InclusiveBetween(1,5).WithMessage("Rating between 1 to 5");
        }
    }
}
