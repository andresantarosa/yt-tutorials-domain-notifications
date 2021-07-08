using DomainNotifications.Domain.Core.Notifications.Implementations;
using DomainNotifications.Domain.Core.Notifications.Interfaces;
using System;
using System.Collections.Generic;

namespace DomainNotifications.Domain.Entities
{
    public class Customer
    {
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }

        public bool Valitate()
        {

            if (Name.Length < 5)
                NotificationsWrapper.AddMessage("Nome não pode ter menos de 5 caracteres");

            if (Email.Length < 5)
                NotificationsWrapper.AddMessage("Email não pode ter menos de 5 caracteres");

            return NotificationsWrapper.IsValid();

        }
    }
}
