using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;

public class Program
{
    private static void Main(string[] args)
    {
        CarsManager carsManager = new CarsManager(new EfCarDal());
      
        foreach (var cars in carsManager.GetAll())
        {
            Console.WriteLine(cars.CarId + ":" +cars.Description + "-" + cars.ModelYear + "-" + " " + "==>" + " " + cars.DailyPrice + "TL");

        }































        //CarsManager carsManager = new CarsManager(new EfCarDal());
        //    foreach (var Cars in carsManager.GetAll())
        //    {
        //        Console.WriteLine(Cars.Description);
        //    }
        //    Console.WriteLine("-----------------------------------------------");

        // foreach (var Cars in carsManager.GetAll())
        //    {
        //        Console.WriteLine(Cars.CarId+":"+" "+Cars.Description + " " +"-"+Cars.ModelYear + "-" + " " +"==>"+" "+Cars.DailyPrice+"TL");
        //    }
        //    Console.WriteLine("-----------------------------------------------");

    }
}