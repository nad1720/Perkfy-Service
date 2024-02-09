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
    public class PunchCardSettingRepo : IPunchCardSetting
    {
        private readonly PerkfyContext _context;

        public PunchCardSettingRepo(PerkfyContext context)
        {
            _context = context;
        }

        public void Add(PunchCardSettingDTO Punchcardsettingdto)
        {
            var punchCardSetting = new PunchCardSetting
            {
                SettingId = Punchcardsettingdto.SettingId,
                ImageUrl = Punchcardsettingdto.ImageUrl,
                Title = Punchcardsettingdto.Title,
                NumberOfRewardCup = Punchcardsettingdto.NumberOfRewardCup,
                NumberOfBuyedCup = Punchcardsettingdto.NumberOfBuyedCup,
                RewardCupType = Punchcardsettingdto.RewardCupType,
                BuyerCupType = Punchcardsettingdto.BuyerCupType,
                ProductId = Punchcardsettingdto.ProductId
            };

            _context.PunchCardSettings.Add(punchCardSetting);
            _context.SaveChanges();
        }

        public void Edit(int BrandID, PunchCardSettingDTO Punchcardsettingdto)
        {
            var existingPunchCardSetting = GetById(BrandID);
            if (existingPunchCardSetting != null)
            {
                existingPunchCardSetting.SettingId = Punchcardsettingdto.SettingId;
                existingPunchCardSetting.ImageUrl = Punchcardsettingdto.ImageUrl;
                existingPunchCardSetting.Title = Punchcardsettingdto.Title;
                existingPunchCardSetting.NumberOfRewardCup = Punchcardsettingdto.NumberOfRewardCup;
                existingPunchCardSetting.NumberOfBuyedCup = Punchcardsettingdto.NumberOfBuyedCup;
                existingPunchCardSetting.RewardCupType = Punchcardsettingdto.RewardCupType;
                existingPunchCardSetting.BuyerCupType = Punchcardsettingdto.BuyerCupType;
                existingPunchCardSetting.ProductId = Punchcardsettingdto.ProductId;

                _context.PunchCardSettings.Update(existingPunchCardSetting);
                _context.SaveChanges();
            }
        }

        public IEnumerable<PunchCardSettingDTO> GetAll()
        {
            return _context.PunchCardSettings.Select(p => new PunchCardSettingDTO
            {
                Id = p.Id,
                SettingId = p.SettingId,
                ImageUrl = p.ImageUrl,
                Title = p.Title,
                NumberOfRewardCup = p.NumberOfRewardCup,
                NumberOfBuyedCup = p.NumberOfBuyedCup,
                RewardCupType = p.RewardCupType,
                BuyerCupType = p.BuyerCupType,
                ProductId = p.ProductId
            }).ToList();
        }

        public PunchCardSetting GetById(int id)
        {
            return _context.PunchCardSettings.FirstOrDefault(p => p.Id == id);
        }

        public IQueryable<PunchCardSettingDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var query = _context.PunchCardSettings.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p => p.Title.Contains(search));
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

            var punchCardSettings = query.Skip(skipCount).Take(pageSize)
                .Select(p => new PunchCardSettingDTO
                {
                    Id = p.Id,
                    SettingId = p.SettingId,
                    ImageUrl = p.ImageUrl,
                    Title = p.Title,
                    NumberOfRewardCup = p.NumberOfRewardCup,
                    NumberOfBuyedCup = p.NumberOfBuyedCup,
                    RewardCupType = p.RewardCupType,
                    BuyerCupType = p.BuyerCupType,
                    ProductId = p.ProductId
                });

            return punchCardSettings;
        }
    }
}
