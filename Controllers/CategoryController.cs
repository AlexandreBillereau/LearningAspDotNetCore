using BulkyBook.Data;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BulkyBook.Controllers;
public class CategoryController : Controller
{
  private readonly ApplicationDBContext _db;

  public CategoryController(ApplicationDBContext db)
  {
    _db = db;
  }

  public IActionResult Index()
  {
    IEnumerable<Category> objCategoryList = _db.categories;
    return View(objCategoryList);
  }
}
