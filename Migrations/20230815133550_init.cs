using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamCooks.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeletedBy = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    TotalSongs = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    IsAccountLocked = table.Column<bool>(nullable: false),
                    HasAcceptedTerms = table.Column<bool>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    ProfilePicture = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false),
                    IsFirstTimeLogin = table.Column<bool>(nullable: false),
                    ReferralCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Era",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeletedBy = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Era", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keyword",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeletedBy = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    Word = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeletedBy = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ReasonOfSelection = table.Column<string>(nullable: true),
                    SociallyConscious = table.Column<int>(nullable: false),
                    CulturallySignificant = table.Column<int>(nullable: false),
                    OverallTheme = table.Column<string>(nullable: true),
                    ArtistId = table.Column<Guid>(nullable: false),
                    LinkedLyrics = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistEra",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeletedBy = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ArtistId = table.Column<Guid>(nullable: false),
                    EraId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistEra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistEra_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistEra_Era_EraId",
                        column: x => x.EraId,
                        principalTable: "Era",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongKeyword",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeletedBy = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    SongId = table.Column<Guid>(nullable: false),
                    KeywordId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongKeyword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SongKeyword_Keyword_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SongKeyword_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "Location", "ModifiedBy", "ModifiedOn", "Name", "Region", "TotalSongs" },
                values: new object[] { new Guid("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), "21 Savage is a British rapper known for his <i>distinct trap style</i> and introspective lyrics. Born in London, he moved to Atlanta at a young age and emerged as a prominent figure in the hip-hop scene. His music often reflects on his personal experiences, addressing topics like <i>violence</i>, <i>poverty</i>, and <b><span style='color: red';>social injustice</span></b>.", null, new DateTime(2023, 8, 15, 13, 35, 50, 168, DateTimeKind.Utc).AddTicks(6301), null, null, false, false, "Atlanta, Georgia", null, null, "21 Savage", "South", 0 });

            migrationBuilder.InsertData(
                table: "Era",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Date", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { new Guid("2fd8696a-414b-41e7-a661-b0dbddc309fa"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(394), "1995", null, null, false, false, null, null },
                    { new Guid("24889416-93f3-44ee-a240-d3d03c5acdd2"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(706), "1999", null, null, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Keyword",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Word" },
                values: new object[,]
                {
                    { new Guid("c1326157-0193-4fff-aa13-6c024b6db075"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(5102), null, null, false, false, null, null, "#Violence" },
                    { new Guid("3a2d81f8-e711-4b65-bb25-e858c9718337"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(5446), null, null, false, false, null, null, "#Success" },
                    { new Guid("038075d4-0f58-40f3-b94c-8e62bfafdcac"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(5464), null, null, false, false, null, null, "#Loyalty" },
                    { new Guid("87631796-cb7e-4f12-9672-40de4f95666c"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(5468), null, null, false, false, null, null, "#LifeOverWealthOrDeath" },
                    { new Guid("a814b9c4-1f18-42e7-8305-233ba7fa7e4c"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(5470), null, null, false, false, null, null, "#Struggles" },
                    { new Guid("b69ba75f-7a49-4f3e-b0f0-7a3d9fb550c9"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(5475), null, null, false, false, null, null, "#Betrayal" },
                    { new Guid("31f002c8-0686-4283-9cd0-b56ba095930a"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(5477), null, null, false, false, null, null, "#GunViolence" }
                });

            migrationBuilder.InsertData(
                table: "ArtistEra",
                columns: new[] { "Id", "ArtistId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "EraId", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { new Guid("5766d40c-03dc-4cbc-9311-68e02fd2c714"), new Guid("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), null, new DateTime(2023, 8, 15, 13, 35, 50, 167, DateTimeKind.Utc).AddTicks(3782), null, null, new Guid("2fd8696a-414b-41e7-a661-b0dbddc309fa"), false, false, null, null });

            migrationBuilder.InsertData(
                table: "ArtistEra",
                columns: new[] { "Id", "ArtistId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "EraId", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { new Guid("24cddc59-1ed9-4e36-b90a-874f344a9cd7"), new Guid("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), null, new DateTime(2023, 8, 15, 13, 35, 50, 167, DateTimeKind.Utc).AddTicks(5187), null, null, new Guid("24889416-93f3-44ee-a240-d3d03c5acdd2"), false, false, null, null });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "ArtistId", "CreatedBy", "CreatedOn", "CulturallySignificant", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LinkedLyrics", "ModifiedBy", "ModifiedOn", "Name", "OverallTheme", "ReasonOfSelection", "SociallyConscious" },
                values: new object[] { new Guid("24cddc59-1ed9-4e36-b90a-874f344a9cd7"), new Guid("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), null, new DateTime(2023, 8, 15, 13, 35, 50, 170, DateTimeKind.Utc).AddTicks(2253), 1, null, null, false, false, "https://genius.com/21-savage-a-lot-lyrics", null, null, "A Lot", "Reflection", "This song addresses various social issues and personal experiences, including the effects of violence, racism, and the struggle for success.", 1 });

            migrationBuilder.InsertData(
                table: "SongKeyword",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "KeywordId", "ModifiedBy", "ModifiedOn", "SongId" },
                values: new object[] { new Guid("c1326157-0193-4fff-aa13-6c024b6db075"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(8682), null, null, false, false, new Guid("c1326157-0193-4fff-aa13-6c024b6db075"), null, null, new Guid("24cddc59-1ed9-4e36-b90a-874f344a9cd7") });

            migrationBuilder.InsertData(
                table: "SongKeyword",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "KeywordId", "ModifiedBy", "ModifiedOn", "SongId" },
                values: new object[] { new Guid("cdec1b46-f382-4b34-a376-c4e1952f6340"), null, new DateTime(2023, 8, 15, 13, 35, 50, 169, DateTimeKind.Utc).AddTicks(9415), null, null, false, false, new Guid("3a2d81f8-e711-4b65-bb25-e858c9718337"), null, null, new Guid("24cddc59-1ed9-4e36-b90a-874f344a9cd7") });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistEra_ArtistId",
                table: "ArtistEra",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistEra_EraId",
                table: "ArtistEra",
                column: "EraId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Song_ArtistId",
                table: "Song",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_SongKeyword_KeywordId",
                table: "SongKeyword",
                column: "KeywordId");

            migrationBuilder.CreateIndex(
                name: "IX_SongKeyword_SongId",
                table: "SongKeyword",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistEra");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "SongKeyword");

            migrationBuilder.DropTable(
                name: "Era");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Keyword");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
