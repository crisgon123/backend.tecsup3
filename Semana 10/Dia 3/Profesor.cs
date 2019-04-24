using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relaciones
{
   public class Profesor
   {
      public int id { get; set; }
      public string nombre { get; set; }
      public string apellido { get; set; }

      public virtual ICollection<Curso> Cursos { get; set; }

   }
}
