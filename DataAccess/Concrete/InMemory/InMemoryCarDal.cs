using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 1998, DailyPrice = 4000, Description = "Alfa Romeo 156"},
                new Car {Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2012, DailyPrice = 6000, Description = "Citroen C5"},
                new Car {Id = 3, BrandId = 2, ColorId = 3, ModelYear = 2000, DailyPrice = 3500, Description = "Citroen Xsara"},
                new Car {Id = 4, BrandId = 3, ColorId = 5, ModelYear = 2009, DailyPrice = 8000, Description = "BMW Series 7"},
                new Car {Id = 5, BrandId = 1, ColorId = 8, ModelYear = 2001, DailyPrice = 4000, Description = "Alfa Romeo 166"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int identity)
        {
            return _cars.Where(c=> c.Id == identity).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
