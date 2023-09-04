using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesAPI.Migrations
{
    /// <inheritdoc />
    public partial class SaleTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionAmountUsd = table.Column<int>(type: "int", nullable: false),
                    TransactionCurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalHour = table.Column<int>(type: "int", nullable: false),
                    TransactionScenario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionIpAddress = table.Column<int>(type: "int", nullable: false),
                    IpState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IpPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IpCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsProxyIp = table.Column<int>(type: "int", nullable: false),
                    BrowserLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentInstrumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentBillingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentBillingState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentBillingCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CvvVerifyResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DigitalItemCount = table.Column<int>(type: "int", nullable: false),
                    PhysicalItemCount = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTransaction", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesTransaction");
        }
    }
}
