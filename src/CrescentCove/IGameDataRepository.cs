using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FFXIV.CrescentCove
{
    public interface IGameDataRepository<T> where T : IGameData, new()
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> query);
        T GetById(int id);
        T GetById(uint id);
    }
}