using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var addBrandEntity = context.Entry(entity);
                addBrandEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var deleteBrandEntity = context.Entry(entity);
                deleteBrandEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>>? filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return filter == null ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var updateBrandEntity = context.Entry(entity);
                updateBrandEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
