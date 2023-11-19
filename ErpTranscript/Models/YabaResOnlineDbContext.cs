using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ErpTranscript.Models.YabaResOnline;

namespace ErpTranscript.Models
{
    public partial class YabaResOnlineDbContext : DbContext
    {
        public YabaResOnlineDbContext()
        {
        }

        public YabaResOnlineDbContext(DbContextOptions<YabaResOnlineDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DelErpresultuser> DelErpresultusers { get; set; } = null!;
        public virtual DbSet<DeptTable2> DeptTable2s { get; set; } = null!;
        public virtual DbSet<Er4Downloadlog> Er4Downloadlogs { get; set; } = null!;
        public virtual DbSet<Er5view01> Er5view01s { get; set; } = null!;
        public virtual DbSet<Er5view02> Er5view02s { get; set; } = null!;
        public virtual DbSet<Er5view03> Er5view03s { get; set; } = null!;
        public virtual DbSet<Er5view04> Er5view04s { get; set; } = null!;
        public virtual DbSet<Er5view05> Er5view05s { get; set; } = null!;
        public virtual DbSet<Er5view06> Er5view06s { get; set; } = null!;
        public virtual DbSet<Er5view07> Er5view07s { get; set; } = null!;
        public virtual DbSet<Er5view11> Er5view11s { get; set; } = null!;
        public virtual DbSet<Er5view12> Er5view12s { get; set; } = null!;
        public virtual DbSet<Er5view13> Er5view13s { get; set; } = null!;
        public virtual DbSet<Er5view14> Er5view14s { get; set; } = null!;
        public virtual DbSet<Er5view15> Er5view15s { get; set; } = null!;
        public virtual DbSet<Er5view16> Er5view16s { get; set; } = null!;
        public virtual DbSet<Er5view17> Er5view17s { get; set; } = null!;
        public virtual DbSet<Er5view18> Er5view18s { get; set; } = null!;
        public virtual DbSet<Er5view21> Er5view21s { get; set; } = null!;
        public virtual DbSet<Er5view22> Er5view22s { get; set; } = null!;
        public virtual DbSet<Er5view23> Er5view23s { get; set; } = null!;
        public virtual DbSet<Er5view24> Er5view24s { get; set; } = null!;
        public virtual DbSet<Er5view25> Er5view25s { get; set; } = null!;
        public virtual DbSet<Er5view26> Er5view26s { get; set; } = null!;
        public virtual DbSet<Er5view27> Er5view27s { get; set; } = null!;
        public virtual DbSet<ErpAdv> ErpAdvs { get; set; } = null!;
        public virtual DbSet<ErpProgrammer> ErpProgrammers { get; set; } = null!;
        public virtual DbSet<ErpResultLog> ErpResultLogs { get; set; } = null!;
        public virtual DbSet<Erpresultuser> Erpresultusers { get; set; } = null!;
        public virtual DbSet<ExamProgrammeType> ExamProgrammeTypes { get; set; } = null!;
        public virtual DbSet<FlExamSemester> FlExamSemesters { get; set; } = null!;
        public virtual DbSet<FlExamSession> FlExamSessions { get; set; } = null!;
        public virtual DbSet<FtExamSemester> FtExamSemesters { get; set; } = null!;
        public virtual DbSet<FtExamSession> FtExamSessions { get; set; } = null!;
        public virtual DbSet<GradeTab> GradeTabs { get; set; } = null!;
        public virtual DbSet<Partflag> Partflags { get; set; } = null!;
        public virtual DbSet<PtExamSemester> PtExamSemesters { get; set; } = null!;
        public virtual DbSet<PtExamSession> PtExamSessions { get; set; } = null!;
        public virtual DbSet<PubReg> PubRegs { get; set; } = null!;
        public virtual DbSet<PubReg01> PubReg01s { get; set; } = null!;
        public virtual DbSet<PubReg02> PubReg02s { get; set; } = null!;
        public virtual DbSet<PubReg03> PubReg03s { get; set; } = null!;
        public virtual DbSet<PubReg04> PubReg04s { get; set; } = null!;
        public virtual DbSet<PubReg05> PubReg05s { get; set; } = null!;
        public virtual DbSet<PubReg06> PubReg06s { get; set; } = null!;
        public virtual DbSet<PubReg07> PubReg07s { get; set; } = null!;
        public virtual DbSet<PubReg11> PubReg11s { get; set; } = null!;
        public virtual DbSet<PubReg12> PubReg12s { get; set; } = null!;
        public virtual DbSet<PubReg13> PubReg13s { get; set; } = null!;
        public virtual DbSet<PubReg14> PubReg14s { get; set; } = null!;
        public virtual DbSet<PubReg15> PubReg15s { get; set; } = null!;
        public virtual DbSet<PubReg16> PubReg16s { get; set; } = null!;
        public virtual DbSet<PubReg17> PubReg17s { get; set; } = null!;
        public virtual DbSet<PubReg18> PubReg18s { get; set; } = null!;
        public virtual DbSet<PubReg21> PubReg21s { get; set; } = null!;
        public virtual DbSet<PubReg22> PubReg22s { get; set; } = null!;
        public virtual DbSet<PubReg24> PubReg24s { get; set; } = null!;
        public virtual DbSet<PubReg25> PubReg25s { get; set; } = null!;
        public virtual DbSet<PubReg26> PubReg26s { get; set; } = null!;
        public virtual DbSet<PubReg27> PubReg27s { get; set; } = null!;
        public virtual DbSet<Putme2021> Putme2021s { get; set; } = null!;
        public virtual DbSet<Putme2021ar> Putme2021ars { get; set; } = null!;
        public virtual DbSet<School> Schools { get; set; } = null!;
        public virtual DbSet<ServiceAuth> ServiceAuths { get; set; } = null!;
        public virtual DbSet<StegradeTab> StegradeTabs { get; set; } = null!;
        public virtual DbSet<Supre> Supres { get; set; } = null!;
        public virtual DbSet<Unflag> Unflags { get; set; } = null!;
        public virtual DbSet<Utmeflag> Utmeflags { get; set; } = null!;
        public virtual DbSet<UtmeflagApril> UtmeflagAprils { get; set; } = null!;
        public virtual DbSet<VwErpProgrammer> VwErpProgrammers { get; set; } = null!;
        public virtual DbSet<VwErpadv> VwErpadvs { get; set; } = null!;
        public virtual DbSet<VwErpresultuser> VwErpresultusers { get; set; } = null!;
        public virtual DbSet<VwErpresultusers1> VwErpresultusers1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=213.171.204.36;Initial Catalog=Yabaresonline;User ID=Josh_dbnew;Password=<password>");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DelErpresultuser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er4Downloadlog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view01>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view02>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view03>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view04>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view05>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view06>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view07>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view11>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view12>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view13>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view14>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view15>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view16>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view17>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view18>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view21>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view22>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view23>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view24>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view25>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view26>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Er5view27>(entity =>
            {
                entity.Property(e => e.Tid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ErpAdv>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ErpProgrammer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ErpResultLog>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_user_log");
            });

            modelBuilder.Entity<Erpresultuser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<FlExamSemester>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<FlExamSession>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<FtExamSemester>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<FtExamSession>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Partflag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PtExamSemester>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PtExamSession>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg01>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg02>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg03>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg04>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg05>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg06>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg07>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg11>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg12>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg13>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg14>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg15>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg16>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg17>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg18>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg21>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg22>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg24>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg25>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg26>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PubReg27>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Putme2021>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Putme2021ar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ServiceAuth>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Supre>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Utmeflag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UtmeflagApril>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwErpProgrammer>(entity =>
            {
                entity.ToView("vw_erpProgrammers");
            });

            modelBuilder.Entity<VwErpadv>(entity =>
            {
                entity.ToView("vw_erpadvs");
            });

            modelBuilder.Entity<VwErpresultuser>(entity =>
            {
                entity.ToView("vw_erpresultusers");
            });

            modelBuilder.Entity<VwErpresultusers1>(entity =>
            {
                entity.ToView("vw_erpresultusers1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
