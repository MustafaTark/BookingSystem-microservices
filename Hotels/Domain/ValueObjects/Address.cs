﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.ValueObjects
{
    public record Address : IEquatable<Address>
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
    }
}
