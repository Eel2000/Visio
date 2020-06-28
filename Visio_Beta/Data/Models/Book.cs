using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Visio_Beta.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Year { get; set; }

        public string Pages { get; set; }

        public string Edition { get; set; }

        public byte Content { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
