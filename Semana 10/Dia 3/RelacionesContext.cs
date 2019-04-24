using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relaciones
{
   class RelacionesContext : DbContext
   {
      public RelacionesContext() :base ("Relaciones")
      {

      }
      public virtual DbSet<Profesor> Profesores { get; set; }
      public virtual DbSet<Curso> Cursos { get; set; }

   }
}
