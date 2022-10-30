using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car() { Id = 4, BrandId = 2, ColorId = 10, ModelYear = 2013, DailyPrice = 800, Description = "New" });
            //carManager.Delete(new Car() { Id = 1 });
            //carManager.Delete(new Car() { Id = 2 });
            //carManager.GetAllById(3);


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
                Console.WriteLine(car.ModelYear);
            }
            Console.ReadLine();
           
        }
    }
}
