﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingMe.Migrations
{
    /// <inheritdoc />
    public partial class DataLayerWithUsersTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(540)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(257)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
