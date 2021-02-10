using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=10,ColorId=1,ModelYear="2019",DailyPrice=100,Description="Opel Astra"},
                new Car{Id=2,BrandId=11,ColorId=1,ModelYear="2020",DailyPrice=10,Description="Fiat Fiorino"},
                new Car{Id=3,BrandId=12,ColorId=2,ModelYear="2021",DailyPrice=150,Description="Audi A6"},
                new Car{Id=4,BrandId=13,ColorId=3,ModelYear="2018",DailyPrice=500,Description="Bmw M5"},
                new Car{Id=5,BrandId=14,ColorId=3,ModelYear="2017",DailyPrice=200,Description="Mercedes S500"},
                new Car{Id=6,BrandId=15,ColorId=4,ModelYear="2015",DailyPrice=1500,Description="Ford Mondeo"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
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

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c=> c.BrandId==brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.BrandId==car.BrandId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
