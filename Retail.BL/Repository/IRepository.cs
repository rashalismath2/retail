using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.BL.Repository
{
    interface IRepository<T>
    {
        bool Save(T item);
        T Retrieve(int itemId);
        List<T> Retrieve();
        bool Delete(int itemId);
        T Update(T item);
    }
}
