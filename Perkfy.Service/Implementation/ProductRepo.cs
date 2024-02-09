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
    public class ProductRepo : IProduct
    {
        private readonly PerkfyContext _context;
        public ProductRepo(PerkfyContext context)
        {
            _context= context;
        }
        public void Add(ProductDTO productDto)
        {
            var product = new Product
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Image = productDto.Image,
            };
            _context.Products.Add(product);
        }

        public void Edit(int ProductID, ProductDTO ProductDto)
        {
            var ExistingProduct = _context.Products.FirstOrDefault(product=>product.Id==ProductID);
            if (ExistingProduct != null)
            {
                ExistingProduct.Id= ProductDto.Id;
                ExistingProduct.Name = ProductDto.Name;
                ExistingProduct.Image = ProductDto.Image;
            }
           
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            return _context.Products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
            }).ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(product => product.Id == id);
        }

      

        public IQueryable<ProductDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var query = _context.Products.AsQueryable();


            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(b => b.Name.Contains(search));
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


            var brands = query.Skip(skipCount).Take(pageSize)
                .Select(p => new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Image = p.Image,

                   
                })
                ;

            return brands;
        }
    }
}
