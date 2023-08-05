using Business.Abstract;
using Core.Results;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length < 2 && car.DailyPrice < 0)
            {
                return new ErrorResult();
            }
           
            _carDal.Add(car);
            return new SuccessResult();
            
        }

        public IResult Delete(Car car)
        {

            _carDal.Delete(car);
            return new SuccessResult();

        }
        
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int carId)
        {
            if (carId==null)
            {
                return new ErrorDataResult<Car>("Check! Unvalıd Id ");
            }
            return new SuccesDataResult<Car>(_carDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
