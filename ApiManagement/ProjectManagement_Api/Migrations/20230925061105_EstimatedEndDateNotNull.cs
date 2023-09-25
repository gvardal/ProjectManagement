using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagement_Api.Migrations
{
    /// <inheritdoc />
    public partial class EstimatedEndDateNotNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EstimatedEndDate",
                table: "KanbanCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 20,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 21,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 22,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 23,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 24,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 25,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 26,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 27,
                column: "EstimatedEndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EstimatedEndDate",
                table: "KanbanCards",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 20,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 21,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 22,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 23,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 24,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 25,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 26,
                column: "EstimatedEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 27,
                column: "EstimatedEndDate",
                value: null);
        }
    }
}
