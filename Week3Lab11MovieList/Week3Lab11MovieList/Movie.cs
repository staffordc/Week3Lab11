using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab11MovieList
{
    class Movie
    {
        private string Category { get; set; }
        private string Title { get; set; }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string GetTitle()
        {
            return Title;
        }
        public string GetCategory()
        {
            return Category;
        }
    }
}
