using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Troual.Migrations
{
    public partial class updateentities4456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 46, DateTimeKind.Local).AddTicks(5381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 263, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 65, DateTimeKind.Local).AddTicks(2488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 271, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 47, 990, DateTimeKind.Local).AddTicks(6186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 227, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPriceBalanceLastMonth",
                table: "InitialBalanceEntities",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 57, DateTimeKind.Local).AddTicks(7570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 268, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 55, DateTimeKind.Local).AddTicks(69),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 267, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 71, DateTimeKind.Local).AddTicks(1886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 274, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 47, 964, DateTimeKind.Local).AddTicks(1513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 216, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 51, DateTimeKind.Local).AddTicks(2231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 265, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 73, DateTimeKind.Local).AddTicks(4428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 275, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 88, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 89, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 90, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 91, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 93, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 95, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 95, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 95, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 95, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 95, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 95, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 96, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 96, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 96, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 96, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 96, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 96, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 96, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 97, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 97, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 97, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 97, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 99, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 99, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 99, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 99, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 99, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 92, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 100, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 100, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 79, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 82, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 82, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 82, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 85, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 10, 48, 86, DateTimeKind.Local).AddTicks(6915));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPriceBalanceLastMonth",
                table: "InitialBalanceEntities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 263, DateTimeKind.Local).AddTicks(7864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 46, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 271, DateTimeKind.Local).AddTicks(8608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 65, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 227, DateTimeKind.Local).AddTicks(5780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 47, 990, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 268, DateTimeKind.Local).AddTicks(6126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 57, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 267, DateTimeKind.Local).AddTicks(5499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 55, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 274, DateTimeKind.Local).AddTicks(3118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 71, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 216, DateTimeKind.Local).AddTicks(5826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 47, 964, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 265, DateTimeKind.Local).AddTicks(7789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 51, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 11, 49, 29, 275, DateTimeKind.Local).AddTicks(8514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 10, 48, 73, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 283, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 284, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 285, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 285, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 285, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 285, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 285, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 285, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 285, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 285, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 287, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 288, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 286, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 289, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 279, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 280, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 280, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 280, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 281, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 25, 11, 49, 29, 282, DateTimeKind.Local).AddTicks(1788));
        }
    }
}
