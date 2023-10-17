using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Troual.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 917, DateTimeKind.Local).AddTicks(8259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 641, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 932, DateTimeKind.Local).AddTicks(1294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 652, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 868, DateTimeKind.Local).AddTicks(1387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 612, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 926, DateTimeKind.Local).AddTicks(150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 648, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 924, DateTimeKind.Local).AddTicks(7596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 646, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 935, DateTimeKind.Local).AddTicks(9202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 655, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 837, DateTimeKind.Local).AddTicks(3773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 581, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 922, DateTimeKind.Local).AddTicks(2532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 644, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 937, DateTimeKind.Local).AddTicks(7981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 657, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 945, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 946, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 947, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 947, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 947, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 947, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 947, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 947, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 947, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 948, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 948, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 948, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 948, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 948, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 948, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 948, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 948, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 949, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 951, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 952, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 953, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 953, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 953, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 953, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 953, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 99L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 954, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 100L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 954, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ActionName", "AddedDate" },
                values: new object[] { "RemoveUnits", new DateTime(2023, 10, 14, 16, 6, 28, 954, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 102L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 954, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 103L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 954, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 950, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 953, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 953, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 941, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 942, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 942, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 942, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2023, 10, 14, 16, 6, 28, 943, DateTimeKind.Local).AddTicks(8434));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 641, DateTimeKind.Local).AddTicks(7203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 917, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 652, DateTimeKind.Local).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 932, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 612, DateTimeKind.Local).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 868, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 648, DateTimeKind.Local).AddTicks(4975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 926, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 646, DateTimeKind.Local).AddTicks(9464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 924, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 655, DateTimeKind.Local).AddTicks(5625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 935, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 581, DateTimeKind.Local).AddTicks(9789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 837, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 644, DateTimeKind.Local).AddTicks(5703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 922, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 657, DateTimeKind.Local).AddTicks(3282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 16, 6, 28, 937, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 666, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 667, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 668, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 670, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 671, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 671, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 671, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 671, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 671, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 671, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 672, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 672, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 672, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 672, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 672, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 672, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 672, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 673, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 99L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 100L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ActionName", "AddedDate" },
                values: new object[] { "RemoveByIdsUnits", new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 102L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 103L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 669, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 662, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 663, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 663, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 663, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 51, 52, 664, DateTimeKind.Local).AddTicks(9165));
        }
    }
}
