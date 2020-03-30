using Microsoft.EntityFrameworkCore.Migrations;

namespace Community.Map.Data.Migrations
{
    public partial class gelperClassesAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HelpOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    HaveDelivery = table.Column<bool>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    WebAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpOffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HelpRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    IsUrgent = table.Column<bool>(nullable: false),
                    IsAbleCollect = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpRequests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HelpOffers",
                columns: new[] { "Id", "Category", "Email", "HaveDelivery", "Latitude", "Location", "Longitude", "Name", "Notes", "Phone", "WebAddress" },
                values: new object[,]
                {
                    { 4, 1, "no email", false, 54.008198, null, -1.467082, "Boots", "Chemist", "01423 863171", null },
                    { 5, 1, "no email", false, 54.008220000000001, null, -1.4661550000000001, "Lloyds Pharmacy", "Chemist", "01423 865308", null },
                    { 6, 1, "no email", false, 54.008101000000003, null, -1.467649, "Naylor P R Chemist", "Chemist", "01423 862117", null },
                    { 7, 1, "no email", false, 54.011490999999999, null, -1.456118, "Chain Line Pharmacy", "Chemist", "01423 864312", null },
                    { 8, 1, "no email", false, 54.000013000000003, null, -1.44391, "Boots Retail Park", "Chemist", "01423 860197", null },
                    { 9, 0, "no email", false, 54.009189999999997, null, -1.46166, "Honey Bees", "DELIVER: Home cooked meals / veg / cakes", "01423 866730", null },
                    { 10, 0, "no email", false, 54.007747000000002, null, -1.4663919999999999, "The Farm Dairy", "DELIVER: Bread / Eggs / Milk / Cooked Meats", "01423 865027", null },
                    { 11, 0, "no email", false, 54.008172999999999, null, -1.4670460000000001, "The Wine Shop", "DELIVER: Wine / Beer / Spirits", "01423 869940", null },
                    { 13, 0, "no email", false, 54.007877000000001, null, -1.4678230000000001, "Knaresborough Delivers", "DELIVER: Meat / Veg / Bread / Milk / Eggs / Cheese", "01423 869918", "https://knaresboroughdelivers.com " },
                    { 14, 0, "no email", false, 54.007260000000002, null, -1.4672700000000001, "Huttons Butchers", "DELIVER: Meat", "01423 863122", "https://www.huttonsbutchers.com/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HelpOffers");

            migrationBuilder.DropTable(
                name: "HelpRequests");
        }
    }
}
