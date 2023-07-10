using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Realm.Data.Migrations
{
    public partial class ChatCreationAndAppUserUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AllowAnonymous = table.Column<bool>(type: "INTEGER", nullable: false),
                    AllowComments = table.Column<bool>(type: "INTEGER", nullable: false),
                    AllowTrackbacks = table.Column<bool>(type: "INTEGER", nullable: true),
                    AutoTrackback = table.Column<bool>(type: "INTEGER", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Culture = table.Column<string>(type: "TEXT", nullable: false),
                    DateFormat = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EmailNotification = table.Column<bool>(type: "INTEGER", nullable: true),
                    LastEntry = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MustApproveAnonymous = table.Column<bool>(type: "INTEGER", nullable: true),
                    MustApproveComments = table.Column<bool>(type: "INTEGER", nullable: true),
                    MustApproveTrackbacks = table.Column<bool>(type: "INTEGER", nullable: true),
                    ParentBlogId = table.Column<int>(type: "INTEGER", nullable: true),
                    PortalId = table.Column<int>(type: "INTEGER", nullable: false),
                    Public = table.Column<bool>(type: "INTEGER", nullable: false),
                    ShowFullName = table.Column<bool>(type: "INTEGER", nullable: false),
                    SyndicateIndependant = table.Column<bool>(type: "INTEGER", nullable: false),
                    Syndicated = table.Column<bool>(type: "INTEGER", nullable: false),
                    SyndicationEmail = table.Column<string>(type: "TEXT", nullable: false),
                    SyndicationUrl = table.Column<string>(type: "TEXT", nullable: false),
                    TimeZone = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    UseCaptcha = table.Column<bool>(type: "INTEGER", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });
        }
    }
}
