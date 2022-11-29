using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backendprojects.Models;

public partial class NewsapiContext : DbContext
{
    public NewsapiContext()
    {
    }

    public NewsapiContext(DbContextOptions<NewsapiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Liveapi> Liveapis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASTBPOLWFH004\\SQLEXPRESS;Initial Catalog=newsapi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Liveapi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__liveapi__3213E83FFBF4F6EC");

            entity.ToTable("liveapi");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.Descriptions)
                .IsUnicode(false)
                .HasColumnName("descriptions");
            entity.Property(e => e.Newsimage).HasColumnName("newsimage");
            entity.Property(e => e.Newsname).IsUnicode(false);
            entity.Property(e => e.Newstopics).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
