using Perkfy.DTO;
using Perkfy.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.Service.Contract
{
    public interface IQoute
    {
       
        void Add(QuoteDTO quote);

        
        IEnumerable<QuoteDTO> GetAll();
        QuoteDTO GetById(int id);

        public IQueryable<QuoteDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection);
        void Edit(int id, QuoteDTO quote);
 
        void Delete(int id);

    }
}
