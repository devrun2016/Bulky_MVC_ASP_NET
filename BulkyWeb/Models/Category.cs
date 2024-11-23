using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models {
    public class Category {
        [Key]
        public int Id { get; set; } // Primary Key on DB
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; } // This field will be set to not null option in SQL
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Please enter the number between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
