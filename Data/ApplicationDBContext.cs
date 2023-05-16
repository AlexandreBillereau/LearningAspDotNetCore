using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.Data;

public class ApplicationDBContext : DbContext
{
	public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option) : base(option)
	{
	}

	public DbSet<Category> categories { get; set; }
}

