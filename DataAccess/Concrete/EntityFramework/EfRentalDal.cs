using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join rental in context.Rentals on car.Id equals rental.CarId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                             join user in context.Users on customer.UserId equals user.Id
                             select new RentalDetailDto {
                                 RentalId = rental.Id,
                                 BrandName = brand.BrandName,
                                 CustomerUser = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.ToList();
            }



            //            from Rentals as r
            //inner join Cars as c on r.CarId = c.Id
            //inner join Brands as b on b.BrandId = c.BrandId
            //inner join Customers as cus on cus.CustomerId = r.CustomerId
            //inner join Users as U on cus.UserId = U.Id

        }


    }
}
