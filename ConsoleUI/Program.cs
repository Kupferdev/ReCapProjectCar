using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

Car car1 = new Car { Id = 1, ColorId = 1654, BrandId = 1, DailyPrice = 3500, Description = "Alfa Romeo 156", ModelYear = 1998 };

carManager.Add(car1);

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

