using CriptoProjectTest.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CriptoProjectTest.Data
{
    public class AssetData : IEntityTypeConfiguration<Asset>
    {   // add test data for user and admin
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasData(
                new Asset
                {
                    Id = 5,
                    AssetId = "PEPE",
                    Name = "PepeCoin",
                    DateLastUpdate = DateTime.Now

                },
                new Asset
                {
                    Id = 2,
                    AssetId = "BTC",
                    Name = "Bitcoin",
                    DateLastUpdate = DateTime.Now

                },
                new Asset
                {
                    Id = 3,
                    AssetId = "ETH",
                    Name = "Ethereum",
                    DateLastUpdate = DateTime.Now

                },
                new Asset
                {
                    Id = 4,
                    AssetId = "BNB",
                    Name = "Binance Coin",
                    DateLastUpdate = DateTime.Now

                },
                new Asset
                {
                    Id = 1,
                    AssetId = "USD",
                    Name = "US Dollar",
                    DateLastUpdate = DateTime.Now
                });
        }
    }
}
