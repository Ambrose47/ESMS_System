using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ESMSBusinessObject.Model;

public partial class EsmsContext : DbContext
{
    public EsmsContext()
    {
    }

    public EsmsContext(DbContextOptions<EsmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<ExamSchedule> ExamSchedules { get; set; }

    public virtual DbSet<SlotExam> SlotExams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionStringDB"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_admin");

            entity.ToTable("admin");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("role");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ExamSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_exam");

            entity.ToTable("ExamSchedule");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("course");
            entity.Property(e => e.Lecturer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lecturer");
            entity.Property(e => e.Room)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("room");
            entity.Property(e => e.Slotid).HasColumnName("slotid");

            entity.HasOne(d => d.Slot).WithMany(p => p.ExamSchedules)
                .HasForeignKey(d => d.Slotid)
                .HasConstraintName("fk_exam");
        });

        modelBuilder.Entity<SlotExam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Slot_id");

            entity.ToTable("SlotExam");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Hour).HasColumnName("hour");
            entity.Property(e => e.Time)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("time");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
