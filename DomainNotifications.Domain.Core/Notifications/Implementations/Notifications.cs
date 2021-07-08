using DomainNotifications.Domain.Core.Notifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotifications.Domain.Core.Notifications.Implementations
{
    public class Notifications : INotifications
    {
        public Notifications()
        {
            Messages = new List<string>();
        }

        public List<string> Messages { get; }

        public bool IsValid => Messages.Count == 0;

        public void AddMessage(string message)
        {
            Messages.Add(message);
        }
    }
}
