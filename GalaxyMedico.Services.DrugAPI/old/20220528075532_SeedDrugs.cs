using Microsoft.EntityFrameworkCore.Migrations;

namespace GalaxyMedico.Services.DrugAPI.Migrations
{
    public partial class SeedDrugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "DrugId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Analgesic", "Pain killer which has anti inflammtory property.", "https://galaxymdstore.blob.core.windows.net/galaxystore/Combiflam.png", "Combiflam", 120.0 },
                    { 2, "Antipyertic", "fever reducer which has analgesic property.", "https://galaxymdstore.blob.core.windows.net/galaxystore/crocin.png", "Crocin", 80.0 },
                    { 3, "Nuero pain killer", "Nuero Pain killer which is good for ", "https://galaxymdstore.blob.core.windows.net/galaxystore/Gabapin-NT.png", "Gabapin NT", 260.0 },
                    { 4, "Anti-Biotic", "treats cold, mumps", "https://galaxymdstore.blob.core.windows.net/galaxystore/Amoxicillin.png", "Amoxcyilin", 150.0 },
                    { 5, "Anti-Allergic", "Nuero Pain killer which is good for ", "https://galaxymdstore.blob.core.windows.net/galaxystore/Allegra120.png", "Allegra 120 Mg", 260.0 },
                    { 6, "Type BP", "To treat blood pressure.", "https://galaxymdstore.blob.core.windows.net/galaxystore/AmlokindAT.png", "Amlokind AT", 25.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 6);
        }
    }
}
