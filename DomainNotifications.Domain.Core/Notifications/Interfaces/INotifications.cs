using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotifications.Domain.Core.Notifications.Interfaces
{
    public interface INotifications
    {
        List<string> Messages { get; }
        bool IsValid { get; }

        void AddMessage(string message);


    }
}
