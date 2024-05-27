using CriptoProjectTest.Entityes;
using CriptoProjectTest.Interfases;
using Microsoft.IdentityModel.Tokens;

namespace CriptoProjectTest.Services
{
    public class MyHttpClient:IMyHttpClient
    {
        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://rest.coinapi.io"),
        };

        private readonly IConfiguration Configuration;

        public MyHttpClient (IConfiguration configuration)
        {
            this.Configuration = configuration;
        }


        public async Task<string> GetHistoriAssetAsync (string assetId, string date_start)
        {

            var ApiKey = Configuration["MyKey"];
            if (sharedClient.DefaultRequestHeaders.IsNullOrEmpty())
            {
                sharedClient.DefaultRequestHeaders.Add("X-CoinAPI-Key", ApiKey);
            }
            using HttpResponseMessage response = await sharedClient.GetAsync($"v1/ohlcv/BITSTAMP_SPOT_{assetId}_USD/history?period_id=1MTH&time_start={date_start}");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            return jsonResponse;
        }

    }
}
