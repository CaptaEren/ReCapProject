using Business.Abstract.Service.Repositories;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Service
{
    public interface ICarService:IBusinessServiceRepository<Car>
    {
        List<Car> GetCarByBrandId(int id);
        List<Car> GetCarByColorId(int id);
        List<CarDetailDto> GetCarDetails();
             
    }
}
