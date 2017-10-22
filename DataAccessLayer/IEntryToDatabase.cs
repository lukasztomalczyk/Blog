using System;
using DataAccessLayer.Repository;

namespace DataAccessLayer
{
    public interface IEntryToDatabase : IDisposable
    {
        IPostRepository PostRepository { get; }

        void Save();
    }
}