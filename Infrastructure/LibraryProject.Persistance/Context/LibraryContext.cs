using LibraryProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Persistance.Context
{
	public class LibraryContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-Q80IDIO; initial Catalog=LibraryProjectDb; integrated Security=true; TrustServerCertificate=true;");
		}

		public DbSet<About> Abouts { get; set; }

		public DbSet<Author> Authors { get; set; }

		public DbSet<Banner> Banners { get; set; }

		public DbSet<Blog> Blogs { get; set; }

		public DbSet<Book> Books { get; set; }

		public DbSet<BookPricing> BookPricings { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<FooterAddress> FooterAddresses { get; set; }

		public DbSet<Genre> Genres { get; set; }

		public DbSet<Location> Locations { get; set; }

		public DbSet<Service> Services { get; set; }

		public DbSet<SocialMedia> SocialMedias { get; set; }

		public DbSet<Testimonial> Testimonials { get; set; }

	}
}
