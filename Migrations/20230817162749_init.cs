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
                values: new object[,]
                {
                    { new Guid("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), "21 Savage is a British rapper known for his <i>distinct trap style</i> and introspective lyrics. Born in London, he moved to Atlanta at a young age and emerged as a prominent figure in the hip-hop scene. His music often reflects on his personal experiences, addressing topics like <i>violence</i>, <i>poverty</i>, and <b><span style='color: red';>social injustice</span></b>.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(7087), null, null, false, false, "Atlanta, Georgia", null, null, "21 Savage", "South", 0 },
                    { new Guid("216ee8ad-45f2-4821-ae2a-a31513b582b2"), "DMX, also known as Dark Man X, was a prominent American rapper and actor...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8439), null, null, false, false, "Yonkers, New York", null, null, "DMX", "East", 0 },
                    { new Guid("ba8f37ad-2c5e-47f4-a698-185d132465bf"), "Don Trip (Christopher Donnie Wallace Jr) is a Memphis-based Hip Hop artist...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8441), null, null, false, false, "Memphis, Tennessee", null, null, "Don Trip", "South", 0 },
                    { new Guid("a86aa0bb-2f52-4c77-ae95-8e13e8647f46"), "Doug E. Fresh is an American rapper, beatboxer, and producer...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8443), null, null, false, false, "Barbados, New York", null, null, "Doug E. Fresh", "East", 0 },
                    { new Guid("82d20e7d-c16d-4871-aa41-e63dd85fc7d9"), "Drake is a Canadian rapper, singer, songwriter, and actor...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8447), null, null, false, false, "Ontario, Canada", null, null, "Drake", "North", 0 },
                    { new Guid("810fd050-69f1-4df7-bd8e-538fdd99cd7a"), "El-P, whose real name is Jaime Meline, is an American rapper...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8449), null, null, false, false, "Brooklyn, New York", null, null, "El-P", "East", 0 },
                    { new Guid("7e8c0d97-d711-4b11-860d-fe8ebed81e88"), "Eminem, also known as Marshall Mathers or Slim Shady, is an American rapper...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8451), null, null, false, false, "Detroit, Michigan", null, null, "Eminem", "North", 0 },
                    { new Guid("0d113502-3201-400b-9032-80b3d08c98e0"), "EPMD, which stands for Erick and Parrish Making Dollars, is an American hip-hop duo...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8453), null, null, false, false, "Brentwood New York", null, null, "EPMD", "East", 0 },
                    { new Guid("8ec42dd7-70aa-41c7-904c-8a35c9498ac5"), "Denzel Curry is an American rapper and songwriter...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8434), null, null, false, false, "Carol City, Florida", null, null, "Denzel Curry", "South", 0 },
                    { new Guid("06668236-a70e-4f92-b9ed-d84c8a92461a"), "Eric B & Rakim were an American hip-hop duo known for their groundbreaking contributions...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8457), null, null, false, false, "Long Island, New York", null, null, "Eric B & Rakim", "East", 0 },
                    { new Guid("08e717ee-1bb9-4d78-a960-806e638edabd"), "Fat Boys were an American hip-hop trio known for their lighthearted and comedic approach...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8461), null, null, false, false, "Brooklyn, New York", null, null, "Fat Boys", "East", 0 },
                    { new Guid("f70ade42-0591-4eaf-8fff-4562a48a914e"), "Fearless Four was an American hip-hop group known for their energetic performances...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8465), null, null, false, false, "New York, New York", null, null, "Fearless Four", "East", 0 },
                    { new Guid("829ff282-771f-4163-b623-c6a376dbccf2"), "Fugees, comprised of Wyclef Jean, Lauryn Hill, and Pras Michel, were an American hip-hop...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8467), null, null, false, false, "South Orange, New Jersey", null, null, "Fugees", "East", 0 },
                    { new Guid("76d60b6b-f561-4f11-a81b-e56714ee4a26"), "Nayvadius DeMun Wilburn, better known by his stage name Future, is an American rapper...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8469), null, null, false, false, "Atlanta, Georgia", null, null, "Future", "South", 0 },
                    { new Guid("7c52c5fd-a42e-489f-8936-6cfd12e396dc"), "Gang Starr was an American hip-hop duo consisting of Guru and DJ Premier. Known for...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8471), null, null, false, false, "Brooklyn, New York", null, null, "Gang Starr", "East", 0 },
                    { new Guid("4eea05c7-76a9-463e-b4b3-ecf36c9da2c7"), "Grandmaster Flash and the Furious Five were an American hip-hop group known for...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8473), null, null, false, false, "South Bronx, New York", null, null, "Grand Master Flash and the Furious 5", "East", 0 },
                    { new Guid("de4fa6c0-69b4-440d-8bfb-1a03d4e50aa9"), "Gunna, also known as Sergio Giavanni Kitchens, is an American rapper and songwriter...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8478), null, null, false, false, "Atlanta, Georgia", null, null, "Gunna", "South", 0 },
                    { new Guid("d89be7b5-908f-4b71-af1e-6413f287b960"), "Fabolous, born John David Jackson, is an American rapper and songwriter from Brooklyn...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8459), null, null, false, false, "Brooklyn, New York", null, null, "Fabolous", "East", 0 },
                    { new Guid("2a1ec110-02f9-439e-8c98-62118414460e"), "DJ Jazzy Jeff & The Fresh Prince, consisting of DJ Jazzy Jeff...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8432), null, null, false, false, "Philadelphia, Pennsylvania", null, null, "DJ Jazzy Jeff & The Fresh Prince", "East", 0 },
                    { new Guid("43e15e26-29c5-43c6-a234-cdb05102d452"), "DJ Quik is an American rapper, record producer, and DJ...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8445), null, null, false, false, "Compton, California", null, null, "DJ Quik", "West", 0 },
                    { new Guid("21396070-8cb6-4013-88b7-9bc770fbdea3"), "De La Soul is an American hip-hop trio...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8428), null, null, false, false, "Amityville, New York", null, null, "De La Soul", "East", 0 },
                    { new Guid("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"), "3rd Bass was an American hip-hop group known for their witty and <span class='pir'>socially conscious</span> lyrics. Consisting of MC Serch, Prime Minister Pete Nice, and DJ Richie Rich, they rose to prominence in the late 1980s and early 1990s. Their music often tackled themes of racial inequality, politics, and cultural criticism.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8212), null, null, false, false, "", null, null, "3rd Bass", "North", 0 },
                    { new Guid("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"), "50 Cent is an American rapper and actor who gained popularity with his debut album 'Get Rich or Die Tryin'.' Born Curtis Jackson, he rose to prominence in the early 2000s with his gritty lyrics and captivating storytelling. Beyond his music career, 50 Cent has ventured into entrepreneurship and acting, showcasing his versatility and business acumen.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8265), null, null, false, false, "Queens, New York", null, null, "50 Cent", "North", 0 },
                    { new Guid("e4aba257-4e44-4fec-9f36-dabbac9e6078"), "Akinyele is a provocative and controversial Hip Hop artist known for pushing boundaries with his explicit lyrics. His debut album 'Vagina Diner' gained attention for its daring content. Akinyele's music often sparks discussions about societal taboos and challenges traditional norms.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8269), null, null, false, false, "Queens, New York", null, null, "Akinyele", "East", 0 },
                    { new Guid("e77e56bb-1965-4bcc-bf97-59fe949ef32e"), "Digital Underground was an American hip-hop group...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8430), null, null, false, false, "Oakland, California", null, null, "Digital Underground", "West", 0 },
                    { new Guid("12b86ab3-08b1-4597-afeb-c259809fadfe"), "Big Daddy Kane is an American rapper and actor known for his smooth delivery and influential contributions to hip-hop. With his charismatic stage presence and intricate wordplay, he became one of the leading figures in the golden age of hip-hop in the late 1980s and early 1990s. His lyrical prowess and suave style influenced generations of artists.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8278), null, null, false, false, "Brooklyn, New York", null, null, "Big Daddy Kane", "East", 0 },
                    { new Guid("c21a0b21-e882-4fc0-a723-ab568dee850e"), "Big Pun, whose real name was Christopher Rios, was a highly influential Puerto Rican-American rapper known for his exceptional lyricism and impactful storytelling. He left a lasting legacy on the hip-hop community as one of the first Latino rappers to achieve mainstream success. Despite his untimely passing, his contributions to the genre continue to inspire and influence artists to this day.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8346), null, null, false, false, "Bronx, New York", null, null, "Big Pun", "East", 0 },
                    { new Guid("e72f8147-068a-4dfc-8076-7ddfd0d0ff4d"), "Biz Markie was an American rapper, beatboxer, and producer known for his humorous and lighthearted style. With his distinctive baritone voice and playful lyrics, he achieved mainstream success in the late 1980s. Biz Markie's contributions to hip-hop extended beyond his music, as he also served as a DJ and appeared in films and TV shows. Additionally, he subtly made <span class='pir';>political statements</span> in his music, demonstrating a slight bit of activism.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8348), null, null, false, false, "New York, New York", null, null, "Biz Markie", "East", 0 },
                    { new Guid("0d869f3a-726a-4801-8959-262f0b9a909f"), "Black Eyed Peas is an American musical group known for their eclectic blend of hip-hop, pop, and electronic music. Consisting of will.i.am (William James Adams Jr.), apl.de.ap (Allan Pineda Lindo), Taboo (Jaime Luis Gomez), and Fergie (Stacy Ann Ferguson), The group's music often carries socially conscious messages and promotes positivity and unity.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8350), null, null, false, false, "Los Angeles, California", null, null, "Black Eyed Peas", "West", 0 },
                    { new Guid("d8643739-f72e-42f0-93f6-48ee78958529"), "Black Moon is an American hip hop group from Brooklyn, New York, formed in the early 1990s. The group consists of members Buckshot, 5 ft, and DJ Evil Dee. Known for their underground sound and <span class='pir'>contribution to the creation of hardcore hip-hop with a focus on social consciousness</span>, they are acclaimed for albums like 'Enta da Stage'.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8354), null, null, false, false, "Brooklyn, New York", null, null, "Black Moon", "East", 0 },
                    { new Guid("b0577578-89ca-4d61-afab-aac673fa4bfb"), "Beastie Boys were an American rap/rock group known for their energetic performances and genre-blending music. Consisting of Michael Diamond (Mike D), Adam Horovitz (Ad-Rock), and Adam Yauch (MCA), they emerged in the 1980s as pioneers of hip-hop and alternative music fusion. Their influential career spanned decades, leaving an indelible impact on the music industry.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8272), null, null, false, false, "Brooklyn, New York", null, null, "Beastie Boys", "North", 0 },
                    { new Guid("9c42203f-12eb-4725-9bdf-ba5df28cbeb1"), "Busta Rhymes is an American rapper, singer, and actor known for his energetic performances and rapid-fire rhymes. With a career spanning several decades, he has released numerous chart-topping hits and collaborated with various artists. Busta Rhymes is celebrated for his dynamic flow and charismatic stage presence.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8358), null, null, false, false, "Brooklyn, New York", null, null, "Busta Rhymes", "East", 0 },
                    { new Guid("cd8c0d16-8147-48a3-b79f-c41f3f3388e0"), "Canibus is an American rapper known for his intricate wordplay and lyrical depth. Emerging in the late 1990s, he gained attention for his technical skills and thought-provoking verses. Canibus's music often explores complex themes and showcases his intellectual approach to hip-hop.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8360), null, null, false, false, "Jamaica, Queens, New York", null, null, "Canibus", "East", 0 },
                    { new Guid("ad7dd979-1452-40f7-abfa-48f0fb090714"), "Cardi B is an American rapper, songwriter, and actress who rose to fame with her chart-topping debut single 'Bodak Yellow'. Known for her charismatic personality and unapologetic lyrics, she has become one of the most successful female artists in the music industry. Cardi B's bold and confident style has made her a cultural icon.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8362), null, null, false, false, "New York, New York", null, null, "Cardi B", "East", 0 },
                    { new Guid("9d4312fa-04a0-46c4-ace1-3cd5db85199a"), "Chancelor Bennett, better known by his stage name Chance the Rapper, is an American rapper, singer, songwriter, and record producer. He is known for his eclectic mix of hip hop, gospel, and soul music, as well as his <span class='pir';>socially conscious</span> lyrics.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8417), null, null, false, false, "Chicago, Illinois", null, null, "Chance the Rapper", "North", 0 },
                    { new Guid("b6117d40-fad4-4101-8f91-861988862778"), "Childish Gambino, also known as Donald Glover, is a multi-talented artist who excels in music, acting, writing, and producing. With critically acclaimed albums like 'Awaken, My Love!' and the hit single 'This Is America', he has proven himself as an innovative and socially conscious artist. Childish Gambino's work often explores themes of race, identity, and cultural commentary.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8420), null, null, false, false, "Stone Mountain, Georgia", null, null, "Childish Gambino", "East", 0 },
                    { new Guid("c1ea5e3f-2080-406f-b300-58e919430f6f"), "Common is an American rapper, actor, and activist known for his introspective and socially conscious lyrics. With a career spanning over three decades, he has released acclaimed albums and collaborated with various artists. Common's music often delves into themes of love, self-reflection, and social issues.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8423), null, null, false, false, "Chicago, Illinois", null, null, "Common", "North", 0 },
                    { new Guid("4aa0a587-22ad-4d74-a4b2-4af7a155b9e1"), "Cypress Hill is an American hip-hop group...", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8426), null, null, false, false, "South Gate, California", null, null, "Cypress Hill", "West", 0 },
                    { new Guid("2d9ceb0d-ef78-45bf-ad55-cc7f9901ae0f"), "Bone Thugs-N-Harmony is an American hip-hop group known for their melodic harmonies and rapid-fire delivery. Formed in Cleveland, Ohio, they rose to prominence in the 1990s with hits like 'Tha Crossroads' and '1st of tha Month'. Their unique style and introspective lyrics made them influential figures in the rap scene.", null, new DateTime(2023, 8, 17, 16, 27, 49, 22, DateTimeKind.Utc).AddTicks(8356), null, null, false, false, "Cleveland, Ohio", null, null, "Bone Thugs-N-Harmony", "North", 0 }
                });

            migrationBuilder.InsertData(
                table: "Era",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Date", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { new Guid("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(3520), "2000", null, null, false, false, null, null },
                    { new Guid("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(3518), "1980", null, null, false, false, null, null },
                    { new Guid("68005290-a3c7-4973-bd05-4ee4c3395d4d"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(3495), "1990", null, null, false, false, null, null },
                    { new Guid("2fd8696a-414b-41e7-a661-b0dbddc309fa"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(3094), "1995", null, null, false, false, null, null },
                    { new Guid("24889416-93f3-44ee-a240-d3d03c5acdd2"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(3514), "1999", null, null, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Keyword",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Word" },
                values: new object[,]
                {
                    { new Guid("b69ba75f-7a49-4f3e-b0f0-7a3d9fb550c9"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(8710), null, null, false, false, null, null, "#Betrayal" },
                    { new Guid("c1326157-0193-4fff-aa13-6c024b6db075"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(8301), null, null, false, false, null, null, "#Violence" },
                    { new Guid("3a2d81f8-e711-4b65-bb25-e858c9718337"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(8680), null, null, false, false, null, null, "#Success" },
                    { new Guid("038075d4-0f58-40f3-b94c-8e62bfafdcac"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(8698), null, null, false, false, null, null, "#Loyalty" },
                    { new Guid("87631796-cb7e-4f12-9672-40de4f95666c"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(8702), null, null, false, false, null, null, "#LifeOverWealthOrDeath" },
                    { new Guid("a814b9c4-1f18-42e7-8305-233ba7fa7e4c"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(8705), null, null, false, false, null, null, "#Struggles" },
                    { new Guid("31f002c8-0686-4283-9cd0-b56ba095930a"), null, new DateTime(2023, 8, 17, 16, 27, 49, 23, DateTimeKind.Utc).AddTicks(8713), null, null, false, false, null, null, "#GunViolence" }
                });

            migrationBuilder.InsertData(
                table: "ArtistEra",
                columns: new[] { "Id", "ArtistId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "EraId", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { new Guid("5766d40c-03dc-4cbc-9311-68e02fd2c714"), new Guid("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), null, new DateTime(2023, 8, 17, 16, 27, 49, 19, DateTimeKind.Utc).AddTicks(7876), null, null, new Guid("2fd8696a-414b-41e7-a661-b0dbddc309fa"), false, false, null, null },
                    { new Guid("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"), new Guid("e4aba257-4e44-4fec-9f36-dabbac9e6078"), null, new DateTime(2023, 8, 17, 16, 27, 49, 19, DateTimeKind.Utc).AddTicks(9375), null, null, new Guid("68005290-a3c7-4973-bd05-4ee4c3395d4d"), false, false, null, null },
                    { new Guid("24cddc59-1ed9-4e36-b90a-874f344a9cd7"), new Guid("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), null, new DateTime(2023, 8, 17, 16, 27, 49, 19, DateTimeKind.Utc).AddTicks(9323), null, null, new Guid("24889416-93f3-44ee-a240-d3d03c5acdd2"), false, false, null, null },
                    { new Guid("43d495e0-a269-46ef-aff4-2f8bd1ab3435"), new Guid("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"), null, new DateTime(2023, 8, 17, 16, 27, 49, 19, DateTimeKind.Utc).AddTicks(9364), null, null, new Guid("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"), false, false, null, null },
                    { new Guid("e4aba257-4e44-4fec-9f36-dabbac9e6078"), new Guid("b0577578-89ca-4d61-afab-aac673fa4bfb"), null, new DateTime(2023, 8, 17, 16, 27, 49, 19, DateTimeKind.Utc).AddTicks(9382), null, null, new Guid("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"), false, false, null, null },
                    { new Guid("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"), new Guid("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"), null, new DateTime(2023, 8, 17, 16, 27, 49, 19, DateTimeKind.Utc).AddTicks(9370), null, null, new Guid("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"), false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "ArtistId", "CreatedBy", "CreatedOn", "CulturallySignificant", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LinkedLyrics", "ModifiedBy", "ModifiedOn", "Name", "OverallTheme", "ReasonOfSelection", "SociallyConscious" },
                values: new object[] { new Guid("24cddc59-1ed9-4e36-b90a-874f344a9cd7"), new Guid("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), null, new DateTime(2023, 8, 17, 16, 27, 49, 24, DateTimeKind.Utc).AddTicks(6528), 1, null, null, false, false, "https://genius.com/21-savage-a-lot-lyrics", null, null, "A Lot", "Reflection", "This song addresses various social issues and personal experiences, including the effects of violence, racism, and the struggle for success.", 1 });

            migrationBuilder.InsertData(
                table: "SongKeyword",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "KeywordId", "ModifiedBy", "ModifiedOn", "SongId" },
                values: new object[] { new Guid("c1326157-0193-4fff-aa13-6c024b6db075"), null, new DateTime(2023, 8, 17, 16, 27, 49, 24, DateTimeKind.Utc).AddTicks(2539), null, null, false, false, new Guid("c1326157-0193-4fff-aa13-6c024b6db075"), null, null, new Guid("24cddc59-1ed9-4e36-b90a-874f344a9cd7") });

            migrationBuilder.InsertData(
                table: "SongKeyword",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "KeywordId", "ModifiedBy", "ModifiedOn", "SongId" },
                values: new object[] { new Guid("cdec1b46-f382-4b34-a376-c4e1952f6340"), null, new DateTime(2023, 8, 17, 16, 27, 49, 24, DateTimeKind.Utc).AddTicks(3317), null, null, false, false, new Guid("3a2d81f8-e711-4b65-bb25-e858c9718337"), null, null, new Guid("24cddc59-1ed9-4e36-b90a-874f344a9cd7") });

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
