using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Colour> Colours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Colour>().HasData(
                new Colour { ColourId = 1, ColourName = "Blue"},
                new Colour { ColourId = 2, ColourName = "Red"},
                new Colour { ColourId = 3, ColourName = "Green"},
                new Colour { ColourId = 4, ColourName = "Brown"},
                new Colour { ColourId = 5, ColourName = "Purple"},
                new Colour { ColourId = 6, ColourName = "Black"},
                new Colour { ColourId = 7, ColourName = "Turquiose"},
                new Colour { ColourId = 8, ColourName = "Orange"},
                new Colour { ColourId = 9, ColourName = "Yellow"},
                new Colour { ColourId = 10, ColourName = "Pink"},
                new Colour { ColourId = 11, ColourName = "Gray"},
                new Colour { ColourId = 12, ColourName = "Beige" },
                new Colour { ColourId = 13, ColourName = "Khaki" },
                new Colour { ColourId = 14, ColourName = "Ecru" },
                new Colour { ColourId = 15, ColourName = "Navy Blue" },
                new Colour { ColourId = 16, ColourName = "Indigo" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Tişört"},
                new Category { CategoryId = 2, CategoryName = "Şort"},
                new Category { CategoryId = 3, CategoryName = "Gömlek"},
                new Category { CategoryId = 4, CategoryName = "Eşofman"},
                new Category { CategoryId = 5, CategoryName = "Pantolon"},
                new Category { CategoryId = 6, CategoryName = "Ceket"},
                new Category { CategoryId = 7, CategoryName = "Jeans"},
                new Category { CategoryId = 8, CategoryName = "Yelek"},
                new Category { CategoryId = 9, CategoryName = "Kazak"},
                new Category { CategoryId = 10, CategoryName = "Mont"},
                new Category { CategoryId = 11, CategoryName = "Sweatshirt"},
                new Category { CategoryId = 12, CategoryName = "Takım Elbise"}
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Kısa Kollu Tişört",
                    Price = 99.9,
                    ColourId = 2,
                    Description = "Slim Fit Bisiklet Yaka Tişört",
                    CategoryId = 1,
                    ImagePath = "images/slimFit.jpg",
                    Supplier = "Defacto",
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Şort",
                    Price = 105.99,
                    ColourId = 15,
                    Description = "Regular fit Basketbolcu Şort",
                    CategoryId = 2,
                    ImagePath = "images/slimFit.jpg",
                    Supplier = "Mavi",

                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Oduncu Gömleği",
                    Price = 176.99,
                    ColourId = 6,
                    Description = "Oversize Ekoseli Oduncu Gömliği",
                    CategoryId = 3,
                    ImagePath = "images/oduncugomlek.jpg",
                    Supplier = "LCW",

                }
                );
        }
    }
}
