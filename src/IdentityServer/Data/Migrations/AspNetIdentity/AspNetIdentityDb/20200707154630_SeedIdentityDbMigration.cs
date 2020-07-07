using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class SeedIdentityDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "3b3f226c-8c6b-4997-a573-0a9d3182a2ff", "AliceSmith@email.com", true, false, null, "ALICESMITH@EMAIL.COM", "ALICE", "AQAAAAEAACcQAAAAEONqBwtPvBnmRS9+a3XVbZexKAmqn5feJtUPpQ6iBP5UjL/bUbPuHmcdH0Q01Szexg==", null, false, "38579a01-8c30-4090-bb91-a446e81b3bb3", false, "alice" },
                    { "2", 0, "c49aafc5-cdc5-4837-942f-c9cdd05eee8f", "BobSmith@email.com", true, false, null, "BOBSMITH@EMAIL.COM", "BOB", "AQAAAAEAACcQAAAAEEEOfbxME58Qs7t2RFk+o4njoTgdE3BIWZvXEokdVJDMp/l8lxPEw5yWzZq2ckB2MA==", null, false, "0d4e1af9-da75-4ff0-8856-8a79b305c753", false, "bob" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "name", "Alice Smith", "1" },
                    { 2, "given_name", "Alice", "1" },
                    { 3, "family_name", "Smith", "1" },
                    { 4, "email", "AliceSmith@email.com", "1" },
                    { 5, "website", "http://alice.com", "1" },
                    { 11, "email_verified", "True", "1" },
                    { 13, "address", "{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", "1" },
                    { 15, "location", "somewhere", "1" },
                    { 6, "name", "Bob Smith", "2" },
                    { 7, "given_name", "Bob", "2" },
                    { 8, "family_name", "Smith", "2" },
                    { 9, "email", "BobSmith@email.com", "2" },
                    { 10, "website", "http://bob.com", "2" },
                    { 12, "email_verified", "True", "2" },
                    { 14, "address", "{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", "2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
