using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagement_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddKanbanCardColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "KanbanCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 20,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 21,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 22,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 23,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 24,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 25,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 26,
                column: "Color",
                value: "");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 27,
                column: "Color",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "KanbanCards");
        }
    }
}
