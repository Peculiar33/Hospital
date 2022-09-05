using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(name: "Patient Id", type: "int", nullable: false),
                    PatientName = table.Column<string>(name: "Patient Name", type: "varchar(max)", unicode: false, nullable: false),
                    Admitted = table.Column<bool>(type: "bit", nullable: false),
                    Allergies = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    HealthHistory = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    StaffId = table.Column<int>(name: "Staff Id", type: "int", nullable: false),
                    Staffs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(name: "Staff Id", type: "int", nullable: false),
                    StaffName = table.Column<string>(name: "Staff Name", type: "varchar(max)", unicode: false, nullable: false),
                    StaffAddress = table.Column<string>(name: "Staff Address", type: "varchar(max)", unicode: false, nullable: false),
                    Department = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Designation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(name: "Phone Number", type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    EmploymentStatues = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients",
                table: "Patients",
                column: "Patient Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
