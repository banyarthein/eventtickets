﻿using GlobalEvents.Application.Responses;

namespace GlobalEvents.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandResponse: BaseResponse
    {
        public CreateOrderCommandResponse(): base()
        {
            
        }

        public CreateOrderModel CreateOrderModel { get; set; }
    }
}
