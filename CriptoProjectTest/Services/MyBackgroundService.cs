using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CriptoProjectTest.Data;
using CriptoProjectTest.Entityes;
using CriptoProjectTest.Interfases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using NewForReact.Data;
using Newtonsoft.Json;

public class MyBackgroundService : BackgroundService
{
    private readonly IConfiguration _configuration;

    private const string CoinApiWebSocketUrl = "wss://ws.coinapi.io/v1/";

    private readonly IServiceScopeFactory _scopeFactory;


    public MyBackgroundService( IConfiguration configuration, IServiceScopeFactory scopeFactory)
    {
        _configuration = configuration;
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var timer = new PeriodicTimer(TimeSpan.FromSeconds(5));
        while(await timer.WaitForNextTickAsync())
        {
            await OnTimedEventAsync(stoppingToken);
        }
    }

    private async Task OnTimedEventAsync(CancellationToken cancellationToken)
    {
        var apiKey = _configuration["MyKey"];
        using var scope = _scopeFactory.CreateScope();
        var _assetService = scope.ServiceProvider.GetRequiredService<IAssetService<Asset>>();
        var listAssetId = await _assetService.GetAllAssetsIDAsync();

        using var client = new ClientWebSocket();
        await client.ConnectAsync(new Uri(CoinApiWebSocketUrl), CancellationToken.None);
        var subscribeMessage = new
        {
            type = "hello",
            apikey = apiKey,
            subscribe_data_type = new[] { "trade" },
            subscribe_filter_asset_id = listAssetId,
        };

        var jsonRequest = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(subscribeMessage));
        await client.SendAsync(new ArraySegment<byte>(jsonRequest), WebSocketMessageType.Text, true, CancellationToken.None);

        var buffer = new byte[1024];
        while (client.State == WebSocketState.Open)
        {
            var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            if (result.MessageType == WebSocketMessageType.Text)
            {
                var response = Encoding.UTF8.GetString(buffer, 0, result.Count);
                var myAssetOnlineJson = JsonConvert.DeserializeObject<AssetOnlineJson>(response);
                if (myAssetOnlineJson != null)
                {
                    await _assetService.UpdateAsync(myAssetOnlineJson);
                }
                
            }
        }
    }
}