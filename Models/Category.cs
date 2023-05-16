using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models;

public class Category
{
  [Key]
  public int ID { get; set; }
  public string Name { get; set; }
  public int DisaplayOrder { get; set; }
  public DateTime createDateTime { get; set; } = DateTime.Now;
  

 }

