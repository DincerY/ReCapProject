using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal=carDal;
        }
        //public void Delete(Car car)
        //{
        //    _carDal.Delete(car);
        //}
        public void Add(Car car)
        {
            _carDal.Add(car);
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void GetAllById(int Id)
        {
            foreach (var item in _carDal.GetAllById(Id))
            {
                Console.WriteLine(item.Description);
                Console.WriteLine(item.ModelYear); 
                Console.WriteLine(item.ColorId);
            }
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
       
    }
}
