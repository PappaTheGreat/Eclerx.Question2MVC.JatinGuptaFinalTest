/*using Eclerx.Question2MVC.JatinGupta.Models;
using Eclerx.Question2MVC.JatinGupta.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Eclerx.Question2MVC.JatinGupta.Controllers
{
    public class BookSearchController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;
        // GET: BookSearch
        public BookSearchController()
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
        public ActionResult Index()
        {
            BookSearchVM BSearch = new BookSearchVM();
            var Genre = PupulateBooksInDropDown();
            BSearch.Genre = Genre;
            return View(BSearch);
        }
    }
}*/