using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMS.Data.Migrations
{
    public partial class AddedPriceColumnToFoodsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 406, DateTimeKind.Utc).AddTicks(2433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 406, DateTimeKind.Utc).AddTicks(1388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 399, DateTimeKind.Utc).AddTicks(4418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 399, DateTimeKind.Utc).AddTicks(3563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 397, DateTimeKind.Utc).AddTicks(8965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 397, DateTimeKind.Utc).AddTicks(7950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 408, DateTimeKind.Utc).AddTicks(2311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 408, DateTimeKind.Utc).AddTicks(1223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 395, DateTimeKind.Utc).AddTicks(2404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 394, DateTimeKind.Utc).AddTicks(9281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 395, DateTimeKind.Utc).AddTicks(1779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 391, DateTimeKind.Utc).AddTicks(9809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 391, DateTimeKind.Utc).AddTicks(8654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 389, DateTimeKind.Utc).AddTicks(8580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 389, DateTimeKind.Utc).AddTicks(7492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 384, DateTimeKind.Utc).AddTicks(5445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 384, DateTimeKind.Utc).AddTicks(4499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 387, DateTimeKind.Utc).AddTicks(8331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 387, DateTimeKind.Utc).AddTicks(6575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 381, DateTimeKind.Utc).AddTicks(8890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 381, DateTimeKind.Utc).AddTicks(7997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 380, DateTimeKind.Utc).AddTicks(3780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 380, DateTimeKind.Utc).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 378, DateTimeKind.Utc).AddTicks(9474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 378, DateTimeKind.Utc).AddTicks(8563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 377, DateTimeKind.Utc).AddTicks(1484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 377, DateTimeKind.Utc).AddTicks(436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 370, DateTimeKind.Utc).AddTicks(1765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 369, DateTimeKind.Utc).AddTicks(1527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Foods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 375, DateTimeKind.Utc).AddTicks(3190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 375, DateTimeKind.Utc).AddTicks(1752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 373, DateTimeKind.Utc).AddTicks(6657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 373, DateTimeKind.Utc).AddTicks(5666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 366, DateTimeKind.Utc).AddTicks(7926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 366, DateTimeKind.Utc).AddTicks(7216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 363, DateTimeKind.Utc).AddTicks(2217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 91, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 343, DateTimeKind.Utc).AddTicks(230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 83, DateTimeKind.Utc).AddTicks(2529));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Foods");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(9165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 406, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 406, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 399, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 399, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(4178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 397, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 397, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 408, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(5997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 408, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 395, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 394, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 395, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 391, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 391, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 389, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 389, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(8150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 384, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(7805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 384, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 387, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 387, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 381, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 381, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 380, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 380, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(1215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 378, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 378, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(3018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 377, DateTimeKind.Utc).AddTicks(1484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(2682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 377, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(9818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 370, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(8977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 369, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 375, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(5728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 375, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 373, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 373, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 366, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 366, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 91, DateTimeKind.Utc).AddTicks(3059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 363, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 83, DateTimeKind.Utc).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 29, 33, 343, DateTimeKind.Utc).AddTicks(230));
        }
    }
}
