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
    public class PointSettingsRepo : IPointSettings
    {
        private readonly PerkfyContext _context;

        public PointSettingsRepo(PerkfyContext context)
        {
            _context = context;
        }

        public void Add(PointSettingsDTO point)
        {
            var pointSettings = new PointSetting
            {
                SettingId = point.SettingId,
                GainPoints = point.GainPoints,
                RedeemPoints = point.RedeemPoints,
                GainMoney = point.GainMoney,
                RedeemMoney = point.RedeemMoney
            };

            _context.PointSettings.Add(pointSettings);
            _context.SaveChanges();
        }

        public void Edit(int PointSettingID, PointSettingsDTO pointsettingdto)
        {
            var existingPointSetting = GetById(PointSettingID);
            if (existingPointSetting != null)
            {
                existingPointSetting.SettingId = pointsettingdto.SettingId;
                existingPointSetting.GainPoints = pointsettingdto.GainPoints;
                existingPointSetting.RedeemPoints = pointsettingdto.RedeemPoints;
                existingPointSetting.GainMoney = pointsettingdto.GainMoney;
                existingPointSetting.RedeemMoney = pointsettingdto.RedeemMoney;

                _context.PointSettings.Update(existingPointSetting);
                _context.SaveChanges();
            }
        }

        public IEnumerable<PointSettingsDTO> GetAll()
        {
            return _context.PointSettings.Select(p => new PointSettingsDTO
            {
                Id = p.Id,
                SettingId = p.SettingId,
                GainPoints = p.GainPoints,
                RedeemPoints = p.RedeemPoints,
                GainMoney = p.GainMoney,
                RedeemMoney = p.RedeemMoney
            }).ToList();
        }

        public PointSetting GetById(int id)
        {
            return _context.PointSettings.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<PointSettingsDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var query = _context.PointSettings.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p => p.SettingId.ToString().Contains(search));
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

            var pointSettings = query.Skip(skipCount).Take(pageSize)
                .Select(p => new PointSettingsDTO
                {
                    Id = p.Id,
                    SettingId = p.SettingId,
                    GainPoints = p.GainPoints,
                    RedeemPoints = p.RedeemPoints,
                    GainMoney = p.GainMoney,
                    RedeemMoney = p.RedeemMoney
                });

            return pointSettings.ToList();
        }

    }
}
