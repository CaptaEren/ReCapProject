using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarsDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDbContext context=new ReCapDbContext())
            {
                var result = from c in context.Cars

                              join b in context.Brands

                              on c.BrandId equals b.BrandId
                              join cr in context.Colors
                              on c.ColorId equals cr.ColorId
                              select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = cr.ColorName, DailyPrice = c.DailyPrice,CarName=c.Description };
                return result.ToList();


                             
                             
                             
                             
                             
            }
        }
    }
}
