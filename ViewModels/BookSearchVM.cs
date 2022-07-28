using Eclerx.Question2MVC.JatinGupta.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eclerx.Question2MVC.JatinGupta.ViewModels
{
    public class BookSearchVM
    {
        public IEnumerable<SelectListItem> Genre { get; set; }
        public IEnumerable<Books> BookGenre { get; set; }
    }
}