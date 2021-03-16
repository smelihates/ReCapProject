using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //if (car.DailyPrice<=0)
            //{
            //    return new ErrorResult(Messages.CarDailyPriceInvalid);
            //}
            //else
            //{
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            //}

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == Id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetailsByBrandId(int Id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetailsByBrandId(Id), Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetailsByColorId(int Id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetailsByColorId(Id), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == Id),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == Id),Messages.CarsListed);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            //if (car.DailyPrice <= 0)
            //{
            //    return new ErrorResult(Messages.CarDailyPriceInvalid);
                
            //}
            //else
            //{
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            //}
            
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int Id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByCarId(Id), Messages.CarsListed);
        }
    }
}
