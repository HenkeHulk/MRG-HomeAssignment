using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRG_HomeAssignment.Repo.Interface
{
    public interface IEntityRepository<T> : IDisposable
    {
        IQueryable<T> All { get; }
        T Find(int id);
        void Update(T entity);
        int Insert(T entity);
        void Delete(int id);
        void Save();
    }
}
