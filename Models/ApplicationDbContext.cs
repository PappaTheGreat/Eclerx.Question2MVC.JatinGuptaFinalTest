using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Eclerx.Question2MVC.JatinGupta.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("EclerxConn")
        {

        }

        public DbSet<Books> Bookss { get; set; }
        
    }
}