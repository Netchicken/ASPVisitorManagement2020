using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPVisitorManagement2020.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    VisitorCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Business = table.Column<string>(nullable: true),
                    Datein = table.Column<DateTime>(nullable: false),
                    DateOut = table.Column<DateTime>(nullable: false),
                    StaffnameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitor_StaffNames_StaffnameId",
                        column: x => x.StaffnameId,
                        principalTable: "StaffNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visitor_StaffnameId",
                table: "Visitor",
                column: "StaffnameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "StaffNames");
        }
    }
}
