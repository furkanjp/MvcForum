using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public interface IRepostory<T>
    {
        List<T> List();

        void Insert(T p);
        void Delete(T p);
        void Update(T p);
    }
}
