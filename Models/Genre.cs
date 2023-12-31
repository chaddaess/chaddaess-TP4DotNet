﻿namespace TP4.Models
{
	public class Genre
	{
		public int Id { get; set; }
		public string? GenreName { get; set; }
		public List<Movie>? Movies { get; set; }
		public Genre() { }
		public Genre(string name)
		{
			GenreName = name;
		}
	}
}
