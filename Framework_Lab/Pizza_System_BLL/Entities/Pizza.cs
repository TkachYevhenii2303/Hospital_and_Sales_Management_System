using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_System_BLL.Entities
{
    [Table("Pizza_table")]
    public class Pizza : Entity
    {
        [Required(ErrorMessage = "This item is required!")]
        [MaxLength(100, ErrorMessage = "The lenght must be less than 100 characters!")]
        public string Pizza_title { get; set; } = string.Empty;

        public virtual Sauce Sauce { get; set; } = null!;

        public virtual ICollection<Toppings> Toppings { get; set; } = null!;
    }
}
