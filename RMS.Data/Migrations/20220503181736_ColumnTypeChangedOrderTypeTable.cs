using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMS.Data.Migrations
{
    public partial class ColumnTypeChangedOrderTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 740, DateTimeKind.Utc).AddTicks(5371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 740, DateTimeKind.Utc).AddTicks(5036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 739, DateTimeKind.Utc).AddTicks(930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 739, DateTimeKind.Utc).AddTicks(488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 738, DateTimeKind.Utc).AddTicks(1408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 738, DateTimeKind.Utc).AddTicks(314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 741, DateTimeKind.Utc).AddTicks(2235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 741, DateTimeKind.Utc).AddTicks(1884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 736, DateTimeKind.Utc).AddTicks(6622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 736, DateTimeKind.Utc).AddTicks(5501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 736, DateTimeKind.Utc).AddTicks(6349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 735, DateTimeKind.Utc).AddTicks(5095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 735, DateTimeKind.Utc).AddTicks(4733),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 734, DateTimeKind.Utc).AddTicks(6318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 734, DateTimeKind.Utc).AddTicks(5991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 733, DateTimeKind.Utc).AddTicks(1324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 733, DateTimeKind.Utc).AddTicks(966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 733, DateTimeKind.Utc).AddTicks(9169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 733, DateTimeKind.Utc).AddTicks(8811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 731, DateTimeKind.Utc).AddTicks(8775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 731, DateTimeKind.Utc).AddTicks(8395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 731, DateTimeKind.Utc).AddTicks(969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OrderTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 731, DateTimeKind.Utc).AddTicks(635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 730, DateTimeKind.Utc).AddTicks(3561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 730, DateTimeKind.Utc).AddTicks(3110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 729, DateTimeKind.Utc).AddTicks(4908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 729, DateTimeKind.Utc).AddTicks(4520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 726, DateTimeKind.Utc).AddTicks(9899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 726, DateTimeKind.Utc).AddTicks(9030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 728, DateTimeKind.Utc).AddTicks(6779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 728, DateTimeKind.Utc).AddTicks(6419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 727, DateTimeKind.Utc).AddTicks(8821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 727, DateTimeKind.Utc).AddTicks(8403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 725, DateTimeKind.Utc).AddTicks(7710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 725, DateTimeKind.Utc).AddTicks(7408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 724, DateTimeKind.Utc).AddTicks(2435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 91, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 716, DateTimeKind.Utc).AddTicks(340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 83, DateTimeKind.Utc).AddTicks(2529));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(9165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 740, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 106, DateTimeKind.Utc).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 740, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 739, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaffTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 105, DateTimeKind.Utc).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 739, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(4178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 738, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 104, DateTimeKind.Utc).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 738, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 741, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 107, DateTimeKind.Utc).AddTicks(5997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 741, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 736, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 736, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 103, DateTimeKind.Utc).AddTicks(1446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 736, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 735, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 102, DateTimeKind.Utc).AddTicks(209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 735, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 734, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 101, DateTimeKind.Utc).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 734, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(8150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 733, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 99, DateTimeKind.Utc).AddTicks(7805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 733, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 733, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductDepos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 100, DateTimeKind.Utc).AddTicks(5599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 733, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 731, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 98, DateTimeKind.Utc).AddTicks(5494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 731, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 731, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "OrderTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 731, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(1215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 730, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 97, DateTimeKind.Utc).AddTicks(862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 730, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(3018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 729, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 96, DateTimeKind.Utc).AddTicks(2682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 729, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(9818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 726, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 93, DateTimeKind.Utc).AddTicks(8977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 726, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 728, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 95, DateTimeKind.Utc).AddTicks(5728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 728, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 727, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 94, DateTimeKind.Utc).AddTicks(8017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 727, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 725, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Depos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 92, DateTimeKind.Utc).AddTicks(7603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 725, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 91, DateTimeKind.Utc).AddTicks(3059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 724, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 3, 21, 14, 26, 83, DateTimeKind.Utc).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 3, 22, 17, 35, 716, DateTimeKind.Utc).AddTicks(340));
        }
    }
}
