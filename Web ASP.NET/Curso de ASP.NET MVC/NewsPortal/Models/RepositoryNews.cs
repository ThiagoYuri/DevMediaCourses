using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsPortal.Models
{
    public class RepositoryNews
    {
        private static List<News> news;

        public static List<News> NewsP
        {
            get
            {
                if(news == null)                
                 CreateNews();

                 return news;
                
            }
        }

        private static void CreateNews()
        {
            news = new List<News>();
            news.Add(new News() 
            { Autor = "Thiago Yuri", Conteudo = "O mundo está morrendo por conta do aquecimento global Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard ", Date = DateTime.Now, Id = 1, Titulo = "Aquecimento Global" });
            news.Add(new News() 
            { Autor = "Thiago Yuri Oliveira", Conteudo = "Novo joga e lançado ao vivo Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard ", Date = DateTime.Now, Id = 2, Titulo = "Lnaçamento de jogo ao vivo" });
            news.Add(new News() 
            { Autor = "Thiago Yuri Oliveira ", Conteudo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged", Date = DateTime.Now, Id = 3, Titulo = "Lorem Ipsum" });
            news.Add(new News() 
            { Autor = "Thiago Yuri Rodrigues", Conteudo = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source.", Date = DateTime.Now, Id = 4, Titulo = "Aquecimento Global" });
            news.Add(new News() 
            { Autor = "Thiago Yuri Martins", Conteudo = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", Date = DateTime.Now, Id = 5, Titulo = "Where does it come from?" });
            news.Add(new News() 
            { Autor = "Victor Santos ", Conteudo = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.", Date = DateTime.Now, Id = 6, Titulo = "Where can I get some" });
        }
    }
}