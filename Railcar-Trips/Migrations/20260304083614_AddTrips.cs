using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railcar_Trips.Migrations
{
    /// <inheritdoc />
    public partial class AddTrips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    OriginCityId = table.Column<int>(type: "int", nullable: true),
                    DestinationCityId = table.Column<int>(type: "int", nullable: true),
                    StartUTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndUTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTripHours = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
