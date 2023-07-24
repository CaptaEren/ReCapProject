using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarsDal
    {
        List<Cars> GetAll();
        List<Cars> GetByCarId(int CarId);

        void Add(Cars car);
        void Update(Cars cars);
        void Delete(Cars cars);
        
    }
}
