using System.Collections.Generic;
using System.Linq;
using sistema.Models;

namespace sistema.Data.Methods
{
    public class GetComentarios
    {
        public List<Comentario> Get(long ID)
        {
            using (var ctx = new SistemaContext())
            {
                var comentarios = ctx.comentarios.Where(x => x.NoticiaID == ID).OrderByDescending(o => o.ComentarioID).ToList();
                return comentarios;   
            }
        }
    }
}