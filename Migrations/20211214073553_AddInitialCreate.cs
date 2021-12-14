using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Software_Engineering_Assingment.Migrations
{
    public partial class AddInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElementHeader",
                columns: table => new
                {
                    ElementHeaderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementHeader", x => x.ElementHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SiteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SiteId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ElementSection",
                columns: table => new
                {
                    ElementSectionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ElementHeaderId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementSection", x => x.ElementSectionId);
                    table.ForeignKey(
                        name: "FK_ElementSection_ElementHeader_ElementHeaderId",
                        column: x => x.ElementHeaderId,
                        principalTable: "ElementHeader",
                        principalColumn: "ElementHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SiteId = table.Column<int>(type: "INTEGER", nullable: false),
                    WorkArea = table.Column<string>(type: "TEXT", nullable: false),
                    Supervisor = table.Column<string>(type: "TEXT", nullable: false),
                    JobDescription = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    InspectorId = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdditionalComments = table.Column<string>(type: "TEXT", nullable: true),
                    IsHighRiskActivity = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Report_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Report_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    ElementId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ElementHeaderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ElementSectionId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false),
                    Interventions = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<string>(type: "TEXT", nullable: true),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Element", x => x.ElementId);
                    table.ForeignKey(
                        name: "FK_Element_ElementHeader_ElementHeaderId",
                        column: x => x.ElementHeaderId,
                        principalTable: "ElementHeader",
                        principalColumn: "ElementHeaderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Element_ElementSection_ElementSectionId",
                        column: x => x.ElementSectionId,
                        principalTable: "ElementSection",
                        principalColumn: "ElementSectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Element_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Element_ElementHeaderId",
                table: "Element",
                column: "ElementHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Element_ElementSectionId",
                table: "Element",
                column: "ElementSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Element_ReportId",
                table: "Element",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementSection_ElementHeaderId",
                table: "ElementSection",
                column: "ElementHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_SiteId",
                table: "Report",
                column: "SiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Report_UserId",
                table: "Report",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.DropTable(
                name: "ElementSection");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "ElementHeader");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
