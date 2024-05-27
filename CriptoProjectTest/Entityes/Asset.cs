using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriptoProjectTest.Entityes
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string AssetId { get; set; }

        [Column(TypeName = "decimal(18, 10)")]
        public decimal? PriceUsd { get; set; }

        public DateTime DateLastUpdate { get; set; }  

    }
}
