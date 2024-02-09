using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.DTO
{
    public class RewardItemDTO
    {
        public int Id { get; set; }

        public int? SettingId { get; set; }

        public string? Name { get; set; }

        public int? PointsCount { get; set; }

        public int? ViewCount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public string? Description { get; set; }

        public int? ProductId { get; set; }
        public virtual ICollection<RewardItemGalleryDTO> RewardItemGalleries { get; set; } = new List<RewardItemGalleryDTO>();

    }
}
