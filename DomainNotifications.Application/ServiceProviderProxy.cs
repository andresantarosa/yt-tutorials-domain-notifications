using DomainNotifications.Domain.Core.Notifications.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotifications.Application
{
    public class ServiceProviderProxy : IContainer
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ServiceProviderProxy(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public T GetService<T>(Type type)
        {
            return (T)_httpContextAccessor.HttpContext.RequestServices.GetService(type);
        }
    }
}
