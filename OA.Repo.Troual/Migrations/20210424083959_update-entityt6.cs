using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Troual.Migrations
{
    public partial class updateentityt6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 258, DateTimeKind.Local).AddTicks(215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 243, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 270, DateTimeKind.Local).AddTicks(3738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 255, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.AlterColumn<decimal>(
                name: "WeightProductInCalculation",
                table: "InitialBalanceJobEntities",
                type: "decimal(7,5)",
                precision: 7,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,5)",
                oldPrecision: 5,
                oldScale: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 217, DateTimeKind.Local).AddTicks(3876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 207, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 265, DateTimeKind.Local).AddTicks(7349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 251, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 264, DateTimeKind.Local).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 249, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 274, DateTimeKind.Local).AddTicks(2604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 258, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 202, DateTimeKind.Local).AddTicks(5691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 192, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 261, DateTimeKind.Local).AddTicks(5075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 247, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 276, DateTimeKind.Local).AddTicks(2519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 260, DateTimeKind.Local).AddTicks(3181));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 243, DateTimeKind.Local).AddTicks(4163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 258, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 255, DateTimeKind.Local).AddTicks(8862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 270, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.AlterColumn<decimal>(
                name: "WeightProductInCalculation",
                table: "InitialBalanceJobEntities",
                type: "decimal(5,5)",
                precision: 5,
                scale: 5,
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
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 207, DateTimeKind.Local).AddTicks(9276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 217, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 251, DateTimeKind.Local).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 265, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 249, DateTimeKind.Local).AddTicks(4770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 264, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 258, DateTimeKind.Local).AddTicks(7626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 274, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 192, DateTimeKind.Local).AddTicks(606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 202, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 247, DateTimeKind.Local).AddTicks(1969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 261, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 1, 32, 58, 260, DateTimeKind.Local).AddTicks(3181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 24, 1, 39, 55, 276, DateTimeKind.Local).AddTicks(2519));

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
    }
}
