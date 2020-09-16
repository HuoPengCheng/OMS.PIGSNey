using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OMS.PIGSNey.Migrations
{
    public partial class Unite001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplyFortb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MaterialName = table.Column<string>(nullable: true),
                    UId = table.Column<int>(nullable: false),
                    MaterialAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyFortb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommodityDetailstb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    CName = table.Column<string>(nullable: true),
                    CPId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityDetailstb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Complaintb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Ordernumber = table.Column<string>(nullable: true),
                    UId1 = table.Column<int>(nullable: false),
                    UId2 = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaintb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Juristb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    RId = table.Column<int>(nullable: false),
                    JAdd = table.Column<int>(nullable: false),
                    JDel = table.Column<int>(nullable: false),
                    JShow = table.Column<int>(nullable: false),
                    JUpt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juristb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceDetailstb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    URDId = table.Column<int>(nullable: false),
                    UId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceDetailstb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materialstb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MaterialName = table.Column<string>(nullable: true),
                    MSpecification = table.Column<string>(nullable: true),
                    MCategory = table.Column<string>(nullable: true),
                    MAmount = table.Column<int>(nullable: false),
                    MImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materialstb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchasetb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MAterialName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    PAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchasetb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questiontb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Question1 = table.Column<string>(nullable: true),
                    Question2 = table.Column<string>(nullable: true),
                    Question3 = table.Column<string>(nullable: true),
                    Question4 = table.Column<string>(nullable: true),
                    QNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questiontb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RealNametb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    UId = table.Column<int>(nullable: false),
                    Prcture1 = table.Column<string>(nullable: true),
                    Prcture2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealNametb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roletb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    RName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roletb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tooltb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ToolName = table.Column<string>(nullable: true),
                    TSpecification = table.Column<string>(nullable: true),
                    TCategory = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tooltb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfotb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    UName = table.Column<string>(nullable: true),
                    UAccount = table.Column<string>(nullable: true),
                    UPwd = table.Column<string>(nullable: true),
                    UPhone = table.Column<string>(nullable: true),
                    RId = table.Column<int>(nullable: false),
                    UState = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfotb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRepairsDetailstb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Ordernumber = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Marque = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    Addrelss = table.Column<string>(nullable: true),
                    DetailedAddress = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    UId = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRepairsDetailstb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSubsidiarytb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    UId = table.Column<int>(nullable: false),
                    TId = table.Column<int>(nullable: false),
                    DrawTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubsidiarytb", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplyFortb");

            migrationBuilder.DropTable(
                name: "CommodityDetailstb");

            migrationBuilder.DropTable(
                name: "Complaintb");

            migrationBuilder.DropTable(
                name: "Juristb");

            migrationBuilder.DropTable(
                name: "MaintenanceDetailstb");

            migrationBuilder.DropTable(
                name: "Materialstb");

            migrationBuilder.DropTable(
                name: "Purchasetb");

            migrationBuilder.DropTable(
                name: "Questiontb");

            migrationBuilder.DropTable(
                name: "RealNametb");

            migrationBuilder.DropTable(
                name: "Roletb");

            migrationBuilder.DropTable(
                name: "Tooltb");

            migrationBuilder.DropTable(
                name: "UserInfotb");

            migrationBuilder.DropTable(
                name: "UserRepairsDetailstb");

            migrationBuilder.DropTable(
                name: "UserSubsidiarytb");
        }
    }
}
