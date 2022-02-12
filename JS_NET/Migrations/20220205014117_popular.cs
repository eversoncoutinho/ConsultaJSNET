using Microsoft.EntityFrameworkCore.Migrations;

namespace JS_NET.Migrations
{
    public partial class popular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Clientes(email,telemovel,telefone,nascimento) " +
                "Values ('pedro@gmail.com',934925445,40151469,'1989/09/24')");
            migrationBuilder.Sql("Insert into Clientes(email,telemovel,telefone,nascimento) " +
                               "Values ('maria@gmail.com',934924445,13151469,'1981/09/27')");

            migrationBuilder.Sql("Insert into Clientes(email,telemovel,telefone,nascimento) " +
                               "Values ('joao@gmail.com',943928445,23151469,'1991/09/27')");

            migrationBuilder.Sql("Insert into Clientes(email,telemovel,telefone,nascimento) " +
                                           "Values ('manoel@gmail.com',934185445,38481469,'2001/09/27')");



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
