
using System.Collections.Generic;

namespace RecipieHub.DataAccess.Models
{
    public class RecipieModel
    {
        public int Id { get; set; }
        public string Title {get; set;}
        public string Description {get; set;}
        public List<IngredientModel> Ingredients { get; set; }
    }
}