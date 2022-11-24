using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment.Data.Migrations.Student
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityOfResidence = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[,]
                {
                    { 1, "Nairobi", "jimpotter@gmail.com", "Jim", "Potter", "072-345-6789", "Computer Science" },
                    { 2, "Nairobi", "janedouglas@gmail.com", "Jane", "Douglas", "072-345-6789", "Computer Science" },
                    { 3, "Nairobi", "tomgardner@gmail.com", "Tom", "Gardner", "072-345-6789", "Computer Science" },
                    { 4, "Nairobi", "annlee@gmail.com", "Ann", "Lee", "072-345-6789", "Computer Science" },
                    { 5, "Nairobi", "", "James", "Jones", "072-345-6789", "Computer Science" },
                    { 6, "Nairobi", "susantaylor@gmail.com", "Susan", "Taylor", "072-345-6789", "Computer Science" },
                    { 7, "Nairobi", "peterwhite@gmail.com", "Peter", "White", "072-345-6789", "Computer Science" },
                    { 8, "Nairobi", "philpfox@gmail.com", "Philip", "Fox", "072-345-6789", "Computer Science" },
                    { 9, "Nairobi", "donnaray@gmail.com", "Donna", "Ray", "072-345-6789", "Computer Science" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
