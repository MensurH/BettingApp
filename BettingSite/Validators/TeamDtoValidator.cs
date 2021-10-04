using BettingSite.Models.DtoModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Validators
{
    public class TeamDtoValidator : AbstractValidator<TeamDto>
    {
        public TeamDtoValidator()
        {
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Team length should be more than 2");
            RuleFor(x => x.Stadium).MinimumLength(3).WithMessage("Stadium length should be more than 3");
        }
    }
}
