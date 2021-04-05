using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IDataResult<CreditCard> GetById(int Id);
        IResult Add(CreditCard  creditCard);
        IResult Update(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);

    }
}
