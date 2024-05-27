using CriptoProjectTest.Entityes;
using CriptoProjectTest.Interfases;
using Microsoft.AspNetCore.Mvc;

namespace CriptoProjectTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CriptoController : ControllerBase
    {
        private readonly IAssetService<Asset> assetServise;

        private readonly IMyHttpClient _myHttpClient;


        public CriptoController(IAssetService<Asset> _assetServise, IMyHttpClient myHttpClient)
        {
            assetServise = _assetServise;
            _myHttpClient = myHttpClient;
        }

        [HttpGet("GetAllAssets")]
        public async Task<IActionResult> GetAllDataAsync()
        {
            var assets = await assetServise.GetAllAssetsAsync();
            if (assets == null)
            {
                return BadRequest("assets == null");
            }
            if (assets.Count == 0)
            {
                return BadRequest("Asset list is empty");
            }
            return Ok(assets);

        }

        [HttpGet("GetAsset")]
        public async Task<IActionResult> GetAssetDataAsync(int id)
        {
            var asset = await assetServise.GetInfoAssetAsync(id);
            if (asset == null)
            {
                return BadRequest("not found");
            }
            return Ok(asset);
        }

        [HttpDelete("DeleteAsset")]
        public async Task<IActionResult> DeleteAssetAsync([FromBody] int id)
        {
            if (id == 0)
            {
                return BadRequest("id = null");
            }
            await assetServise.RemoveAsync(id);
            return Ok();
        }

        [HttpPost("CreateAsset")]
        public async Task<IActionResult> CreateAssetAsync([FromBody] Asset asset)
        {
            if (asset == null)
            {
                return BadRequest("assets == null");
            }
            await assetServise.CreateAsync(asset);
            return Ok(asset);
        }

        [HttpGet("GetAssetHistori")]
        public async Task<IActionResult> GetAssetHistoriAsync(int assetId, string date_start)
        {
            try
            {
                var asset = await assetServise.GetInfoAssetAsync(assetId);
                if (asset != null)
                {
                    var response = await _myHttpClient.GetHistoriAssetAsync(asset.AssetId, date_start);
                    return Ok(response);
                }
                return BadRequest("Not Found asset");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error fetching data: {ex.Message}");
            }
        }

    }
}