using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrueHome.Migrations
{
    public partial class updateFormatValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Properties_PropertyId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Activity_ActivityId",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "Surveys",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Activity",
                type: "VARCHAR(35)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Property",
                type: "VARCHAR(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Property",
                type: "VARCHAR(35)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Property",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Property_PropertyId",
                table: "Activity",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Activity_ActivityId",
                table: "Surveys",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Property_PropertyId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Activity_ActivityId",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "Surveys",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Activity",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(35)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Properties",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Properties",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(35)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Properties",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Properties_PropertyId",
                table: "Activity",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Activity_ActivityId",
                table: "Surveys",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
