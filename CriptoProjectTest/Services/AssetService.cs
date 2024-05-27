using CriptoProjectTest.Entityes;
using CriptoProjectTest.Interfases;
using System.Linq;
using System.Text.RegularExpressions;

namespace CriptoProjectTest.Servises
{
    public class AssetService : IAssetService<Asset>
    {
        private readonly IRepository<Asset> _repository;
        public AssetService(IRepository<Asset> repository) => _repository = repository;


        

        public async Task<List<string>> GetAllAssetsIDAsync()
        {
            var listId = new List<string>();
            var list = await _repository.FindAllAsync();

            foreach (var asset in list)
            {
                if (asset.AssetId == "USD") continue;
                var assetSoketId = asset.AssetId+ "/USD";
                listId.Add(assetSoketId);
            }
            return listId;
        }

        public async Task<Asset> GetInfoAssetAsync(int id)
        {
            var asset = await _repository.FindByIdAsync(id);
            return asset;
        }

        public async Task<List<Asset>> GetAllAssetsAsync()
        {
            return await _repository.FindAllAsync();
        }

       

        public async Task RemoveAsync(int id)
        {
            var entity = await _repository.FindByIdAsync(id);
            await _repository.RemoveAsync(entity);
        }

        public async Task UpdateAsync(AssetOnlineJson entity)
        {
            var assetlist = await _repository.FindAllAsync();
            foreach (var id in assetlist)
            {
                if(id.AssetId=="USD") continue;
                if (Regex.IsMatch(entity.AssetId, $"_{id.AssetId}_"))
                {
                    if(id.PriceUsd == entity.PriceUsd)
                    {
                        break;
                    }
                    id.PriceUsd = entity.PriceUsd;
                    id.DateLastUpdate = entity.DateLastUpdate;
                    await _repository.UpdateAsync(id);
                    
                }
               
            }
        }

        public async Task CreateAsync(Asset entity)
        {
           await _repository.CreateAsync(entity);
        }
    }
}
