using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ErpTranscript.Models.Transcript;

namespace ErpTranscript.Models
{
    public partial class TranscriptDbContext : DbContext
    {
        public TranscriptDbContext()
        {
        }

        public TranscriptDbContext(DbContextOptions<TranscriptDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Domainx> Domainxes { get; set; } = null!;
        public virtual DbSet<TranscriptActivity> TranscriptActivities { get; set; } = null!;
        public virtual DbSet<TranscriptDest> TranscriptDests { get; set; } = null!;
        public virtual DbSet<TranscriptDownload> TranscriptDownloads { get; set; } = null!;
        public virtual DbSet<TranscriptOrder> TranscriptOrders { get; set; } = null!;
        public virtual DbSet<TranscriptRequest> TranscriptRequests { get; set; } = null!;
        public virtual DbSet<TranscriptStatus> TranscriptStatuses { get; set; } = null!;
        public virtual DbSet<TranscriptUpload> TranscriptUploads { get; set; } = null!;
        public virtual DbSet<Transcriptid> Transcriptids { get; set; } = null!;
        public virtual DbSet<VwTranscriptOrder> VwTranscriptOrders { get; set; } = null!;
        public virtual DbSet<VwTranscriptRequest> VwTranscriptRequests { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=213.171.204.36;Initial Catalog=Transcript;Persist Security Info=True;MultipleActiveResultSets=true;User ID=Josh_dbnew;Password=<password>");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domainx>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TranscriptActivity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TranscriptDest>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TranscriptDownload>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TranscriptOrder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TranscriptStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTranscriptOrder>(entity =>
            {
                entity.ToView("vw_Transcript_order");

                entity.Property(e => e.Program).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SchoolName).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwTranscriptRequest>(entity =>
            {
                entity.ToView("vw_Transcript_Request");

                entity.Property(e => e.Appnum).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Firstname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Program).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Surname).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
