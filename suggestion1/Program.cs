﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SampleSender
{
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Azure.EventHubs;

    public class Program
    {
        private static EventHubClient eventHubClient;
        private const string EventHubConnectionString = "Endpoint=sb://namespacegbg.servicebus.windows.net/;SharedAccessKeyName=newpolicy;SharedAccessKey=nE++p/zJZF1QB16U4EcnybVGmZolstRYD+LXXOxCppw="; // Event Hubs namespace connection string
        private const string EventHubName = "eventhub"; // event hub name
        private static bool SetRandomPartitionKey = false;

        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            // Creates an EventHubsConnectionStringBuilder object from a the connection string, and sets the EntityPath.
            // Typically the connection string should have the Entity Path in it, but for the sake of this simple scenario
            // we are using the connection string from the namespace.
            var connectionStringBuilder = new EventHubsConnectionStringBuilder(EventHubConnectionString)
            {
                EntityPath = EventHubName
            };

            eventHubClient = EventHubClient.CreateFromConnectionString(connectionStringBuilder.ToString());

            await SendMessagesToEventHub(10000);

            await eventHubClient.CloseAsync();

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        // Creates an Event Hub client and sends 100 messages to the event hub.
        private static async Task SendMessagesToEventHub(int numMessagesToSend)
        {
            var rnd = new Random();

            for (var i = 0; i < numMessagesToSend; i++)
            {
                try
                {
                    var message2 = $"Message {i}";
                    
                    var message = $"[ {{ \"Make\":\"Honda\", \"Price\":\"{i}\", \"Time\":\"2019 - 12 - 04T00: 00:01.0000000Z\" }}]";

                    // Set random partition key?
                    if (SetRandomPartitionKey)
                    {
                        var pKey = Guid.NewGuid().ToString();
                        await eventHubClient.SendAsync(new EventData(Encoding.UTF8.GetBytes(message)), pKey);
                        Console.WriteLine($"Sent message: '{message}' Partition Key: '{pKey}'");
                    }
                    else
                    {
                        await eventHubClient.SendAsync(new EventData(Encoding.UTF8.GetBytes(message)));
                        Console.WriteLine($"Sent message: '{message}'");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"{DateTime.Now} > Exception: {exception.Message}");
                }

                await Task.Delay(10);
            }

            Console.WriteLine($"{numMessagesToSend} messages sent.");
        }
    }
}
