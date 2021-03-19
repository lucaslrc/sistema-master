using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sistema.Models
{
    public class Noticia
    {
        [Key]
        public long NoticiaID { get; set; }

        [Required]
        [Display(Name = "Titulo")]
        [DataType(DataType.Text)]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Subtitulo")]
        [DataType(DataType.Text)]
        public string Subtitulo { get; set; }

        [Required]
        [Display(Name = "Corpo")]
        [DataType(DataType.Text)]
        public string Corpo { get; set; }
        
        [Display(Name = "Comentarios")]
        public List<Comentario> Comentarios { get; set; }
    }
    public class Comentario
    {
        [Key]
        public long ComentarioID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Autor { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5)]
        public string ComentarioTexto { get; set; }
        public long NoticiaID { get; set; }
        public Noticia Noticia { get; set; }
    }
}