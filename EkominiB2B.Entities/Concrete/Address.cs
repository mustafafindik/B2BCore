using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Entities.Concrete
{
    public class Address : BaseEntity
    {
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public string AddressName { get; set; }

        public string Branch { get; set; }

        public string AddressDefination { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public bool IsDefault { get; set; }
    }
}
