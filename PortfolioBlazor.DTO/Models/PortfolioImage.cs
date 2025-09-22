using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioBlazor.DTO.Models
{
    public class PortfolioImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DisplayText { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
