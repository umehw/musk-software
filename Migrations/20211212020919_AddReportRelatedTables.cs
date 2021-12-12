using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Software_Engineering_Assingment.Migrations
{
    public partial class AddReportRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    InspectorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                name: "AwarenessFireExits",
                columns: table => new
                {
                    AwarenessFireExitsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwarenessFireExits", x => x.AwarenessFireExitsId);
                    table.ForeignKey(
                        name: "FK_AwarenessFireExits_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificationDailyChecksheets",
                columns: table => new
                {
                    CertificationDailyChecksheetsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationDailyChecksheets", x => x.CertificationDailyChecksheetsId);
                    table.ForeignKey(
                        name: "FK_CertificationDailyChecksheets_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificationTrainingInsurance",
                columns: table => new
                {
                    CertificationTrainingInsuranceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationTrainingInsurance", x => x.CertificationTrainingInsuranceId);
                    table.ForeignKey(
                        name: "FK_CertificationTrainingInsurance_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConfinedSpaceWork",
                columns: table => new
                {
                    ConfinedSpaceWorkId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfinedSpaceWork", x => x.ConfinedSpaceWorkId);
                    table.ForeignKey(
                        name: "FK_ConfinedSpaceWork_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COSHH",
                columns: table => new
                {
                    COSHHId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COSHH", x => x.COSHHId);
                    table.ForeignKey(
                        name: "FK_COSHH_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalWork",
                columns: table => new
                {
                    ElectricalWorkId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalWork", x => x.ElectricalWorkId);
                    table.ForeignKey(
                        name: "FK_ElectricalWork_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireExits",
                columns: table => new
                {
                    FireExitsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireExits", x => x.FireExitsId);
                    table.ForeignKey(
                        name: "FK_FireExits_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotWork",
                columns: table => new
                {
                    HotWorkId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotWork", x => x.HotWorkId);
                    table.ForeignKey(
                        name: "FK_HotWork_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Isolation",
                columns: table => new
                {
                    IsolationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isolation", x => x.IsolationId);
                    table.ForeignKey(
                        name: "FK_Isolation_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiftingOperations",
                columns: table => new
                {
                    LiftingOperationsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiftingOperations", x => x.LiftingOperationsId);
                    table.ForeignKey(
                        name: "FK_LiftingOperations_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManualHandling",
                columns: table => new
                {
                    ManualHandlingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualHandling", x => x.ManualHandlingId);
                    table.ForeignKey(
                        name: "FK_ManualHandling_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherContractors",
                columns: table => new
                {
                    OtherContractorsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherContractors", x => x.OtherContractorsId);
                    table.ForeignKey(
                        name: "FK_OtherContractors_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paperwork",
                columns: table => new
                {
                    PaperworkId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paperwork", x => x.PaperworkId);
                    table.ForeignKey(
                        name: "FK_Paperwork_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PowerTools",
                columns: table => new
                {
                    PowerToolsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerTools", x => x.PowerToolsId);
                    table.ForeignKey(
                        name: "FK_PowerTools_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PPE",
                columns: table => new
                {
                    PPEId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PPE", x => x.PPEId);
                    table.ForeignKey(
                        name: "FK_PPE_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductContamination",
                columns: table => new
                {
                    ProductContaminationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductContamination", x => x.ProductContaminationId);
                    table.ForeignKey(
                        name: "FK_ProductContamination_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteSetUpAppearance",
                columns: table => new
                {
                    SiteSetUpAppearanceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSetUpAppearance", x => x.SiteSetUpAppearanceId);
                    table.ForeignKey(
                        name: "FK_SiteSetUpAppearance_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToolsUsedFitForPurpose",
                columns: table => new
                {
                    ToolsUsedFitForPurposeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolsUsedFitForPurpose", x => x.ToolsUsedFitForPurposeId);
                    table.ForeignKey(
                        name: "FK_ToolsUsedFitForPurpose_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCondition",
                columns: table => new
                {
                    VehicleConditionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCondition", x => x.VehicleConditionId);
                    table.ForeignKey(
                        name: "FK_VehicleCondition_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleLogSheetUpToDate",
                columns: table => new
                {
                    VehicleLogSheetUpToDateId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleLogSheetUpToDate", x => x.VehicleLogSheetUpToDateId);
                    table.ForeignKey(
                        name: "FK_VehicleLogSheetUpToDate_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleServiceRecords",
                columns: table => new
                {
                    VehicleServiceRecordsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleServiceRecords", x => x.VehicleServiceRecordsId);
                    table.ForeignKey(
                        name: "FK_VehicleServiceRecords_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoltageDetectorChecked",
                columns: table => new
                {
                    VoltageDetectorCheckedId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoltageDetectorChecked", x => x.VoltageDetectorCheckedId);
                    table.ForeignKey(
                        name: "FK_VoltageDetectorChecked_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteManagement",
                columns: table => new
                {
                    WasteManagementId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteManagement", x => x.WasteManagementId);
                    table.ForeignKey(
                        name: "FK_WasteManagement_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkAtHeight",
                columns: table => new
                {
                    WorkAtHeightsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interventions = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActionTaken = table.Column<string>(type: "TEXT", nullable: true),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkAtHeight", x => x.WorkAtHeightsId);
                    table.ForeignKey(
                        name: "FK_WorkAtHeight_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AwarenessFireExits_ReportId",
                table: "AwarenessFireExits",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CertificationDailyChecksheets_ReportId",
                table: "CertificationDailyChecksheets",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CertificationTrainingInsurance_ReportId",
                table: "CertificationTrainingInsurance",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConfinedSpaceWork_ReportId",
                table: "ConfinedSpaceWork",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_COSHH_ReportId",
                table: "COSHH",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalWork_ReportId",
                table: "ElectricalWork",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FireExits_ReportId",
                table: "FireExits",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotWork_ReportId",
                table: "HotWork",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Isolation_ReportId",
                table: "Isolation",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LiftingOperations_ReportId",
                table: "LiftingOperations",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ManualHandling_ReportId",
                table: "ManualHandling",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherContractors_ReportId",
                table: "OtherContractors",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paperwork_ReportId",
                table: "Paperwork",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PowerTools_ReportId",
                table: "PowerTools",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PPE_ReportId",
                table: "PPE",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductContamination_ReportId",
                table: "ProductContamination",
                column: "ReportId",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_SiteSetUpAppearance_ReportId",
                table: "SiteSetUpAppearance",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToolsUsedFitForPurpose_ReportId",
                table: "ToolsUsedFitForPurpose",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleCondition_ReportId",
                table: "VehicleCondition",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLogSheetUpToDate_ReportId",
                table: "VehicleLogSheetUpToDate",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleServiceRecords_ReportId",
                table: "VehicleServiceRecords",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoltageDetectorChecked_ReportId",
                table: "VoltageDetectorChecked",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagement_ReportId",
                table: "WasteManagement",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkAtHeight_ReportId",
                table: "WorkAtHeight",
                column: "ReportId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AwarenessFireExits");

            migrationBuilder.DropTable(
                name: "CertificationDailyChecksheets");

            migrationBuilder.DropTable(
                name: "CertificationTrainingInsurance");

            migrationBuilder.DropTable(
                name: "ConfinedSpaceWork");

            migrationBuilder.DropTable(
                name: "COSHH");

            migrationBuilder.DropTable(
                name: "ElectricalWork");

            migrationBuilder.DropTable(
                name: "FireExits");

            migrationBuilder.DropTable(
                name: "HotWork");

            migrationBuilder.DropTable(
                name: "Isolation");

            migrationBuilder.DropTable(
                name: "LiftingOperations");

            migrationBuilder.DropTable(
                name: "ManualHandling");

            migrationBuilder.DropTable(
                name: "OtherContractors");

            migrationBuilder.DropTable(
                name: "Paperwork");

            migrationBuilder.DropTable(
                name: "PowerTools");

            migrationBuilder.DropTable(
                name: "PPE");

            migrationBuilder.DropTable(
                name: "ProductContamination");

            migrationBuilder.DropTable(
                name: "SiteSetUpAppearance");

            migrationBuilder.DropTable(
                name: "ToolsUsedFitForPurpose");

            migrationBuilder.DropTable(
                name: "VehicleCondition");

            migrationBuilder.DropTable(
                name: "VehicleLogSheetUpToDate");

            migrationBuilder.DropTable(
                name: "VehicleServiceRecords");

            migrationBuilder.DropTable(
                name: "VoltageDetectorChecked");

            migrationBuilder.DropTable(
                name: "WasteManagement");

            migrationBuilder.DropTable(
                name: "WorkAtHeight");

            migrationBuilder.DropTable(
                name: "Report");
        }
    }
}
