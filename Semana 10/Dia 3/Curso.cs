using System.Collections.Generic;

namespace EF_Relaciones
{
   public class Curso
   {
      public int ID { get; set; }
      public string nombreCurso { get; set; }
      public int id___profesor { get; set; }

      public virtual Profesor Profesor { get; set; }
      public virtual ICollection<Estudiante> Estudiantes {get;set;}
   }
}