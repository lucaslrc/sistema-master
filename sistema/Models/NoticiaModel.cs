using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [StringLength(50)]
        public string Autor { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        [Required]
        [StringLength(300)]
        public string ComentarioTexto { get; set; }
        public long NoticiaID { get; set; }
        public Noticia Noticia { get; set; }
    }
}