using DomainNotifications.Domain.Core.Notifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotifications.Domain.Core.Notifications.Implementations
{
    public static class NotificationsWrapper
    {
        private static INotifications GetContainer()
        {
            return ServiceLocator.Container.GetService<INotifications>(typeof(INotifications));
        }

        public static void AddMessage(string message)
        {
            GetContainer().AddMessage(message);
        }

        public static bool IsValid() => 
            GetContainer().IsValid;
    }
}
