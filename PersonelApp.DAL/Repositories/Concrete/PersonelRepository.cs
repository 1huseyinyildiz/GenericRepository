using PersonelApp.DAL.Repositories.Abstract;
using PersonelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Concrete
{
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {
        public PersonelRepository(PersonelContext context):base(context)
        {

        }

        public IEnumerable<Personel> GetPersonelWithDepartmens()
        {
            return PersonelContext.Personels.Include("Departman").ToList();
        }

        public PersonelContext PersonelContext { get { return _context as PersonelContext;  } }
    }
}
