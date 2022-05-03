using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMS.Data.Migrations
{
    public partial class ImageColumnAddToCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(9165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 802, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 802, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 801, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 801, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(4178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 800, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 800, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 803, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(5997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 803, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 799, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 799, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 799, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 798, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 798, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 797, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 797, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(8150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 795, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(7805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 795, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 796, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 796, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 794, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 794, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 793, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 793, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(1215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 793, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 793, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(3018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 792, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(2682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 792, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(9818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 789, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(8977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 789, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 791, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(5728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 791, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 790, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 790, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 788, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 788, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 91, DateTimeKind.Utc).AddTicks(3059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 786, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 83, DateTimeKind.Utc).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 779, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 802, DateTimeKind.Utc).AddTicks(5162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 802, DateTimeKind.Utc).AddTicks(4832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 801, DateTimeKind.Utc).AddTicks(579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 801, DateTimeKind.Utc).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 800, DateTimeKind.Utc).AddTicks(3343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 800, DateTimeKind.Utc).AddTicks(2985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 803, DateTimeKind.Utc).AddTicks(1706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 803, DateTimeKind.Utc).AddTicks(1370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 799, DateTimeKind.Utc).AddTicks(1606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 799, DateTimeKind.Utc).AddTicks(592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 799, DateTimeKind.Utc).AddTicks(1353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 798, DateTimeKind.Utc).AddTicks(365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 798, DateTimeKind.Utc).AddTicks(25),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 797, DateTimeKind.Utc).AddTicks(2791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 797, DateTimeKind.Utc).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 795, DateTimeKind.Utc).AddTicks(7837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 795, DateTimeKind.Utc).AddTicks(7480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 796, DateTimeKind.Utc).AddTicks(5690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 796, DateTimeKind.Utc).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 794, DateTimeKind.Utc).AddTicks(5406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 794, DateTimeKind.Utc).AddTicks(5063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 793, DateTimeKind.Utc).AddTicks(7724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 793, DateTimeKind.Utc).AddTicks(7390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 793, DateTimeKind.Utc).AddTicks(388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 793, DateTimeKind.Utc).AddTicks(25),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 792, DateTimeKind.Utc).AddTicks(858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 792, DateTimeKind.Utc).AddTicks(535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 789, DateTimeKind.Utc).AddTicks(7345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 789, DateTimeKind.Utc).AddTicks(6263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 791, DateTimeKind.Utc).AddTicks(3853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 791, DateTimeKind.Utc).AddTicks(3495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 790, DateTimeKind.Utc).AddTicks(6182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 790, DateTimeKind.Utc).AddTicks(5837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 788, DateTimeKind.Utc).AddTicks(1243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 788, DateTimeKind.Utc).AddTicks(945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 786, DateTimeKind.Utc).AddTicks(6967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 91, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 23, 56, 23, 779, DateTimeKind.Utc).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 83, DateTimeKind.Utc).AddTicks(2529));
        }
    }
}
