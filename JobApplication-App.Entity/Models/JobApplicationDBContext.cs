using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobApplication_App.Entity.Models
{
    public partial class JobApplicationDBContext : DbContext
    {
        public JobApplicationDBContext()
        {
        }

        public JobApplicationDBContext(DbContextOptions<JobApplicationDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Confirmation> Confirmation { get; set; }
        public virtual DbSet<JobAdvert> JobAdvert { get; set; }
        public virtual DbSet<StateOfApplication> StateOfApplication { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-5A3KHTP;Database=JobApplicationDB;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.Cv).HasColumnName("CV");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HighSchool).HasMaxLength(50);

                entity.Property(e => e.University).HasMaxLength(50);

                entity.HasOne(d => d.JobAdvert)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.JobAdvertId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Application_JobAdvert");
            });

            modelBuilder.Entity<Confirmation>(entity =>
            {
                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Confirmation)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_Confirmation_Application");

                entity.HasOne(d => d.ApplicationState)
                    .WithMany(p => p.Confirmation)
                    .HasForeignKey(d => d.ApplicationStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Confirmation_StateOfApplication");
            });

            modelBuilder.Entity<JobAdvert>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StateOfApplication>(entity =>
            {
                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
