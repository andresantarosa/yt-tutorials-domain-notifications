using DomainNotifications.API.VMs;
using DomainNotifications.Domain.Core.Notifications.Interfaces;
using DomainNotifications.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainNotifications.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerDomainServices _customerDomainServices;
        private readonly INotifications _notifications;

        public CustomerController(ICustomerDomainServices customerDomainServices,
                                  INotifications notifications)
        {
            _customerDomainServices = customerDomainServices;
            _notifications = notifications;
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerAddRequest request)
        {
            try
            {
                var requestResult = _customerDomainServices.Add(request.Name, request.Email);
                if(_notifications.IsValid)
                {
                    return Ok(requestResult);
                }
                else
                {
                    return BadRequest(_notifications.Messages);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
