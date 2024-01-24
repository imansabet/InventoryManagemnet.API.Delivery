using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagemnet.API.Delivery.Migrations
{
    /// <inheritdoc />
    public partial class AddInternals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "ProductId",
                keyValue: new Guid("2634798d-6a53-4393-8c40-e4ce7b519a82"));

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "ProductId", "ProductName", "Quantity" },
                values: new object[] { new Guid("2a1a2745-aae0-4625-b11b-5f18c03826bf"), "مثال محصول", 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "ProductId",
                keyValue: new Guid("2a1a2745-aae0-4625-b11b-5f18c03826bf"));

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "ProductId", "ProductName", "Quantity" },
                values: new object[] { new Guid("2634798d-6a53-4393-8c40-e4ce7b519a82"), "مثال محصول", 10 });
        }
    }
}
