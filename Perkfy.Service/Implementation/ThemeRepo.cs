using Perkfy.Data.Models;
using Perkfy.DTO;
using Perkfy.DTO.Enums;
using Perkfy.Repository;
using Perkfy.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.Service.Implementation
{
    public class ThemeRepo:ITheme
    {
        private readonly PerkfyContext _context;
        public ThemeRepo(PerkfyContext context)
        {
            _context = context;
        }

        public void Add(ThemeDTO themeDto)
        {
            var theme = new Theme
            {
                Id = themeDto.Id,
                BackgroundColor = themeDto.BackgroundColor,
                MainColor = themeDto.MainColor,
                SecoundColor = themeDto.SecoundColor,
                FontFamily = themeDto.FontFamily,
            };
            _context.Themes.Add(theme);
        }

        public void Edit(int ThemeID, ThemeDTO ProductDto)
        {
            var existingTheme = _context.Themes.FirstOrDefault(theme=>theme.Id==ThemeID);
        }

        public IEnumerable<ThemeDTO> GetAll()
        {
            return _context.Themes.Select(t => new ThemeDTO
            {
                Id = t.Id,
                BackgroundColor = t.BackgroundColor,
                MainColor = t.MainColor,
                FontFamily = t.FontFamily,
            });
        }

        public ThemeDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ThemeDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var query = _context.Themes.AsQueryable();


            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(b => b.FontFamily.Contains(search));
            }

            switch (sortDirection)
            {
                case SortDirectionEnum.Ascending:
                    query = query.OrderBy(sortColumn);
                    break;

                default:
                    query = query.OrderBy(sortColumn);
                    break;
            }


            int skipCount = (pageNumber - 1) * pageSize;


            var Themes = query.Skip(skipCount).Take(pageSize)
                .Select(t => new ThemeDTO
                {
                    Id = t.Id,
                    MainColor=t.MainColor,
                    FontFamily = t.FontFamily,
                    BackgroundColor=t.BackgroundColor,
                    SecoundColor=t.SecoundColor,

                })
                ;

            return Themes;
        }
    }
}
