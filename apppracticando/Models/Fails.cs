

using System;
namespace apppracticando.Models
{
    public class Fails
    {
          public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Usuario { get; set; }

        public string Foto { get; set; }


        public Comentario Comentario { get; set; }

        public int ComentarioId { get; set; }


        public DateTime Fecha { get; set; }


        
    }
}