﻿using Course.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services.Order.Domain.OrderAggregate
{
    public class Address : ValueObject
    {
        public string Province { get; private set; }

        public string District { get; private set; }

        public string Street { get; private set; }

        public string ZipCode { get; private set; }

        public string Line { get; private set; }

        public Address(string province, string district, string street, string zipCode, string line)
        {
            Province = province;
            District = district;
            Street = street;
            ZipCode = zipCode;
            Line = line;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            /*
             Yield return ifadesi ile iterator’a çağrı yapılan foreach döngüsüne bir eleman döndürülürken 
            yield break ifadesi ile de artık bulunan iterator içerisindeki iterasyonun sona erdiği bilgisi iterator’ı çağıran foreach döngüsüne iletilmekte.
             */
            yield return Province;
            yield return District;
            yield return Street;
            yield return ZipCode;
            yield return Line;
        }
    }
}