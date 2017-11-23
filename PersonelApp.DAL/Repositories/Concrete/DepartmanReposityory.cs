using PersonelApp.DAL.Repositories.Abstract;
using PersonelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace PersonelApp.DAL.Repositories.Concrete
{
    public class DepartmanReposityory :Repository<Departmant> ,IDepatmanRepository
    {


        public DepartmanReposityory(PersonelContext context) : base(context)
        {

        }
       
        

        public IEnumerable<Departmant> GetDepartmanWithPErsonnels()
        {
            return PersonelContext.Departmans.Include("Personels").ToList();
        }

        public IEnumerable<Departmant> GetTopDepartmans(int count)
        {
            return PersonelContext.Departmans.Take(count);
        }
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
