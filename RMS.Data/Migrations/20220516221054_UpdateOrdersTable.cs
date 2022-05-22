using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMS.Data.Migrations
{
    public partial class UpdateOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 858, DateTimeKind.Utc).AddTicks(5028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 124, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 858, DateTimeKind.Utc).AddTicks(4381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 124, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 856, DateTimeKind.Utc).AddTicks(130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 120, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 855, DateTimeKind.Utc).AddTicks(9515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 120, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 854, DateTimeKind.Utc).AddTicks(6723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 119, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 854, DateTimeKind.Utc).AddTicks(5757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 119, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 859, DateTimeKind.Utc).AddTicks(5866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 126, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 859, DateTimeKind.Utc).AddTicks(5361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 126, DateTimeKind.Utc).AddTicks(2176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 853, DateTimeKind.Utc).AddTicks(285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 114, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 852, DateTimeKind.Utc).AddTicks(8955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 114, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 852, DateTimeKind.Utc).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 114, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 851, DateTimeKind.Utc).AddTicks(7598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 112, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 851, DateTimeKind.Utc).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 112, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 850, DateTimeKind.Utc).AddTicks(8655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 111, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 850, DateTimeKind.Utc).AddTicks(8211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 111, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 848, DateTimeKind.Utc).AddTicks(7220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 108, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 848, DateTimeKind.Utc).AddTicks(6424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 108, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 849, DateTimeKind.Utc).AddTicks(8915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 109, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 849, DateTimeKind.Utc).AddTicks(8426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 109, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(9867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 106, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(9448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 105, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 104, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 104, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 845, DateTimeKind.Utc).AddTicks(3016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 103, DateTimeKind.Utc).AddTicks(2356));

            migrationBuilder.AlterColumn<int>(
                name: "OrderTypeId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 845, DateTimeKind.Utc).AddTicks(2580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 103, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 844, DateTimeKind.Utc).AddTicks(4178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 101, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 844, DateTimeKind.Utc).AddTicks(3646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 100, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 841, DateTimeKind.Utc).AddTicks(7024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 93, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 841, DateTimeKind.Utc).AddTicks(5952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 93, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 843, DateTimeKind.Utc).AddTicks(5599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 98, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 843, DateTimeKind.Utc).AddTicks(5196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 98, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 842, DateTimeKind.Utc).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 96, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 842, DateTimeKind.Utc).AddTicks(6445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 96, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 840, DateTimeKind.Utc).AddTicks(3905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 90, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 840, DateTimeKind.Utc).AddTicks(3573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 90, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 838, DateTimeKind.Utc).AddTicks(7201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 86, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 830, DateTimeKind.Utc).AddTicks(1664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 72, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 124, DateTimeKind.Utc).AddTicks(5524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 858, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 124, DateTimeKind.Utc).AddTicks(4816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 858, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 120, DateTimeKind.Utc).AddTicks(9970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 856, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 120, DateTimeKind.Utc).AddTicks(8818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 855, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 119, DateTimeKind.Utc).AddTicks(1281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 854, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 119, DateTimeKind.Utc).AddTicks(143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 854, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 126, DateTimeKind.Utc).AddTicks(3400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 859, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 126, DateTimeKind.Utc).AddTicks(2176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 859, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 114, DateTimeKind.Utc).AddTicks(6403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 853, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 114, DateTimeKind.Utc).AddTicks(4354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 852, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 114, DateTimeKind.Utc).AddTicks(5961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 852, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 112, DateTimeKind.Utc).AddTicks(6280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 851, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 112, DateTimeKind.Utc).AddTicks(5342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 851, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 111, DateTimeKind.Utc).AddTicks(938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 850, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 111, DateTimeKind.Utc).AddTicks(69),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 850, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 108, DateTimeKind.Utc).AddTicks(2929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 848, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 108, DateTimeKind.Utc).AddTicks(2155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 848, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 109, DateTimeKind.Utc).AddTicks(6488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 849, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 109, DateTimeKind.Utc).AddTicks(5727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 849, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 106, DateTimeKind.Utc).AddTicks(504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 105, DateTimeKind.Utc).AddTicks(9516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 104, DateTimeKind.Utc).AddTicks(6449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 104, DateTimeKind.Utc).AddTicks(5563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 846, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 103, DateTimeKind.Utc).AddTicks(2356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 845, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.AlterColumn<int>(
                name: "OrderTypeId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 103, DateTimeKind.Utc).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 845, DateTimeKind.Utc).AddTicks(2580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 101, DateTimeKind.Utc).AddTicks(227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 844, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 100, DateTimeKind.Utc).AddTicks(9052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 844, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 93, DateTimeKind.Utc).AddTicks(9043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 841, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 93, DateTimeKind.Utc).AddTicks(4819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 841, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 98, DateTimeKind.Utc).AddTicks(2054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 843, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 98, DateTimeKind.Utc).AddTicks(725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 843, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 96, DateTimeKind.Utc).AddTicks(1785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 842, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 96, DateTimeKind.Utc).AddTicks(392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 842, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 90, DateTimeKind.Utc).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 840, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 90, DateTimeKind.Utc).AddTicks(4153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 840, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 86, DateTimeKind.Utc).AddTicks(9370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 838, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 4, 0, 48, 56, 72, DateTimeKind.Utc).AddTicks(9340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 17, 2, 10, 53, 830, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
