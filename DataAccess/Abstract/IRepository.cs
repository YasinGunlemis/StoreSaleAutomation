using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepository<T>
    {
        DataTable GetDataTable();
        T Get(int id);
        string Add(T entity);
        string Update(T entity);
        string Delete(int id);
    }
}
