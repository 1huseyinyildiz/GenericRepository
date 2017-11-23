using PersonelApp.DAL;
using PersonelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Console.UI
{
    class Program
    {
        public static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            unitOfWork.DepartmanRepository.Add(new Departmant()
            {
                Name = "Bilgi işlem",
                İsActive = true,
                CreateDate = DateTime.Now,

            });
            unitOfWork.Complete();
        }
    }
}
