using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotifications.Domain.Core.Notifications.Interfaces
{
    public interface IContainer
    {
        T GetService<T>(Type type);
    }
}
