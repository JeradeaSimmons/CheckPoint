using System.Collections.Generic;
using System.Data;
using System.Linq;
using CheckPoint.Models;
using Dapper;

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
      string sql = @"
      r.*
      a.*
      FROM recipe r
      JOIN accounts a ON a.id = r.creatorId;
      ";
      return _db.Query<Recipe, Account, Recipe>(sql, (Recipe, account) =>
      {
        return Recipe;
      }).ToList();
      }
  }
}