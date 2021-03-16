using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarsDetailsByBrandId(int Id);
        List<CarDetailDto> GetCarsDetailsByColorId(int Id);
        List<CarDetailDto> GetCarDetailsByCarId(int Id);

    }
}
