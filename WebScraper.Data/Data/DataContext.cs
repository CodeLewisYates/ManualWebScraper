using Microsoft.EntityFrameworkCore;
using WebScraper.Data.Models;

namespace WebScraper.Data.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SearchEngine> SearchEngines { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }

        // On model creation, want to insert the needed search engine
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SearchEngine>().HasData(
                new SearchEngine
                {
                    Id = 1,
                    Name = "Google",
                    BaseUrl = "https://www.google.co.uk/",
                    SearchUrl = "search?num=100&q=",
                    Regex = "\"yuRUbf\\\"(.*?href.*?ved)"
                }
            );
        }
    }
}
