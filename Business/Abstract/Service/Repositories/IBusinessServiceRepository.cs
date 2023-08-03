using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Service.Repositories
{
    public interface IBusinessServiceRepository<T>
    {
        
        List<T> GetAll();
        
        T GetById(int id);
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        
    }
}
