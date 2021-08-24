using System;
using System.Collections.Generic;
using System.Text;

namespace MainMusicStore.DataAccess.IMainRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository category { get; }
        IProductRepository product { get; }
        IBrandRepository brand { get; }
        object Category { get; }
        ISPCallRepository sp_call { get; }
        void Save();
    }
}
