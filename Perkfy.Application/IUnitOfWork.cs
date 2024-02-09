using Perkfy.Service.Contract;
using Perkfy.Service.Implementation;

namespace Perkfy.Application
{
    public interface IUnitOfWork : IDisposable
    {
        IBrand Brands { get; }
        IProduct Products { get; }
        IQoute Qoutes { get; }   
        IPunchCardSetting PunchCardSettings { get; }
        IPointSettings PointSettings { get; }
        ITheme Themes { get; }
        ITransaction Transactions { get; }
       
        void Commit();
     
    }
}