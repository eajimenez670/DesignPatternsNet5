using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASPNET.Models.ViewModels
{
    public class FormBeerViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Estilo")]
        public string Style { get; set; }
        [Display(Name = "Id de Marca")]
        public Guid? BrandId { get; set; }
        [Display(Name = "Otra Marca")]
        public string OtherBrand { get; set; }
    }
}
