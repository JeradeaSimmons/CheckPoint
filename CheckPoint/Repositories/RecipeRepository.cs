using System.Collections.Generic;
using System.Data;
using CheckPoint.Models;

namespace CheckPoint.Repositories
{
  public class RecipeRepository
    {
        private readonly IDbConnection _db;

        public RecipeRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Recipe> GetAll()
        {
    }
  }
}