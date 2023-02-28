using FreeCourse.Services.Order.Application.DTOs;
using FreeCourseShared.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Services.Order.Application.Commands
{
   public class CreateOrderCommand:IRequest<Response<CreatedOrderDto>>
    {

        public string BuyerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
        public AdressDto Adress { get; set; }
    }
}
