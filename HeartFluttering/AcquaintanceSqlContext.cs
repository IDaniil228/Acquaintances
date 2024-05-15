using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HeartFluttering;

public partial class AcquaintanceSqlContext : DbContext
{
    public AcquaintanceSqlContext()
    {
    }

    public AcquaintanceSqlContext(DbContextOptions<AcquaintanceSqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<BlockerForm> BlockerForms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=../../../AcquaintanceSQL.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");
        });

        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.Property(e => e.Blocker)
                .HasColumnType("INTEGER (0, 1)")
                .HasColumnName("blocker");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Administrator)
                .HasForeignKey<Administrator>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<BlockerForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BlockerForm");

            entity.Property(e => e.BlockerLogin)
                .HasColumnType("INTEGER (0, 1)")
                .HasColumnName("blockerLogin");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Blocker)
                .HasColumnType("INTEGER (0, 1)")
                .HasColumnName("blocker");
            entity.Property(e => e.Sex).HasColumnType("INTEGER (0, 1)");
            entity.Property(e => e.Status).HasColumnType("INTEGER (0, 1)");
            entity.Property(e => e.Vk).HasColumnName("VK");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.User)
                .HasForeignKey<User>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
