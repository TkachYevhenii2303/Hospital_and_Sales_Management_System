using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pizza_System_BLL.Entities
{
    [Table("Topping_table")]
    public class Toppings : Entity
    {
        [Required(ErrorMessage = "This item is required!")]
        [MaxLength(100, ErrorMessage = "The lenght must be less than 100 characters!")]
        public string Toppings_table { get; set; } = string.Empty;

        public decimal Calories { get; set; } = 0.0M;

        [JsonIgnore]
        public virtual ICollection<Pizza> Pizzas { get; set; } = null!;
    }
}
