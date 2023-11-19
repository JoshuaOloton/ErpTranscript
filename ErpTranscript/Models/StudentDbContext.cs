using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ErpTranscript.Models.Student;

namespace ErpTranscript.Models
{
    public partial class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {
        }

        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AClass> AClasses { get; set; } = null!;
        public virtual DbSet<ASession> ASessions { get; set; } = null!;
        public virtual DbSet<ASessionSetup> ASessionSetups { get; set; } = null!;
        public virtual DbSet<AccessLevel> AccessLevels { get; set; } = null!;
        public virtual DbSet<AccessLevelErp> AccessLevelErps { get; set; } = null!;
        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<Adminz> Adminzs { get; set; } = null!;
        public virtual DbSet<AdvApprovalLog> AdvApprovalLogs { get; set; } = null!;
        public virtual DbSet<ApplicantSession> ApplicantSessions { get; set; } = null!;
        public virtual DbSet<AvailableLevel> AvailableLevels { get; set; } = null!;
        public virtual DbSet<CbtError> CbtErrors { get; set; } = null!;
        public virtual DbSet<CbtSubject> CbtSubjects { get; set; } = null!;
        public virtual DbSet<CbtSubjectsptsec> CbtSubjectsptsecs { get; set; } = null!;
        public virtual DbSet<Cbtsub2> Cbtsub2s { get; set; } = null!;
        public virtual DbSet<Cbtsubft> Cbtsubfts { get; set; } = null!;
        public virtual DbSet<Complain> Complains { get; set; } = null!;
        public virtual DbSet<Complainstbl> Complainstbls { get; set; } = null!;
        public virtual DbSet<ComplianAdmin> ComplianAdmins { get; set; } = null!;
        public virtual DbSet<ComplianStatus> ComplianStatuses { get; set; } = null!;
        public virtual DbSet<CosBase> CosBases { get; set; } = null!;
        public virtual DbSet<Cosheadsync> Cosheadsyncs { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Course1> Courses1 { get; set; } = null!;
        public virtual DbSet<CourseBack> CourseBacks { get; set; } = null!;
        public virtual DbSet<CourseMaxUnitSetup> CourseMaxUnitSetups { get; set; } = null!;
        public virtual DbSet<Courses1> Courses1s { get; set; } = null!;
        public virtual DbSet<Courses2> Courses2s { get; set; } = null!;
        public virtual DbSet<CoursesSubmit> CoursesSubmits { get; set; } = null!;
        public virtual DbSet<Coursesar> Coursesars { get; set; } = null!;
        public virtual DbSet<Coursestemp> Coursestemps { get; set; } = null!;
        public virtual DbSet<Cvdumpsent> Cvdumpsents { get; set; } = null!;
        public virtual DbSet<Deferment> Deferments { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<EbportalProgmap> EbportalProgmaps { get; set; } = null!;
        public virtual DbSet<Endownment> Endownments { get; set; } = null!;
        public virtual DbSet<Errors1> Errors1s { get; set; } = null!;
        public virtual DbSet<Exempt> Exempts { get; set; } = null!;
        public virtual DbSet<Exemption> Exemptions { get; set; } = null!;
        public virtual DbSet<Extrafee> Extrafees { get; set; } = null!;
        public virtual DbSet<FeePaymentTable> FeePaymentTables { get; set; } = null!;
        public virtual DbSet<Fraud> Frauds { get; set; } = null!;
        public virtual DbSet<Fullprogramme> Fullprogrammes { get; set; } = null!;
        public virtual DbSet<Grad> Grads { get; set; } = null!;
        public virtual DbSet<Grad2> Grad2s { get; set; } = null!;
        public virtual DbSet<GradRequirement> GradRequirements { get; set; } = null!;
        public virtual DbSet<GradeLevel> GradeLevels { get; set; } = null!;
        public virtual DbSet<Gradsummary> Gradsummaries { get; set; } = null!;
        public virtual DbSet<Identy> Identies { get; set; } = null!;
        public virtual DbSet<InactivePortal> InactivePortals { get; set; } = null!;
        public virtual DbSet<Issue> Issues { get; set; } = null!;
        public virtual DbSet<Latereg> Lateregs { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<LevelTbl> LevelTbls { get; set; } = null!;
        public virtual DbSet<Lockhistory> Lockhistories { get; set; } = null!;
        public virtual DbSet<Logz> Logzs { get; set; } = null!;
        public virtual DbSet<LstPassport> LstPassports { get; set; } = null!;
        public virtual DbSet<Matric> Matrics { get; set; } = null!;
        public virtual DbSet<Mechathronic> Mechathronics { get; set; } = null!;
        public virtual DbSet<MessageNotification> MessageNotifications { get; set; } = null!;
        public virtual DbSet<MissingIdTbl> MissingIdTbls { get; set; } = null!;
        public virtual DbSet<MobileNotification> MobileNotifications { get; set; } = null!;
        public virtual DbSet<MopUpRegistedStudent> MopUpRegistedStudents { get; set; } = null!;
        public virtual DbSet<Mopup> Mopups { get; set; } = null!;
        public virtual DbSet<Mopup1> Mopup1s { get; set; } = null!;
        public virtual DbSet<Mopup2> Mopup2s { get; set; } = null!;
        public virtual DbSet<Newdept> Newdepts { get; set; } = null!;
        public virtual DbSet<News> News { get; set; } = null!;
        public virtual DbSet<Newtwoseating> Newtwoseatings { get; set; } = null!;
        public virtual DbSet<Nextlevel> Nextlevels { get; set; } = null!;
        public virtual DbSet<Olevelissue> Olevelissues { get; set; } = null!;
        public virtual DbSet<OptionSplit> OptionSplits { get; set; } = null!;
        public virtual DbSet<OptionTable> OptionTables { get; set; } = null!;
        public virtual DbSet<OtherPayment> OtherPayments { get; set; } = null!;
        public virtual DbSet<Otp> Otps { get; set; } = null!;
        public virtual DbSet<Paidmatric> Paidmatrics { get; set; } = null!;
        public virtual DbSet<Passportret> Passportrets { get; set; } = null!;
        public virtual DbSet<PayLevel> PayLevels { get; set; } = null!;
        public virtual DbSet<Payitem> Payitems { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PaymentIdSetup> PaymentIdSetups { get; set; } = null!;
        public virtual DbSet<Paytype> Paytypes { get; set; } = null!;
        public virtual DbSet<Penalty> Penalties { get; set; } = null!;
        public virtual DbSet<PersonalPayment> PersonalPayments { get; set; } = null!;
        public virtual DbSet<Population> Populations { get; set; } = null!;
        public virtual DbSet<PrintedIdCard> PrintedIdCards { get; set; } = null!;
        public virtual DbSet<ProcessOrder> ProcessOrders { get; set; } = null!;
        public virtual DbSet<Progmediate> Progmediates { get; set; } = null!;
        public virtual DbSet<ProgramType2> ProgramType2s { get; set; } = null!;
        public virtual DbSet<Programme> Programmes { get; set; } = null!;
        public virtual DbSet<ProgrammeType> ProgrammeTypes { get; set; } = null!;
        public virtual DbSet<Programmecopy> Programmecopies { get; set; } = null!;
        public virtual DbSet<Promote> Promotes { get; set; } = null!;
        public virtual DbSet<Promote2> Promote2s { get; set; } = null!;
        public virtual DbSet<RegAnalysis> RegAnalyses { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<Registration2> Registration2s { get; set; } = null!;
        public virtual DbSet<RegistrationCopy> RegistrationCopies { get; set; } = null!;
        public virtual DbSet<RegistrationCopy1> RegistrationCopy1s { get; set; } = null!;
        public virtual DbSet<RegistrationDel> RegistrationDels { get; set; } = null!;
        public virtual DbSet<RegistrationDisplay> RegistrationDisplays { get; set; } = null!;
        public virtual DbSet<RegistrationDisplay2> RegistrationDisplay2s { get; set; } = null!;
        public virtual DbSet<RegistrationDisplayCopy> RegistrationDisplayCopies { get; set; } = null!;
        public virtual DbSet<RegistrationDisplayDel> RegistrationDisplayDels { get; set; } = null!;
        public virtual DbSet<RegistrationDisplayKeep> RegistrationDisplayKeeps { get; set; } = null!;
        public virtual DbSet<RegistrationDisplayar> RegistrationDisplayars { get; set; } = null!;
        public virtual DbSet<RegistrationDisplayha> RegistrationDisplayhas { get; set; } = null!;
        public virtual DbSet<RegistrationExemption> RegistrationExemptions { get; set; } = null!;
        public virtual DbSet<RegistrationExemptionCopy> RegistrationExemptionCopies { get; set; } = null!;
        public virtual DbSet<RegistrationKeep> RegistrationKeeps { get; set; } = null!;
        public virtual DbSet<RegistrationLock> RegistrationLocks { get; set; } = null!;
        public virtual DbSet<RegistrationLocktemp> RegistrationLocktemps { get; set; } = null!;
        public virtual DbSet<Registrationar> Registrationars { get; set; } = null!;
        public virtual DbSet<Registrationha> Registrationhas { get; set; } = null!;
        public virtual DbSet<Rejpassport> Rejpassports { get; set; } = null!;
        public virtual DbSet<Resortar> Resortars { get; set; } = null!;
        public virtual DbSet<School> Schools { get; set; } = null!;
        public virtual DbSet<SchoolFeesTransaction> SchoolFeesTransactions { get; set; } = null!;
        public virtual DbSet<SchoolOff> SchoolOffs { get; set; } = null!;
        public virtual DbSet<Schoolfee> Schoolfees { get; set; } = null!;
        public virtual DbSet<Schoolfeebalance> Schoolfeebalances { get; set; } = null!;
        public virtual DbSet<Semester> Semesters { get; set; } = null!;
        public virtual DbSet<Semid> Semids { get; set; } = null!;
        public virtual DbSet<Separate> Separates { get; set; } = null!;
        public virtual DbSet<Set> Sets { get; set; } = null!;
        public virtual DbSet<SetupPaymentSchoolFee> SetupPaymentSchoolFees { get; set; } = null!;
        public virtual DbSet<Stetemp> Stetemps { get; set; } = null!;
        public virtual DbSet<StudentNotification> StudentNotifications { get; set; } = null!;
        public virtual DbSet<StudentPassport> StudentPassports { get; set; } = null!;
        public virtual DbSet<StudentRecord> StudentRecords { get; set; } = null!;
        public virtual DbSet<StudentRecordBackUp> StudentRecordBackUps { get; set; } = null!;
        public virtual DbSet<StudentRecordCopy> StudentRecordCopies { get; set; } = null!;
        public virtual DbSet<StudentRecordCopy1> StudentRecordCopy1s { get; set; } = null!;
        public virtual DbSet<StudentRecordTemp> StudentRecordTemps { get; set; } = null!;
        public virtual DbSet<SummaryTable> SummaryTables { get; set; } = null!;
        public virtual DbSet<SummaryTable11> SummaryTable11s { get; set; } = null!;
        public virtual DbSet<SummaryTable2> SummaryTable2s { get; set; } = null!;
        public virtual DbSet<SummaryTable21> SummaryTable21s { get; set; } = null!;
        public virtual DbSet<SummaryTable2Copy> SummaryTable2Copies { get; set; } = null!;
        public virtual DbSet<SummaryTable2b> SummaryTable2bs { get; set; } = null!;
        public virtual DbSet<SummaryTable2ha> SummaryTable2has { get; set; } = null!;
        public virtual DbSet<SummaryTable3> SummaryTable3s { get; set; } = null!;
        public virtual DbSet<Tempcose> Tempcoses { get; set; } = null!;
        public virtual DbSet<Tempsex> Tempsexes { get; set; } = null!;
        public virtual DbSet<Tempsex2> Tempsex2s { get; set; } = null!;
        public virtual DbSet<UnnRec> UnnRecs { get; set; } = null!;
        public virtual DbSet<UserSession> UserSessions { get; set; } = null!;
        public virtual DbSet<VwAvailableLevel> VwAvailableLevels { get; set; } = null!;
        public virtual DbSet<VwComplain> VwComplains { get; set; } = null!;
        public virtual DbSet<VwCourse> VwCourses { get; set; } = null!;
        public virtual DbSet<VwCourses2> VwCourses2s { get; set; } = null!;
        public virtual DbSet<VwGradRequirement> VwGradRequirements { get; set; } = null!;
        public virtual DbSet<VwOptionSplit> VwOptionSplits { get; set; } = null!;
        public virtual DbSet<VwPrintedIdCard> VwPrintedIdCards { get; set; } = null!;
        public virtual DbSet<VwPrintedIdCard1> VwPrintedIdCard1s { get; set; } = null!;
        public virtual DbSet<VwProgramme> VwProgrammes { get; set; } = null!;
        public virtual DbSet<VwProgrammeType> VwProgrammeTypes { get; set; } = null!;
        public virtual DbSet<VwRegistration> VwRegistrations { get; set; } = null!;
        public virtual DbSet<VwRegistrationDel> VwRegistrationDels { get; set; } = null!;
        public virtual DbSet<VwRegistrationDisplay> VwRegistrationDisplays { get; set; } = null!;
        public virtual DbSet<VwResort> VwResorts { get; set; } = null!;
        public virtual DbSet<VwStudentProgramDepartment> VwStudentProgramDepartments { get; set; } = null!;
        public virtual DbSet<VwStudentRecord1> VwStudentRecord1s { get; set; } = null!;
        public virtual DbSet<YellowCase> YellowCases { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=213.171.204.36;Initial Catalog=student;Persist Security Info=True;User ID=Josh_dbnew;Password=<password>");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ASession>(entity =>
            {
                entity.Property(e => e.CurrentFtsession).HasComment("");

                entity.Property(e => e.CurrentPtsession).HasComment("");
            });

            modelBuilder.Entity<AccessLevel>(entity =>
            {
                entity.Property(e => e.Active).HasComment("");
            });

            modelBuilder.Entity<Adminz>(entity =>
            {
                entity.Property(e => e.Updateid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AvailableLevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Complain>(entity =>
            {
                entity.Property(e => e.Sn).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Complainstbl>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK_complainstbl");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Complainstbls)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_complainstbl_Complian_Status");
            });

            modelBuilder.Entity<ComplianAdmin>(entity =>
            {
                entity.HasOne(d => d.Programm)
                    .WithMany(p => p.ComplianAdmins)
                    .HasForeignKey(d => d.ProgrammId)
                    .HasConstraintName("FK_complian_admin_programme");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.ComplianAdmins)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_complian_admin_school");
            });

            modelBuilder.Entity<Cosheadsync>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CourseBack>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Courses2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CoursesSubmit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Coursesar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).ValueGeneratedNever();
            });

            modelBuilder.Entity<EbportalProgmap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Extrafee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Fraud>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GradRequirement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GradeLevel>(entity =>
            {
                entity.Property(e => e.GradelevelId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Identy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InactivePortal>(entity =>
            {
                entity.Property(e => e.InactiveId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Matric>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MessageNotification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MobileNotification>(entity =>
            {
                entity.Property(e => e.NewsId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MopUpRegistedStudent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Mopup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Mopup1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Mopup2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Nextlevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OptionSplit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OptionTable>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Otp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PayLevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PrintedIdCard>(entity =>
            {
                entity.Property(e => e.Sn).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Programme>(entity =>
            {
                entity.Property(e => e.ProgrammeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProgrammeType>(entity =>
            {
                entity.Property(e => e.ProgrammeTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Promote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Promote2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegAnalysis>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegistrationDisplay>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasComment("This is actually pointing at programme ID");
            });

            modelBuilder.Entity<RegistrationDisplayDel>(entity =>
            {
                entity.HasKey(e => e.RegistrationDisplayId)
                    .HasName("PK__registra__B87E18944C8A7E8E");
            });

            modelBuilder.Entity<RegistrationDisplayKeep>(entity =>
            {
                entity.Property(e => e.RegistrationDisplayId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegistrationDisplayar>(entity =>
            {
                entity.Property(e => e.RegistrationDisplayarId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegistrationDisplayha>(entity =>
            {
                entity.HasKey(e => e.RegistrationDisplayIdha)
                    .HasName("PK__registra__5D761476487D9A57");
            });

            modelBuilder.Entity<RegistrationExemption>(entity =>
            {
                entity.Property(e => e.ExemptionId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegistrationExemptionCopy>(entity =>
            {
                entity.Property(e => e.ExemptionId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegistrationKeep>(entity =>
            {
                entity.Property(e => e.RegistrationId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegistrationLock>(entity =>
            {
                entity.Property(e => e.DocketStatus).HasComment("");

                entity.Property(e => e.RegLockId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Registrationar>(entity =>
            {
                entity.Property(e => e.RegistrationarId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Registrationha>(entity =>
            {
                entity.HasKey(e => e.RegistrationIdha)
                    .HasName("PK__registra__D970A38EFC2D0987");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.Property(e => e.SchoolId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SchoolOff>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Schoolfeebalance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.Property(e => e.SemesterId).ValueGeneratedNever();

                entity.Property(e => e.CurrentFtsemester).HasComment("");

                entity.Property(e => e.CurrentPtsemester).HasComment("");
            });

            modelBuilder.Entity<Semid>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StudentNotification>(entity =>
            {
                entity.Property(e => e.DatePublished).IsFixedLength();

                entity.Property(e => e.NotificationId).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).IsFixedLength();
            });

            modelBuilder.Entity<StudentPassport>(entity =>
            {
                entity.Property(e => e.StudentPassportId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StudentRecord>(entity =>
            {
                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Failout).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();

                entity.Property(e => e.WithdrawalCertificate).IsFixedLength();
            });

            modelBuilder.Entity<StudentRecordBackUp>(entity =>
            {
                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Failout).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();

                entity.Property(e => e.WithdrawalCertificate).IsFixedLength();
            });

            modelBuilder.Entity<StudentRecordCopy>(entity =>
            {
                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Failout).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();

                entity.Property(e => e.WithdrawalCertificate).IsFixedLength();
            });

            modelBuilder.Entity<StudentRecordCopy1>(entity =>
            {
                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Failout).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();

                entity.Property(e => e.WithdrawalCertificate).IsFixedLength();
            });

            modelBuilder.Entity<SummaryTable2>(entity =>
            {
                entity.Property(e => e.SummaryId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UserSession>(entity =>
            {
                entity.Property(e => e.TimeOfLastLogin)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<VwAvailableLevel>(entity =>
            {
                entity.ToView("vw_available_levels");
            });

            modelBuilder.Entity<VwComplain>(entity =>
            {
                entity.ToView("vw_complains");
            });

            modelBuilder.Entity<VwCourse>(entity =>
            {
                entity.ToView("vw_courses");
            });

            modelBuilder.Entity<VwCourses2>(entity =>
            {
                entity.ToView("vw_courses2");
            });

            modelBuilder.Entity<VwGradRequirement>(entity =>
            {
                entity.ToView("vw_GradRequirement");

                entity.Property(e => e.PcAcronym).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Program).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Ptacronym).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwOptionSplit>(entity =>
            {
                entity.ToView("vw_OptionSplit");
            });

            modelBuilder.Entity<VwPrintedIdCard>(entity =>
            {
                entity.ToView("vw_printedIdCard");

                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Failout).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();

                entity.Property(e => e.WithdrawalCertificate).IsFixedLength();
            });

            modelBuilder.Entity<VwPrintedIdCard1>(entity =>
            {
                entity.ToView("Vw_printedIdCard1");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EntrySession).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Firstname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Othername).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Pnname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Program).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SchoolName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Sex).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Surname).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwProgramme>(entity =>
            {
                entity.ToView("vw_programme");
            });

            modelBuilder.Entity<VwProgrammeType>(entity =>
            {
                entity.ToView("vw_programme_type");
            });

            modelBuilder.Entity<VwRegistration>(entity =>
            {
                entity.ToView("vw_registration");
            });

            modelBuilder.Entity<VwRegistrationDel>(entity =>
            {
                entity.ToView("vw_registration_del");
            });

            modelBuilder.Entity<VwRegistrationDisplay>(entity =>
            {
                entity.ToView("vw_registration_display");
            });

            modelBuilder.Entity<VwResort>(entity =>
            {
                entity.ToView("vw_resort");
            });

            modelBuilder.Entity<VwStudentProgramDepartment>(entity =>
            {
                entity.ToView("vw_studentProgramDepartment");

                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Failout).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();

                entity.Property(e => e.WithdrawalCertificate).IsFixedLength();
            });

            modelBuilder.Entity<VwStudentRecord1>(entity =>
            {
                entity.ToView("vw_student_record_1");

                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Failout).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();

                entity.Property(e => e.WithdrawalCertificate).IsFixedLength();
            });

            modelBuilder.Entity<YellowCase>(entity =>
            {
                entity.HasComment("This table was set up in respect of issue with CODE NAME: 'YELLO CASE / YELLOW FILE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
