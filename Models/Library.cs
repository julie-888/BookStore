using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Library
    {
        public int Id { get; set; }
        public List<Book> Books { get; set; }
    }
}
