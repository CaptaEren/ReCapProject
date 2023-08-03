using Business.Abstract.Service;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand t)
        {
            _brandDal.Add(t);
        }

        public void Delete(Brand t)
        {
            _brandDal.Delete(t);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        //public List<Brand> GetBrandByCarId(int id)
        //{
        //    return _brandDal.GetAll(b =>b.BrandId==);
        //}

        //public List<Brand> GetBrandByColorId(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public Brand GetById(int id)
        {
            return _brandDal.Get(b=>b.BrandId==id);
        }

        public void Update(Brand t)
        {
            _brandDal.Update(t);
        }
    }
}
