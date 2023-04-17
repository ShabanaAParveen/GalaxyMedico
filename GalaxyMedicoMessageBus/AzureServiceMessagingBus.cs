using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyMedicoMessageBus
{
    public class AzureServiceMessagingBus : IMessageBus
    {
        private string _connectionString = "Endpoint=sb://galaxymedico.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=sGVOle7T/UbRE58o3xDqOCLcjoLeHCrN1+ASbMbHeFc=";
        public async Task PublishMessage(BaseMessage message, string topicName)
        {
            await using var client = new ServiceBusClient(_connectionString);
           
            ServiceBusSender sender = client.CreateSender(topicName);
           
            var jsonMessage = JsonConvert.SerializeObject(message);
            ServiceBusMessage finalMessage = new ServiceBusMessage(Encoding.UTF8.GetBytes(jsonMessage))
            {
                CorrelationId = Guid.NewGuid().ToString()
            };
            finalMessage.SessionId =Guid.NewGuid().ToString();
            finalMessage.TimeToLive = TimeSpan.MaxValue;
            await sender.SendMessageAsync(finalMessage);

            await client.DisposeAsync();
        }
    }
}
