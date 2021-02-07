﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Izburs.DAL.Migrations
{
    public partial class izburs13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankaAdi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Iban",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankaAdi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Iban",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Resim",
                table: "AspNetUsers");
        }
    }
}
