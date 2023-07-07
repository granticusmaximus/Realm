using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Realm.Data.Migrations
{
    public partial class BlogEntityCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PortalId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Public = table.Column<bool>(type: "INTEGER", nullable: false),
                    AllowComments = table.Column<bool>(type: "INTEGER", nullable: false),
                    AllowAnonymous = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastEntry = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ShowFullName = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateFormat = table.Column<string>(type: "TEXT", nullable: false),
                    Culture = table.Column<string>(type: "TEXT", nullable: false),
                    TimeZone = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentBlogId = table.Column<int>(type: "INTEGER", nullable: true),
                    Syndicated = table.Column<bool>(type: "INTEGER", nullable: false),
                    SyndicateIndependant = table.Column<bool>(type: "INTEGER", nullable: false),
                    SyndicationUrl = table.Column<string>(type: "TEXT", nullable: false),
                    SyndicationEmail = table.Column<string>(type: "TEXT", nullable: false),
                    EmailNotification = table.Column<bool>(type: "INTEGER", nullable: true),
                    AllowTrackbacks = table.Column<bool>(type: "INTEGER", nullable: true),
                    AutoTrackback = table.Column<bool>(type: "INTEGER", nullable: true),
                    MustApproveComments = table.Column<bool>(type: "INTEGER", nullable: true),
                    MustApproveAnonymous = table.Column<bool>(type: "INTEGER", nullable: true),
                    MustApproveTrackbacks = table.Column<bool>(type: "INTEGER", nullable: true),
                    UseCaptcha = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });
        }
    }
}
