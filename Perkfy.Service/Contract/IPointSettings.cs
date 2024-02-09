using Perkfy.Data.Models;
using Perkfy.DTO.Enums;
using Perkfy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.Service.Contract
{
    public interface IPointSettings
    {
        IEnumerable<PointSettingsDTO> GetAll();
        PointSetting GetById(int id);
        public IEnumerable<PointSettingsDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection);
        void Edit(int PointSettingID, PointSettingsDTO pointsettingdto);
        void Add(PointSettingsDTO point);
    }
}
