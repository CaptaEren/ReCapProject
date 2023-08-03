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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color t)
        {
            _colorDal.Add(t);
        }

        public void Delete(Color t)
        {
            _colorDal.Delete(t);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(clr=>clr.ColorId==id);
          
        }

        //public List<Color> GetColorByBrandId(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Color> GetColorByColorId(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(Color t)
        {
            _colorDal.Update(t);
        }
    }
}
