using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenCommunityAccounting.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Land_Person_OwnerId",
                table: "Land");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Land",
                table: "Land");            

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "Land",
                newName: "Lands");

            migrationBuilder.RenameIndex(
                name: "IX_Land_OwnerId",
                table: "Lands",
                newName: "IX_Lands_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lands",
                table: "Lands",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsIncome = table.Column<bool>(nullable: false),
                    IsOutcome = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "Id", "IsIncome", "IsOutcome", "Name" },
                values: new object[,]
                {
                    { new Guid("64501dc6-695c-4f29-ab13-5481a529c228"), true, false, "Електроенергія" },
                    { new Guid("6ac1c44f-2db3-4a54-9bd7-fc3dc40bcdb1"), true, false, "Податок на землю" },
                    { new Guid("0f4400dd-dd58-405d-ae7e-34fd0693bd15"), true, false, "Цільовий внесок" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lands_Persons_OwnerId",
                table: "Lands",
                column: "OwnerId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lands_Persons_OwnerId",
                table: "Lands");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lands",
                table: "Lands");            

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.RenameTable(
                name: "Lands",
                newName: "Land");

            migrationBuilder.RenameIndex(
                name: "IX_Lands_OwnerId",
                table: "Land",
                newName: "IX_Land_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Land",
                table: "Land",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Land_Person_OwnerId",
                table: "Land",
                column: "OwnerId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
