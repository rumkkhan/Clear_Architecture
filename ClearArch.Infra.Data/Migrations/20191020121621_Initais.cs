﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ClearArch.Infra.Data.Migrations
{
    public partial class Initais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Designation", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Software", "Ramzan", "Khan" },
                    { 2, "Doctor", "Tariq", "Khan" },
                    { 3, "Teacher", "javid", "Khan" },
                    { 4, "Driver", "Anaytullah", "Khan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
