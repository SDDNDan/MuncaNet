using System;
using System.Collections.Generic;

namespace GetUsers.Entities
{
    public partial class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int? AddressId { get; set; }
        public int? GeoId { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public int? CompanyId { get; set; }
    }
}
