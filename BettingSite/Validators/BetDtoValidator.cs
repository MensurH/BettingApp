using BettingSite.Models.DtoModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Validators
{
    public class BetDtoValidator : AbstractValidator<BetDto>
    {
        public BetDtoValidator()
        {
            RuleFor(x => x.Amount).GreaterThan(0).WithMessage("Amount should be greater than 0!");
            RuleFor(x => x.QuoteId).GreaterThan(0);
        }
    }
}
