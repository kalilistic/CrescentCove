using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CrescentCove.Model;

namespace CrescentCove
{
    public interface IGameDataRepository<T> where T : IGameData, new()
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> query);
        T GetById(int id);
    }
}