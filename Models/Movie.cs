using Humanizer.Localisation;

namespace TP4.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public Genre? Genre { get; set; }
		public int? GenreId { get; set; }
		public List<Customer>? Customers { get; set; }
		public Movie()
		{
		}
		public Movie(int id, string? name)
		{
			Id = id;
			Name = name;
		}
	}
}
