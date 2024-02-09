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
    public class QouteRepo:IQoute
    {
        private readonly PerkfyContext _context;

        public QouteRepo(PerkfyContext context)
        {
            _context = context;
        }

        public void Add(QuoteDTO quote)
        {
            var qoute = new Qoute
            {
                Id = quote.Id,
                QouteContent = quote.QouteContent,
                PublishDate = quote.PublishDate,
            };
            _context.Add(qoute);
        }

        public void Delete(int id)
        {
            var qoute=_context.Qoutes.Find(id);
            if (qoute != null)
            {
                _context.Qoutes.Remove(qoute);
            }
        }

        public void Edit(int id, QuoteDTO quote)
        {
            var existingqoute= _context.Qoutes.Find(id);
            if (existingqoute != null)
            {
                existingqoute.Id = quote.Id;
                existingqoute.QouteContent = quote.QouteContent;
                existingqoute.PublishDate = quote.PublishDate;
            }
        }

        public IEnumerable<QuoteDTO> GetAll()
        {
            return _context.Qoutes.Select(q=> new QuoteDTO
            {
                Id = q.Id,
                QouteContent = q.QouteContent, 
                PublishDate = q.PublishDate,

            } ).ToList();
        }

        public QuoteDTO GetById(int id)
        {
            var quote = _context.Qoutes.Find(id);
            if (quote == null)
            {
                return null;
            }

            return new QuoteDTO
            {
                Id = quote.Id,
                QouteContent = quote.QouteContent,
                PublishDate = quote.PublishDate
                
            };

        }

        public IQueryable<QuoteDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var query = _context.Qoutes.AsQueryable();


            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(b => b.QouteContent.Contains(search));
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


            var Qoutes = query.Skip(skipCount).Take(pageSize)
                .Select(q => new QuoteDTO
                {
                    Id = q.Id,
                  QouteContent= q.QouteContent,
                  PublishDate= q.PublishDate,
                })
                ;

            return Qoutes;
        }
    }
}
