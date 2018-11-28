using System.Collections.Generic;

namespace RecipieHub.Domain.Interfaces
{
    public interface IRecipieLibrary
    {
        List<Recipie> RetrieveRecipies();
    }
}