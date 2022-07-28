using System;
using System.ComponentModel.DataAnnotations;
namespace Eclerx.Question2MVC.JatinGupta.Models
{
    public class Books
    {
        [Display(Name = "Books")]
        public int Id { get; set; }

        [Required(ErrorMessage = "ISBN cannot be empty")]
        public string ISBN { get; set; }

        [Required]
        public string BookName { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string AuthorName { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.Date)]
        public DateTime? PublishedDate { get; set; }
    }
}