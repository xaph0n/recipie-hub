namespace RecipieHub.Domain
{
    public class Ingredient
    {
        public string Name {get; set; }
        public string Description { get; set; }

        public Ingredient (string name, string description)
        {
            Name = name;
            Description = description;        
        }
    }
}
