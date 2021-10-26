using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using MerchandiseService.HttpModels;

namespace MerchandiseService.HttpClient
{
    public interface IMerchandiseHttpClient
    {
        Task<MerchPackResponse> V1Get(int id, CancellationToken token);

        public Task<List<MerchPackResponse>> V1GetEmployeePacks(int id, CancellationToken token);
    }

    public class MerchandiseHttpClient : IMerchandiseHttpClient
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        public MerchandiseHttpClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MerchPackResponse> V1Get(int id, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync($"v1/api/merch/employee/{id}/pack", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<MerchPackResponse>(body);
        }

        public async Task<List<MerchPackResponse>> V1GetEmployeePacks(int id, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync($"v1/api/merch/employee/{id}/packs", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<List<MerchPackResponse>>(body);
        }
    }
}