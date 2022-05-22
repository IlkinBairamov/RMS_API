using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMS.Data.Migrations
{
    public partial class DeleteOrderTypesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTypeId",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 755, DateTimeKind.Utc).AddTicks(9533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 858, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 755, DateTimeKind.Utc).AddTicks(8621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 858, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 752, DateTimeKind.Utc).AddTicks(7019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 856, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 752, DateTimeKind.Utc).AddTicks(6305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 855, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 751, DateTimeKind.Utc).AddTicks(1630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 854, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 751, DateTimeKind.Utc).AddTicks(678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 854, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 757, DateTimeKind.Utc).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 859, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 757, DateTimeKind.Utc).AddTicks(3670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 859, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 748, DateTimeKind.Utc).AddTicks(6006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 853, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 748, DateTimeKind.Utc).AddTicks(3046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 852, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 748, DateTimeKind.Utc).AddTicks(5168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 852, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 745, DateTimeKind.Utc).AddTicks(9685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 851, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 745, DateTimeKind.Utc).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 851, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 744, DateTimeKind.Utc).AddTicks(4726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 850, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 744, DateTimeKind.Utc).AddTicks(3837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 850, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 740, DateTimeKind.Utc).AddTicks(4073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 848, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 740, DateTimeKind.Utc).AddTicks(2882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 848, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 742, DateTimeKind.Utc).AddTicks(6363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 849, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 742, DateTimeKind.Utc).AddTicks(5372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 849, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 736, DateTimeKind.Utc).AddTicks(4977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 736, DateTimeKind.Utc).AddTicks(3804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 734, DateTimeKind.Utc).AddTicks(9137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 845, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 734, DateTimeKind.Utc).AddTicks(8292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 845, DateTimeKind.Utc).AddTicks(2580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 733, DateTimeKind.Utc).AddTicks(2943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 844, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 733, DateTimeKind.Utc).AddTicks(2307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 844, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 728, DateTimeKind.Utc).AddTicks(3840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 841, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 728, DateTimeKind.Utc).AddTicks(1535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 841, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 731, DateTimeKind.Utc).AddTicks(8904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 843, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 731, DateTimeKind.Utc).AddTicks(7976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 843, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 730, DateTimeKind.Utc).AddTicks(2489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 842, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 730, DateTimeKind.Utc).AddTicks(1675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 842, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 725, DateTimeKind.Utc).AddTicks(9944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 840, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 725, DateTimeKind.Utc).AddTicks(9357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 840, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 723, DateTimeKind.Utc).AddTicks(5760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 838, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 710, DateTimeKind.Utc).AddTicks(6892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 830, DateTimeKind.Utc).AddTicks(1664));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 858, DateTimeKind.Utc).AddTicks(5028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 755, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 858, DateTimeKind.Utc).AddTicks(4381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 755, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 856, DateTimeKind.Utc).AddTicks(130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 752, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 855, DateTimeKind.Utc).AddTicks(9515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 752, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 854, DateTimeKind.Utc).AddTicks(6723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 751, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 854, DateTimeKind.Utc).AddTicks(5757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 751, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 859, DateTimeKind.Utc).AddTicks(5866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 757, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 859, DateTimeKind.Utc).AddTicks(5361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 757, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 853, DateTimeKind.Utc).AddTicks(285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 748, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 852, DateTimeKind.Utc).AddTicks(8955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 748, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 852, DateTimeKind.Utc).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 748, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 851, DateTimeKind.Utc).AddTicks(7598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 745, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 851, DateTimeKind.Utc).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 745, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 850, DateTimeKind.Utc).AddTicks(8655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 744, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 850, DateTimeKind.Utc).AddTicks(8211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 744, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 848, DateTimeKind.Utc).AddTicks(7220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 740, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 848, DateTimeKind.Utc).AddTicks(6424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 740, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 849, DateTimeKind.Utc).AddTicks(8915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 742, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 849, DateTimeKind.Utc).AddTicks(8426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 742, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(9867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 736, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(9448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 736, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 845, DateTimeKind.Utc).AddTicks(3016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 734, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 845, DateTimeKind.Utc).AddTicks(2580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 734, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.AddColumn<int>(
                name: "OrderTypeId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 844, DateTimeKind.Utc).AddTicks(4178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 733, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 844, DateTimeKind.Utc).AddTicks(3646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 733, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 841, DateTimeKind.Utc).AddTicks(7024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 728, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 841, DateTimeKind.Utc).AddTicks(5952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 728, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 843, DateTimeKind.Utc).AddTicks(5599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 731, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 843, DateTimeKind.Utc).AddTicks(5196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 731, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 842, DateTimeKind.Utc).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 730, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 842, DateTimeKind.Utc).AddTicks(6445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 730, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 840, DateTimeKind.Utc).AddTicks(3905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 725, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 840, DateTimeKind.Utc).AddTicks(3573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 725, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 838, DateTimeKind.Utc).AddTicks(7201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 723, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 830, DateTimeKind.Utc).AddTicks(1664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 18, 4, 21, 31, 710, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(448)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(920))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
