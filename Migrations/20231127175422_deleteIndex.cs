using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP4.Migrations
{
    /// <inheritdoc />
    public partial class deleteIndex : Migration
    {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropIndex(
				name: "IX_Customers_MembershipTypeId",
				table: "Customers");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateIndex(
				name: "IX_Customers_MembershipTypeId",
				table: "Customers",
				column: "MembershipTypeId",
				unique: true);
		}
	}
}
