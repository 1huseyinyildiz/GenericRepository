using PersonelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Abstract
{
    public interface IDepatmanRepository : IRepository<Departmant>
    {
         IEnumerable<Departmant> GetTopDepartmans(int Count);

         IEnumerable<Departmant> GetDepartmanWithPErsonnels();
    }
}
