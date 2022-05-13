using Alta.DTOs.DtoAbstraction;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Alta.PrimeClient
{
    public class HttpPrimeClient : IPrimeClient
    {
        private readonly HttpClient _httpClient;
        public HttpPrimeClient(IOptions<PrimeWsOptions> options)
        {
            _httpClient = new HttpClient();
            var primeWsOptions = options.Value;
            _httpClient.BaseAddress = new Uri(primeWsOptions.Url);
        }



        public async Task<TransactionResult> SendMessage(string uri, DtoBase dto)
        {
            HttpContent content = new StringContent(JsonSerializer.Serialize(dto));

            var result = await _httpClient.PostAsync(uri, content);

            return await result.ToResult(dto);
        }
    }
}
