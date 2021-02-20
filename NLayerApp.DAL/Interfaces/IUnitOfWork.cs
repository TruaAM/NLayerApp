using NLayerApp.DAL.Interfaces;
using NLayerApp.DAL.Models;
using System;

namespace NLayerApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Interfaces.IRepository<Product> Products { get; }
        Interfaces.IRepository<Order> Orders { get; }
        void Save();
    }
}