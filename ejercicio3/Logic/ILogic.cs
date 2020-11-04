using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    interface ILogic<T>
    {
        List<T> All();

        T One(int id);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
