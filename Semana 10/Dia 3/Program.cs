using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relaciones
{
   class Program
   {
      static void Main(string[] args)
      {
         using (var context = new RelacionesContext())
         {
            context.Profesores.Add(new Profesor
            {
               nombre = "Jorge",
               apellido = "Garnica"
            });
            context.SaveChanges();
         }


      }
   }
}
