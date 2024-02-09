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
    public interface ITheme
    {
        IEnumerable<ThemeDTO> GetAll();
        ThemeDTO GetById(int id);
        IQueryable<ThemeDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection);
        void Edit(int BrandID, ThemeDTO ProductDto);
        void Add(ThemeDTO themeDto);
    }
}
