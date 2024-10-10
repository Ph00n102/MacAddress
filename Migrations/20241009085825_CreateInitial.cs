using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MacAddress.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "macaddresses",
                columns: table => new
                {
                    MacAddId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MacAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceProgram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramInAgency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HosXp = table.Column<bool>(type: "bit", nullable: false),
                    KPHIS = table.Column<bool>(type: "bit", nullable: false),
                    Lab = table.Column<bool>(type: "bit", nullable: false),
                    Parcel = table.Column<bool>(type: "bit", nullable: false),
                    InternalProgram = table.Column<bool>(type: "bit", nullable: false),
                    PACS = table.Column<bool>(type: "bit", nullable: false),
                    Authen = table.Column<bool>(type: "bit", nullable: false),
                    Finance = table.Column<bool>(type: "bit", nullable: false),
                    SoftwareDev = table.Column<bool>(type: "bit", nullable: false),
                    Google = table.Column<bool>(type: "bit", nullable: false),
                    MicrosoftOffice = table.Column<bool>(type: "bit", nullable: false),
                    Facebook = table.Column<bool>(type: "bit", nullable: false),
                    Youtube = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_macaddresses", x => x.MacAddId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "macaddresses");
        }
    }
}
