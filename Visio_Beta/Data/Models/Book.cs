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

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public string Pages { get; set; }

        [Required]
        public string Edition { get; set; }

        [Required]
        public byte Content { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
