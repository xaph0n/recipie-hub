using System.Collections.Generic;

namespace RecipieHub.Domain
{
    public class Recipie
    {
        public int Id { get; set; }
        public string Title {get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Recipie (int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            Ingredients = new List<Ingredient>();
        }
    }
}
