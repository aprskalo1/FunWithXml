using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunWithXml_API.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyMeasurements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BiaDi = table.Column<float>(type: "real", nullable: false),
                    BiiDi = table.Column<float>(type: "real", nullable: false),
                    BitDi = table.Column<float>(type: "real", nullable: false),
                    CheDe = table.Column<float>(type: "real", nullable: false),
                    CheDi = table.Column<float>(type: "real", nullable: false),
                    ElbDi = table.Column<float>(type: "real", nullable: false),
                    WriDi = table.Column<float>(type: "real", nullable: false),
                    KneDi = table.Column<float>(type: "real", nullable: false),
                    AnkDi = table.Column<float>(type: "real", nullable: false),
                    ShoGi = table.Column<float>(type: "real", nullable: false),
                    CheGi = table.Column<float>(type: "real", nullable: false),
                    WaiGi = table.Column<float>(type: "real", nullable: false),
                    NavGi = table.Column<float>(type: "real", nullable: false),
                    HipGi = table.Column<float>(type: "real", nullable: false),
                    ThiGi = table.Column<float>(type: "real", nullable: false),
                    BicGi = table.Column<float>(type: "real", nullable: false),
                    ForGi = table.Column<float>(type: "real", nullable: false),
                    KneGi = table.Column<float>(type: "real", nullable: false),
                    CalGi = table.Column<float>(type: "real", nullable: false),
                    AnkGi = table.Column<float>(type: "real", nullable: false),
                    WriGi = table.Column<float>(type: "real", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Wgt = table.Column<float>(type: "real", nullable: false),
                    Hgt = table.Column<float>(type: "real", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyMeasurements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyMeasurements");
        }
    }
}
