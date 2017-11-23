using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PersonelApp.Domain;

namespace PersonelApp.DAL
{
    public class PersonelContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }

        public DbSet<Departmant> Departmans { get; set; }

        public PersonelContext() : base("DataContext")
        {

        }
    }
}
