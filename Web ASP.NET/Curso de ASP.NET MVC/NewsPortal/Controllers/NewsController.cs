using NewsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View(RepositoryNews.NewsP);
        }


        //get details 

        public ActionResult Details(int id)
        {
            var news = RepositoryNews.NewsP.FirstOrDefault(x => x.Id == id);
            return View(news);
        }

        public ActionResult Search(string texto)
        {
            var news = RepositoryNews.NewsP.Where(n => n.Titulo.Contains(texto) || n.Conteudo.Contains(texto));
            return View(news);
        }


    }
}