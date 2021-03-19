using System.Linq;
using sistema.Models;

namespace sistema.Data.Methods
{
    public class GetNoticia
    {
        public Noticia Get(long ID)
        {
            using (var ctx = new SistemaContext())
            {
                var noticia = ctx.noticias.Where(x => x.NoticiaID == ID).FirstOrDefault();
                return noticia;   
            }
        }
    }
}