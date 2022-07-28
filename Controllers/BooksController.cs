using Eclerx.Question2MVC.JatinGupta.Models;
using Eclerx.Question2MVC.JatinGupta.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Eclerx.Question2MVC.JatinGupta.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;
        public BooksController()
        {
            _dbContext = new ApplicationDbContext();
        }
        private IEnumerable<SelectListItem> PupulateBooksInDropDown()
        {
            return _dbContext.Bookss.Select(c => new SelectListItem
            {
                Value = c.AuthorName,
                Text = c.AuthorName,
            }).AsEnumerable();
        }
        public ActionResult SearchIndexView()
        {
            BookSearchVM BSearch = new BookSearchVM();
            var Genre = PupulateBooksInDropDown();
            BSearch.Genre = Genre;
            return View(BSearch);
        }
        public ActionResult GetBooks(string GenreName)
        {
            BookSearchVM BookbyGenre = new BookSearchVM();
            var products = _dbContext.Bookss.Where(p => p.Genre == GenreName);

            var Genres = PupulateBooksInDropDown();
            BookbyGenre.Genre = Genres;
            return View("SearchIndexView", BookbyGenre);
        }
        // GET: Booksch
        public ActionResult Index()
        {
            return View();
        }
    }
}