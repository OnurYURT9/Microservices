using FreeCourse.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Services.Order.Domain.OrderAggregate
{
    public class Adress:ValueObject
    {
        public string Provience { get;private set; }
        public string District { get;private set; }
        public string Street { get;private set; }
        public string ZipCode { get;private set; }
        public string Line { get;private set; }

        public Adress(string provience, string district, string street, string zipCode, string line)
        {
            Provience = provience;
            District = district;
            Street = street;
            ZipCode = zipCode;
            Line = line;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Provience;
            yield return District;
            yield return Street;
            yield return ZipCode;
            yield return Line;
        }
    }
}
