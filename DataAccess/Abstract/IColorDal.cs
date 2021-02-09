using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
        ////Entity Repository gelince aşağıdaki kodlar desible edildi.
        //List<Color> GetAll();
        //Color GetByColorId(int Id);
        //void Add(Color color);
        //void Update(Color color);
        //void Delete(Color color);
    }
}
