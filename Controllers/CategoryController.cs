using BulkyBook.Data;
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
    var objCategoryList = _db.categories.ToList();
    return View();
  }
}
