using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFirst;

public partial class DatabasefirstContext : DbContext
{
    public DatabasefirstContext()
    {
    }

    public DatabasefirstContext(DbContextOptions<DatabasefirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Email> emails { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=databasefirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__emails__3213E83FA60DA448");

            entity.ToTable("emails");

            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FkPessoa).HasColumnName("fk_pessoa");

            entity.HasOne(d => d.FkPessoaNavigation).WithMany(p => p.emails)
                .HasForeignKey(d => d.FkPessoa)
                .HasConstraintName("FK__emails__fk_pesso__398D8EEE");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__pessoas__3213E83F541F5DE0");

            entity.ToTable("pessoas");

            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
