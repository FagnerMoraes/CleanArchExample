using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchExample.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [Display(Name = "Name of Product")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The description is Required")]
        [MinLength(5)]
        [MaxLength(300)]
        [Display(Name = "Description of Product")]
        public string Description { get; set; }

        
        
        [Range(1, 9999.99 )]
        [Display(Name = "Price of Product")]
        public decimal Price { get; set; }
    }
}