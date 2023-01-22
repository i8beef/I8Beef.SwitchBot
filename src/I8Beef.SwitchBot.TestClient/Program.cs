using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace I8Beef.SwitchBot.TestClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var token = "";
            var secretKey = "";

            var client = new Client(token, secretKey);

            await RunDevicesTests(client);

            //var deviceId = "";
            //Console.WriteLine();
            //await RunSingleDeviceTests(client, deviceId);

            Console.WriteLine();
            await RunScenesTests(client);

            //var sceneId = "";
            //Console.WriteLine();
            //await RunSingleSceneTests(client, sceneId);

            //var webhookUrl = "http://www.test.com";
            //Console.WriteLine();
            //await RunWebHookTests(client, webhookUrl);

            Console.WriteLine();
            Console.WriteLine("All tests complete!");
            Console.ReadKey();
        }

        private static async Task RunDevicesTests(Client client)
        {
            // Get all devices
            Console.WriteLine("Get All Devices Test");
            var getDevicesResponse = await client.GetDevicesAsync();
            Console.WriteLine(JsonSerializer<Protocol.GetDevices.GetDevicesResponseBody>.Serialize(getDevicesResponse));
        }

        private static async Task RunSingleDeviceTests(Client client, string deviceId)
        {
            // Get single device
            Console.WriteLine("Get Device Test");
            var getDeviceStatusResponse = await client.GetDeviceStatusAsync<Protocol.GetDeviceStatus.BlindTilt>(deviceId);
            Console.WriteLine(JsonSerializer<Protocol.GetDeviceStatus.BlindTilt>.Serialize(getDeviceStatusResponse));

            // Command tests
            var closeCommand = new Protocol.Commands.CommandBase
            {
                Command = "closeDown",
                Parameter = "default"
            };

            var openCommand = new Protocol.Commands.CommandBase
            {
                Command = "fullyOpen",
                Parameter = "default"
            };

            Console.WriteLine();
            Console.WriteLine("Command Test");
            await client.ExecuteCommandAsync(deviceId, closeCommand);
        }

        private static async Task RunScenesTests(Client client)
        {
            // Get scenes
            Console.WriteLine("Get Scenes Test");
            var getScenesResponse = await client.GetScenesAsync();
            Console.WriteLine(JsonSerializer<IList<Protocol.Scene>>.Serialize(getScenesResponse));
        }

        private static async Task RunSingleSceneTests(Client client, string sceneId)
        {
            // Execute scenes
            Console.WriteLine("Get Scenes Test");
            await client.ExecuteSceneAsync(sceneId);
        }

        private static async Task RunWebHookTests(Client client, string webhookUrl)
        {
            // Setup web hook
            Console.WriteLine("Setup WebHooks Test");
            await client.SetupWebHookAsync(webhookUrl);

            // Get web hooks
            // Will error if there are no WebHooks setup
            Console.WriteLine();
            Console.WriteLine("Get WebHooks Test");
            var getWebhooksResponse = await client.GetWebHooksAsync();
            Console.WriteLine(JsonSerializer<Protocol.WebHook.QueryUrlResponseBody>.Serialize(getWebhooksResponse));

            // Get web hooks
            // Will error if there are no WebHooks setup
            Console.WriteLine();
            Console.WriteLine("Get WebHooks Details Test");
            var urls = new List<string> { webhookUrl };
            var getWebhookDetailsResponse = await client.GetWebHookDetailsAsync(urls);
            Console.WriteLine(JsonSerializer<IList<Protocol.WebHook.WebHookDetails>>.Serialize(getWebhookDetailsResponse));

            // Delete web hook
            Console.WriteLine();
            Console.WriteLine("Delete WebHooks Test");
            await client.DeleteWebHookAsync(webhookUrl);
        }
    }
}