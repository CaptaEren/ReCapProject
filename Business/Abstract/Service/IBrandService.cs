using Business.Abstract.Service.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Service
{
    public interface IBrandService : IBusinessServiceRepository<Brand>
    {
        //List<Brand> GetBrandByCarId(int id);
        //List<Brand> GetBrandByColorId(int id);
    }
}
