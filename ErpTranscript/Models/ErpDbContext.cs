using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ErpTranscript.Models.Erp;

namespace ErpTranscript.Models
{
    public partial class ErpDbContext : DbContext
    {
        public ErpDbContext()
        {
        }

        public ErpDbContext(DbContextOptions<ErpDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<ActivityLocation> ActivityLocations { get; set; } = null!;
        public virtual DbSet<Cerr> Cerrs { get; set; } = null!;
        public virtual DbSet<CosMaterial> CosMaterials { get; set; } = null!;
        public virtual DbSet<Dean> Deans { get; set; } = null!;
        public virtual DbSet<ErpLog> ErpLogs { get; set; } = null!;
        public virtual DbSet<GroupActivity> GroupActivities { get; set; } = null!;
        public virtual DbSet<GroupActivityName> GroupActivityNames { get; set; } = null!;
        public virtual DbSet<Hod> Hods { get; set; } = null!;
        public virtual DbSet<Icon> Icons { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<SchoolOff> SchoolOffs { get; set; } = null!;
        public virtual DbSet<ServiceAuth> ServiceAuths { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserPreviledge> UserPreviledges { get; set; } = null!;
        public virtual DbSet<Users2> Users2s { get; set; } = null!;
        public virtual DbSet<Users3> Users3s { get; set; } = null!;
        public virtual DbSet<VwActivity> VwActivities { get; set; } = null!;
        public virtual DbSet<VwGroupActivity> VwGroupActivities { get; set; } = null!;
        public virtual DbSet<VwUserPreviledge> VwUserPreviledges { get; set; } = null!;
        public virtual DbSet<VwUsersIdenty> VwUsersIdenties { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=213.171.204.36;Initial Catalog=erp;Persist Security Info=True;User ID=Josh_dbnew;Password=<password>");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.Menuid)
                    .HasConstraintName("FK_Activities_Menus");
            });

            modelBuilder.Entity<ActivityLocation>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityLocations)
                    .HasForeignKey(d => d.Activityid)
                    .HasConstraintName("FK_ActivityLocation_Activities");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.ActivityLocations)
                    .HasForeignKey(d => d.CreatedByid)
                    .HasConstraintName("FK_ActivityLocation_Users");
            });

            modelBuilder.Entity<Cerr>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CosMaterial>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Dean>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ErpLog>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_user_log");
            });

            modelBuilder.Entity<GroupActivity>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupActivities)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_GroupActivities_GroupActivityName");
            });

            modelBuilder.Entity<GroupActivityName>(entity =>
            {
                entity.Property(e => e.Status).IsFixedLength();
            });

            modelBuilder.Entity<Hod>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SchoolOff>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UserPreviledge>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.UserPreviledges)
                    .HasForeignKey(d => d.Activityid)
                    .HasConstraintName("FK_UserPreviledges_Activities");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPreviledges)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_UserPreviledges_Users");
            });

            modelBuilder.Entity<Users2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwActivity>(entity =>
            {
                entity.ToView("vw_Activities");
            });

            modelBuilder.Entity<VwGroupActivity>(entity =>
            {
                entity.ToView("vw_GroupActivities");

                entity.Property(e => e.Status).IsFixedLength();
            });

            modelBuilder.Entity<VwUserPreviledge>(entity =>
            {
                entity.ToView("vw_userPreviledges");
            });

            modelBuilder.Entity<VwUsersIdenty>(entity =>
            {
                entity.ToView("vw_users_identy");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
