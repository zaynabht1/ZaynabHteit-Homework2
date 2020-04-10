using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZaynabHteit_Homework2.Models;

namespace ZaynabHteit_Homework2.ViewModels
{
    public class RandomMovieViewModel
    {
      //  internal List<Movies> Movieslist;

        public Movie Movie { get; set; } 

        public List<Customer> Customers { get; set; }

        public List<Movies> Movieslist { get; set; }


    }
}