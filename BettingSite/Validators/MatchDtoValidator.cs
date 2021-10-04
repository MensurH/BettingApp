using BettingSite.Models.DtoModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Validators
{
    public class MatchDtoValidator : AbstractValidator<MatchDto>
    {
       public MatchDtoValidator()
        {
            RuleFor(x => x.HomeTeamId).GreaterThan(0).WithMessage("Home ID should be greater than 0!");
            RuleFor(x => x.AwayTeamId).GreaterThan(0).WithMessage("Away ID should be greater than 0!");
            RuleFor(x => x.MatchTime).NotNull();
        }
    }
}
