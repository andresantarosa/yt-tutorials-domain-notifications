using DomainNotifications.Domain.Core.Notifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotifications.Domain.Core.Notifications.Implementations
{
    public static class ServiceLocator
    {
        public static IContainer Container { get; set; }

        public static void Initialize(IContainer container)
        {
            Container = container;
        }
    }
}
