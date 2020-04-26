using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryManagementSystem
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BorrowerDetails> BorrowerDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(SecureData.FetchDBString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorrowerDetails>(entity =>
            {
                entity.HasKey(e => e.IssueId)
                    .HasName("PK__Borrower__B29F2BD8AE38F198");

                entity.ToTable("Borrower_Details");

                entity.Property(e => e.IssueId).HasColumnName("Issue_ID");

                entity.Property(e => e.BookName)
                    .HasColumnName("Book_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BorrowedFromDate)
                    .HasColumnName("Borrowed_From_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BorrowedToDate)
                    .HasColumnName("Borrowed_To_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IssuedBy)
                    .HasColumnName("Issued_by")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
