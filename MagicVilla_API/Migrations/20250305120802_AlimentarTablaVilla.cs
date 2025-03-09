using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Descripcion de Villa Real", new DateTime(2025, 3, 5, 6, 8, 2, 704, DateTimeKind.Local).AddTicks(8867), new DateTime(2025, 3, 5, 6, 8, 2, 704, DateTimeKind.Local).AddTicks(8852), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Descripcion de Villa Real Piscina", new DateTime(2025, 3, 5, 6, 8, 2, 704, DateTimeKind.Local).AddTicks(8871), new DateTime(2025, 3, 5, 6, 8, 2, 704, DateTimeKind.Local).AddTicks(8870), "", 50, "Villa Real a la  Piscina", 5, 200.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
