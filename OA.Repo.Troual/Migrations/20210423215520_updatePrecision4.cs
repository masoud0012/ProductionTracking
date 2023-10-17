using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Troual.Migrations
{
    public partial class updatePrecision4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CostJobEntities",
                table: "CostJobEntities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 690, DateTimeKind.Local).AddTicks(9485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 907, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 704, DateTimeKind.Local).AddTicks(800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 922, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 648, DateTimeKind.Local).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 870, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "CostJobEntities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 698, DateTimeKind.Local).AddTicks(72),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 915, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 696, DateTimeKind.Local).AddTicks(7175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 913, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 708, DateTimeKind.Local).AddTicks(1811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 926, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 632, DateTimeKind.Local).AddTicks(2702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 855, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 694, DateTimeKind.Local).AddTicks(5285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 911, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 710, DateTimeKind.Local).AddTicks(4013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 927, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostJobEntities",
                table: "CostJobEntities",
                column: "ID");

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

            migrationBuilder.CreateIndex(
                name: "IX_CostJobEntities_CostEntityID",
                table: "CostJobEntities",
                column: "CostEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CostJobEntities",
                table: "CostJobEntities");

            migrationBuilder.DropIndex(
                name: "IX_CostJobEntities_CostEntityID",
                table: "CostJobEntities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 907, DateTimeKind.Local).AddTicks(8372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 690, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 922, DateTimeKind.Local).AddTicks(4564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 704, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 870, DateTimeKind.Local).AddTicks(2325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 648, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "CostJobEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 915, DateTimeKind.Local).AddTicks(8677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 698, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 913, DateTimeKind.Local).AddTicks(9414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 696, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 926, DateTimeKind.Local).AddTicks(254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 708, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 855, DateTimeKind.Local).AddTicks(7754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 632, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 911, DateTimeKind.Local).AddTicks(3496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 694, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 14, 50, 19, 927, DateTimeKind.Local).AddTicks(8319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 14, 55, 16, 710, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostJobEntities",
                table: "CostJobEntities",
                column: "CostEntityID");

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 936, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 937, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 938, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 939, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 941, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 942, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 943, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 943, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 943, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 943, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 943, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 940, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 943, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 943, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 932, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 933, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 933, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 933, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 23, 14, 50, 19, 935, DateTimeKind.Local).AddTicks(5906));
        }
    }
}
