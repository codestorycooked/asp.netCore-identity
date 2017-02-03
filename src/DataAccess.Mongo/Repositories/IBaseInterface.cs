using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Mongo.Repositories
{
    public interface IBaseInterface<T>
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Post(T data);
        void Put(T data);
        void DeleteByID(int Id);
    }
}
