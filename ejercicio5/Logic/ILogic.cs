using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    interface ILogic<T>
    {
        List<T> GetAll();
        T Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
