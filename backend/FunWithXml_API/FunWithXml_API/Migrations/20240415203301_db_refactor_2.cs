using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunWithXml_API.Migrations
{
    /// <inheritdoc />
    public partial class db_refactor_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wri_gi",
                table: "BodyMeasurements",
                newName: "wri_gi");

            migrationBuilder.RenameColumn(
                name: "Wri_di",
                table: "BodyMeasurements",
                newName: "wri_di");

            migrationBuilder.RenameColumn(
                name: "Wgt",
                table: "BodyMeasurements",
                newName: "wgt");

            migrationBuilder.RenameColumn(
                name: "Wai_gi",
                table: "BodyMeasurements",
                newName: "wai_gi");

            migrationBuilder.RenameColumn(
                name: "Thi_gi",
                table: "BodyMeasurements",
                newName: "thi_gi");

            migrationBuilder.RenameColumn(
                name: "Sho_gi",
                table: "BodyMeasurements",
                newName: "sho_gi");

            migrationBuilder.RenameColumn(
                name: "Sex",
                table: "BodyMeasurements",
                newName: "sex");

            migrationBuilder.RenameColumn(
                name: "Nav_gi",
                table: "BodyMeasurements",
                newName: "nav_gi");

            migrationBuilder.RenameColumn(
                name: "Kne_gi",
                table: "BodyMeasurements",
                newName: "kne_gi");

            migrationBuilder.RenameColumn(
                name: "Kne_di",
                table: "BodyMeasurements",
                newName: "kne_di");

            migrationBuilder.RenameColumn(
                name: "Hip_gi",
                table: "BodyMeasurements",
                newName: "hip_gi");

            migrationBuilder.RenameColumn(
                name: "Hgt",
                table: "BodyMeasurements",
                newName: "hgt");

            migrationBuilder.RenameColumn(
                name: "For_gi",
                table: "BodyMeasurements",
                newName: "for_gi");

            migrationBuilder.RenameColumn(
                name: "Elb_di",
                table: "BodyMeasurements",
                newName: "elb_di");

            migrationBuilder.RenameColumn(
                name: "Che_gi",
                table: "BodyMeasurements",
                newName: "che_gi");

            migrationBuilder.RenameColumn(
                name: "Che_di",
                table: "BodyMeasurements",
                newName: "che_di");

            migrationBuilder.RenameColumn(
                name: "Che_de",
                table: "BodyMeasurements",
                newName: "che_de");

            migrationBuilder.RenameColumn(
                name: "Cal_gi",
                table: "BodyMeasurements",
                newName: "cal_gi");

            migrationBuilder.RenameColumn(
                name: "Bit_di",
                table: "BodyMeasurements",
                newName: "bit_di");

            migrationBuilder.RenameColumn(
                name: "Bii_di",
                table: "BodyMeasurements",
                newName: "bii_di");

            migrationBuilder.RenameColumn(
                name: "Bic_gi",
                table: "BodyMeasurements",
                newName: "bic_gi");

            migrationBuilder.RenameColumn(
                name: "Bia_di",
                table: "BodyMeasurements",
                newName: "bia_di");

            migrationBuilder.RenameColumn(
                name: "Ank_gi",
                table: "BodyMeasurements",
                newName: "ank_gi");

            migrationBuilder.RenameColumn(
                name: "Ank_di",
                table: "BodyMeasurements",
                newName: "ank_di");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "BodyMeasurements",
                newName: "age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "wri_gi",
                table: "BodyMeasurements",
                newName: "Wri_gi");

            migrationBuilder.RenameColumn(
                name: "wri_di",
                table: "BodyMeasurements",
                newName: "Wri_di");

            migrationBuilder.RenameColumn(
                name: "wgt",
                table: "BodyMeasurements",
                newName: "Wgt");

            migrationBuilder.RenameColumn(
                name: "wai_gi",
                table: "BodyMeasurements",
                newName: "Wai_gi");

            migrationBuilder.RenameColumn(
                name: "thi_gi",
                table: "BodyMeasurements",
                newName: "Thi_gi");

            migrationBuilder.RenameColumn(
                name: "sho_gi",
                table: "BodyMeasurements",
                newName: "Sho_gi");

            migrationBuilder.RenameColumn(
                name: "sex",
                table: "BodyMeasurements",
                newName: "Sex");

            migrationBuilder.RenameColumn(
                name: "nav_gi",
                table: "BodyMeasurements",
                newName: "Nav_gi");

            migrationBuilder.RenameColumn(
                name: "kne_gi",
                table: "BodyMeasurements",
                newName: "Kne_gi");

            migrationBuilder.RenameColumn(
                name: "kne_di",
                table: "BodyMeasurements",
                newName: "Kne_di");

            migrationBuilder.RenameColumn(
                name: "hip_gi",
                table: "BodyMeasurements",
                newName: "Hip_gi");

            migrationBuilder.RenameColumn(
                name: "hgt",
                table: "BodyMeasurements",
                newName: "Hgt");

            migrationBuilder.RenameColumn(
                name: "for_gi",
                table: "BodyMeasurements",
                newName: "For_gi");

            migrationBuilder.RenameColumn(
                name: "elb_di",
                table: "BodyMeasurements",
                newName: "Elb_di");

            migrationBuilder.RenameColumn(
                name: "che_gi",
                table: "BodyMeasurements",
                newName: "Che_gi");

            migrationBuilder.RenameColumn(
                name: "che_di",
                table: "BodyMeasurements",
                newName: "Che_di");

            migrationBuilder.RenameColumn(
                name: "che_de",
                table: "BodyMeasurements",
                newName: "Che_de");

            migrationBuilder.RenameColumn(
                name: "cal_gi",
                table: "BodyMeasurements",
                newName: "Cal_gi");

            migrationBuilder.RenameColumn(
                name: "bit_di",
                table: "BodyMeasurements",
                newName: "Bit_di");

            migrationBuilder.RenameColumn(
                name: "bii_di",
                table: "BodyMeasurements",
                newName: "Bii_di");

            migrationBuilder.RenameColumn(
                name: "bic_gi",
                table: "BodyMeasurements",
                newName: "Bic_gi");

            migrationBuilder.RenameColumn(
                name: "bia_di",
                table: "BodyMeasurements",
                newName: "Bia_di");

            migrationBuilder.RenameColumn(
                name: "ank_gi",
                table: "BodyMeasurements",
                newName: "Ank_gi");

            migrationBuilder.RenameColumn(
                name: "ank_di",
                table: "BodyMeasurements",
                newName: "Ank_di");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "BodyMeasurements",
                newName: "Age");
        }
    }
}
