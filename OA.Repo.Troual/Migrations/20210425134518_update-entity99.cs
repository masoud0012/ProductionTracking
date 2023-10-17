using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Troual.Migrations
{
    public partial class updateentity99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Replace",
                table: "WastageEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UnitMeaurementFK_ID",
                table: "WastageEntity",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 383, DateTimeKind.Local).AddTicks(4396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 258, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 392, DateTimeKind.Local).AddTicks(2294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 270, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 341, DateTimeKind.Local).AddTicks(6889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 217, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 388, DateTimeKind.Local).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 265, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 387, DateTimeKind.Local).AddTicks(5188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 264, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 396, DateTimeKind.Local).AddTicks(2689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 274, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 326, DateTimeKind.Local).AddTicks(995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 202, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 385, DateTimeKind.Local).AddTicks(6174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 261, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 398, DateTimeKind.Local).AddTicks(2385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 276, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 408, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 409, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 410, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 412, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 413, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 415, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 415, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 416, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 417, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 417, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 417, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 417, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 417, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 417, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 418, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 418, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 418, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 418, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 418, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 418, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 418, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 419, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 414, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 420, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 420, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 403, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 404, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 404, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 404, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 406, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 407, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 407, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 407, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 407, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 6, 45, 15, 407, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.CreateIndex(
                name: "IX_WastageEntity_UnitMeaurementFK_ID",
                table: "WastageEntity",
                column: "UnitMeaurementFK_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_WastageEntity_GeneralParameters_UnitMeaurementFK_ID",
                table: "WastageEntity",
                column: "UnitMeaurementFK_ID",
                principalTable: "GeneralParameters",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WastageEntity_GeneralParameters_UnitMeaurementFK_ID",
                table: "WastageEntity");

            migrationBuilder.DropIndex(
                name: "IX_WastageEntity_UnitMeaurementFK_ID",
                table: "WastageEntity");

            migrationBuilder.DropColumn(
                name: "Replace",
                table: "WastageEntity");

            migrationBuilder.DropColumn(
                name: "UnitMeaurementFK_ID",
                table: "WastageEntity");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 258, DateTimeKind.Local).AddTicks(215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 383, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 270, DateTimeKind.Local).AddTicks(3738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 392, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 217, DateTimeKind.Local).AddTicks(3876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 341, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 265, DateTimeKind.Local).AddTicks(7349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 388, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 264, DateTimeKind.Local).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 387, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 274, DateTimeKind.Local).AddTicks(2604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 396, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 202, DateTimeKind.Local).AddTicks(5691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 326, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 261, DateTimeKind.Local).AddTicks(5075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 385, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 276, DateTimeKind.Local).AddTicks(2519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 6, 45, 15, 398, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 287, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 288, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 288, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 288, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 288, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 288, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 289, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 290, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 290, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 290, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 290, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 290, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 290, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 290, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 291, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 291, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 291, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 291, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 291, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 291, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 291, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 291, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 292, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 295, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 296, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 296, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 296, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 296, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 296, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 296, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 297, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 297, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 297, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 297, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 297, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 297, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 297, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 298, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 298, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 298, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 298, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 299, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 299, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 299, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 299, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 299, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 294, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 299, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 299, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 281, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 283, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 283, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 283, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 39, 55, 285, DateTimeKind.Local).AddTicks(5834));
        }
    }
}
