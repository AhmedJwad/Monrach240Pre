using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monrach240Pre.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Datasets",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_TIME_STAMP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATA_SOURCE_NAME = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DEVICE_ID = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PATIENT_SEQ_NUM = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    PATIENT_ID = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    PATIENT_NAME = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PATIENT_NAME_LAST = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PATIENT_NAME_MIDDLE = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PATIENT_NAME_FIRST = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PATIENT_NAME_SEX = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PATIENT_ADDRESS = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PATIENT_PHONE = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PATIENT_RACE = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_SEQ_NUM = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    RESULT_TEST_ID = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_TEST_ID1 = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_TEST_ID2 = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_TEST_ID3 = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_TEST_ID4 = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_VALUE = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_UNIT = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_ABNORMAL = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_STATUS = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    RESULT_OPERATOR_ID = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datasets", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Datasets_DEVICE_ID",
                table: "Datasets",
                column: "DEVICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Datasets_TIMESTAMP",
                table: "Datasets",
                column: "TIMESTAMP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datasets");
        }
    }
}
