using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolMGT.Api.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateuseraccounttablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userAccounts_Student_StudentId",
                table: "userAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_userAccounts_Teacher_TeacherId",
                table: "userAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userAccounts",
                table: "userAccounts");

            migrationBuilder.RenameTable(
                name: "userAccounts",
                newName: "UserAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_userAccounts_TeacherId",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_userAccounts_StudentId",
                table: "UserAccounts",
                newName: "IX_UserAccounts_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_Student_StudentId",
                table: "UserAccounts",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_Teacher_TeacherId",
                table: "UserAccounts",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Student_StudentId",
                table: "UserAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Teacher_TeacherId",
                table: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                newName: "userAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TeacherId",
                table: "userAccounts",
                newName: "IX_userAccounts_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_StudentId",
                table: "userAccounts",
                newName: "IX_userAccounts_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userAccounts",
                table: "userAccounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userAccounts_Student_StudentId",
                table: "userAccounts",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userAccounts_Teacher_TeacherId",
                table: "userAccounts",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
