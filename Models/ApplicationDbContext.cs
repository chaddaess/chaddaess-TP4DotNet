using Microsoft.EntityFrameworkCore;

namespace TP4.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder model)
		{
			base.OnModelCreating(model);
			string GenreJSon = System.IO.File.ReadAllText("Data/Genres.Json");
			List<Genre>? genres = System.Text.Json.
			JsonSerializer.Deserialize<List<Genre>>(GenreJSon);
			//Seed to categorie
			foreach (Genre c in genres)
				model.Entity<Genre>()
				.HasData(c);

		}
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<MembershipType> MembershipTypes { get; set; }

	}
}
