using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using I8Beef.SwitchBot.Protocol;
using I8Beef.SwitchBot.Protocol.Commands;
using I8Beef.SwitchBot.Protocol.GetDevices;
using I8Beef.SwitchBot.Protocol.WebHook;

namespace I8Beef.SwitchBot
{
    /// <summary>
    /// SwitchBot client implementation.
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Peforms a GetDevices request to the SwitchBot API.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the SwitchBot API.</returns>
        Task<GetDevicesResponseBody> GetDevicesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Peforms a GetDeviceStatus request to the SwitchBot API.
        /// </summary>
        /// <typeparam name="TDevice">Response device type.</typeparam>
        /// <param name="deviceId">The device id to send to the SwitchBot API.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the SwitchBot API.</returns>
        Task<TDevice> GetDeviceStatusAsync<TDevice>(string deviceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Executes a command against the SwitchBot API.
        /// </summary>
        /// <param name="deviceId">The device id to send to the SwitchBot API.</param>
        /// <param name="command">The command to send to the SwitchBot API.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>An awaitable <see cref="Task"/>.</returns>
        Task ExecuteCommandAsync(string deviceId, CommandBase command, CancellationToken cancellationToken = default);

        /// <summary>
        /// Performs a GetScenes request to the SwitchBot API.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the SwitchBot API.</returns>
        Task<IList<Scene>> GetScenesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Executes a scene against the SwitchBot API.
        /// </summary>
        /// <param name="sceneId">The scene id to send to the SwitchBot API.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>An awaitable <see cref="Task"/>.</returns>
        Task ExecuteSceneAsync(string sceneId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Performs a QueryUrl WebHook request against the SwitchBit API.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the SwitchBot API.</returns>
        Task<QueryUrlResponseBody> GetWebHooksAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Performs a QueryDetails WebHook request against the SwitchBit API.
        /// </summary>
        /// <param name="urls">The URLs to fetch.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the SwitchBot API.</returns>
        Task<IList<WebHookDetails>> GetWebHookDetailsAsync(IList<string> urls, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a WebHook with SwitchBit API.
        /// </summary>
        /// <param name="url">The URL to delete.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>An awaitable <see cref="Task"/>.</returns>
        Task DeleteWebHookAsync(string url, CancellationToken cancellationToken = default);

        /// <summary>
        /// Setup WebHook with SwitchBot API.
        /// </summary>
        /// <param name="url">The URL to send events to.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>An awaitable <see cref="Task"/>.</returns>
        Task SetupWebHookAsync(string url, CancellationToken cancellationToken = default);
    }
}
