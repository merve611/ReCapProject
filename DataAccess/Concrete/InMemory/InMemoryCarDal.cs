using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{BrandId = 1,CarId=1,ColorId=1,DailyPrice=100000,ModelYear=2015, Description ="Mercedes" },
                new Car{BrandId = 1,CarId=2,ColorId=2,DailyPrice=120000,ModelYear=2017, Description ="Mercedes" },
                new Car{BrandId = 2,CarId=3,ColorId=4,DailyPrice=100000,ModelYear=2017, Description ="Skoda" },
                new Car{BrandId = 3,CarId=4,ColorId=4,DailyPrice=200000,ModelYear=2019, Description ="Cıtroen" },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete  = _cars.SingleOrDefault(c=>c.CarId ==c.CarId);


            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
