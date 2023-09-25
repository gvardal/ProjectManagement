using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagement_Api.Migrations
{
    /// <inheritdoc />
    public partial class EstimatedEndDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedEndDate",
                table: "KanbanCards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EstimatedEndDate", "Priority" },
                values: new object[] { null, "UnSet" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedEndDate",
                table: "KanbanCards");

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 20,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 21,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 22,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 23,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 24,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 25,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 26,
                column: "Priority",
                value: null);

            migrationBuilder.UpdateData(
                table: "KanbanCards",
                keyColumn: "Id",
                keyValue: 27,
                column: "Priority",
                value: null);
        }
    }
}
