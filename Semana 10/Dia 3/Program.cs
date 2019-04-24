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
            var profe = new Profesor()
            {
               nombre = "Jorge",
               apellido = "Garnica"
            };
            context.Profesores.Add(new Profesor
            {
               nombre = "Patrick",
               apellido = "Rodriguez"
            });

            var est = new Estudiante()
            {
               nombre = "Christian",
               Telefono = new Telefono { numeroTelefonico = 1234123 }

            };
            var cur = new Curso()
            {
               nombreCurso = "Angular",
               Profesor = profe
            };

            est.Cursos.Add(cur);
            context.Cursos.Add(new Curso
            {
               nombreCurso = "SCRUM",
               Profesor = profe,
               
            });
            
            context.Estudiantes.Add(est);

            context.SaveChanges();
         }


      }
   }
}
