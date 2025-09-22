using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioBlazor.DTO.Models
{
    public class MotorcycleVideo
    {
        [Key]
        [DisplayName("Motorcycle Video ID")]
        public int Id { get; set; }
        [Required]
        public string VideoUrl { get; set; }
    }
}
