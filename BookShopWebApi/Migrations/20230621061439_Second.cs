using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "BookTable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTable", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookTable_ClientId",
                table: "BookTable",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTable_ClientTable_ClientId",
                table: "BookTable",
                column: "ClientId",
                principalTable: "ClientTable",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTable_ClientTable_ClientId",
                table: "BookTable");

            migrationBuilder.DropTable(
                name: "ClientTable");

            migrationBuilder.DropIndex(
                name: "IX_BookTable_ClientId",
                table: "BookTable");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "BookTable");
        }
    }
}
