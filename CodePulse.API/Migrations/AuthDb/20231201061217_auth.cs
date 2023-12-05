using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class auth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2532ed3-ddaa-4c55-8b47-90e1c27a08a6", "AQAAAAIAAYagAAAAEFHSdkplTrQzubsy4krwCh2Vfa6+d0t2ZDluLX546a5BCnbp18zVb2kfTY8RO8hfUQ==", "c35ae4c7-9d01-4724-88f7-32abb14bb594" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36133d24-05e9-47a7-92e7-26a3a04657c0", "AQAAAAIAAYagAAAAEFFugz4+/jgC5expBuZd0vaXRKHu8AQ7CVNbM+H1sHeylsaLv2GJzpByC5lk785NFQ==", "17a80c1d-54b0-4a38-836d-07d816449916" });
        }
    }
}
