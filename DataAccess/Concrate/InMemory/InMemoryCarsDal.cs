using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.InMemory
{
    
    public class InMemoryCarsDal : ICarsDal
    {
        List<Cars> _cars;

        public InMemoryCarsDal()
        {
            _cars = new List<Cars> { 
                new Cars {CarId=1,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=749,Description="Toyata Vits" },
                new Cars {CarId=2,BrandId=1,ColorId=2,ModelYear=2018,DailyPrice=749,Description="Toyata Coralla" },
                new Cars {CarId=3,BrandId=1,ColorId=5,ModelYear=2014,DailyPrice=850,Description="Toyata Auris" },
                new Cars {CarId=4,BrandId=2,ColorId=4,ModelYear=2022,DailyPrice=1010,Description="Mercedes E200" },
                new Cars {CarId=5,BrandId=2,ColorId=6,ModelYear=2021,DailyPrice=1000,Description="Mercedes E150" },
                new Cars {CarId=6,BrandId=3,ColorId=3,ModelYear=2023,DailyPrice=1500,Description="BMW M Serisi M5" },
                new Cars {CarId=7,BrandId=3,ColorId=2,ModelYear=2020,DailyPrice=1300,Description="BMW M Serisi M3" },
                new Cars {CarId=8,BrandId=3,ColorId=2,ModelYear=2022,DailyPrice=1400,Description="BMW X4" },
                new Cars {CarId=9,BrandId=4,ColorId=1,ModelYear=1999,DailyPrice=450,Description="Fiat Egea 1.3 Multijet Easy" },
                new Cars {CarId=10,BrandId=4,ColorId=5,ModelYear=2001,DailyPrice=350,Description="Fiat Egea 1.4 Easy" },
                new Cars {CarId=11,BrandId=4,ColorId=5,ModelYear=2004,DailyPrice=950,Description="Fiat Egea 1.6 Multijet Lounge DCT" },
                new Cars {CarId=12,BrandId=5,ColorId=6,ModelYear=2009,DailyPrice=250,Description="Suzuki Swift 1.2 GL" },
                new Cars {CarId=13,BrandId=5,ColorId=4,ModelYear=2015,DailyPrice=500,Description="Suzuki Swift 1.6 Sport" }
            };
            
              
            
        }

        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetByCarId(int carId)
        {
            return _cars.Where(ıd => ıd.CarId == carId).ToList();
        }

        public void Update(Cars car)
        {
            Cars carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
