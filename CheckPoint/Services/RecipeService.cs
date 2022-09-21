using System.Collections.Generic;
using CheckPoint.Models;

namespace CheckPoint.Services
{
  public class RecipeService
  {
    private object _recipeRepo;

    internal List<Recipe> GetAll()
    {
     
    return _recipeRepo.GetAll();
    }
  }
}