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
    public class TransactionRepo : ITransaction
    {
        private readonly PerkfyContext _context;

        public TransactionRepo(PerkfyContext context)
        {
            _context = context;
        }

        public void Add(TransactionDTO transactiondto)
        {
            var transaction = new Transaction
            {
                UserId = transactiondto.UserId,
                CashierId = transactiondto.CashierId,
                SettingId = transactiondto.SettingId,
                PointsCount = transactiondto.PointsCount,
                TransactionTime = transactiondto.TransactionTime,
                Note = transactiondto.Note,
                TypeId = transactiondto.TypeId
            };

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void Edit(int ID, TransactionDTO transactiondto)
        {
            var existingTransaction = GetById(ID);
            if (existingTransaction != null)
            {
                existingTransaction.UserId = transactiondto.UserId;
                existingTransaction.CashierId = transactiondto.CashierId;
                existingTransaction.SettingId = transactiondto.SettingId;
                existingTransaction.PointsCount = transactiondto.PointsCount;
                existingTransaction.TransactionTime = transactiondto.TransactionTime;
                existingTransaction.Note = transactiondto.Note;
                existingTransaction.TypeId = transactiondto.TypeId;

                _context.Transactions.Update(existingTransaction);
                _context.SaveChanges();
            }
        }

        public IEnumerable<TransactionDTO> GetAll()
        {
            return _context.Transactions.Select(t => new TransactionDTO
            {
                Id = t.Id,
                UserId = t.UserId,
                CashierId = t.CashierId,
                SettingId = t.SettingId,
                PointsCount = t.PointsCount,
                TransactionTime = t.TransactionTime,
                Note = t.Note,
                TypeId = t.TypeId
            }).ToList();
        }

        public Transaction GetById(int id)
        {
            return _context.Transactions.FirstOrDefault(t => t.Id == id);
        }

        public IQueryable<TransactionDTO> GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var query = _context.Transactions.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(t => t.Note.Contains(search));
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

            var transactions = query.Skip(skipCount).Take(pageSize)
                .Select(t => new TransactionDTO
                {
                    Id = t.Id,
                    UserId = t.UserId,
                    CashierId = t.CashierId,
                    SettingId = t.SettingId,
                    PointsCount = t.PointsCount,
                    TransactionTime = t.TransactionTime,
                    Note = t.Note,
                    TypeId = t.TypeId
                });

            return transactions;
        }
    }
}
