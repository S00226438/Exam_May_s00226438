using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_s00226438
{
    public class Movie : IComparable
    {
        public int MovieID { get; set; }
        public string Title { get; set; }

        public string ImageName { get; set; }
        public string Description { get; set; }
        public string Cast { get; set; }
        public Movie(string title)
        {
            Title = title;
        }

        public Movie() : this("unknown") { }
        public int CompareTo(object obj)
        {
            Movie other = obj as Movie;
            return this.Title.CompareTo(other.Title);
        }

    }
}
