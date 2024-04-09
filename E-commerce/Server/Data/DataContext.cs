using E_commerce.shared;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Handheld PC",
                    Description = "A handheld personal computer (PC), typically built around either a clamshell form factor or a gaming form factor with a gamepad integrated for video games, is a mobile device that is significantly smaller than any standard personal computer (PC), but based on the same principles as PCs. The clamshell form factor is sometimes referred to as a palmtop computer, not to be confused with Palmtop PC which was a name used mainly by Hewlett-Packard.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.qXcocaHp2V8brplkQX9a0gHaE7?rs=1&pid=ImgDetMain",
                    Price = 77.5m
                },
                new Product
                {
                    Id = 2,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                    ImageUrl = "https://www.themoviedb.org/t/p/original/hmGMMcehDlTdiBEnq3fAc5QOkS1.jpg",
                    Price = 75.4m
                },
                new Product
                {
                    Id = 3,
                    Title = "Ready Player One (film)",
                    Description = "Ready Player One is a 2018 American science fiction action film based on Ernest Cline's novel of the same name. The film was co-produced and directed by Steven Spielberg, written by Cline and Zak Penn, and stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance.",
                    ImageUrl = "https://theculturednerd.org/wp-content/uploads/2020/04/1_Nzaxn52WDFE7BTois8ZQ7w-1382x2048.jpeg",
                    Price = 88.5m
                }
            );
        }
    }
}