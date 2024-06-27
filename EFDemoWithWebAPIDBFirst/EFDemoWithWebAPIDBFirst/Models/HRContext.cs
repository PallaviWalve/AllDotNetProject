using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFDemoWithWebAPIDBFirst.Models
{
    public partial class HRContext : DbContext
    {
        public HRContext()
        {
        }

        public HRContext(DbContextOptions<HRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dept> Depts { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;\nDatabase=HR;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Deptno)
                    .HasName("PK__Dept__0149C6864EB41AC8");

                entity.ToTable("Dept");

                entity.Property(e => e.Dname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loc)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PK__Emp__AF226A2BF416433E");

                entity.ToTable("Emp");

                entity.Property(e => e.Empname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sal).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.DeptnoNavigation)
                    .WithMany(p => p.Emps)
                    .HasForeignKey(d => d.Deptno)
                    .HasConstraintName("FK__Emp__Deptno__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
