using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car(){Id=1,BrandId=2,ColorId=2,ModelYear=2022,DailyPrice=1200,Description="Full"},
                new Car(){Id=2,BrandId=3,ColorId=2,ModelYear=2021,DailyPrice=100,Description="Medium"},
                new Car(){Id=3,BrandId=5,ColorId=2,ModelYear=2010,DailyPrice=500,Description="Low"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id==car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(c=> c.Id==Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.Id==car.Id);
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;    
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.BrandId=car.BrandId;
        }
    }
}
