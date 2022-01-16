using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MoviesAPI.ApiContracts.Requests;

namespace MoviesAPI.Validators
{
    public class SearchRequestValidator: AbstractValidator<SearchRequest>
    {
        public SearchRequestValidator()
        {
            RuleFor(t => t).Must(t => !string.IsNullOrWhiteSpace(t.Title) || t.YearofRelease != null || !string.IsNullOrWhiteSpace(t.Genres))
               .WithMessage("Atleast One is Requeired");
        }
    }
}
