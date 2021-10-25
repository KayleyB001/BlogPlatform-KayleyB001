using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public interface IRepository<T>
    {


        void Create(T obj);
        IEnumerable<T> GetAll();

        T GetByID(int id);

        void Update(T obj);

        void Delete(T obj);

    }
}
