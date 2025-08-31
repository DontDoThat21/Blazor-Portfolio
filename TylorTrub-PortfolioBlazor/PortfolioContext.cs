using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TylorTrubPortfolioBlazor.UI;

public partial class PortfolioContext : DbContext
{
    public PortfolioContext()
    {
    }

    public PortfolioContext(DbContextOptions<PortfolioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Motorcycle> Motorcycles { get; set; }

    public virtual DbSet<MotorcycleVideo> MotorcycleVideos { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderHeader> OrderHeaders { get; set; }

    public virtual DbSet<PortfolioImage> PortfolioImages { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TY;Database=Portfolio;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.CompanyId, "IX_AspNetUsers_CompanyId");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Discriminator)
                .HasMaxLength(21)
                .HasDefaultValue("");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Company).WithMany(p => p.AspNetUsers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasIndex(e => e.OrderHeaderId, "IX_OrderDetails_OrderHeaderId");

            entity.HasIndex(e => e.ProductId, "IX_OrderDetails_ProductId");

            entity.HasOne(d => d.OrderHeader).WithMany(p => p.OrderDetails).HasForeignKey(d => d.OrderHeaderId);

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<OrderHeader>(entity =>
        {
            entity.HasIndex(e => e.ApplicationUserId, "IX_OrderHeaders_ApplicationUserId");

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.OrderHeaders).HasForeignKey(d => d.ApplicationUserId);
        });

        modelBuilder.Entity<PortfolioImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PortfolioImageVideos");

            entity.Property(e => e.DisplayText).HasDefaultValue("");
            entity.Property(e => e.FileName).HasDefaultValue("");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

            entity.Property(e => e.Isbn).HasColumnName("ISBN");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasIndex(e => e.ProductId, "IX_ProductImages_ProductId");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductImages).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.Property(e => e.Language).HasDefaultValue("");
        });

        modelBuilder.Entity<ShoppingCart>(entity =>
        {
            entity.HasIndex(e => e.ApplicationUserId, "IX_ShoppingCarts_ApplicationUserId");

            entity.HasIndex(e => e.ProductId, "IX_ShoppingCarts_ProductId");

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.ShoppingCarts).HasForeignKey(d => d.ApplicationUserId);

            entity.HasOne(d => d.Product).WithMany(p => p.ShoppingCarts).HasForeignKey(d => d.ProductId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
