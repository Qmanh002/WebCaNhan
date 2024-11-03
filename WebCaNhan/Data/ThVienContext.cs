using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebCaNhan.Data;

public partial class ThVienContext : DbContext
{
    public ThVienContext()
    {
    }

    public ThVienContext(DbContextOptions<ThVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ThanhVien> ThanhViens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ThanhVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ThanhVie__3214EC077CF3E371");

            entity.ToTable("ThanhVien");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HinhAnh).HasMaxLength(255);
            entity.Property(e => e.MaSinhVien).HasMaxLength(20);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
