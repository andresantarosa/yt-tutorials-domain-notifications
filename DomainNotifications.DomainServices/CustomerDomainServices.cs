using DomainNotifications.Domain.Core;
using DomainNotifications.Domain.Core.Notifications.Interfaces;
using DomainNotifications.Domain.Entities;
using DomainNotifications.Domain.Interfaces;
using System;

namespace DomainNotifications.DomainServices
{
    public class CustomerDomainServices : ICustomerDomainServices
    {
        private readonly INotifications _notifications;

        public CustomerDomainServices(INotifications notifications)
        {
            _notifications = notifications;
        }

        public Customer Add(string name, string email)
        {
            BaseResponse<Customer> baseResponse = new BaseResponse<Customer>();

            Customer customer = new Customer(name, email);
            var isValid = customer.Valitate();

            if(isValid)
            {
                //CustomerRepository.Add(customer)
            }

            return customer;
        }
    }
}
