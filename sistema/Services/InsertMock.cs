using System;
using System.Linq;
using sistema.Data;
using sistema.Models;

namespace sistema.Services
{
    public class InsertMock
    {
        public void InsertNoticia()
        {
            using (var ctx = new SistemaContext())
            {
                var existeNoticia1 = ctx.noticias.Any(x => x.NoticiaID == 1);
                var existeNoticia2 = ctx.noticias.Any(x => x.NoticiaID == 2);
                var existeNoticia3 = ctx.noticias.Any(x => x.NoticiaID == 3);

                if (!existeNoticia1)
                {
                    ctx.noticias.Add(new Noticia{
                        NoticiaID = 1,
                        Titulo = "Correios: estudo oficial recomenda privatização total da empresa",
                        Subtitulo = "Estudos sobre privatização dos Correios desaconselha venda minoritária da estatal ou sua divisão entre vários interessados",
                        Corpo = "Nesta quarta-feira (17), o Conselho do Programa de Parcerias de Investimentos (CPPI) e o Banco Nacional de Desenvolvimento Econômico e Social (BNDES) anunciaram a conclusão da primeira fase dos estudos oficiais que avaliam a desestatização dos serviços postais no Brasil. A conclusão é a de que a privatização dos Correios deve ser completa."
                    });
                    ctx.SaveChanges();
                }

                if (!existeNoticia2)
                {
                    ctx.noticias.Add(new Noticia{
                        NoticiaID = 2,
                        Titulo = "Não Me Perturbe das operadoras é insuficiente e Anatel quer alternativas",
                        Subtitulo = "Anatel quer endurecer regras contra telemarketing abusivo; conselheiro diz que Não Me Perturbe é insuficiente e quer alternativas",
                        Corpo = "As ligações de telemarketing de operadoras de telefonia costumam ser indesejadas, e consumidores que não quiserem se incomodar com as chamadas de spam podem se cadastrar no Não Me Perturbe. No entanto, a Anatel considera que o registro na lista de bloqueio é insatisfatório e propõe mudanças para endurecer as regras desse tipo de serviço."
                    });
                    ctx.SaveChanges();
                }

                if (!existeNoticia3)
                {
                    ctx.noticias.Add(new Noticia{
                        NoticiaID = 3,
                        Titulo = "Google Chrome agora tem legenda instantânea para áudios e vídeos",
                        Subtitulo = "Função do Chrome gera legenda instantânea para qualquer vídeo ou áudio em inglês; suporte a outros idiomas está nos planos",
                        Corpo = "O Google Chrome 89 para desktops chegou no início do mês com lista de links para ler depois e um gerenciamento melhorado de perfis. Mas essa não é a única novidade: um recurso de legenda instantânea para áudios e vídeos (live caption) também faz parte dos recursos da versão."
                    });
                    ctx.SaveChanges();
                }
            }
        }
        public void InsertComentario()
        {
            using (var ctx = new SistemaContext())
            {
                var existeComentario1 = ctx.comentarios.Any(x => x.NoticiaID == 1);
                var existeComentario2 = ctx.comentarios.Any(x => x.NoticiaID == 2);
                var existeComentario3 = ctx.comentarios.Any(x => x.NoticiaID == 3);

                if (!existeComentario1) {
                    ctx.comentarios.Add(new Comentario{
                        NoticiaID = 1,
                        Autor = "Lucas",
                        Email = "lucas@email.com",
                        ComentarioTexto = "Meu comentário"
                    });  
                    ctx.SaveChanges();
                }

                if (!existeComentario2) {
                    ctx.comentarios.Add(new Comentario{
                        NoticiaID = 2,
                        Autor = "Lucas",
                        Email = "lucas@email.com",
                        ComentarioTexto = "Meu comentário"
                    });
                    ctx.SaveChanges();   
                }

                if (!existeComentario3) {
                    ctx.comentarios.Add(new Comentario{
                        NoticiaID = 3,
                        Autor = "Lucas",
                        Email = "lucas@email.com",
                        ComentarioTexto = "Meu comentário"
                    });   
                    ctx.SaveChanges();     
                }        
            }
        }
    }
}