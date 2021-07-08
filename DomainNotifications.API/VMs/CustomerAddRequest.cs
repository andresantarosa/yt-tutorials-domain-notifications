using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainNotifications.API.VMs
{
    public class CustomerAddRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
