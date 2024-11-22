using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models {
    public class Category {
        [Key]
        public int Id { get; set; } // Primary Key on DB
        [Required]
        public string Name { get; set; } // This field will be set to not null option in SQL
        public int DisplayOrder { get; set; }
    }
}
