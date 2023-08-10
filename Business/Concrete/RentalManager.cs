using Business.Abstract;
using Core.Entities;
using Core.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var exist_Rental = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == default);

            if (exist_Rental!=null)
            {
                return new ErrorResult("Araç Halen Kullanımda dır!");
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult("Araç Kiralanmıştır");
            }
           
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Araç Kiralama isteği İptal Edilmiştir");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.RentalId == rentalId));
        }

        public IResult Update(Rental rental)
        {
           
            _rentalDal.Update(rental);
            return new SuccessResult("Araç Kiralama Güncellendi");
        }
    }
}
