using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joota.com.Migrations
{
    public partial class Order_And_OrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
            name: "ProfilePictureURL",
            table: "Shoes",
            type: "nvarchar(max)",
            defaultValue: "",
            oldClrType: typeof(string),
            oldType: "nvarchar(max)",
            oldNullable: true);


            migrationBuilder.AlterColumn<string>(
                name: "fullname",
                table: "Shoes",
                type:   "nvarchar(50)",
                maxLength: 50

                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
