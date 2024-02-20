using KodlamaioCSharp.Entities.concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCSharp.DataAccess.Abstrats
{
    public interface IBaseDal<T>
    {
        void Add(T entity);
        List<T> GetAll();
        void Delete(T entity);
        void Update(T entity);
    }
}
