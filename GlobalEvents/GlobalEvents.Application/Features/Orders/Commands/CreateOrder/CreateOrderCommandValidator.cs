﻿using FluentValidation;

namespace GlobalEvents.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandValidator: AbstractValidator<CreateOrderCommand>
    {
    
        public CreateOrderCommandValidator()
        {

            RuleFor(p => p.CreateOrderModel.EventId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();


            RuleFor(p => p.CreateOrderModel.UserId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();


            RuleFor(p => p.CreateOrderModel.OrderPlaced)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .LessThanOrEqualTo(DateTime.Now).WithMessage("{PropertyName} should not be future date.");


            RuleFor(p => p.CreateOrderModel.OrderTotal)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0);


            RuleFor(p => p.CreateOrderModel.TicketsCount)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0).WithMessage("{PropertyName} should be valid number and greater than 0.");
        }
    }
}
