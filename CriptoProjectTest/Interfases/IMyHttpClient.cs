namespace CriptoProjectTest.Interfases
{
    public interface IMyHttpClient
    {
        Task<string> GetHistoriAssetAsync(string assetId, string date_start);
    }
}
