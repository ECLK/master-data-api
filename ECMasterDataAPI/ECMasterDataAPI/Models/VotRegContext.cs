using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ECMasterDataAPI.Models
{
    public partial class VotRegContext : DbContext
    {
        public VotRegContext()
        {
        }

        public VotRegContext(DbContextOptions<VotRegContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aedistrict> Aedistricts { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Dsd> Dsds { get; set; }
        public virtual DbSet<Gnd> Gnds { get; set; }
        public virtual DbSet<HouseHold> HouseHolds { get; set; }
        public virtual DbSet<Lga> Lgas { get; set; }
        public virtual DbSet<Lgatype> Lgatypes { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<PollingDistrict> PollingDistricts { get; set; }
        public virtual DbSet<PollingDivision> PollingDivisions { get; set; }
        public virtual DbSet<PollingStation> PollingStations { get; set; }
        public virtual DbSet<PostalArea> PostalAreas { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Revision> Revisions { get; set; }
        public virtual DbSet<VillageStreet> VillageStreets { get; set; }
        public virtual DbSet<Voter1> Voters1 { get; set; }

        // Unable to generate entity type for table 'dbo.PollingDivisionBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGAGND'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevDataUpdateAllowDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonBlackList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldPCWardPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldRevUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionWardSystem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterMR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldPCWardPDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterCRN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonBlackListDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldPCWardPDTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterMRDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictRevBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonBlackListUpdte'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldPDTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictSerializeRequest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterCRN_Del'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGAPDTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterCRN_Update'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictSerializeRequestBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictRevTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterXDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGA_WardPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationPDTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGA_WardPDBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VillageStreetRevTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterA+'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterEDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.XListReasons'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterA+Del'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EListReasons'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldLGAWardPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldLGAWardPDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GNDBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterB+'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGAPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterADel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionLATemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldVS_GND'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldVS_GNDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterB+Del'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldVS_GNDTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldVS_GNDBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionURTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterB+Update'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RelationCO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SerializeLogAB'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionSetup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Gender'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldExt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldExtTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterBUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationWardPDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VillageStreetBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CentralizedProcessing'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterDuplicateResolved'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BListReasons'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Voter18+'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserElectionDistrict'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserElectionDistrictAll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictPF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserElectionDistrictAllDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterB'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictGND'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterA+Update'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserElectionDistrictDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Voter18+Del'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictRev_Update'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictGNDDescription'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserHousehold'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Voter18+Update'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterDuplicateDes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictVS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserHouseholdAll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterRR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictVSDescription'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPDAllowPollingDistrict'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionHousehold'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterRRUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterOBDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGAPDBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPDAllowPollingDistrictAll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterEUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterOB'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictSerialize'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TaskAvailability'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPDAllowPollingDistrictAllDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictPFBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TaskAvailabilityBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPDAllowPollingDistrictDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPDVerifyPollingDistrict'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictSerializeBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPDVerifyPollingDistrictAll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictRev'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPDVerifyPollingDistrictAllDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPDVerifyPollingDistrictDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonDuplicate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PostalAreaUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDistrict'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDistrictAll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonPWD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDistrictAllDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProccessPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonPWDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGA_Update'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDistrictDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProccessPDUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonCRN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDivision'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictVSDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDivisionAll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDivisionAllDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PWD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DocTypes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDivisionDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterRRDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDivisionVerify'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ElectionDistrict'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserPollingDivisionVerifyDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevDistrictCaptureAllow'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterSDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevDistrictCaptureAllowDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QualifyingDOB'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterDuplicate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterV+'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GND_DSD_Rev'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDivission_LGA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GND_DSD_RevTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldExtDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldPDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GND_DSD_RevDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterDuplicateDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterV+Del'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._CMB2014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterV+Update'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterDuplicate_Upload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InvalidSLINNIC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserAdminDistrict'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserAdminDistrictDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterDuplicate_UploadDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGAGNDBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VillageStreetRev'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrictGNDBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegExt_DataRequest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GND_DSD_RevBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegExt_DataRequestUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationWardPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PC_Ward'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegExt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationWardPDTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AListReasons'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGA_Ward'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PC_WardBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGA_WardBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterRem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PC_WardDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationPDLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegExtUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegOfficer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationWardPDLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PC_WardPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PC_WardPDBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegExt_VfRequest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PC_WardPDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionCertify'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrict_9III_Update'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionFinalize'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDivission_LGA_Del'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionCertifyUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGA_WardPDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingDistrict_OldPDNum'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AdminDistrictBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGA_WardDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AdminDistrict'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegExtLastSeq'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionFinalizeBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoterBDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PersonTR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MGR_LGA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldLGAWardPDTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationPCWardPD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGADSD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DSDBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationPCWardPDDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionSchedule'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationPCWardPDLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldRev'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevisionScheduleBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PollingStationPCWardPDTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HouseHoldUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ElectionDistrictBack'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RevDataUpdateAllow'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Aedistrict>(entity =>
            {
                entity.HasKey(e => new { e.AdisId, e.EdisId })
                    .HasName("PK_AdminElectionDistrict");

                entity.ToTable("AEDistrict");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.EdisId).HasColumnName("EDisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasKey(e => e.Did);

                entity.ToTable("Designation");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.DesignationEn)
                    .HasColumnName("DesignationEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationSi)
                    .HasColumnName("DesignationSI")
                    .HasMaxLength(50);

                entity.Property(e => e.DesignationTa)
                    .HasColumnName("DesignationTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Publish)
                    .HasColumnName("publish")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sort).HasColumnName("sort");
            });

            modelBuilder.Entity<Dsd>(entity =>
            {
                entity.ToTable("DSD");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.HasIndex(e => e.Dsdcode)
                    .HasName("dsdcode");

                entity.Property(e => e.Dsdid).HasColumnName("DSDID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Dsdcode).HasColumnName("DSDCode");

                entity.Property(e => e.DsdnameEn)
                    .HasColumnName("DSDNameEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsdnameSi)
                    .HasColumnName("DSDNameSI")
                    .HasMaxLength(50);

                entity.Property(e => e.DsdnameTa)
                    .HasColumnName("DSDNameTA")
                    .HasMaxLength(50);

                entity.Property(e => e.LocCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LocCodeId).HasColumnName("LocCodeID");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Gnd>(entity =>
            {
                entity.ToTable("GND");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.HasIndex(e => e.Dsdid)
                    .HasName("dsdid");

                entity.HasIndex(e => e.Gndidold)
                    .HasName("gndidold");

                entity.HasIndex(e => e.Gndno)
                    .HasName("gndno");

                entity.Property(e => e.Gndid).HasColumnName("GNDID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Dsdid).HasColumnName("DSDID");

                entity.Property(e => e.Gndidold).HasColumnName("GNDIDOld");

                entity.Property(e => e.GndnameEn)
                    .HasColumnName("GNDNameEN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GndnameSi)
                    .HasColumnName("GNDNameSI")
                    .HasMaxLength(100);

                entity.Property(e => e.GndnameTa)
                    .HasColumnName("GNDNameTA")
                    .HasMaxLength(100);

                entity.Property(e => e.Gndno)
                    .HasColumnName("GNDNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LocCodeId).HasColumnName("LocCodeID");
            });

            modelBuilder.Entity<HouseHold>(entity =>
            {
                entity.HasKey(e => e.Hhid);

                entity.ToTable("HouseHold");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.HasIndex(e => e.Gndid)
                    .HasName("gndid");

                entity.HasIndex(e => e.HhnumberEn)
                    .HasName("HouseHoldHHNo");

                entity.HasIndex(e => e.HhnumberOld)
                    .HasName("hhnoold");

                entity.HasIndex(e => e.Lgaid)
                    .HasName("lgaid");

                entity.HasIndex(e => e.Paid)
                    .HasName("paid");

                entity.HasIndex(e => e.Vsid)
                    .HasName("vsid");

                entity.Property(e => e.Hhid).HasColumnName("HHID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Gndid).HasColumnName("GNDID");

                entity.Property(e => e.Hhinsid)
                    .HasColumnName("hhinsid")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HhnumberEn)
                    .HasColumnName("HHNumberEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HhnumberOld)
                    .HasColumnName("HHNumberOld")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HhnumberSi)
                    .HasColumnName("HHNumberSI")
                    .HasMaxLength(50);

                entity.Property(e => e.HhnumberTa)
                    .HasColumnName("HHNumberTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Lgaid).HasColumnName("LGAID");

                entity.Property(e => e.Paid).HasColumnName("PAID");

                entity.Property(e => e.Vsid).HasColumnName("VSID");
            });

            modelBuilder.Entity<Lga>(entity =>
            {
                entity.ToTable("LGA");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.HasIndex(e => e.LganameSi)
                    .HasName("namesi");

                entity.HasIndex(e => e.LganameTa)
                    .HasName("nameta");

                entity.Property(e => e.Lgaid).HasColumnName("LGAID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.LganameEn)
                    .HasColumnName("LGANameEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LganameSi)
                    .HasColumnName("LGANameSI")
                    .HasMaxLength(50);

                entity.Property(e => e.LganameTa)
                    .HasColumnName("LGANameTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Lganumber).HasColumnName("LGANumber");

                entity.Property(e => e.Lgatype).HasColumnName("LGAType");
            });

            modelBuilder.Entity<Lgatype>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("LGAType");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lgatype1)
                    .HasColumnName("LGAType")
                    .HasMaxLength(50);

                entity.Property(e => e.LgatypeEn)
                    .HasColumnName("LGATypeEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LgatypeSi)
                    .HasColumnName("LGATypeSI")
                    .HasMaxLength(50);

                entity.Property(e => e.LgatypeTa)
                    .HasColumnName("LGATypeTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PerId);

                entity.ToTable("Person");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.HasIndex(e => e.Nic)
                    .HasName("PersonNIC");

                entity.HasIndex(e => e.Nicold)
                    .HasName("nicold");

                entity.HasIndex(e => e.Slin)
                    .HasName("PersonSLIN");

                entity.Property(e => e.PerId).HasColumnName("PerID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.CommLanguage)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.FullNameEn)
                    .HasColumnName("FullNameEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameSi)
                    .HasColumnName("FullNameSI")
                    .HasMaxLength(250);

                entity.Property(e => e.FullNameTa)
                    .HasColumnName("FullNameTA")
                    .HasMaxLength(250);

                entity.Property(e => e.InsTag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nic)
                    .HasColumnName("NIC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nicold)
                    .HasColumnName("NICOld")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PerInsId)
                    .HasColumnName("PerInsID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Slin)
                    .HasColumnName("SLIN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Slinnictag)
                    .HasColumnName("SLINNICTag")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PollingDistrict>(entity =>
            {
                entity.HasKey(e => e.Pdid);

                entity.ToTable("PollingDistrict");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.HasIndex(e => e.PdivId)
                    .HasName("pdivid");

                entity.HasIndex(e => e.Pdnumber)
                    .HasName("pdno");

                entity.Property(e => e.Pdid).HasColumnName("PDID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Ext).HasDefaultValueSql("((1))");

                entity.Property(e => e.PdivId).HasColumnName("PDivID");

                entity.Property(e => e.Pdnumber).HasColumnName("PDNumber");
            });

            modelBuilder.Entity<PollingDivision>(entity =>
            {
                entity.HasKey(e => e.PdivId);

                entity.ToTable("PollingDivision");

                entity.Property(e => e.PdivId).HasColumnName("PDivID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.EdisId).HasColumnName("EDisID");

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdivCodeEn)
                    .HasColumnName("PDivCodeEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PdivCodeSi)
                    .HasColumnName("PDivCodeSI")
                    .HasMaxLength(20);

                entity.Property(e => e.PdivCodeTa)
                    .HasColumnName("PDivCodeTA")
                    .HasMaxLength(20);

                entity.Property(e => e.PdivEn)
                    .HasColumnName("PDivEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdivIdold).HasColumnName("PDivIDold");

                entity.Property(e => e.PdivSi)
                    .HasColumnName("PDivSI")
                    .HasMaxLength(50);

                entity.Property(e => e.PdivTa)
                    .HasColumnName("PDivTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PollingStation>(entity =>
            {
                entity.HasKey(e => e.Psid);

                entity.ToTable("PollingStation");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.Property(e => e.Psid).HasColumnName("PSID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PdivId).HasColumnName("PDivID");

                entity.Property(e => e.Psidold).HasColumnName("PSIDOld");

                entity.Property(e => e.PsnameEn)
                    .HasColumnName("PSNameEN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PsnameSi)
                    .HasColumnName("PSNameSI")
                    .HasMaxLength(200);

                entity.Property(e => e.PsnameTa)
                    .HasColumnName("PSNameTA")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PostalArea>(entity =>
            {
                entity.HasKey(e => e.Paid);

                entity.ToTable("PostalArea");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.Property(e => e.Paid).HasColumnName("PAID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.PanameEn)
                    .HasColumnName("PANameEN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PanameSi)
                    .HasColumnName("PANameSI")
                    .HasMaxLength(100);

                entity.Property(e => e.PanameTa)
                    .HasColumnName("PANameTA")
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.ProvId);

                entity.ToTable("Province");

                entity.Property(e => e.ProvId).HasColumnName("ProvID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceEn)
                    .HasColumnName("ProvinceEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceSi)
                    .HasColumnName("ProvinceSI")
                    .HasMaxLength(20);

                entity.Property(e => e.ProvinceTa)
                    .HasColumnName("ProvinceTA")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Revision>(entity =>
            {
                entity.HasKey(e => e.RevId);

                entity.ToTable("Revision");

                entity.Property(e => e.RevId).HasColumnName("RevID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Des)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionEn)
                    .HasColumnName("RevisionEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionSi)
                    .HasColumnName("RevisionSI")
                    .HasMaxLength(20);

                entity.Property(e => e.RevisionTa)
                    .HasColumnName("RevisionTA")
                    .HasMaxLength(20);

                entity.Property(e => e.Tag)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VillageStreet>(entity =>
            {
                entity.HasKey(e => e.Vsid);

                entity.ToTable("VillageStreet");

                entity.HasIndex(e => e.AdisId)
                    .HasName("adisid");

                entity.HasIndex(e => e.Gndid)
                    .HasName("gndid");

                entity.HasIndex(e => e.Vsidold)
                    .HasName("vsidold");

                entity.Property(e => e.Vsid).HasColumnName("VSID");

                entity.Property(e => e.AdisId).HasColumnName("ADisID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Gndid).HasColumnName("GNDID");

                entity.Property(e => e.Vsidold).HasColumnName("VSIDOld");

                entity.Property(e => e.VsnameEn)
                    .HasColumnName("VSNameEN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VsnameSi)
                    .HasColumnName("VSNameSI")
                    .HasMaxLength(100);

                entity.Property(e => e.VsnameTa)
                    .HasColumnName("VSNameTA")
                    .HasMaxLength(100);

                entity.Property(e => e.Vsono).HasColumnName("VSONO");
            });

            modelBuilder.Entity<Voter1>(entity =>
            {
                entity.HasKey(e => e.VoterId);

                entity.ToTable("Voter");

                entity.HasIndex(e => e.Adisid)
                    .HasName("adisid");

                entity.HasIndex(e => e.Hhid)
                    .HasName("hhid");

                entity.HasIndex(e => e.SerNo)
                    .HasName("serno");

                entity.Property(e => e.VoterId).HasColumnName("VoterID");

                entity.Property(e => e.Adisid).HasColumnName("adisid");

                entity.Property(e => e.Cm)
                    .HasColumnName("CM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.DateVerify).HasColumnType("datetime");

                entity.Property(e => e.Hhext).HasColumnName("HHExt");

                entity.Property(e => e.Hhid).HasColumnName("HHID");

                entity.Property(e => e.PerId).HasColumnName("PerID");

                entity.Property(e => e.PerInsId)
                    .HasColumnName("PerInsID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Revid).HasColumnName("revid");

                entity.Property(e => e.SerNoLg).HasColumnName("SerNoLG");

                entity.Property(e => e.SerNoPc).HasColumnName("SerNoPC");

                entity.Property(e => e.VerifyBy).HasDefaultValueSql("((0))");
            });
        }
    }
}
