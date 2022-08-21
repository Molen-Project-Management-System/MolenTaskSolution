using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MolenTaskSolution.Models
{
    public partial class molendbContext : DbContext
    {
        public molendbContext()
        {
        }

        public molendbContext(DbContextOptions<molendbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FileAttachment> FileAttachments { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=144.126.158.15,1433;Database=molendb; User ID=administrator; Password=Qwert1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileAttachment>(entity =>
            {
                entity.ToTable("File_Attachment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AttachmentType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileAttachment1).HasColumnName("FileAttachment");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TaskOwnerId).HasColumnName("TaskOwnerID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.FileAttachments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tasks_projects_ProjectID");

                entity.HasOne(d => d.TaskOwner)
                    .WithMany(p => p.FileAttachments)
                    .HasForeignKey(d => d.TaskOwnerId)
                    .HasConstraintName("FK_tasks_employess_TaskOwnerID");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProjectID");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectOwnerId).HasColumnName("ProjectOwnerID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProjectOwner)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProjectOwnerId)
                    .HasConstraintName("FK_projects_employees_ProjectOwner");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.TasksId)
                    .HasName("PK__Tasks__6DD78979AB1411EE");

                entity.Property(e => e.TasksId).ValueGeneratedNever();

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaskOwnerId).HasColumnName("TaskOwnerID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Project");

                entity.HasOne(d => d.TaskOwner)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.TaskOwnerId)
                    .HasConstraintName("FK_TaskOwner");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
