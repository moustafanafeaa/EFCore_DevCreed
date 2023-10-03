using EFCore_DevCreed.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DevCreed
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-41U9JGO\SQLEXPRESS;Initial Catalog = EFCore_DevCreed;Integrated Security=True;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 10
            //*add table post without dbset<> or list<post> posts*//
            //modelBuilder.Entity<Post>();

            //*don't addtable post to database*//
            //modelBuilder.Ignore<Post>();

            //*ignore any update-migration in database*//
            //modelBuilder.Entity<Blog>()
            //    .ToTable("Blogs", b => b.ExcludeFromMigrations());
            #endregion
            #region 11


            //11
            //modelBuilder.Entity<Blog>()
            //    .ToTable("blogss");

            //13
            //modelBuilder.Entity<Post>()
            //    .Ignore(b => b.Content);

            //14
            //modelBuilder.Entity<Blog>()
            //    .Property(b => b.Url)
            //    .HasColumnName("urls");

            //15
            //modelBuilder.Entity<Blog>().
            //    Property(b => b.Price)
            //    .HasColumnType("decimal(20, 2)");

            //16
            //modelBuilder.Entity<Blog>()
            //    .Property(B => B.Url)
            //    .HasMaxLength(50);

            ////17
            //modelBuilder.Entity<Blog>().
            //    Property(b => b.Url).HasComment("hah");

            ////18
            //modelBuilder.Entity<Book>()
            //    .HasKey(b => b.booknumber)
            //    .HasName("bookid");

            //19 defult val
            //modelBuilder.Entity<Blog>().
            //    Property(b => b.Price).HasDefaultValue(40);


            ////22
            //modelBuilder.Entity<Author>()
            //    .Property(b => b.FullName)
            //    .HasComputedColumnSql("[FName] + ' ' + [LName]");

            ////23
            //modelBuilder.Entity<category>()
            //     .Property(c => c.Id)
            //     .ValueGeneratedOnAdd();


            #endregion
            #region relations

            //24*one to one*//
            //modelBuilder.Entity<Blog>()
            //    .HasOne(b => b.BlogImage)
            //    .WithOne(b => b.Blog)
            //    .HasForeignKey<BlogImage>(b => b.BlogKey);


            //25*one to many*//
            //modelBuilder.Entity<Post>()
            //    .HasOne<Blog>()
            //    .WithMany()
            //    .HasForeignKey(b => new { b.BLogkey, b.Descriptionkey })
            //    .HasPrincipalKey(b => new { b.Id, b.description });


            //*26 many-many*//
            //1//
            //modelBuilder.Entity<Post>()
            //    .HasMany<Tag>().WithMany()
            //   .UsingEntity(b => b.ToTable("PostsTagtest"));

            //2//
            //modelBuilder.Entity<Post>()
            //    .HasMany(b => b.Tags)
            //    .WithMany(b => b.posts)
            //    .UsingEntity<PostTag>(
            //    j => j.
            //    HasOne(j => j.Tag)
            //    .WithMany(p => p.postTags)
            //    .HasForeignKey(j => j.TagId),
            //    j => j
            //    .HasOne(j => j.post)
            //    .WithMany(j => j.PostTags)
            //    .HasForeignKey(j => j.PostId),
            //    j =>
            //    {
            //        j.HasKey(j => new { j.TagId, j.PostId });
            //    });
                


            #endregion
        }
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }
        //public DbSet<category> Categories { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Tag> tags { get; set; }
    }
}
