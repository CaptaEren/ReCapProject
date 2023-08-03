using Business.Abstract.Service;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarsDal _carDal;

        public CarManager(ICarsDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car t)
        {
            if (t.Description.Length >= 2 && t.DailyPrice > 0)
            {
                _carDal.Add(t);
            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır yada Araba günlük fiyatı 0 TL'den büyük olmalıdır.");
            }
        }

        public void Delete(Car t)
        {
            _carDal.Delete(t);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetCarByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId==id);
        }

        public List<Car> GetCarByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car t)
        {
            _carDal.Update(t);
        }
    }
}
