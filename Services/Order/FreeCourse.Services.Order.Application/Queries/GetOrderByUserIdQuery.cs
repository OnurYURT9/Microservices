using FreeCourse.Services.Order.Application.DTOs;
using FreeCourseShared.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Services.Order.Application.Queries
{
   public class GetOrderByUserIdQuery:IRequest<Response<List<OrderDto>>>
    {
        public string UserId { get; set; }
    }
}
