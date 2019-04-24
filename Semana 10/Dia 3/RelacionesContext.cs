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
         Database.SetInitializer<RelacionesContext>
             (new DropCreateDatabaseAlways<RelacionesContext>());
      }
      public virtual DbSet<Profesor> Profesores { get; set; }
      public virtual DbSet<Curso> Cursos { get; set; }
      public virtual DbSet<Estudiante> Estudiantes { get; set; }

      
      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Profesor>()
            .HasMany(x => x.Cursos)
            .WithRequired(x => x.Profesor)
            .HasForeignKey(x => x.id___profesor);

         modelBuilder.Entity<Estudiante>()
            .HasMany<Curso>(x => x.Cursos)
            .WithMany(x => x.Estudiantes);
            

         base.OnModelCreating(modelBuilder);
      }

   }
}
