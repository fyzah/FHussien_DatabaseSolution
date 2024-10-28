using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FHussien_DatabaseSolution.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Location 1", "Company 1" },
                    { 2, "Location 2", "Company 2" },
                    { 3, "Location 3", "Company 3" },
                    { 4, "Location 4", "Company 4" },
                    { 5, "Location 5", "Company 5" },
                    { 6, "Location 6", "Company 6" },
                    { 7, "Location 7", "Company 7" },
                    { 8, "Location 8", "Company 8" },
                    { 9, "Location 9", "Company 9" },
                    { 10, "Location 10", "Company 10" },
                    { 11, "Location 11", "Company 11" },
                    { 12, "Location 12", "Company 12" },
                    { 13, "Location 13", "Company 13" },
                    { 14, "Location 14", "Company 14" },
                    { 15, "Location 15", "Company 15" },
                    { 16, "Location 16", "Company 16" },
                    { 17, "Location 17", "Company 17" },
                    { 18, "Location 18", "Company 18" },
                    { 19, "Location 19", "Company 19" },
                    { 20, "Location 20", "Company 20" },
                    { 21, "Location 21", "Company 21" },
                    { 22, "Location 22", "Company 22" },
                    { 23, "Location 23", "Company 23" },
                    { 24, "Location 24", "Company 24" },
                    { 25, "Location 25", "Company 25" },
                    { 26, "Location 26", "Company 26" },
                    { 27, "Location 27", "Company 27" },
                    { 28, "Location 28", "Company 28" },
                    { 29, "Location 29", "Company 29" },
                    { 30, "Location 30", "Company 30" },
                    { 31, "Location 31", "Company 31" },
                    { 32, "Location 32", "Company 32" },
                    { 33, "Location 33", "Company 33" },
                    { 34, "Location 34", "Company 34" },
                    { 35, "Location 35", "Company 35" },
                    { 36, "Location 36", "Company 36" },
                    { 37, "Location 37", "Company 37" },
                    { 38, "Location 38", "Company 38" },
                    { 39, "Location 39", "Company 39" },
                    { 40, "Location 40", "Company 40" },
                    { 41, "Location 41", "Company 41" },
                    { 42, "Location 42", "Company 42" },
                    { 43, "Location 43", "Company 43" },
                    { 44, "Location 44", "Company 44" },
                    { 45, "Location 45", "Company 45" },
                    { 46, "Location 46", "Company 46" },
                    { 47, "Location 47", "Company 47" },
                    { 48, "Location 48", "Company 48" },
                    { 49, "Location 49", "Company 49" },
                    { 50, "Location 50", "Company 50" },
                    { 51, "Location 51", "Company 51" },
                    { 52, "Location 52", "Company 52" },
                    { 53, "Location 53", "Company 53" },
                    { 54, "Location 54", "Company 54" },
                    { 55, "Location 55", "Company 55" },
                    { 56, "Location 56", "Company 56" },
                    { 57, "Location 57", "Company 57" },
                    { 58, "Location 58", "Company 58" },
                    { 59, "Location 59", "Company 59" },
                    { 60, "Location 60", "Company 60" },
                    { 61, "Location 61", "Company 61" },
                    { 62, "Location 62", "Company 62" },
                    { 63, "Location 63", "Company 63" },
                    { 64, "Location 64", "Company 64" },
                    { 65, "Location 65", "Company 65" },
                    { 66, "Location 66", "Company 66" },
                    { 67, "Location 67", "Company 67" },
                    { 68, "Location 68", "Company 68" },
                    { 69, "Location 69", "Company 69" },
                    { 70, "Location 70", "Company 70" },
                    { 71, "Location 71", "Company 71" },
                    { 72, "Location 72", "Company 72" },
                    { 73, "Location 73", "Company 73" },
                    { 74, "Location 74", "Company 74" },
                    { 75, "Location 75", "Company 75" },
                    { 76, "Location 76", "Company 76" },
                    { 77, "Location 77", "Company 77" },
                    { 78, "Location 78", "Company 78" },
                    { 79, "Location 79", "Company 79" },
                    { 80, "Location 80", "Company 80" },
                    { 81, "Location 81", "Company 81" },
                    { 82, "Location 82", "Company 82" },
                    { 83, "Location 83", "Company 83" },
                    { 84, "Location 84", "Company 84" },
                    { 85, "Location 85", "Company 85" },
                    { 86, "Location 86", "Company 86" },
                    { 87, "Location 87", "Company 87" },
                    { 88, "Location 88", "Company 88" },
                    { 89, "Location 89", "Company 89" },
                    { 90, "Location 90", "Company 90" },
                    { 91, "Location 91", "Company 91" },
                    { 92, "Location 92", "Company 92" },
                    { 93, "Location 93", "Company 93" },
                    { 94, "Location 94", "Company 94" },
                    { 95, "Location 95", "Company 95" },
                    { 96, "Location 96", "Company 96" },
                    { 97, "Location 97", "Company 97" },
                    { 98, "Location 98", "Company 98" },
                    { 99, "Location 99", "Company 99" },
                    { 100, "Location 100", "Company 100" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator", "Admin" },
                    { 2, "Flat User", "User" }
                });

            migrationBuilder.InsertData(
                table: "UserInformations",
                columns: new[] { "Id", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateOnly(1995, 5, 9), "First Name 1", "Last Name 1" },
                    { 2, new DateOnly(1995, 5, 9), "First Name 2", "Last Name 2" },
                    { 3, new DateOnly(1995, 5, 9), "First Name 3", "Last Name 3" },
                    { 4, new DateOnly(1995, 5, 9), "First Name 4", "Last Name 4" },
                    { 5, new DateOnly(1995, 5, 9), "First Name 5", "Last Name 5" },
                    { 6, new DateOnly(1995, 5, 9), "First Name 6", "Last Name 6" },
                    { 7, new DateOnly(1995, 5, 9), "First Name 7", "Last Name 7" },
                    { 8, new DateOnly(1995, 5, 9), "First Name 8", "Last Name 8" },
                    { 9, new DateOnly(1995, 5, 9), "First Name 9", "Last Name 9" },
                    { 10, new DateOnly(1995, 5, 9), "First Name 10", "Last Name 10" },
                    { 11, new DateOnly(1995, 5, 9), "First Name 11", "Last Name 11" },
                    { 12, new DateOnly(1995, 5, 9), "First Name 12", "Last Name 12" },
                    { 13, new DateOnly(1995, 5, 9), "First Name 13", "Last Name 13" },
                    { 14, new DateOnly(1995, 5, 9), "First Name 14", "Last Name 14" },
                    { 15, new DateOnly(1995, 5, 9), "First Name 15", "Last Name 15" },
                    { 16, new DateOnly(1995, 5, 9), "First Name 16", "Last Name 16" },
                    { 17, new DateOnly(1995, 5, 9), "First Name 17", "Last Name 17" },
                    { 18, new DateOnly(1995, 5, 9), "First Name 18", "Last Name 18" },
                    { 19, new DateOnly(1995, 5, 9), "First Name 19", "Last Name 19" },
                    { 20, new DateOnly(1995, 5, 9), "First Name 20", "Last Name 20" },
                    { 21, new DateOnly(1995, 5, 9), "First Name 21", "Last Name 21" },
                    { 22, new DateOnly(1995, 5, 9), "First Name 22", "Last Name 22" },
                    { 23, new DateOnly(1995, 5, 9), "First Name 23", "Last Name 23" },
                    { 24, new DateOnly(1995, 5, 9), "First Name 24", "Last Name 24" },
                    { 25, new DateOnly(1995, 5, 9), "First Name 25", "Last Name 25" },
                    { 26, new DateOnly(1995, 5, 9), "First Name 26", "Last Name 26" },
                    { 27, new DateOnly(1995, 5, 9), "First Name 27", "Last Name 27" },
                    { 28, new DateOnly(1995, 5, 9), "First Name 28", "Last Name 28" },
                    { 29, new DateOnly(1995, 5, 9), "First Name 29", "Last Name 29" },
                    { 30, new DateOnly(1995, 5, 9), "First Name 30", "Last Name 30" },
                    { 31, new DateOnly(1995, 5, 9), "First Name 31", "Last Name 31" },
                    { 32, new DateOnly(1995, 5, 9), "First Name 32", "Last Name 32" },
                    { 33, new DateOnly(1995, 5, 9), "First Name 33", "Last Name 33" },
                    { 34, new DateOnly(1995, 5, 9), "First Name 34", "Last Name 34" },
                    { 35, new DateOnly(1995, 5, 9), "First Name 35", "Last Name 35" },
                    { 36, new DateOnly(1995, 5, 9), "First Name 36", "Last Name 36" },
                    { 37, new DateOnly(1995, 5, 9), "First Name 37", "Last Name 37" },
                    { 38, new DateOnly(1995, 5, 9), "First Name 38", "Last Name 38" },
                    { 39, new DateOnly(1995, 5, 9), "First Name 39", "Last Name 39" },
                    { 40, new DateOnly(1995, 5, 9), "First Name 40", "Last Name 40" },
                    { 41, new DateOnly(1995, 5, 9), "First Name 41", "Last Name 41" },
                    { 42, new DateOnly(1995, 5, 9), "First Name 42", "Last Name 42" },
                    { 43, new DateOnly(1995, 5, 9), "First Name 43", "Last Name 43" },
                    { 44, new DateOnly(1995, 5, 9), "First Name 44", "Last Name 44" },
                    { 45, new DateOnly(1995, 5, 9), "First Name 45", "Last Name 45" },
                    { 46, new DateOnly(1995, 5, 9), "First Name 46", "Last Name 46" },
                    { 47, new DateOnly(1995, 5, 9), "First Name 47", "Last Name 47" },
                    { 48, new DateOnly(1995, 5, 9), "First Name 48", "Last Name 48" },
                    { 49, new DateOnly(1995, 5, 9), "First Name 49", "Last Name 49" },
                    { 50, new DateOnly(1995, 5, 9), "First Name 50", "Last Name 50" },
                    { 51, new DateOnly(1995, 5, 9), "First Name 51", "Last Name 51" },
                    { 52, new DateOnly(1995, 5, 9), "First Name 52", "Last Name 52" },
                    { 53, new DateOnly(1995, 5, 9), "First Name 53", "Last Name 53" },
                    { 54, new DateOnly(1995, 5, 9), "First Name 54", "Last Name 54" },
                    { 55, new DateOnly(1995, 5, 9), "First Name 55", "Last Name 55" },
                    { 56, new DateOnly(1995, 5, 9), "First Name 56", "Last Name 56" },
                    { 57, new DateOnly(1995, 5, 9), "First Name 57", "Last Name 57" },
                    { 58, new DateOnly(1995, 5, 9), "First Name 58", "Last Name 58" },
                    { 59, new DateOnly(1995, 5, 9), "First Name 59", "Last Name 59" },
                    { 60, new DateOnly(1995, 5, 9), "First Name 60", "Last Name 60" },
                    { 61, new DateOnly(1995, 5, 9), "First Name 61", "Last Name 61" },
                    { 62, new DateOnly(1995, 5, 9), "First Name 62", "Last Name 62" },
                    { 63, new DateOnly(1995, 5, 9), "First Name 63", "Last Name 63" },
                    { 64, new DateOnly(1995, 5, 9), "First Name 64", "Last Name 64" },
                    { 65, new DateOnly(1995, 5, 9), "First Name 65", "Last Name 65" },
                    { 66, new DateOnly(1995, 5, 9), "First Name 66", "Last Name 66" },
                    { 67, new DateOnly(1995, 5, 9), "First Name 67", "Last Name 67" },
                    { 68, new DateOnly(1995, 5, 9), "First Name 68", "Last Name 68" },
                    { 69, new DateOnly(1995, 5, 9), "First Name 69", "Last Name 69" },
                    { 70, new DateOnly(1995, 5, 9), "First Name 70", "Last Name 70" },
                    { 71, new DateOnly(1995, 5, 9), "First Name 71", "Last Name 71" },
                    { 72, new DateOnly(1995, 5, 9), "First Name 72", "Last Name 72" },
                    { 73, new DateOnly(1995, 5, 9), "First Name 73", "Last Name 73" },
                    { 74, new DateOnly(1995, 5, 9), "First Name 74", "Last Name 74" },
                    { 75, new DateOnly(1995, 5, 9), "First Name 75", "Last Name 75" },
                    { 76, new DateOnly(1995, 5, 9), "First Name 76", "Last Name 76" },
                    { 77, new DateOnly(1995, 5, 9), "First Name 77", "Last Name 77" },
                    { 78, new DateOnly(1995, 5, 9), "First Name 78", "Last Name 78" },
                    { 79, new DateOnly(1995, 5, 9), "First Name 79", "Last Name 79" },
                    { 80, new DateOnly(1995, 5, 9), "First Name 80", "Last Name 80" },
                    { 81, new DateOnly(1995, 5, 9), "First Name 81", "Last Name 81" },
                    { 82, new DateOnly(1995, 5, 9), "First Name 82", "Last Name 82" },
                    { 83, new DateOnly(1995, 5, 9), "First Name 83", "Last Name 83" },
                    { 84, new DateOnly(1995, 5, 9), "First Name 84", "Last Name 84" },
                    { 85, new DateOnly(1995, 5, 9), "First Name 85", "Last Name 85" },
                    { 86, new DateOnly(1995, 5, 9), "First Name 86", "Last Name 86" },
                    { 87, new DateOnly(1995, 5, 9), "First Name 87", "Last Name 87" },
                    { 88, new DateOnly(1995, 5, 9), "First Name 88", "Last Name 88" },
                    { 89, new DateOnly(1995, 5, 9), "First Name 89", "Last Name 89" },
                    { 90, new DateOnly(1995, 5, 9), "First Name 90", "Last Name 90" },
                    { 91, new DateOnly(1995, 5, 9), "First Name 91", "Last Name 91" },
                    { 92, new DateOnly(1995, 5, 9), "First Name 92", "Last Name 92" },
                    { 93, new DateOnly(1995, 5, 9), "First Name 93", "Last Name 93" },
                    { 94, new DateOnly(1995, 5, 9), "First Name 94", "Last Name 94" },
                    { 95, new DateOnly(1995, 5, 9), "First Name 95", "Last Name 95" },
                    { 96, new DateOnly(1995, 5, 9), "First Name 96", "Last Name 96" },
                    { 97, new DateOnly(1995, 5, 9), "First Name 97", "Last Name 97" },
                    { 98, new DateOnly(1995, 5, 9), "First Name 98", "Last Name 98" },
                    { 99, new DateOnly(1995, 5, 9), "First Name 99", "Last Name 99" },
                    { 100, new DateOnly(1995, 5, 9), "First Name 100", "Last Name 100" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "Email", "Password", "RoleId", "UserInformationId", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "admin.email1@email.com", "admin", 1, 1, "Admin 1" },
                    { 2, 2, "admin.email2@email.com", "admin", 1, 2, "Admin 2" },
                    { 3, 3, "admin.email3@email.com", "admin", 1, 3, "Admin 3" },
                    { 4, 4, "admin.email4@email.com", "admin", 1, 4, "Admin 4" },
                    { 5, 5, "admin.email5@email.com", "admin", 1, 5, "Admin 5" },
                    { 6, 6, "admin.email6@email.com", "admin", 1, 6, "Admin 6" },
                    { 7, 7, "admin.email7@email.com", "admin", 1, 7, "Admin 7" },
                    { 8, 8, "admin.email8@email.com", "admin", 1, 8, "Admin 8" },
                    { 9, 9, "admin.email9@email.com", "admin", 1, 9, "Admin 9" },
                    { 10, 10, "admin.email10@email.com", "admin", 1, 10, "Admin 10" },
                    { 11, 11, "admin.email11@email.com", "admin", 1, 11, "Admin 11" },
                    { 12, 12, "admin.email12@email.com", "admin", 1, 12, "Admin 12" },
                    { 13, 13, "admin.email13@email.com", "admin", 1, 13, "Admin 13" },
                    { 14, 14, "admin.email14@email.com", "admin", 1, 14, "Admin 14" },
                    { 15, 15, "admin.email15@email.com", "admin", 1, 15, "Admin 15" },
                    { 16, 16, "admin.email16@email.com", "admin", 1, 16, "Admin 16" },
                    { 17, 17, "admin.email17@email.com", "admin", 1, 17, "Admin 17" },
                    { 18, 18, "admin.email18@email.com", "admin", 1, 18, "Admin 18" },
                    { 19, 19, "admin.email19@email.com", "admin", 1, 19, "Admin 19" },
                    { 20, 20, "admin.email20@email.com", "admin", 1, 20, "Admin 20" },
                    { 21, 21, "admin.email21@email.com", "admin", 1, 21, "Admin 21" },
                    { 22, 22, "admin.email22@email.com", "admin", 1, 22, "Admin 22" },
                    { 23, 23, "admin.email23@email.com", "admin", 1, 23, "Admin 23" },
                    { 24, 24, "admin.email24@email.com", "admin", 1, 24, "Admin 24" },
                    { 25, 25, "admin.email25@email.com", "admin", 1, 25, "Admin 25" },
                    { 26, 26, "admin.email26@email.com", "admin", 1, 26, "Admin 26" },
                    { 27, 27, "admin.email27@email.com", "admin", 1, 27, "Admin 27" },
                    { 28, 28, "admin.email28@email.com", "admin", 1, 28, "Admin 28" },
                    { 29, 29, "admin.email29@email.com", "admin", 1, 29, "Admin 29" },
                    { 30, 30, "admin.email30@email.com", "admin", 1, 30, "Admin 30" },
                    { 31, 31, "admin.email31@email.com", "admin", 1, 31, "Admin 31" },
                    { 32, 32, "admin.email32@email.com", "admin", 1, 32, "Admin 32" },
                    { 33, 33, "admin.email33@email.com", "admin", 1, 33, "Admin 33" },
                    { 34, 34, "admin.email34@email.com", "admin", 1, 34, "Admin 34" },
                    { 35, 35, "admin.email35@email.com", "admin", 1, 35, "Admin 35" },
                    { 36, 36, "admin.email36@email.com", "admin", 1, 36, "Admin 36" },
                    { 37, 37, "admin.email37@email.com", "admin", 1, 37, "Admin 37" },
                    { 38, 38, "admin.email38@email.com", "admin", 1, 38, "Admin 38" },
                    { 39, 39, "admin.email39@email.com", "admin", 1, 39, "Admin 39" },
                    { 40, 40, "admin.email40@email.com", "admin", 1, 40, "Admin 40" },
                    { 41, 41, "admin.email41@email.com", "admin", 1, 41, "Admin 41" },
                    { 42, 42, "admin.email42@email.com", "admin", 1, 42, "Admin 42" },
                    { 43, 43, "admin.email43@email.com", "admin", 1, 43, "Admin 43" },
                    { 44, 44, "admin.email44@email.com", "admin", 1, 44, "Admin 44" },
                    { 45, 45, "admin.email45@email.com", "admin", 1, 45, "Admin 45" },
                    { 46, 46, "admin.email46@email.com", "admin", 1, 46, "Admin 46" },
                    { 47, 47, "admin.email47@email.com", "admin", 1, 47, "Admin 47" },
                    { 48, 48, "admin.email48@email.com", "admin", 1, 48, "Admin 48" },
                    { 49, 49, "admin.email49@email.com", "admin", 1, 49, "Admin 49" },
                    { 50, 50, "admin.email50@email.com", "admin", 1, 50, "Admin 50" },
                    { 51, 51, "user.email51@email.com", "password", 2, 51, "User 51" },
                    { 52, 52, "user.email52@email.com", "password", 2, 52, "User 52" },
                    { 53, 53, "user.email53@email.com", "password", 2, 53, "User 53" },
                    { 54, 54, "user.email54@email.com", "password", 2, 54, "User 54" },
                    { 55, 55, "user.email55@email.com", "password", 2, 55, "User 55" },
                    { 56, 56, "user.email56@email.com", "password", 2, 56, "User 56" },
                    { 57, 57, "user.email57@email.com", "password", 2, 57, "User 57" },
                    { 58, 58, "user.email58@email.com", "password", 2, 58, "User 58" },
                    { 59, 59, "user.email59@email.com", "password", 2, 59, "User 59" },
                    { 60, 60, "user.email60@email.com", "password", 2, 60, "User 60" },
                    { 61, 61, "user.email61@email.com", "password", 2, 61, "User 61" },
                    { 62, 62, "user.email62@email.com", "password", 2, 62, "User 62" },
                    { 63, 63, "user.email63@email.com", "password", 2, 63, "User 63" },
                    { 64, 64, "user.email64@email.com", "password", 2, 64, "User 64" },
                    { 65, 65, "user.email65@email.com", "password", 2, 65, "User 65" },
                    { 66, 66, "user.email66@email.com", "password", 2, 66, "User 66" },
                    { 67, 67, "user.email67@email.com", "password", 2, 67, "User 67" },
                    { 68, 68, "user.email68@email.com", "password", 2, 68, "User 68" },
                    { 69, 69, "user.email69@email.com", "password", 2, 69, "User 69" },
                    { 70, 70, "user.email70@email.com", "password", 2, 70, "User 70" },
                    { 71, 71, "user.email71@email.com", "password", 2, 71, "User 71" },
                    { 72, 72, "user.email72@email.com", "password", 2, 72, "User 72" },
                    { 73, 73, "user.email73@email.com", "password", 2, 73, "User 73" },
                    { 74, 74, "user.email74@email.com", "password", 2, 74, "User 74" },
                    { 75, 75, "user.email75@email.com", "password", 2, 75, "User 75" },
                    { 76, 76, "user.email76@email.com", "password", 2, 76, "User 76" },
                    { 77, 77, "user.email77@email.com", "password", 2, 77, "User 77" },
                    { 78, 78, "user.email78@email.com", "password", 2, 78, "User 78" },
                    { 79, 79, "user.email79@email.com", "password", 2, 79, "User 79" },
                    { 80, 80, "user.email80@email.com", "password", 2, 80, "User 80" },
                    { 81, 81, "user.email81@email.com", "password", 2, 81, "User 81" },
                    { 82, 82, "user.email82@email.com", "password", 2, 82, "User 82" },
                    { 83, 83, "user.email83@email.com", "password", 2, 83, "User 83" },
                    { 84, 84, "user.email84@email.com", "password", 2, 84, "User 84" },
                    { 85, 85, "user.email85@email.com", "password", 2, 85, "User 85" },
                    { 86, 86, "user.email86@email.com", "password", 2, 86, "User 86" },
                    { 87, 87, "user.email87@email.com", "password", 2, 87, "User 87" },
                    { 88, 88, "user.email88@email.com", "password", 2, 88, "User 88" },
                    { 89, 89, "user.email89@email.com", "password", 2, 89, "User 89" },
                    { 90, 90, "user.email90@email.com", "password", 2, 90, "User 90" },
                    { 91, 91, "user.email91@email.com", "password", 2, 91, "User 91" },
                    { 92, 92, "user.email92@email.com", "password", 2, 92, "User 92" },
                    { 93, 93, "user.email93@email.com", "password", 2, 93, "User 93" },
                    { 94, 94, "user.email94@email.com", "password", 2, 94, "User 94" },
                    { 95, 95, "user.email95@email.com", "password", 2, 95, "User 95" },
                    { 96, 96, "user.email96@email.com", "password", 2, 96, "User 96" },
                    { 97, 97, "user.email97@email.com", "password", 2, 97, "User 97" },
                    { 98, 98, "user.email98@email.com", "password", 2, 98, "User 98" },
                    { 99, 99, "user.email99@email.com", "password", 2, 99, "User 99" },
                    { 100, 100, "user.email100@email.com", "password", 2, 100, "User 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
