using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsControllers
{
    public interface IManage<T>
    {

        List<T> GetAlle();


        T GetFromId(int number);


        bool Create(T obj);


        bool Update(T obj, int id);


        T Delete(int number);
    }
}
