// <auto-generated />
using Hospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hospital.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("Patient Id");

                    b.Property<bool>("Admitted")
                        .HasColumnType("bit");

                    b.Property<string>("Allergies")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("HealthHistory")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Patient Name");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("Staff Id");

                    b.Property<string>("Staffs")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("PatientId");

                    b.HasIndex(new[] { "PatientId" }, "IX_Patients");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Hospital.Models.staff", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("Staff Id");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmploymentStatues")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Phone Number");

                    b.Property<string>("StaffAddress")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Staff Address");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Staff Name");

                    b.HasKey("StaffId");

                    b.ToTable("Staff", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
