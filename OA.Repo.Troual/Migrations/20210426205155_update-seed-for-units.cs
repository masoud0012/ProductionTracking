using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Troual.Migrations
{
    public partial class updateseedforunits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 641, DateTimeKind.Local).AddTicks(7203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 140, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 652, DateTimeKind.Local).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 154, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 612, DateTimeKind.Local).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 81, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 648, DateTimeKind.Local).AddTicks(4975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 148, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 646, DateTimeKind.Local).AddTicks(9464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 146, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 655, DateTimeKind.Local).AddTicks(5625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 158, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 581, DateTimeKind.Local).AddTicks(9789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 64, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 644, DateTimeKind.Local).AddTicks(5703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 142, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 657, DateTimeKind.Local).AddTicks(3282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 161, DateTimeKind.Local).AddTicks(785));

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
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "EditUnits", new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9095), "ویرایش" });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "SearchUnits", new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9124), "جستجو" });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "RemoveByIdsUnits", new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9132), "حدف تکی" });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "RemoveByIdsUnits", new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9139), "حدف گروهی" });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "InsertUnits", new DateTime(2021, 4, 26, 13, 51, 52, 674, DateTimeKind.Local).AddTicks(9147), "افزودن" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "StockRoom_InitialBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 140, DateTimeKind.Local).AddTicks(5084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 641, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedDate",
                table: "JobEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 154, DateTimeKind.Local).AddTicks(3766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 652, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "InitialBalanceEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 81, DateTimeKind.Local).AddTicks(6571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 612, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 148, DateTimeKind.Local).AddTicks(3633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 648, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "CostCategoryEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 146, DateTimeKind.Local).AddTicks(3644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 646, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ControllerEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 158, DateTimeKind.Local).AddTicks(5867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 655, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 64, DateTimeKind.Local).AddTicks(3087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 581, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 142, DateTimeKind.Local).AddTicks(6743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 644, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "ActionsEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 13, 48, 52, 161, DateTimeKind.Local).AddTicks(785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 26, 13, 51, 52, 657, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 172, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 173, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 174, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 174, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 174, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 174, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 174, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 174, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 174, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 175, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 175, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 175, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 175, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 175, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 175, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 175, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 175, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 176, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 178, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 178, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 179, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 180, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 180, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 180, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 180, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 180, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 180, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 86L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 87L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 88L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 89L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 90L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 91L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 92L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 93L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 181, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 94L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 95L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 96L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 97L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 98L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "GetAll", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3957), null });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "GetChildsByParents", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3966), "دریافت مقادیر پایه" });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "Remove", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3970), "حذف تکی" });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "GetParentCodes", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3974), "دریافت مقادیر پدر" });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ActionName", "AddedDate", "TitleFr" },
                values: new object[] { "Edit", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3978), "ویرایش" });

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 213L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 214L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 215L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 216L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 177, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 217L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "ActionsEntities",
                keyColumn: "Id",
                keyValue: 218L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.InsertData(
                table: "ActionsEntities",
                columns: new[] { "Id", "ActionName", "AddedDate", "ControllerEntityID", "CreatedById", "IPAddress", "IsEnabled", "ModifiedById", "ModifiedDate", "TitleEn", "TitleFr" },
                values: new object[,]
                {
                    { 104L, "Search", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3986), 16L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 108L, "GetGeneralParameterByID", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(4002), 16L, 1L, null, true, 0L, null, null, null },
                    { 107L, "RemoveByIds", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3997), 16L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 106L, "Insert", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3993), 16L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 105L, "GetGeneralParamsByCode", new DateTime(2021, 4, 26, 13, 48, 52, 182, DateTimeKind.Local).AddTicks(3990), 16L, 1L, null, true, 0L, null, null, "دریافت بر اساس کد" }
                });

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 166, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 168, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 168, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 168, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 17L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 18L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 20L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 21L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "GeneralParameters",
                keyColumn: "Id",
                keyValue: 22L,
                column: "AddedDate",
                value: new DateTime(2021, 4, 26, 13, 48, 52, 170, DateTimeKind.Local).AddTicks(7607));
        }
    }
}
