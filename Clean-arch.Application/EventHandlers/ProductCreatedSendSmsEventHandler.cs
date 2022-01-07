using Clean_arch.Contracts;
using Clean_arch.Domain.ProductAgg.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.EventHandlers
{
    public class ProductCreatedSendSmsEventHandler : INotificationHandler<ProductCreated>
    {
        private ISmsService _smsService;

        public ProductCreatedSendSmsEventHandler(ISmsService smsService)
        {
            _smsService = smsService;
        }

        public async Task Handle(ProductCreated notification, CancellationToken cancellationToken)
        {
            _smsService.SendSms(new SmsBody());
            await Task.CompletedTask;
        }
    }
}