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
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.Service.Implementation
{
    public class RewardItemRepo: IRewardItem
    {
        private readonly PerkfyContext _context;

        public RewardItemRepo(PerkfyContext context)
        {
            _context = context;
        }

        public void Add(RewardItemDTO rewardItemDto)
        {
            var rewardItem = new RewardItem
            {
                SettingId = rewardItemDto.SettingId,
                Name = rewardItemDto.Name,
                PointsCount = rewardItemDto.PointsCount,
                ViewCount = rewardItemDto.ViewCount,
                StartDate = rewardItemDto.StartDate,
                ExpiryDate = rewardItemDto.ExpiryDate,
                Description = rewardItemDto.Description,
                ProductId = rewardItemDto.ProductId,
                RewardItemGalleries = rewardItemDto.RewardItemGalleries
             .Select(g => new RewardItemGallery
             {
                 ImageUrl = g.ImageUrl,
                 RewardItemId = g.RewardItemId
             })
             .ToList()
            };

            _context.RewardItems.Add(rewardItem);
        }

        public void Delete(int rewardItemId)
        {
            var rewardItemToDelete = _context.RewardItems.FirstOrDefault(r => r.Id == rewardItemId);
            if (rewardItemToDelete != null)
            {
                _context.RewardItems.Remove(rewardItemToDelete);
               
            }
        }

        public void Edit(int rewardItemId, RewardItemDTO rewardItemDto)
        {
            var existingRewardItem = _context.RewardItems.FirstOrDefault(r => r.Id == rewardItemId);
            if (existingRewardItem != null)
            {
                existingRewardItem.Name = rewardItemDto.Name;
                existingRewardItem.PointsCount = rewardItemDto.PointsCount;
                existingRewardItem.ViewCount = rewardItemDto.ViewCount;
                existingRewardItem.StartDate = rewardItemDto.StartDate;
                existingRewardItem.ExpiryDate = rewardItemDto.ExpiryDate;
                existingRewardItem.Description = rewardItemDto.Description;
                existingRewardItem.ProductId = rewardItemDto.ProductId;

               
                existingRewardItem.RewardItemGalleries.Clear();
                if (rewardItemDto.RewardItemGalleries != null)
                {
                    foreach (var galleryDto in rewardItemDto.RewardItemGalleries)
                    {
                        existingRewardItem.RewardItemGalleries.Add(new RewardItemGallery
                        {
                            ImageUrl = galleryDto.ImageUrl,
                            RewardItemId = rewardItemId
                        });
                    }
                }

                _context.SaveChanges();
            }
        }

        public IEnumerable<RewardItemDTO> GetAll()
        {
            return _context.RewardItems
                .Select(r => new RewardItemDTO
                {
                    Id = r.Id,
                    SettingId = r.SettingId,
                    Name = r.Name,
                    PointsCount = r.PointsCount,
                    ViewCount = r.ViewCount,
                    StartDate = r.StartDate,
                    ExpiryDate = r.ExpiryDate,
                    Description = r.Description,
                    ProductId = r.ProductId,
                    RewardItemGalleries = r.RewardItemGalleries
                        .Select(g => new RewardItemGalleryDTO
                        {
                            Id = g.Id,
                            ImageUrl = g.ImageUrl,
                            RewardItemId = g.RewardItemId
                        })
                        .ToList()
                })
                .ToList();
        }

        public RewardItemDTO GetById(int id)
        {
            var rewardItem = _context.RewardItems.FirstOrDefault(r => r.Id == id);
            if (rewardItem == null)
                return null;

            return new RewardItemDTO
            {
                Id = rewardItem.Id,
                SettingId = rewardItem.SettingId,
                Name = rewardItem.Name,
                PointsCount = rewardItem.PointsCount,
                ViewCount = rewardItem.ViewCount,
                StartDate = rewardItem.StartDate,
                ExpiryDate = rewardItem.ExpiryDate,
                Description = rewardItem.Description,
                ProductId = rewardItem.ProductId,
                RewardItemGalleries = rewardItem.RewardItemGalleries
                    .Select(g => new RewardItemGalleryDTO
                    {
                        Id = g.Id,
                        ImageUrl = g.ImageUrl,
                        RewardItemId = g.RewardItemId
                    })
                    .ToList()
            };
        }

        public IEnumerable<RewardItemDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var query = _context.RewardItems.AsQueryable();

            
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(r => r.Name.Contains(search));
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

            
            var rewardItems = query.Skip(skipCount).Take(pageSize)
                .Select(r => new RewardItemDTO
                {
                    Id = r.Id,
                    Name = r.Name,
                    PointsCount = r.PointsCount,
                    ViewCount = r.ViewCount,
                    StartDate = r.StartDate,
                    ExpiryDate = r.ExpiryDate,
                    Description = r.Description,
                    ProductId = r.ProductId,
                    
                    RewardItemGalleries = r.RewardItemGalleries.Select(rg => new RewardItemGalleryDTO
                    {
                        Id = rg.Id,
                        ImageUrl = rg.ImageUrl,
                        RewardItemId = rg.RewardItemId
                    }).ToList()
                })
                .ToList();

            return rewardItems;
        }
    }
}


    

