using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domain
{
    public class Personel : BaseEntity
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string lastName { get; set; }

        public int DepartmantId { get; set; }

        public Departmant Departmant { get; set; }
    }
}
