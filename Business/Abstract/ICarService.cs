﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int Id);
        IDataResult< List<Car>> GetCarsByColorId(int Id);
        IDataResult< List<Car>> GetCarsByBrandId(int Id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarsDetailsByBrandId(int Id);
        IDataResult<List<CarDetailDto>> GetCarsDetailsByColorId(int Id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int Id);


    }
}


//GetCarsByBrandId , GetCarsByColorId