using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = Convert.ToString(car.Id),
                                 BrandName = brand.BrandName,
                                 ModelName =car.Model,
                                 ModelYear= Convert.ToString(car.ModelYear),
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description=car.Description
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarsDetailsByBrandId(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             where car.BrandId==brandId
                             select new CarDetailDto {
                                 CarId = Convert.ToString(car.Id),
                                 BrandName = brand.BrandName,
                                 ModelName = car.Model,
                                 ModelYear = Convert.ToString(car.ModelYear),
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarsDetailsByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             where car.ColorId == colorId
                             select new CarDetailDto {
                                 CarId = Convert.ToString(car.Id),
                                 BrandName = brand.BrandName,
                                 ModelName = car.Model,
                                 ModelYear = Convert.ToString(car.ModelYear),
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description
                             };
                return result.ToList();
            }
        }



        public List<CarDetailDto> GetCarDetailsByCarId(int Id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             where car.Id == Id
                             select new CarDetailDto {
                                 CarId = Convert.ToString(car.Id),
                                 BrandName = brand.BrandName,
                                 ModelName = car.Model,
                                 ModelYear = Convert.ToString(car.ModelYear),
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description
                             };
                return result.ToList();
            }
        }
    }
}
