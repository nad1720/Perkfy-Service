using Perkfy.DTO.Enums;
using Perkfy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.Service.Contract
{
    public interface IRewardItem
    {
        IEnumerable<RewardItemDTO> GetAll();
        RewardItemDTO GetById(int id);
        IEnumerable<RewardItemDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection);
        void Edit(int rewardItemId, RewardItemDTO rewardItemDto);
        void Add(RewardItemDTO rewardItemDto);
        void Delete(int rewardItemId);
    }
}
