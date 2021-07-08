using System.Collections.Generic;

namespace DomainNotifications.Domain.Core
{
    public class BaseResponse<T>
    {
        public List<string> Errors { get; set; }
        public T Data { get; set; }
        public bool IsValid { get => Errors.Count == 0; }
    }
}
