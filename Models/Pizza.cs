using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization; 

namespace pizza_mama.Models
{
    public class Pizza
    {
        [JsonIgnore] // pour ignorer l'attribut PizzaID dans le l'importation Json 
        public int PizzaID { get; set; }
        [Display(Name = "Nom")]
        public string nom { get; set; }
        [Display(Name = "Prix (€)")]
        public float prix { get; set; }

        [Display(Name = "Végétarienne")]
        public bool vegetarienne { get; set; }
        [JsonIgnore]
        [Display(Name = "Ingrédients")]
        public string ingredients { get; set; }


        [System.ComponentModel.DataAnnotations.Schema.NotMapped] // dis a Entity d'ignorer la propriete listesIngredients dans la base de donnée
        [JsonPropertyName("ingredients")]
        public string[] listesIngredients
        {
            get
            {
                if((ingredients==null)||(ingredients.Count()==0))
                {
                    return null; 
                }
                return ingredients.Split(", ");
            }
           
        }
    }
}
