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
         // AUTOMÁTICAS
         // RELACION DE UNO A MUCHOS
         modelBuilder.Entity<Profesor>()
            .HasMany(x => x.Cursos)
            .WithRequired(x => x.Profesor)
            .HasForeignKey(x => x.id___profesor);

         // AUTOMÁTICAS
         // RELACION DE MUCHOS A MUCHOS
         modelBuilder.Entity<Estudiante>()
            .HasMany(x => x.Cursos)
            .WithMany(x => x.Estudiantes)
            .Map(x =>
                 {
                    x.MapLeftKey("id___Estudiante");
                    x.MapRightKey("id___Curso");
                    x.ToTable("EstudianteConCursos");
                 });

         // CONFIGURAR MANUALMENTE
         // RELACION DE 1 A 0..1
         modelBuilder.Entity<Estudiante>()
            .HasOptional(x => x.Direccion)
            .WithRequired(x => x.Estudiante);

         // RELACION DE 1 A 1
         modelBuilder.Entity<Telefono>()
            .HasRequired(x => x.Estudiante)
            .WithRequiredPrincipal(x => x.Telefono);

         base.OnModelCreating(modelBuilder);
      }

   }
}
