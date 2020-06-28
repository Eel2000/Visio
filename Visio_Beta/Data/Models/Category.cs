using System.ComponentModel.DataAnnotations;

namespace Visio_Beta.Data.Models
{
    public class Category
    { 
        [Key]
        public int Id { get; set; }

        [Required]
        public string Designation { get; set; }
    }
}