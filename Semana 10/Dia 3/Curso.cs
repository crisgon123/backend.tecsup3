namespace EF_Relaciones
{
   public class Curso
   {
      public int ID { get; set; }
      public string nombreCurso { get; set; }

      public virtual Profesor Profesor { get; set; }
   }
}