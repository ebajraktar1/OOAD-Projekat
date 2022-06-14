using Microsoft.EntityFrameworkCore.Migrations;

namespace SanZan.Data.Migrations
{
    public partial class MigracijaBezDodatnihKonstruktora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Lokacija_LokacijaId",
                table: "Korisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_ModeratorOglasi_Korisnik_IDModeratora",
                table: "ModeratorOglasi");

            migrationBuilder.DropForeignKey(
                name: "FK_ModeratorOglasi_Oglas_IDOglasa",
                table: "ModeratorOglasi");

            migrationBuilder.DropForeignKey(
                name: "FK_Oglas_Lokacija_LokacijaID",
                table: "Oglas");

            migrationBuilder.DropForeignKey(
                name: "FK_Poruka_Korisnik_PosiljaocIDKorisnika",
                table: "Poruka");

            migrationBuilder.DropForeignKey(
                name: "FK_Poruka_Korisnik_PrimaocIDKorisnika",
                table: "Poruka");

            migrationBuilder.DropForeignKey(
                name: "FK_Prijava_Korisnik_AdministratorIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropForeignKey(
                name: "FK_Prijava_Korisnik_PrijavljeniIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropForeignKey(
                name: "FK_Prijava_Korisnik_ZalbenikIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_Korisnik_DjelatnikIDKorisnika",
                table: "Recenzija");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_Korisnik_RecenzentIDKorisnika",
                table: "Recenzija");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistika_Korisnik_DjelatnikIDKorisnika",
                table: "Statistika");

            migrationBuilder.DropForeignKey(
                name: "FK_Zahtjev_Korisnik_IDKlijenta",
                table: "Zahtjev");

            migrationBuilder.DropForeignKey(
                name: "FK_Zahtjev_Lokacija_IDLokacija",
                table: "Zahtjev");

            migrationBuilder.DropIndex(
                name: "IX_Zahtjev_IDKlijenta",
                table: "Zahtjev");

            migrationBuilder.DropIndex(
                name: "IX_Zahtjev_IDLokacija",
                table: "Zahtjev");

            migrationBuilder.DropIndex(
                name: "IX_Statistika_DjelatnikIDKorisnika",
                table: "Statistika");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_DjelatnikIDKorisnika",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_RecenzentIDKorisnika",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Prijava_AdministratorIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropIndex(
                name: "IX_Prijava_PrijavljeniIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropIndex(
                name: "IX_Prijava_ZalbenikIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropIndex(
                name: "IX_Poruka_PosiljaocIDKorisnika",
                table: "Poruka");

            migrationBuilder.DropIndex(
                name: "IX_Poruka_PrimaocIDKorisnika",
                table: "Poruka");

            migrationBuilder.DropIndex(
                name: "IX_Oglas_LokacijaID",
                table: "Oglas");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_LokacijaId",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "DjelatnikIDKorisnika",
                table: "Statistika");

            migrationBuilder.DropColumn(
                name: "DjelatnikIDKorisnika",
                table: "Recenzija");

            migrationBuilder.DropColumn(
                name: "RecenzentIDKorisnika",
                table: "Recenzija");

            migrationBuilder.DropColumn(
                name: "AdministratorIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropColumn(
                name: "PrijavljeniIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropColumn(
                name: "ZalbenikIDKorisnika",
                table: "Prijava");

            migrationBuilder.DropColumn(
                name: "PosiljaocIDKorisnika",
                table: "Poruka");

            migrationBuilder.DropColumn(
                name: "PrimaocIDKorisnika",
                table: "Poruka");

            migrationBuilder.AlterColumn<int>(
                name: "IDLokacija",
                table: "Zahtjev",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IDOglasa",
                table: "ModeratorOglasi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IDModeratora",
                table: "ModeratorOglasi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ModeratorOglasi_Korisnik_IDModeratora",
                table: "ModeratorOglasi",
                column: "IDModeratora",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModeratorOglasi_Oglas_IDOglasa",
                table: "ModeratorOglasi",
                column: "IDOglasa",
                principalTable: "Oglas",
                principalColumn: "IDOglasa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModeratorOglasi_Korisnik_IDModeratora",
                table: "ModeratorOglasi");

            migrationBuilder.DropForeignKey(
                name: "FK_ModeratorOglasi_Oglas_IDOglasa",
                table: "ModeratorOglasi");

            migrationBuilder.AlterColumn<int>(
                name: "IDLokacija",
                table: "Zahtjev",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DjelatnikIDKorisnika",
                table: "Statistika",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DjelatnikIDKorisnika",
                table: "Recenzija",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecenzentIDKorisnika",
                table: "Recenzija",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorIDKorisnika",
                table: "Prijava",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrijavljeniIDKorisnika",
                table: "Prijava",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZalbenikIDKorisnika",
                table: "Prijava",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PosiljaocIDKorisnika",
                table: "Poruka",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimaocIDKorisnika",
                table: "Poruka",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IDOglasa",
                table: "ModeratorOglasi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IDModeratora",
                table: "ModeratorOglasi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_IDKlijenta",
                table: "Zahtjev",
                column: "IDKlijenta");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_IDLokacija",
                table: "Zahtjev",
                column: "IDLokacija");

            migrationBuilder.CreateIndex(
                name: "IX_Statistika_DjelatnikIDKorisnika",
                table: "Statistika",
                column: "DjelatnikIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_DjelatnikIDKorisnika",
                table: "Recenzija",
                column: "DjelatnikIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_RecenzentIDKorisnika",
                table: "Recenzija",
                column: "RecenzentIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_AdministratorIDKorisnika",
                table: "Prijava",
                column: "AdministratorIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_PrijavljeniIDKorisnika",
                table: "Prijava",
                column: "PrijavljeniIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_ZalbenikIDKorisnika",
                table: "Prijava",
                column: "ZalbenikIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_PosiljaocIDKorisnika",
                table: "Poruka",
                column: "PosiljaocIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_PrimaocIDKorisnika",
                table: "Poruka",
                column: "PrimaocIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Oglas_LokacijaID",
                table: "Oglas",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_LokacijaId",
                table: "Korisnik",
                column: "LokacijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Lokacija_LokacijaId",
                table: "Korisnik",
                column: "LokacijaId",
                principalTable: "Lokacija",
                principalColumn: "IDLokacije",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModeratorOglasi_Korisnik_IDModeratora",
                table: "ModeratorOglasi",
                column: "IDModeratora",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ModeratorOglasi_Oglas_IDOglasa",
                table: "ModeratorOglasi",
                column: "IDOglasa",
                principalTable: "Oglas",
                principalColumn: "IDOglasa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Oglas_Lokacija_LokacijaID",
                table: "Oglas",
                column: "LokacijaID",
                principalTable: "Lokacija",
                principalColumn: "IDLokacije",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Poruka_Korisnik_PosiljaocIDKorisnika",
                table: "Poruka",
                column: "PosiljaocIDKorisnika",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Poruka_Korisnik_PrimaocIDKorisnika",
                table: "Poruka",
                column: "PrimaocIDKorisnika",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prijava_Korisnik_AdministratorIDKorisnika",
                table: "Prijava",
                column: "AdministratorIDKorisnika",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prijava_Korisnik_PrijavljeniIDKorisnika",
                table: "Prijava",
                column: "PrijavljeniIDKorisnika",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prijava_Korisnik_ZalbenikIDKorisnika",
                table: "Prijava",
                column: "ZalbenikIDKorisnika",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_Korisnik_DjelatnikIDKorisnika",
                table: "Recenzija",
                column: "DjelatnikIDKorisnika",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_Korisnik_RecenzentIDKorisnika",
                table: "Recenzija",
                column: "RecenzentIDKorisnika",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statistika_Korisnik_DjelatnikIDKorisnika",
                table: "Statistika",
                column: "DjelatnikIDKorisnika",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zahtjev_Korisnik_IDKlijenta",
                table: "Zahtjev",
                column: "IDKlijenta",
                principalTable: "Korisnik",
                principalColumn: "IDKorisnika",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zahtjev_Lokacija_IDLokacija",
                table: "Zahtjev",
                column: "IDLokacija",
                principalTable: "Lokacija",
                principalColumn: "IDLokacije",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
