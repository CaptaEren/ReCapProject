using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Diagnostics.CodeAnalysis;

public class Program
{
    private static void Main(string[] args)
    {

        //ICarService carService = new CarManager(new EfCarDal());
        //carService.Add(new Car { BrandId = 2,ColorId =2,DailyPrice=800,ModelYear=2013,Description="BMW M3 1.6" });

        //IBrandService brandService = new BrandManager(new EfBrandDal());
        //brandService.Add(new Brand { BrandId=1,BrandName="Toyata"});
        //brandService.Add(new Brand { BrandId = 2, BrandName = "BMW" });
        //brandService.Add(new Brand { BrandId = 3, BrandName = "Mercedes" });


        //IColorService colorService= new ColorManager(new EfColorDal());
        //colorService.Add(new Color {ColorId=1,ColorName="Beyaz" });
        //colorService.Add(new Color { ColorId = 2, ColorName = "Siyah" });

        //IUserService userService = new UserManager(new EfUserDal());
        //userService.Add(new User { FirstName ="Mehmet Eren",LastName="Çiftçi",Email="mehmetciftci142@gmail.com",Password="Eren123"});

        //ICustomerService customerService=new CustomerManager(new EfCustomerDal());
        //customerService.Add(new Customer { UserId = 1,CompanyName="Eren Software" });
        

        IRentalService rentalService= new RentalManager(new EfRentalDal());
        rentalService.Add(new Rental { CarId = 1, RentDate = new DateTime(2023,08,10)});

    }
    
}