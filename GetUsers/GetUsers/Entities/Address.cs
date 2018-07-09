using System;
using System.Collections.Generic;

namespace GetUsers.Entities
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Street { get; set; }
    }
}
