using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pittig.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ge moet iets invullen hé")]
        [Display(Name="Geef de naam van de categorie:")]
        public string Name { get; set; }
    }
}
