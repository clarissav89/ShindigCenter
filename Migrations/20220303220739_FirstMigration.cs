using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ActivityCenter.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Shindigs",
                columns: table => new
                {
                    shindigId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    startTime = table.Column<DateTime>(nullable: false),
                    duration = table.Column<int>(nullable: false),
                    durationAmt = table.Column<string>(nullable: true),
                    userId = table.Column<int>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shindigs", x => x.shindigId);
                    table.ForeignKey(
                        name: "FK_Shindigs_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Shindigs",
                columns: table => new
                {
                    user_ShindigId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userId = table.Column<int>(nullable: false),
                    shindigId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Shindigs", x => x.user_ShindigId);
                    table.ForeignKey(
                        name: "FK_User_Shindigs_Shindigs_shindigId",
                        column: x => x.shindigId,
                        principalTable: "Shindigs",
                        principalColumn: "shindigId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Shindigs_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shindigs_userId",
                table: "Shindigs",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Shindigs_shindigId",
                table: "User_Shindigs",
                column: "shindigId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Shindigs_userId",
                table: "User_Shindigs",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_Shindigs");

            migrationBuilder.DropTable(
                name: "Shindigs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
