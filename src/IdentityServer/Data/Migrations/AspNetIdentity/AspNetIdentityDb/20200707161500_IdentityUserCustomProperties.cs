using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class IdentityUserCustomProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d96db876-028a-4732-9736-1a64f1cd7559", "AQAAAAEAACcQAAAAEAFubMDzpArqzNDGyxWghjYFhKSn5B0M4fdZ4UKQPrW+ewjp0q95PkMAjnL+6PwetA==", "b8d948ac-e82a-4ca8-844e-ff4309c0f4dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c035ced-9e20-44ff-91a9-4fca367206bf", "AQAAAAEAACcQAAAAEPrcgA75xp1zkzX6w2tG9mPtTzec1s8dhQc/VRNil+q9shjTnvaqhIrcH0yjE0tmVw==", "c201d954-fe78-4859-ab47-452452c2ee3a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b3f226c-8c6b-4997-a573-0a9d3182a2ff", "AQAAAAEAACcQAAAAEONqBwtPvBnmRS9+a3XVbZexKAmqn5feJtUPpQ6iBP5UjL/bUbPuHmcdH0Q01Szexg==", "38579a01-8c30-4090-bb91-a446e81b3bb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c49aafc5-cdc5-4837-942f-c9cdd05eee8f", "AQAAAAEAACcQAAAAEEEOfbxME58Qs7t2RFk+o4njoTgdE3BIWZvXEokdVJDMp/l8lxPEw5yWzZq2ckB2MA==", "0d4e1af9-da75-4ff0-8856-8a79b305c753" });
        }
    }
}
