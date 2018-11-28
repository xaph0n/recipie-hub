using System.Collections.Generic;
using RecipieHub.Domain;

namespace RecipieHub.Domain.Interfaces
{
    public interface IRecipieApplicationService
    {
        List<Recipie> RecipiesRetreive();
    }
}