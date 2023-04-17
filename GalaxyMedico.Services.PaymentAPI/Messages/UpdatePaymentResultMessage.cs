using GalaxyMedicoMessageBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.PaymentAPI.Messages
{
    public class UpdatePaymentResultMessage:BaseMessage
    {
        public int OrderId { get; set; }
        public bool Status { get; set; }
    }
}
