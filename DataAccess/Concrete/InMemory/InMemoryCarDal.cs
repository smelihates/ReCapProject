using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
                new Car{ Id =1, BrandId =1, ColorId=1,  ModelYear =2010,  Description ="Sedan", DailyPrice=150000 },
                new Car{ Id =2, BrandId =2, ColorId=3,  ModelYear =2012,  Description ="Sedan", DailyPrice=165000 },
                new Car{ Id =3, BrandId =1, ColorId=1,  ModelYear =2013,  Description ="Hatcback", DailyPrice=145000 },
                new Car{ Id =4, BrandId =3, ColorId=2,  ModelYear =2011,  Description ="Sedan", DailyPrice=110000 },
                new Car{ Id =5, BrandId =2, ColorId=1,  ModelYear =2010,  Description ="SUV", DailyPrice=140000 },
            };

            



        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

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

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetailsByCarId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsDetailsByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsDetailsByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
         }

        List<CarDetailDto> ICarDal.GetCarDetailsByCarId(int Id)
        {
            throw new NotImplementedException();
        }

        //List<Car> ICarDal.GetByBrandId(int BrandId)
        //{
        //    return _cars.Where(c => c.BrandId == BrandId).ToList();
        //}

        //Car ICarDal.GetByCarId(int Id)
        //{
        //    return _cars.SingleOrDefault(c => c.Id == Id);
        //}

        //List<Car> ICarDal.GetByColorId(int ColorId)
        //{
        //    return _cars.Where(c => c.ColorId == ColorId).ToList();
        //}
    }
}
