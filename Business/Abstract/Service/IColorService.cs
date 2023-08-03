using Business.Abstract.Service.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Service
{
    public interface IColorService:IBusinessServiceRepository<Color>
    {
        //List<Color> GetColorByBrandId(int id);
        //List<Color> GetColorByCarId(int id);
    }
}
