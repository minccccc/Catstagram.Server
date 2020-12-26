﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catstagram.Server.Data.Migrations
{
    public partial class AddAuditInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Cats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Cats",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Cats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Cats",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Cats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Cats",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Cats");
        }
    }
}
