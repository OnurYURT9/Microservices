using AutoMapper;
using FreeCourse.Services.Order.Application.DTOs;
using FreeCourse.Services.Order.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Services.Order.Application.Mapping
{
    class CustomMapping:Profile
    {
        public CustomMapping()
        {
            CreateMap<Domain.OrderAggregate.Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderDto>().ReverseMap();
            CreateMap<Adress, AdressDto>().ReverseMap();
        }

    }
}
