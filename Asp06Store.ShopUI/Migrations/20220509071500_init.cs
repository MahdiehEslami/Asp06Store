using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp06Store.ShopUI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Mobile", "Fast charging (27W, unofficial rating), 50% in 30 min (advertised)USB Power Delivery 2.0MagSafe wireless charging 15WQi magnetic fast wireless charging 7.5W", "Apple 13 Promax", 49000000 },
                    { 2, "Mobile", "Armour aluminum frame with tougher drop and scratch resistance (advertised) Glass front (Gorilla Glass Victus+), glass back (Gorilla Glass Victus+),Samsung DeX, Samsung Wireless DeX (desktop experience support) aluminum   ", "Samsung Galaxy S22 Ultra 5G", 30000000 },
                    { 3, "Mobile", "Wi-Fi 802, dual-band, Wi-Fi Direct, hotspot, Super AMOLED, 120Hz, HDR10, 700 nits (HBM), 1200 nits (peak)", "Xiaomi Redmi Note 11 Pro", 22000000 },
                    { 4, "Mobile", "BlackBerry OS 10.3, upgradable to 10.3.1 Qualcomm MSM8960T Snapdragon S4 Pro", "BlackBerry Porsche Design P'9983", 17000000 },
                    { 5, "LapTop", "Meet the totally mobile Pro. Always with you, instantly ready, and designed to light up the best of Windows 11 Keep up anywhere, at any angle, with a detachable Keyboard* with built-in Slim Pen storage and charging^—plus ", "Surface Pro X", 75000000 },
                    { 6, "LapTop", "Unlock more possibilities than ever with the Pro designed for a Pro like you. The first Surface Pro built on the Intel® Evo™ platform on select configurations†† and designed to light up the best of Windows 11, Surface Pro 8 combines the power ", "Surface Pro 8", 65000000 },
                    { 7, "LapTop", "Our classic Surface Pro 2-in-1 design meets high-speed performance to give you premium laptop versatility, a powerful tablet, or portable digital canvas de", "Surface Pro 7", 42000000 },
                    { 8, "LapTop", "Microsoft Store offers 60day returns on Surface products plus free expert help, digital workshops, and remote learning opportunities. Our online associates will provide free personal assistance to help you get the right Surface for your needs.", "Surface Go 3", 28000000 },
                    { 9, "LapTop", "Zenbook is premium, thin and light, and is the best laptop with top performance and the latest technology to unleash your creative power. ", "Zenbook ", 37000000 },
                    { 10, "LapTop", "The bold and youthful Vivobook series represents who you are. With topnotch performance, gorgeous displays, and efficient cooling, get the job done with ease. ", "Vivobook", 41000000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
