using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Services.Order.Application.DTOs
{
    public class AdressDto
    {
        public string Provience { get; private set; }
        public string District { get; private set; }
        public string Street { get; private set; }
        public string ZipCode { get; private set; }
        public string Line { get; private set; }
    }
}
