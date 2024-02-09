using Microsoft.EntityFrameworkCore;
using Perkfy.Data.Models;
using Perkfy.DTO;
using Perkfy.DTO.Enums;
using Perkfy.Repository;
using Perkfy.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Perkfy.Service.Implementation
{
    public class BrandRepo : IBrand
    {
        private readonly PerkfyContext _context;

        public BrandRepo(PerkfyContext context)
        {
            _context = context;
        }

        public void Add(BrandDTO brandDto)
        {
            var brand = new Brand
            {
                
                Name = brandDto.Name,
                Logo = brandDto.Logo,
                RenewDate = brandDto.RenewDate,
                StartDate = brandDto.StartDate,
                NumberOfUsers = brandDto.NumberOfUsers,
                //ThemeId = brandDto.ThemeId
            };

            _context.Brands.Add(brand);

        }

        public void ChangeStatus(int id, StatusEnum Status)
        {
            var brand = _context.Brands.FirstOrDefault(brand => brand.Id == id);
           
            if (brand != null)
            {
                brand.StatusId = Status;
            }

        }

        public void Edit(int BrandID, BrandDTO brandDto)
        {
            var Existingbrand = _context.Brands.FirstOrDefault(brand => brand.Id == BrandID);
            if (Existingbrand != null)
            {
                Existingbrand.Name = brandDto.Name;
                Existingbrand.Logo = brandDto.Logo;
                Existingbrand.NumberOfUsers = brandDto.NumberOfUsers;
                Existingbrand.StatusId = brandDto.StatusId;
                Existingbrand.StartDate = brandDto.StartDate;
                Existingbrand.RenewDate = brandDto.RenewDate;
            }
        }

        public IEnumerable<BrandDTO> GetAll()
        {
            return _context.Brands
                    .Select(b => new BrandDTO
                    {
                        Id = b.Id,
                        Name = b.Name,
                        Logo = b.Logo,
                        RenewDate = b.RenewDate,
                        StartDate = b.StartDate,
                        NumberOfUsers = b.NumberOfUsers,
                        //ThemeId = b.ThemeId

                    })
                    .ToList();

        }

        public BrandDTO GetById(int id)
        {
            var brand = _context.Brands.FirstOrDefault(brand => brand.Id == id);
            if (brand == null)
            {
                return null;
            }
            return new BrandDTO
            {
                Id = brand.Id,
                StatusId = brand.StatusId,
                Name = brand.Name,
                Logo = brand.Logo,
                RenewDate = brand.RenewDate,
                StartDate = brand.StartDate,
                NumberOfUsers = brand.NumberOfUsers,
                //ThemeId = brand.ThemeId
            };

        }


        public IEnumerable<BrandDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var query = _context.Brands.AsQueryable();


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
                .Select(b => new BrandDTO
                {
                    Id = b.Id,
                    Name = b.Name,
                    Logo = b.Logo,
                    RenewDate= b.RenewDate,
                    StartDate = b.StartDate,
                    StatusId = b.StatusId,
                    //ThemeId = b.ThemeId,
                    NumberOfUsers = b.NumberOfUsers
                })
                ;

            return brands;
        }
    }
}

