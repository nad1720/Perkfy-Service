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
    public interface ITransaction
    {
        IEnumerable<TransactionDTO> GetAll();
        Transaction GetById(int id);
        public IQueryable<TransactionDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection);
        void Edit(int BrandID, TransactionDTO transactiondto);
        void Add(TransactionDTO transactiondto);
       
    }
}
