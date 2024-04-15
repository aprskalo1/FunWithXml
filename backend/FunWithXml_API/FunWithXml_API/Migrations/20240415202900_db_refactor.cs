using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunWithXml_API.Migrations
{
    /// <inheritdoc />
    public partial class db_refactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WriGi",
                table: "BodyMeasurements",
                newName: "Wri_gi");

            migrationBuilder.RenameColumn(
                name: "WriDi",
                table: "BodyMeasurements",
                newName: "Wri_di");

            migrationBuilder.RenameColumn(
                name: "WaiGi",
                table: "BodyMeasurements",
                newName: "Wai_gi");

            migrationBuilder.RenameColumn(
                name: "ThiGi",
                table: "BodyMeasurements",
                newName: "Thi_gi");

            migrationBuilder.RenameColumn(
                name: "ShoGi",
                table: "BodyMeasurements",
                newName: "Sho_gi");

            migrationBuilder.RenameColumn(
                name: "NavGi",
                table: "BodyMeasurements",
                newName: "Nav_gi");

            migrationBuilder.RenameColumn(
                name: "KneGi",
                table: "BodyMeasurements",
                newName: "Kne_gi");

            migrationBuilder.RenameColumn(
                name: "KneDi",
                table: "BodyMeasurements",
                newName: "Kne_di");

            migrationBuilder.RenameColumn(
                name: "HipGi",
                table: "BodyMeasurements",
                newName: "Hip_gi");

            migrationBuilder.RenameColumn(
                name: "ForGi",
                table: "BodyMeasurements",
                newName: "For_gi");

            migrationBuilder.RenameColumn(
                name: "ElbDi",
                table: "BodyMeasurements",
                newName: "Elb_di");

            migrationBuilder.RenameColumn(
                name: "CheGi",
                table: "BodyMeasurements",
                newName: "Che_gi");

            migrationBuilder.RenameColumn(
                name: "CheDi",
                table: "BodyMeasurements",
                newName: "Che_di");

            migrationBuilder.RenameColumn(
                name: "CheDe",
                table: "BodyMeasurements",
                newName: "Che_de");

            migrationBuilder.RenameColumn(
                name: "CalGi",
                table: "BodyMeasurements",
                newName: "Cal_gi");

            migrationBuilder.RenameColumn(
                name: "BitDi",
                table: "BodyMeasurements",
                newName: "Bit_di");

            migrationBuilder.RenameColumn(
                name: "BiiDi",
                table: "BodyMeasurements",
                newName: "Bii_di");

            migrationBuilder.RenameColumn(
                name: "BicGi",
                table: "BodyMeasurements",
                newName: "Bic_gi");

            migrationBuilder.RenameColumn(
                name: "BiaDi",
                table: "BodyMeasurements",
                newName: "Bia_di");

            migrationBuilder.RenameColumn(
                name: "AnkGi",
                table: "BodyMeasurements",
                newName: "Ank_gi");

            migrationBuilder.RenameColumn(
                name: "AnkDi",
                table: "BodyMeasurements",
                newName: "Ank_di");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wri_gi",
                table: "BodyMeasurements",
                newName: "WriGi");

            migrationBuilder.RenameColumn(
                name: "Wri_di",
                table: "BodyMeasurements",
                newName: "WriDi");

            migrationBuilder.RenameColumn(
                name: "Wai_gi",
                table: "BodyMeasurements",
                newName: "WaiGi");

            migrationBuilder.RenameColumn(
                name: "Thi_gi",
                table: "BodyMeasurements",
                newName: "ThiGi");

            migrationBuilder.RenameColumn(
                name: "Sho_gi",
                table: "BodyMeasurements",
                newName: "ShoGi");

            migrationBuilder.RenameColumn(
                name: "Nav_gi",
                table: "BodyMeasurements",
                newName: "NavGi");

            migrationBuilder.RenameColumn(
                name: "Kne_gi",
                table: "BodyMeasurements",
                newName: "KneGi");

            migrationBuilder.RenameColumn(
                name: "Kne_di",
                table: "BodyMeasurements",
                newName: "KneDi");

            migrationBuilder.RenameColumn(
                name: "Hip_gi",
                table: "BodyMeasurements",
                newName: "HipGi");

            migrationBuilder.RenameColumn(
                name: "For_gi",
                table: "BodyMeasurements",
                newName: "ForGi");

            migrationBuilder.RenameColumn(
                name: "Elb_di",
                table: "BodyMeasurements",
                newName: "ElbDi");

            migrationBuilder.RenameColumn(
                name: "Che_gi",
                table: "BodyMeasurements",
                newName: "CheGi");

            migrationBuilder.RenameColumn(
                name: "Che_di",
                table: "BodyMeasurements",
                newName: "CheDi");

            migrationBuilder.RenameColumn(
                name: "Che_de",
                table: "BodyMeasurements",
                newName: "CheDe");

            migrationBuilder.RenameColumn(
                name: "Cal_gi",
                table: "BodyMeasurements",
                newName: "CalGi");

            migrationBuilder.RenameColumn(
                name: "Bit_di",
                table: "BodyMeasurements",
                newName: "BitDi");

            migrationBuilder.RenameColumn(
                name: "Bii_di",
                table: "BodyMeasurements",
                newName: "BiiDi");

            migrationBuilder.RenameColumn(
                name: "Bic_gi",
                table: "BodyMeasurements",
                newName: "BicGi");

            migrationBuilder.RenameColumn(
                name: "Bia_di",
                table: "BodyMeasurements",
                newName: "BiaDi");

            migrationBuilder.RenameColumn(
                name: "Ank_gi",
                table: "BodyMeasurements",
                newName: "AnkGi");

            migrationBuilder.RenameColumn(
                name: "Ank_di",
                table: "BodyMeasurements",
                newName: "AnkDi");
        }
    }
}
