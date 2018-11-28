using System;
using System.Collections.Generic;
using RecipieHub.DataAccess.Context;
using RecipieHub.Domain;
using RecipieHub.Domain.Interfaces;

namespace RecipieHub.Services
{
    public class RecipieApplicationService : IRecipieApplicationService
    {
        private RecipieDbContext _context;

        public RecipieApplicationService(RecipieDbContext context)
        {
            _context = context;
        }

        public List<Recipie> RecipiesRetreive()
        {
            var recipies = new List<Recipie>();
            var models = _context.Recipies;

            foreach (var m in models)
            {
                var r = new Recipie(m.Id, m.Title, m.Description);
                foreach (var i in m.Ingredients)
                    r.Ingredients.Add(new Ingredient(i.Name, i.Description));
                
                recipies.Add(r);
            }

            return recipies;
        }
    }
}
