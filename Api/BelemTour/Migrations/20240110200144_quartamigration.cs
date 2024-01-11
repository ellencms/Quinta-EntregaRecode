using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelemTour.Migrations
{
    /// <inheritdoc />
    public partial class quartamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imagem",
                table: "destino",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 1,
                column: "imagem",
                value: "http://www.altaestacaoturismo.com.br/images/content/destinos/14-1.jpg");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 2,
                column: "imagem",
                value: "https://scontent.fsjk9-1.fna.fbcdn.net/v/t1.6435-9/37023389_1329318750504085_4156171523704487936_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=c2f564&_nc_ohc=Q3g9qmEooD4AX_vXbAf&_nc_ht=scontent.fsjk9-1.fna&oh=00_AfA-xe3b64XOLbrlCoscdctcAM2EQZIXjKj2U1Y73aZ0uw&oe=65C675E6");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 3,
                column: "imagem",
                value: "https://s2-g1.glbimg.com/8csOy6Wslb86EiUyE_oloIM5oOQ=/0x0:620x465/1008x0/smart/filters:strip_icc()/s.glbimg.com/jo/g1/f/original/2012/07/25/vistaaereapraia_da_princesa-henriquefelicio.jpg");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 4,
                column: "imagem",
                value: "https://www.ferias.tur.br/imgs/4682/maruda/g_maruda-pa-dsc_0080.jpg");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 5,
                column: "imagem",
                value: "https://scontent.fsjk9-1.fna.fbcdn.net/v/t39.30808-6/310595670_542403674555503_1563832596458789831_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=783fdb&_nc_ohc=bSXETuLcMNIAX-1Mhib&_nc_ht=scontent.fsjk9-1.fna&oh=00_AfDwTz-DNaBCcBSCeFCMtLGRzbZ62BdohuVXtM5yFtZ0eg&oe=65A4476F");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 6,
                column: "imagem",
                value: "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/06/0c/9a/58/praia-do-outeiro.jpg?w=900&h=600&s=1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagem",
                table: "destino");
        }
    }
}
