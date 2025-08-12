using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBlog.Migrations
{
    /// <inheritdoc />
    public partial class RemocaoColunaIncorretaComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_BlogPost_BlogPostId",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "BlogPostId",
                table: "Comment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_BlogPost_BlogPostId",
                table: "Comment",
                column: "BlogPostId",
                principalTable: "BlogPost",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_BlogPost_BlogPostId",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "BlogPostId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_BlogPost_BlogPostId",
                table: "Comment",
                column: "BlogPostId",
                principalTable: "BlogPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
