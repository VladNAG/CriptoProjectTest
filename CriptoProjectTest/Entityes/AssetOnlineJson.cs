using Newtonsoft.Json;

namespace CriptoProjectTest.Entityes
{
    public class AssetOnlineJson:Asset
    {
        [JsonProperty("time_exchange")]
        public DateTime DateLastUpdate { get; set; }



        [JsonProperty("price")]
        public decimal PriceUsd { get; set; }



        [JsonProperty("symbol_id")]
        public string AssetId { get; set; }


    }
}
