using DomainNotifications.Domain.Core;
using DomainNotifications.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotifications.Domain.Interfaces
{
    public interface ICustomerDomainServices
    {
        Customer Add(string name, string email);
    }
}
