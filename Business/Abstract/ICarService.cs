using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetByCarId(int Id);
        List<Car> GetByColorId(int ColorId);
        List<Car> GetByBrandId(int BrandId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
