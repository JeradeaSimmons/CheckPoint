using System;
using System.Collections.Generic;
using CheckPoint.Models;
using CheckPoint.Services;
using Microsoft.AspNetCore.Mvc;

namespace CheckPoint.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class RecipeController : ControllerBase
  {
    private readonly RecipeService _recipeService;

    public RecipeController(RecipeService recipeService)
    {
      _recipeService = recipeService;
    }

    [HttpGet]
    public ActionResult<List<RecipeController>> GetAll()
    {
      try
      {
        List<Recipe> recipe = _recipeService.GetAll();
        return Ok(recipe);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
       

