using System;

namespace GenericRepository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}