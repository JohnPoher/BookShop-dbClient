//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShop_WinForms
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookShopEntities2 : DbContext
    {
        public BookShopEntities2()
            : base("name=BookShopEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BooksToGenres> BooksToGenres { get; set; }
        public virtual DbSet<Buyers> Buyers { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Promotions> Promotions { get; set; }
        public virtual DbSet<Publishing> Publishing { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
