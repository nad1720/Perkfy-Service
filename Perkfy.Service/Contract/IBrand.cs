using Perkfy.Data.Models;
using Perkfy.DTO;
using Perkfy.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.Service.Contract
{
    public interface IBrand
    {
        IEnumerable<BrandDTO> GetAll();
        BrandDTO GetById(int id);
        public IEnumerable<BrandDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection);
        void Edit(int BrandID, BrandDTO brandDto);
        void Add(BrandDTO brand);
        void ChangeStatus(int id, StatusEnum Status);
    }
}
