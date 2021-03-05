using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;


        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [TransactionScopeAspect]
        [SecuredOperation("rental.add")]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Add(Rental rental)
        {

            var result = _rentalDal.GetAll();


            foreach (var item in result)
            {
                if (item.CarId == rental.CarId && item.ReturnDate == null)
                {
                    return new ErrorResult(Messages.RentalReturnError);
                }
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);

        }

        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        [PerformanceAspect(3)]
        [CacheAspect]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        [CacheAspect]
        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Update(Rental rental)
        {
            var result = _rentalDal.GetAll();


            foreach (var item in result)
            {
                if (item.CarId == rental.CarId && item.ReturnDate == null)
                {
                    _rentalDal.Update(rental);
                    return new SuccessResult(Messages.RentalFinished);
                }

            }
            return new ErrorResult();

        }

        [CacheAspect]
        public IDataResult<List<Rental>> GetRentedCars()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.ReturnDate == null), Messages.RentalsListed);
        }




    }
}
