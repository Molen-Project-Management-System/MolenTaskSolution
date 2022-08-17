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
        public virtual DbSet<ProjectUser> ProjectUsers { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-8U6PSPCB;Database=molendb;Trusted_Connection=True;");
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

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.FileAttachments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ProjectID");
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
                    .HasConstraintName("FK_ProjectOwner");
            });

            modelBuilder.Entity<ProjectUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Project___1788CC4CC6FC975C");

                entity.ToTable("Project_Users");

                entity.Property(e => e.UserId).ValueGeneratedNever();

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

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.TasksId)
                    .HasName("PK__Tasks__6DD7897932583E2F");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
