using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PortfolioBlazor.DTO.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Id")]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        [DefaultValue("")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Display Order must be between 1-100.")]
        public int DisplayOrder { get; set; }
    }
}
