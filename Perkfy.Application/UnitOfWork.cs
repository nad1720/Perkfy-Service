using Perkfy.Repository;
using Perkfy.Service.Contract;
using Perkfy.Service.Implementation;
using System;

namespace Perkfy.Application
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PerkfyContext _context;

        public UnitOfWork(PerkfyContext context)
        {
            _context = context;
            Brands = new BrandRepo(context);
            Products = new ProductRepo(context);
            Qoutes = new QouteRepo(context);
            PunchCardSettings = new PunchCardSettingRepo(context);
            PointSettings = new PointSettingsRepo(context);
            Themes = new ThemeRepo(context);
            Transactions = new TransactionRepo(context);
        }

        public IBrand Brands { get; private set; }
        public IProduct Products { get; private set; }
        public IQoute Qoutes { get; private set; }
        public IPunchCardSetting PunchCardSettings { get; private set; }
        public IPointSettings PointSettings { get; private set; }
        public ITheme Themes { get; private set; }
        public ITransaction Transactions { get; private set; }

        public void Commit()
        {
            _context.SaveChanges();
        }

      

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
