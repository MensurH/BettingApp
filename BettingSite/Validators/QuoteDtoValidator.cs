using BettingSite.Models.DtoModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Validators
{
    public class QuoteDtoValidator : AbstractValidator<QuoteDto>
    {
        public QuoteDtoValidator()
        {
            RuleFor(x => x.MatchId).GreaterThanOrEqualTo(1).WithMessage("Match ID should be greater or equal to 1");
            RuleFor(x => x.Type).NotNull();
            RuleFor(x => x.Value).GreaterThan(1).WithMessage("Value should be greater than 1");
        }
    }
}
