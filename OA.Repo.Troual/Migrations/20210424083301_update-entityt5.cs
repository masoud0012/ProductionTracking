using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Troual.Migrations
{
    public partial class updateentityt5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 243, DateTimeKind.Local).AddTicks(4163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 690, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.AlterColumn<decimal>(
                name: "WeightInCalculation",
                table: "JobEntities",
                type: "decimal(7,5)",
                precision: 7,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,5)",
                oldPrecision: 5,
                oldScale: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "WeighProductInCalculation",
                table: "JobEntities",
                type: "decimal(7,5)",
                precision: 7,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,5)",
                oldPrecision: 5,
                oldScale: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 255, DateTimeKind.Local).AddTicks(8862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 704, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.AlterColumn<decimal>(
                name: "WeighProductInCalculation",
                table: "InitialBalanceEntities",
                type: "decimal(7,5)",
                precision: 7,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 207, DateTimeKind.Local).AddTicks(9276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 648, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 251, DateTimeKind.Local).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 698, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 249, DateTimeKind.Local).AddTicks(4770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 696, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 258, DateTimeKind.Local).AddTicks(7626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 708, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 192, DateTimeKind.Local).AddTicks(606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 632, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 247, DateTimeKind.Local).AddTicks(1969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 694, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 260, DateTimeKind.Local).AddTicks(3181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 710, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 269, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 270, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 271, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 272, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 272, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 272, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 272, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 272, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 272, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 272, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 273, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 273, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 273, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 273, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 273, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 273, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 273, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 273, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 274, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 276, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 276, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 277, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 278, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 278, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 278, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 278, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 278, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 278, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 278, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 279, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 279, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 279, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 279, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 280, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 280, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 280, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 280, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 280, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 275, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 281, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 281, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 264, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 265, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 265, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 265, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 24, 1, 32, 58, 267, DateTimeKind.Local).AddTicks(9184));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 690, DateTimeKind.Local).AddTicks(9485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 243, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.AlterColumn<decimal>(
                name: "WeightInCalculation",
                table: "JobEntities",
                type: "decimal(5,5)",
                precision: 5,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,5)",
                oldPrecision: 7,
                oldScale: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "WeighProductInCalculation",
                table: "JobEntities",
                type: "decimal(5,5)",
                precision: 5,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,5)",
                oldPrecision: 7,
                oldScale: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 704, DateTimeKind.Local).AddTicks(800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 255, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.AlterColumn<decimal>(
                name: "WeighProductInCalculation",
                table: "InitialBalanceEntities",
                type: "decimal(5,2)",
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,5)",
                oldPrecision: 7,
                oldScale: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 648, DateTimeKind.Local).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 207, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 698, DateTimeKind.Local).AddTicks(72),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 251, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 696, DateTimeKind.Local).AddTicks(7175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 249, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 708, DateTimeKind.Local).AddTicks(1811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 258, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 632, DateTimeKind.Local).AddTicks(2702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 192, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 694, DateTimeKind.Local).AddTicks(5285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 247, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 710, DateTimeKind.Local).AddTicks(4013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 260, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 721, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 722, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 723, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 724, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 724, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 724, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 724, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 724, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 724, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 724, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 724, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 725, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 728, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 729, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 729, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 729, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 729, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 729, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 729, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 730, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 731, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 731, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 731, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 731, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 731, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 727, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 731, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 731, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 715, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 716, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 716, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 716, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 718, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 719, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 719, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 719, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 719, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 719, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 55, 16, 719, DateTimeKind.Local).AddTicks(610));
        }
    }
}
