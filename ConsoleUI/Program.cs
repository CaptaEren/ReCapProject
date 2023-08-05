using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

public class Program
{
    private static void Main(string[] args)
    {
        //CarTest();
        //CarTest2();
        //DetailsTest();
        CarAddTest();

    }

    private static void CarAddTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = 2018, DailyPrice = 749, Description = "Toyata Coralla" });
    }

    private static void DetailsTest()
    {
        CarManager carsManager = new CarManager(new EfCarDal());
        foreach (var Cars in carsManager.GetCarDetails())
        {
            Console.WriteLine(Cars.CarName + ":" + " " + Cars.BrandName + " " + "-" + Cars.ColorName + "-" + " " + "==>" + " " + Cars.DailyPrice + "TL");
        }
    }

    private static void CarTest2()
    {
        CarManager carsManager = new CarManager(new EfCarDal());
        foreach (var Cars in carsManager.GetAll())
        {
            Console.WriteLine(Cars);
        }
        Console.WriteLine("-----------------------------------------------");

        foreach (var Cars in carsManager.GetAll())
        {
            Console.WriteLine(Cars.CarId + ":" + " " + Cars.Description + " " + "-" + Cars.ModelYear + "-" + " " + "==>" + " " + Cars.DailyPrice + "TL");
        }
        Console.WriteLine("-----------------------------------------------");
    }

    private static void CarTest()
    {
        CarManager carsManager = new CarManager(new EfCarDal());

        foreach (var cars in carsManager.GetAll())
        {
            Console.WriteLine(cars.CarId + ":" + cars.Description + "-" + cars.ModelYear + "-" + " " + "==>" + " " + cars.DailyPrice + "TL");

        }
    }
}