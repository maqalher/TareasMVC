using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS(Select Id from AspNetRoles where Id = '3c87c477-481b-45a0-b9d1-7c3a1084522b')
                BEGIN
                    INSERT AspNetRoles (Id, [Name], [NormalizedName])
                    VALUES ('3c87c477-481b-45a0-b9d1-7c3a1084522b', 'admin', 'ADMIN')
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles Where Id = '3c87c477-481b-45a0-b9d1-7c3a1084522b'");
        }
    }
}
