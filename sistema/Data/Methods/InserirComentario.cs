using System;
using sistema.Models;

namespace sistema.Data.Methods
{
    public class InserirComentario
    {
        public bool Insere(long id, string autor, string email, string comentario)
        {
            try
            {
                using (var ctx = new SistemaContext())
                {
                    ctx.comentarios.Add(new Comentario {
                        NoticiaID = id,
                        Autor = autor,
                        Email = email,
                        ComentarioTexto = comentario
                    });
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch 
            {
                return false;
            }
        }
    }
}