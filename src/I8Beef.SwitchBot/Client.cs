using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using I8Beef.SwitchBot.Exceptions;
using I8Beef.SwitchBot.Protocol;
using I8Beef.SwitchBot.Protocol.Commands;
using I8Beef.SwitchBot.Protocol.GetDevices;
using I8Beef.SwitchBot.Protocol.WebHook;
using Newtonsoft.Json;

namespace I8Beef.SwitchBot
{
    /// <inheritdoc />
    public class Client : IClient
    {
        private const string _baseUri = "https://api.switch-bot.com/v1.1";
        private static readonly HttpClient _httpClient = new() { Timeout = Timeout.InfiniteTimeSpan };
        private readonly string _token;
        private readonly string _secretKey;
        private readonly TimeSpan _timeout;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="token">SwitchBot token.</param>
        /// <param name="secretKey">SwitchBot secret key.</param>
        public Client(
            string token,
            string secretKey)
            : this(token, secretKey, TimeSpan.FromSeconds(100))
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="token">SwitchBot token.</param>
        /// <param name="secretKey">SwitchBot secret key.</param>
        /// <param name="timeout">Timeout for all HTTP calls.</param>
        public Client(
            string token,
            string secretKey,
            TimeSpan timeout)
        {
            _token = token;
            _secretKey = secretKey;
            _timeout = timeout;
        }

        /// <inheritdoc />
        public async Task<GetDevicesResponseBody> GetDevicesAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{_baseUri}/devices");
            AddAuthHeaders(requestMessage);

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<GetDevicesResponseBody>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }

            return result.Body;
        }

        /// <inheritdoc />
        public async Task<TDevice> GetDeviceStatusAsync<TDevice>(string deviceId, CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{_baseUri}/devices/{deviceId}/status");
            AddAuthHeaders(requestMessage);

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<TDevice>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }

            return result.Body;
        }

        /// <inheritdoc />
        public async Task ExecuteCommandAsync(string deviceId, CommandBase command, CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{_baseUri}/devices/{deviceId}/commands");
            AddAuthHeaders(requestMessage);

            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(command), Encoding.UTF8, "application/json");

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<dynamic>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }
        }

        /// <inheritdoc />
        public async Task<IList<Scene>> GetScenesAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{_baseUri}/scenes");
            AddAuthHeaders(requestMessage);

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<IList<Scene>>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }

            return result.Body;
        }

        /// <inheritdoc />
        public async Task ExecuteSceneAsync(string sceneId, CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{_baseUri}/scenes/{sceneId}/execute");
            AddAuthHeaders(requestMessage);

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<dynamic>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }
        }

        /// <inheritdoc />
        public async Task<QueryUrlResponseBody> GetWebHooksAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{_baseUri}/webhook/queryWebhook");
            AddAuthHeaders(requestMessage);

            var request = new QueryUrlRequest();
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<QueryUrlResponseBody>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }

            return result.Body;
        }

        /// <inheritdoc />
        public async Task<IList<WebHookDetails>> GetWebHookDetailsAsync(IList<string> urls, CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{_baseUri}/webhook/queryWebhook");
            AddAuthHeaders(requestMessage);

            var request = new QueryDetailsRequest { Urls = urls };
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<IList<WebHookDetails>>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }

            return result.Body;
        }

        /// <inheritdoc />
        public async Task DeleteWebHookAsync(string url, CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{_baseUri}/webhook/deleteWebhook");
            AddAuthHeaders(requestMessage);

            var request = new DeleteWebHookRequest { Url = url };
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<dynamic>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }
        }

        /// <inheritdoc />
        public async Task SetupWebHookAsync(string url, CancellationToken cancellationToken = default)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{_baseUri}/webhook/setupWebhook");
            AddAuthHeaders(requestMessage);

            var request = new SetupWebHookRequest { Url = url, DeviceList = "ALL" };
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await SendWithTimeoutAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApiException(responseString);
            }

            var result = JsonSerializer<Response<dynamic>>.Deserialize(responseString);
            if (result.StatusCode != StatusCode.Success)
            {
                throw new ApiException(responseString);
            }
        }

        /// <summary>
        /// Executes HttpClient.SendAsync() with a timeout extension.
        /// </summary>
        /// <param name="requestMessage">Same as parameters in HttpClient.SendAsync()</param>
        /// <param name="cancellationToken">Same as parameters in HttpClient.SendAsync()</param>
        /// <returns>The <see cref="HttpResponseMessage"/>.</returns>
        /// <remarks>
        /// The HttpClient has a Timout feature that has been poorly implemented in that it raises an ambiguous exception on timeout.
        /// This wraps the HttpClient.SendAsync() and adds a proper timeout option.
        /// </remarks>
        private async Task<HttpResponseMessage> SendWithTimeoutAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            var timoutCts = new CancellationTokenSource(_timeout);
            var aggregateCts = CancellationTokenSource.CreateLinkedTokenSource(timoutCts.Token, cancellationToken);

            try
            {
                return await _httpClient.SendAsync(requestMessage, aggregateCts.Token)
                    .ConfigureAwait(false);
            }
            catch (TaskCanceledException) when (timoutCts.IsCancellationRequested)
            {
                throw new TimeoutException("HTTP request to Ecobee API servers timed out.");
            }
        }

        /// <summary>
        /// Adds the auth request headers to the specified message.
        /// </summary>
        /// <param name="requestMessage">The request message.</param>
        private void AddAuthHeaders(HttpRequestMessage requestMessage)
        {
            var time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var nonce = Guid.NewGuid().ToString();
            var data = _token + time.ToString() + nonce;
            var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_secretKey));
            var signature = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(data)));

            requestMessage.Headers.TryAddWithoutValidation(@"Authorization", _token);
            requestMessage.Headers.TryAddWithoutValidation(@"sign", signature);
            requestMessage.Headers.TryAddWithoutValidation(@"nonce", nonce);
            requestMessage.Headers.TryAddWithoutValidation(@"t", time.ToString());
            requestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json; charset=utf8");
        }
    }
}
