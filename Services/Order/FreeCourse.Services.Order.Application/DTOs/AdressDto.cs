using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Services.Order.Application.DTOs
{
    public class AdressDto
    {
        public string Provience { get;  set; }
        public string District { get;  set; }
        public string Street { get;  set; }
        public string ZipCode { get;  set; }
        public string Line { get;  set; }
    }
}
