using CriptoProjectTest.Entityes;

namespace CriptoProjectTest.Interfases
{
    public interface IAssetService<Asset>
    {
        Task<Asset> GetInfoAssetAsync(int id);
        Task<List<Asset>> GetAllAssetsAsync();
        Task CreateAsync(Asset entity);
        Task UpdateAsync(AssetOnlineJson entity);
        Task RemoveAsync(int id);
        Task<List<string>> GetAllAssetsIDAsync();

    }
}
