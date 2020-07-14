using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class FidoStoredCredentialAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73172745-ad59-49ac-b806-dd5b03b0275b", "AQAAAAEAACcQAAAAEOQogGmhF7q3wbXY2EOOPd4SWC9xltEqEAWI78qoo2uyr0gnNMhAgBGazUZ8O3LbKg==", "d3a75991-23c6-428d-945c-819182b5764a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cf2e552-cedf-46c3-a7b1-3bb15a9cbb1d", "AQAAAAEAACcQAAAAEJbE6m87tz2VNXROVOx9bumlShQxa+vQ+0EJ3v6InFSyneUXxTvE+3P0r0RuPByA2w==", "381fb62a-c90a-40f8-9abd-af3358674803" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abf74388-9f15-4db8-ae76-03a5e1dec8ec", "AQAAAAEAACcQAAAAEFKxl9dFfppA3t28QnZkwveDhaZBllzcSGBwz8lzBiUXXgESlE2fpMJ6t0Gl+xUuPw==", "c0b266f0-f629-4109-b19f-e11cb5209cf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b5e1390-6163-4afe-8695-0d6a68ea1b5e", "AQAAAAEAACcQAAAAEHSAZ2iv2OovcuAqWvykUGx8EjQ4tqQnoPJQz92pgav5tX44bDwVUiupcJoE6NQHJw==", "9493d91d-d043-4790-b229-171537d82f7d" });
        }
    }
}
