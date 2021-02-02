using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        List<Color> GetAll();
        Color GetByColorId(int Id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
