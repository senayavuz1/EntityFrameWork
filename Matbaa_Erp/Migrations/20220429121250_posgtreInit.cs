using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Matbaa_Erp.Migrations
{
    public partial class posgtreInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_anilox",
                columns: table => new
                {
                    aniloxkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    linecm = table.Column<int>(type: "integer", nullable: false),
                    lineinch = table.Column<int>(type: "integer", nullable: false),
                    volume = table.Column<double>(type: "double precision", nullable: false),
                    boyaaktarimi = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_arac",
                columns: table => new
                {
                    aracid = table.Column<int>(type: "integer", nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    tonaj = table.Column<double>(type: "double precision", nullable: false),
                    kullanma = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bakim",
                columns: table => new
                {
                    bakimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_baski_tip",
                columns: table => new
                {
                    baskitipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    klisefiyat = table.Column<double>(type: "double precision", nullable: false),
                    klisedovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    klisefiyatbirim = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false, defaultValueSql: "('cm2')"),
                    boyayogunlugu = table.Column<double>(type: "double precision", nullable: false),
                    boyafiyat = table.Column<double>(type: "double precision", nullable: false),
                    boyadovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_baski_tip_detay",
                columns: table => new
                {
                    baskitipaltID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    baskitipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    mamultipkod = table.Column<int>(type: "integer", nullable: false),
                    azyogunluk = table.Column<double>(type: "double precision", nullable: false),
                    cokyogunluk = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bicak",
                columns: table => new
                {
                    bicakId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    bicakuzunkod = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    kisakod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    bicakno = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    arsivno = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    bicakyonu = table.Column<bool>(type: "boolean", nullable: false),
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    tekebadboy = table.Column<double>(type: "double precision", nullable: false),
                    tekebaden = table.Column<double>(type: "double precision", nullable: false),
                    aaadet = table.Column<short>(type: "smallint", nullable: false),
                    yyadet = table.Column<short>(type: "smallint", nullable: false),
                    radus = table.Column<float>(type: "real", nullable: false),
                    bicaktipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    aabosluk = table.Column<double>(type: "double precision", nullable: false),
                    yybosluk = table.Column<double>(type: "double precision", nullable: false),
                    yybitisikadet = table.Column<short>(type: "smallint", nullable: false),
                    ozelbilgi = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    bicakek = table.Column<short>(type: "smallint", nullable: false),
                    grafikonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    kullanimalanikod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    bicakiz = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    bicakiztarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    sabagkod = table.Column<string>(type: "character varying(13)", unicode: false, maxLength: 13, nullable: false, defaultValueSql: "('')"),
                    bicaksekilkod = table.Column<int>(type: "integer", nullable: false),
                    ds = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    yenibicak = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('Y')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bicak_disli",
                columns: table => new
                {
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    dislisayisi2 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    dislidegeri = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bicak_iz",
                columns: table => new
                {
                    bicakizId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bicakId = table.Column<long>(type: "bigint", nullable: false),
                    bicakiz = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    bicakiztarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bicak_makina",
                columns: table => new
                {
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bicak_sebep",
                columns: table => new
                {
                    bicaksebepkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bicak_sekil",
                columns: table => new
                {
                    bicaksekilkod = table.Column<int>(type: "integer", nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bicak_tip",
                columns: table => new
                {
                    bicaktipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    simge = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    dislivar = table.Column<bool>(type: "boolean", nullable: false),
                    dislisizvar = table.Column<bool>(type: "boolean", nullable: false),
                    yandondur = table.Column<bool>(type: "boolean", nullable: false),
                    dislidegeri = table.Column<double>(type: "double precision", nullable: false),
                    maksboy = table.Column<double>(type: "double precision", nullable: false),
                    minboy = table.Column<double>(type: "double precision", nullable: false),
                    maksen = table.Column<double>(type: "double precision", nullable: false),
                    minen = table.Column<double>(type: "double precision", nullable: false),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_bicak_yenileme",
                columns: table => new
                {
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    yenilemeno = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    serino = table.Column<string>(type: "text", nullable: false),
                    iptal = table.Column<bool>(type: "boolean", nullable: false),
                    durumkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    imaltarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    imhatarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    fiilitarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    bicaksebepkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    tursayisi = table.Column<int>(type: "integer", nullable: false),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    kullanimda = table.Column<bool>(type: "boolean", nullable: false),
                    sipariste = table.Column<bool>(type: "boolean", nullable: false),
                    sasiparisno = table.Column<int>(type: "integer", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_birim",
                columns: table => new
                {
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(25)", unicode: false, maxLength: 25, nullable: false),
                    birimtip = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    oran = table.Column<double>(type: "double precision", nullable: false),
                    simge = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    teklifbirimikullan = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    kodaciklamaing = table.Column<string>(type: "character varying(25)", unicode: false, maxLength: 25, nullable: false),
                    simgeing = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_boy_hesap",
                columns: table => new
                {
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    cekim = table.Column<short>(type: "smallint", nullable: true),
                    baskisaat = table.Column<float>(type: "real", nullable: true),
                    metredakika = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_carpan",
                columns: table => new
                {
                    carpan = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_degisen",
                columns: table => new
                {
                    degisenid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    bagla = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    degisenbolum = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    degisenalan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    degisenveri = table.Column<string>(type: "text", nullable: false),
                    yeniveri = table.Column<string>(type: "text", nullable: false),
                    desigtirenadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    degistirmetarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_depo",
                columns: table => new
                {
                    depokod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    durumu = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    depotipi = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    firmId = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_depo_firma",
                columns: table => new
                {
                    depokod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dilim",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    stokno = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    dilmeno = table.Column<string>(type: "character varying(12)", unicode: false, maxLength: 12, nullable: false),
                    eskimiktar1 = table.Column<double>(type: "double precision", nullable: false),
                    eskimiktar2 = table.Column<double>(type: "double precision", nullable: true),
                    miktar1 = table.Column<double>(type: "double precision", nullable: false),
                    miktar2 = table.Column<double>(type: "double precision", nullable: true),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    seviye = table.Column<byte>(type: "smallint", nullable: false),
                    dilmekod = table.Column<int>(type: "integer", nullable: false),
                    gideceksiparisno = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dilim_gecici",
                columns: table => new
                {
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    sira = table.Column<int>(type: "integer", nullable: false),
                    boy = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dilim_gecici1",
                columns: table => new
                {
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    sira = table.Column<int>(type: "integer", nullable: false),
                    en = table.Column<double>(type: "double precision", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dilim_kombine",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: true),
                    en = table.Column<float>(type: "real", nullable: true),
                    sutun = table.Column<byte>(type: "smallint", nullable: true),
                    aciklama = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_disli_hesap",
                columns: table => new
                {
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    dislisayisi2 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    dislisayisi3 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    aaadet = table.Column<short>(type: "smallint", nullable: false),
                    boy = table.Column<float>(type: "real", nullable: false),
                    cevre = table.Column<float>(type: "real", nullable: true),
                    dislidegeri = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dof",
                columns: table => new
                {
                    dofkod = table.Column<string>(type: "character varying(9)", unicode: false, maxLength: 9, nullable: false),
                    doftipi = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    dofno = table.Column<short>(type: "smallint", nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    dfof = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    miktar = table.Column<float>(type: "real", nullable: false),
                    irsaliyeno = table.Column<string>(type: "character varying(12)", unicode: false, maxLength: 12, nullable: false),
                    tanimi = table.Column<string>(type: "text", nullable: false),
                    hatanedenibildirim = table.Column<string>(type: "text", nullable: false),
                    hatanedeni = table.Column<string>(type: "text", nullable: false),
                    eylembildirim = table.Column<string>(type: "text", nullable: false),
                    eylem = table.Column<string>(type: "text", nullable: false),
                    eylemplanlama = table.Column<string>(type: "text", nullable: false),
                    sevktarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    raporno = table.Column<string>(type: "text", nullable: false),
                    acanpersonel = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    acankisi = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    acanbolum = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ilgilikisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ilgilibolum = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    kontrol_kapat = table.Column<bool>(type: "boolean", nullable: false),
                    kapattarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    kapatankisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    sonuc = table.Column<string>(type: "text", nullable: false),
                    dfgerekli = table.Column<bool>(type: "boolean", nullable: false),
                    dfno = table.Column<string>(type: "character varying(9)", unicode: false, maxLength: 9, nullable: false),
                    onayliyankisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    onaytarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dof_dagitim",
                columns: table => new
                {
                    dofkod = table.Column<string>(type: "character varying(9)", unicode: false, maxLength: 9, nullable: false),
                    dagitim = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: true),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dof_grup",
                columns: table => new
                {
                    dofkod = table.Column<string>(type: "character varying(9)", unicode: false, maxLength: 9, nullable: false),
                    personelgrupkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dof_personel",
                columns: table => new
                {
                    dofkod = table.Column<string>(type: "character varying(9)", unicode: false, maxLength: 9, nullable: false),
                    personel = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: true),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_dof_tip",
                columns: table => new
                {
                    dofkod = table.Column<string>(type: "character varying(9)", unicode: false, maxLength: 9, nullable: false),
                    tipkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    aciklama = table.Column<string>(type: "text", nullable: true),
                    nedeneylem = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_doviz",
                columns: table => new
                {
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    dovizaciklama = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    dovizsimge = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_doviz_kur",
                columns: table => new
                {
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    dovizalisf = table.Column<double>(type: "double precision", nullable: true),
                    dovizsatisf = table.Column<double>(type: "double precision", nullable: true),
                    efektifalisf1 = table.Column<double>(type: "double precision", nullable: true),
                    efektifsatisf1 = table.Column<double>(type: "double precision", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_durum",
                columns: table => new
                {
                    durumkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    kullanimda = table.Column<bool>(type: "boolean", nullable: true),
                    sipariste = table.Column<bool>(type: "boolean", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_durum_firma",
                columns: table => new
                {
                    durumfirmakod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(60)", unicode: false, maxLength: 60, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_durum_teklif",
                columns: table => new
                {
                    durumteklifkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_ekstragider_tip",
                columns: table => new
                {
                    ekstragiderkod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_fire_islem",
                columns: table => new
                {
                    urunfirekod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_fire_makina",
                columns: table => new
                {
                    urunfirekod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_firm",
                columns: table => new
                {
                    firmId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firmAd = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_firm", x => x.firmId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_firma_kontakt_cocuk",
                columns: table => new
                {
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    cocukadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    bilgi = table.Column<string>(type: "text", nullable: true),
                    hatirno = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_genel",
                columns: table => new
                {
                    genelkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_gerceklesen_satis",
                columns: table => new
                {
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ay = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    yil = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    gerceklesen = table.Column<double>(type: "double precision", nullable: false),
                    fatura = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_gider",
                columns: table => new
                {
                    giderkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_gorusme_teknik",
                columns: table => new
                {
                    teknikno = table.Column<int>(type: "integer", nullable: false),
                    urunadi = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    musterikod = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    nasilyapis = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    rulotabaka = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    iccap = table.Column<short>(type: "smallint", nullable: false),
                    discap = table.Column<short>(type: "smallint", nullable: false),
                    bobindeadet = table.Column<int>(type: "integer", nullable: false),
                    akisyonu = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    tekebadboy = table.Column<double>(type: "double precision", nullable: false),
                    tekebaden = table.Column<double>(type: "double precision", nullable: false),
                    aabosluk = table.Column<double>(type: "double precision", nullable: false),
                    tasiyicien = table.Column<double>(type: "double precision", nullable: false),
                    radus = table.Column<double>(type: "double precision", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    malzemeadi = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    yapiskan = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    yapiskanadi = table.Column<string>(type: "text", nullable: false),
                    baskili = table.Column<bool>(type: "boolean", nullable: false),
                    serigafi = table.Column<bool>(type: "boolean", nullable: false),
                    trignomi = table.Column<bool>(type: "boolean", nullable: false),
                    cifttaraf = table.Column<bool>(type: "boolean", nullable: false),
                    lak = table.Column<bool>(type: "boolean", nullable: false),
                    yuzey = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    aylikkulanim = table.Column<string>(type: "text", nullable: false),
                    ambalaj = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    koliadet = table.Column<string>(type: "text", nullable: false),
                    ambalajnot = table.Column<string>(type: "text", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false),
                    rafomru = table.Column<string>(type: "text", nullable: false),
                    degiskenbaski = table.Column<bool>(type: "boolean", nullable: false),
                    baskiadi = table.Column<string>(type: "text", nullable: false),
                    ozelsart = table.Column<string>(type: "text", nullable: false),
                    bicak = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_gorusme_tip",
                columns: table => new
                {
                    gorusmetipno = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    tipaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_grafik",
                columns: table => new
                {
                    grafikno = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    grafikadi = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    hat = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    isinsekli = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    baslatarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    bitistarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    aciklama = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    gecikme = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false, defaultValueSql: "('')"),
                    grafikdurumkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    netsure = table.Column<short>(type: "smallint", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    maliyetkodu = table.Column<long>(type: "bigint", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    montaj = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    takip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    sirala = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1000))"),
                    siralagrafiker = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1000))"),
                    akisyonu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    uygulamasekli = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    gelenorjinal = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_grafik_durum",
                columns: table => new
                {
                    grafikdurumkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(64)", unicode: false, maxLength: 64, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_grafik_islem",
                columns: table => new
                {
                    grafikislemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(64)", unicode: false, maxLength: 64, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_grafik_onay",
                columns: table => new
                {
                    grafno = table.Column<long>(type: "bigint", nullable: false),
                    grafikno = table.Column<long>(type: "bigint", nullable: false),
                    gidistarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    gelistarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    grafikislemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    aciklama = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_grup",
                columns: table => new
                {
                    grupkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    grupad = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_hareket_tip",
                columns: table => new
                {
                    harekettipkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    hareketsekli = table.Column<bool>(type: "boolean", nullable: true),
                    siparis = table.Column<bool>(type: "boolean", nullable: true),
                    dis = table.Column<bool>(type: "boolean", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_hatirlama",
                columns: table => new
                {
                    hatirid = table.Column<long>(type: "bigint", nullable: false),
                    hatirno = table.Column<long>(type: "bigint", nullable: false),
                    gorid = table.Column<long>(type: "bigint", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: true),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: true),
                    kisinin = table.Column<bool>(type: "boolean", nullable: true),
                    cocuk = table.Column<bool>(type: "boolean", nullable: true),
                    hatirlama = table.Column<string>(type: "character varying(64)", unicode: false, maxLength: 64, nullable: true),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    siklik = table.Column<short>(type: "smallint", nullable: true),
                    siklikadi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    gun = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    hafta = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: true),
                    ay = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    ucay = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    altiay = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    yil = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: true),
                    iptal = table.Column<bool>(type: "boolean", nullable: true),
                    aciklama = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_hatirlama_personel",
                columns: table => new
                {
                    hatirno = table.Column<int>(type: "integer", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_hedef_satis",
                columns: table => new
                {
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ay = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    yil = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: true),
                    hedef = table.Column<float>(type: "real", nullable: true),
                    personelkodu = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_il",
                columns: table => new
                {
                    ulkekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ilkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ilad = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_il_ilce",
                columns: table => new
                {
                    ulkekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ilkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ilcekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ilcead = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_imalatci",
                columns: table => new
                {
                    imalatcikod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_islem",
                columns: table => new
                {
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    islemtipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    baskitipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    bicaktipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fiyatbirim = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    yaldiz = table.Column<bool>(type: "boolean", nullable: false),
                    yaldizbaski = table.Column<bool>(type: "boolean", nullable: false),
                    bilgi = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    minalan = table.Column<double>(type: "double precision", nullable: false),
                    maksalan = table.Column<double>(type: "double precision", nullable: false),
                    teklifteyaz = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    islemaktif = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('A')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_islem_tip",
                columns: table => new
                {
                    islemtipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    maliyetsorgu = table.Column<bool>(type: "boolean", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_kalite_ilk",
                columns: table => new
                {
                    kaliteilkid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    teslimno = table.Column<long>(type: "bigint", nullable: false),
                    ambalajbutunluk = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    sevkaraci = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    paletuygunluk = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    etiketkontrolu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    bobinsarimyonu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    korona = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    yapisma = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    cekmekontrolu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    olcukontrolu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    analizsertifikasi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    mikronkontolu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    kabuldurumu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('K')"),
                    kontoleden = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    onayliyan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_kalite_son",
                columns: table => new
                {
                    kalitesonno = table.Column<int>(type: "integer", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: true),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    miktar = table.Column<float>(type: "real", nullable: true),
                    irsaliyeno = table.Column<string>(type: "character varying(12)", unicode: false, maxLength: 12, nullable: true),
                    sano = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    urunrulo = table.Column<int>(type: "integer", nullable: true),
                    urunbirim = table.Column<int>(type: "integer", nullable: true),
                    ornekrulo = table.Column<int>(type: "integer", nullable: true),
                    ornekbirim = table.Column<int>(type: "integer", nullable: true),
                    kabul = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: true),
                    dusunceler = table.Column<string>(type: "text", nullable: true),
                    sonuc0 = table.Column<string>(type: "text", nullable: true),
                    sonuc1 = table.Column<string>(type: "text", nullable: true),
                    sonuc2 = table.Column<string>(type: "text", nullable: true),
                    sonuc3 = table.Column<string>(type: "text", nullable: true),
                    sonuc4 = table.Column<string>(type: "text", nullable: true),
                    sonuc5 = table.Column<string>(type: "text", nullable: true),
                    sonuc6 = table.Column<string>(type: "text", nullable: true),
                    sonuc7 = table.Column<string>(type: "text", nullable: true),
                    sonuc8 = table.Column<string>(type: "text", nullable: true),
                    sonuc9 = table.Column<string>(type: "text", nullable: true),
                    sonuc10 = table.Column<string>(type: "text", nullable: true),
                    sonuc11 = table.Column<string>(type: "text", nullable: true),
                    sonuc12 = table.Column<string>(type: "text", nullable: true),
                    sonuc13 = table.Column<string>(type: "text", nullable: true),
                    sonuc14 = table.Column<string>(type: "text", nullable: true),
                    sonuc15 = table.Column<string>(type: "text", nullable: true),
                    aql0 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql1 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql2 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql3 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql4 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql5 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql6 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql7 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql8 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql9 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql10 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql11 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql12 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql13 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql14 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    aql15 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    kritik = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    minor = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    major = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    aqlkritik = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    aqlminor = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    aqlmajor = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    standart0 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    standart1 = table.Column<float>(type: "real", nullable: true),
                    standart2 = table.Column<float>(type: "real", nullable: true),
                    standart3 = table.Column<float>(type: "real", nullable: true),
                    standart4 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    standart5 = table.Column<float>(type: "real", nullable: true),
                    standart6 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    standart7 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    standart8 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    standart9 = table.Column<float>(type: "real", nullable: true),
                    bulgu0 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    bulgu1 = table.Column<float>(type: "real", nullable: true),
                    bulgu2 = table.Column<float>(type: "real", nullable: true),
                    bulgu3 = table.Column<float>(type: "real", nullable: true),
                    bulgu4 = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    bulgu5 = table.Column<float>(type: "real", nullable: true),
                    bulgu6 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    bulgu7 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    bulgu8 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    bulgu9 = table.Column<float>(type: "real", nullable: true),
                    renk0 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    renk1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    renk2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    renk3 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    renk4 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    renk5 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    renk6 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    renk7 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    musteripartino = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    paketleme = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise",
                columns: table => new
                {
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    kliseadi = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    arsivno = table.Column<int>(type: "integer", nullable: false),
                    ozelbilgi = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    grafikonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    onaykisi = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    tram = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_alt",
                columns: table => new
                {
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    no = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    revizyonkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    baskitipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    klisetipkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    aaadet = table.Column<short>(type: "smallint", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_ebad",
                columns: table => new
                {
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    calismano = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    calismatarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    tekebadboy = table.Column<double>(type: "double precision", nullable: true),
                    tekebaden = table.Column<double>(type: "double precision", nullable: true),
                    aaadet = table.Column<short>(type: "smallint", nullable: true),
                    yyadet = table.Column<short>(type: "smallint", nullable: true),
                    aabosluk = table.Column<double>(type: "double precision", nullable: true),
                    yybosluk = table.Column<double>(type: "double precision", nullable: true),
                    yybitisikadet = table.Column<short>(type: "smallint", nullable: true),
                    malzemekod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: true),
                    alan = table.Column<double>(type: "double precision", nullable: true),
                    aciklama = table.Column<string>(type: "text", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_film",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    revizyonkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    siparismiktar = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    siparistarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    siparisbirim = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: true),
                    siparisfiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: true),
                    ozelbilgi = table.Column<string>(type: "text", nullable: true),
                    bicakfiyat = table.Column<double>(type: "double precision", nullable: true),
                    bdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    klisefiyat = table.Column<double>(type: "double precision", nullable: true),
                    kdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    kliseadet = table.Column<short>(type: "smallint", nullable: true),
                    bfaturaet = table.Column<bool>(type: "boolean", nullable: true),
                    kfaturaet = table.Column<bool>(type: "boolean", nullable: true),
                    kontrol_kapat = table.Column<bool>(type: "boolean", nullable: true),
                    kapattarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    kontrol_depo = table.Column<bool>(type: "boolean", nullable: true),
                    toplamalan = table.Column<double>(type: "double precision", nullable: true),
                    toplamagirlik = table.Column<double>(type: "double precision", nullable: true),
                    toplamadet = table.Column<double>(type: "double precision", nullable: true),
                    toplamteslimmiktar = table.Column<double>(type: "double precision", nullable: true),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    imalattakip = table.Column<bool>(type: "boolean", nullable: true),
                    tramyogunlugu = table.Column<int>(type: "integer", nullable: true),
                    malzemetutar = table.Column<double>(type: "double precision", nullable: true),
                    makinatutar = table.Column<double>(type: "double precision", nullable: true),
                    genelgidertutar = table.Column<double>(type: "double precision", nullable: true),
                    ekstragidertutar = table.Column<double>(type: "double precision", nullable: true),
                    toplamteslim = table.Column<double>(type: "double precision", nullable: true),
                    muhtemeltarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    planlanantarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    depodan = table.Column<bool>(type: "boolean", nullable: true),
                    ilkdefa = table.Column<bool>(type: "boolean", nullable: true),
                    ilkdefauy = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    revizyonvar = table.Column<bool>(type: "boolean", nullable: true),
                    eskifilmat = table.Column<bool>(type: "boolean", nullable: true),
                    revizyonfilmdegil = table.Column<bool>(type: "boolean", nullable: true),
                    revizyonnot = table.Column<string>(type: "text", nullable: true),
                    irsaliyenot = table.Column<string>(type: "text", nullable: true),
                    faturanot = table.Column<string>(type: "text", nullable: true),
                    musterisano = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: true),
                    onayadres = table.Column<string>(type: "text", nullable: true),
                    oncekilot = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: true),
                    iptal = table.Column<bool>(type: "boolean", nullable: true),
                    prova = table.Column<bool>(type: "boolean", nullable: true),
                    globalfiyat = table.Column<float>(type: "real", nullable: true),
                    yeniurun = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: true),
                    urunacildi = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: true),
                    satistltutar = table.Column<double>(type: "double precision", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek5 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek6 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek7 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek8 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek9 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_gonderme",
                columns: table => new
                {
                    klisegondermekod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_pantone",
                columns: table => new
                {
                    klisepantoneid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    sonno = table.Column<int>(type: "integer", nullable: false),
                    pantoneno = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    kliseuyumkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    formul = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    aniloxkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_revizyon",
                columns: table => new
                {
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    revizyonkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kliserevizyonsebepkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_revizyon_sebep",
                columns: table => new
                {
                    kliserevizyonsebepkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_sabagkod",
                columns: table => new
                {
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    sabagkod = table.Column<string>(type: "character varying(13)", unicode: false, maxLength: 13, nullable: false),
                    klisetipkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_saklama",
                columns: table => new
                {
                    klisesaklamakod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_sebep",
                columns: table => new
                {
                    klisesebepkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_takim",
                columns: table => new
                {
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    takimkod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    takimno = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    takimadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_tip",
                columns: table => new
                {
                    klisetipkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    sabagkod = table.Column<string>(type: "character varying(13)", unicode: false, maxLength: 13, nullable: true),
                    fiyatmaliyet = table.Column<float>(type: "real", nullable: true),
                    baskitipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_uyum",
                columns: table => new
                {
                    kliseuyumkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_klise_yenileme",
                columns: table => new
                {
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    yenilemeno = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    klisetipkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    imaltarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    iptal = table.Column<bool>(type: "boolean", nullable: false),
                    imhatarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    tursayisi = table.Column<int>(type: "integer", nullable: false),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    birimfiyat = table.Column<double>(type: "double precision", nullable: false),
                    birimdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('002')"),
                    klisesebepkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    durumkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    sipariste = table.Column<bool>(type: "boolean", nullable: false),
                    kullanimda = table.Column<bool>(type: "boolean", nullable: false),
                    imhasebepkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    isteyen = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    sebepkisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    siparisno = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    miktar1 = table.Column<double>(type: "double precision", nullable: false),
                    miktar2 = table.Column<double>(type: "double precision", nullable: false),
                    netmiktar = table.Column<double>(type: "double precision", nullable: false),
                    said = table.Column<long>(type: "bigint", nullable: false),
                    sasiparisno = table.Column<int>(type: "integer", nullable: false),
                    sira = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    klisetakip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    teslimalan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    teslimtarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    gondertarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    uretimyeri = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    cekirdekvar = table.Column<bool>(type: "boolean", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_konsinye",
                columns: table => new
                {
                    konsinyeno = table.Column<int>(type: "integer", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: true),
                    sevkiyatno = table.Column<int>(type: "integer", nullable: true),
                    irsaliyeno = table.Column<string>(type: "character varying(12)", unicode: false, maxLength: 12, nullable: true),
                    koliadet = table.Column<int>(type: "integer", nullable: true),
                    ruloadet = table.Column<int>(type: "integer", nullable: true),
                    urunadet = table.Column<string>(type: "text", nullable: true),
                    toplamadet = table.Column<double>(type: "double precision", nullable: true),
                    sevkfiyat = table.Column<double>(type: "double precision", nullable: true),
                    faturano = table.Column<string>(type: "character varying(12)", unicode: false, maxLength: 12, nullable: true),
                    faturakoliadet = table.Column<int>(type: "integer", nullable: true),
                    faturaruloadet = table.Column<int>(type: "integer", nullable: true),
                    faturaurunadet = table.Column<string>(type: "text", nullable: true),
                    faturatoplamadet = table.Column<double>(type: "double precision", nullable: true),
                    faturafiyat = table.Column<double>(type: "double precision", nullable: true),
                    faturadovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    nettoplamadet = table.Column<double>(type: "double precision", nullable: true),
                    iadeadet = table.Column<double>(type: "double precision", nullable: true),
                    geriiadeadet = table.Column<double>(type: "double precision", nullable: true),
                    iadeirsaliyeno = table.Column<string>(type: "character varying(12)", unicode: false, maxLength: 12, nullable: true),
                    sikayetno = table.Column<int>(type: "integer", nullable: true),
                    iadenot = table.Column<string>(type: "text", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_kullanimalani",
                columns: table => new
                {
                    kullanimalanikod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_bakim",
                columns: table => new
                {
                    bakimno = table.Column<int>(type: "integer", nullable: false),
                    bakimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    talepeden = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    saat = table.Column<DateTime>(type: "datetime", nullable: true),
                    baslatarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    baslasaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    bitistarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    bitissaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    aciliyet = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    durumu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    uretimdurdu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    arizatanimi = table.Column<string>(type: "text", nullable: false),
                    bakimtanimi = table.Column<string>(type: "text", nullable: false),
                    hareketno = table.Column<int>(type: "integer", nullable: false),
                    sonuc = table.Column<string>(type: "text", nullable: false),
                    bakimiyapan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    sure = table.Column<short>(type: "smallint", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_bakim_hareket",
                columns: table => new
                {
                    bakimhareketno = table.Column<int>(type: "integer", nullable: false),
                    bakimno = table.Column<int>(type: "integer", nullable: false),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    miktar = table.Column<double>(type: "double precision", nullable: false),
                    fiyat = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_bicaktip",
                columns: table => new
                {
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    bicaktipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_birim",
                columns: table => new
                {
                    makinabirimkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    birimadi = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_bol",
                columns: table => new
                {
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    bol = table.Column<short>(type: "smallint", nullable: true),
                    cekim = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_calisma",
                columns: table => new
                {
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    calisiyor = table.Column<bool>(type: "boolean", nullable: true),
                    baslamasaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    bitissaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_calisma_hafta",
                columns: table => new
                {
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    gun = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    calisiyor = table.Column<bool>(type: "boolean", nullable: true),
                    baslamasaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    bitissaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_disli",
                columns: table => new
                {
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    dislisayisi2 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    dislisayisi3 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    dislidegeri = table.Column<float>(type: "real", nullable: false),
                    islemunitesayisi = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    manyetiken = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_gider",
                columns: table => new
                {
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    genelgiderpayi = table.Column<double>(type: "double precision", nullable: true),
                    iscilikgideri = table.Column<double>(type: "double precision", nullable: true),
                    elektrikgideri = table.Column<double>(type: "double precision", nullable: true),
                    gidergrupkod = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_gider_grup",
                columns: table => new
                {
                    gidergrupkod = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_grup",
                columns: table => new
                {
                    makinagrupkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    firmId = table.Column<short>(type: "smallint", nullable: false),
                    kalipbilgi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    tanimsira = table.Column<short>(type: "smallint", nullable: false),
                    adetforma = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    uretimdeTakipEt = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_islem",
                columns: table => new
                {
                    makinaislemkod = table.Column<int>(type: "integer", nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    iptal = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    elisciligi = table.Column<bool>(type: "boolean", nullable: false),
                    fason = table.Column<bool>(type: "boolean", nullable: false),
                    islemtipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ortsetupdakika = table.Column<short>(type: "smallint", nullable: false),
                    ortsaatehiz = table.Column<double>(type: "double precision", nullable: false),
                    makinabirimkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    setupfire = table.Column<double>(type: "double precision", nullable: false),
                    yuzdefire = table.Column<double>(type: "double precision", nullable: false),
                    maksen = table.Column<double>(type: "double precision", nullable: false),
                    maksboy = table.Column<double>(type: "double precision", nullable: false),
                    minen = table.Column<double>(type: "double precision", nullable: false),
                    minboy = table.Column<double>(type: "double precision", nullable: false),
                    islemunitesayisi = table.Column<short>(type: "smallint", nullable: false),
                    dislivar = table.Column<bool>(type: "boolean", nullable: false),
                    dislisizvar = table.Column<bool>(type: "boolean", nullable: false),
                    yandondur = table.Column<bool>(type: "boolean", nullable: false),
                    semirot = table.Column<bool>(type: "boolean", nullable: false),
                    dislidegeri = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "('')"),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fiyatbirim = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    bicaktipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    baskitipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    kesim = table.Column<int>(type: "integer", nullable: false),
                    bol = table.Column<bool>(type: "boolean", nullable: false),
                    baski = table.Column<bool>(type: "boolean", nullable: false),
                    setupfiyat = table.Column<double>(type: "double precision", nullable: false),
                    setupdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    urunyyadetorani = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "((1))"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_islem_urun",
                columns: table => new
                {
                    makinaislemkod = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    enibelli = table.Column<bool>(type: "boolean", nullable: false),
                    boyubelli = table.Column<bool>(type: "boolean", nullable: false),
                    enibelirsiz = table.Column<bool>(type: "boolean", nullable: false),
                    boyubelirsiz = table.Column<bool>(type: "boolean", nullable: false),
                    artien = table.Column<double>(type: "double precision", nullable: false),
                    artiboy = table.Column<double>(type: "double precision", nullable: false),
                    artitopen = table.Column<double>(type: "double precision", nullable: false),
                    artitopboy = table.Column<double>(type: "double precision", nullable: false),
                    yogunlukgram = table.Column<double>(type: "double precision", nullable: false),
                    yogunlukadet = table.Column<double>(type: "double precision", nullable: false),
                    yogunlukalan = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_makina_kart",
                columns: table => new
                {
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    makinaadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    maksboy = table.Column<double>(type: "double precision", nullable: false),
                    minboy = table.Column<double>(type: "double precision", nullable: false),
                    maksen = table.Column<double>(type: "double precision", nullable: false),
                    minen = table.Column<double>(type: "double precision", nullable: false),
                    makinaek = table.Column<short>(type: "smallint", nullable: false),
                    genelgiderpayi = table.Column<double>(type: "double precision", nullable: false),
                    iscilikgideri = table.Column<double>(type: "double precision", nullable: false),
                    elektrikgideri = table.Column<double>(type: "double precision", nullable: false),
                    giderkatsayisi = table.Column<double>(type: "double precision", nullable: false),
                    saatucret = table.Column<double>(type: "double precision", nullable: false),
                    setup = table.Column<double>(type: "double precision", nullable: false),
                    setupfire = table.Column<double>(type: "double precision", nullable: false),
                    yuzdefire = table.Column<double>(type: "double precision", nullable: false),
                    durumkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    aktif = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "((1))"),
                    uretimplanlamaadet = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((10))"),
                    planlamasirasi = table.Column<byte>(type: "smallint", nullable: false),
                    kkontrol = table.Column<bool>(type: "boolean", nullable: false),
                    bakiunitesi = table.Column<short>(type: "smallint", nullable: false),
                    anaislemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    gidersaatucret = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet",
                columns: table => new
                {
                    maliyetkodu = table.Column<long>(type: "bigint", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    maliyeten = table.Column<double>(type: "double precision", nullable: false),
                    maliyetboy = table.Column<double>(type: "double precision", nullable: false),
                    maliyetadet = table.Column<double>(type: "double precision", nullable: false),
                    maliyetrenk = table.Column<byte>(type: "smallint", nullable: false),
                    mamultipkod = table.Column<int>(type: "integer", nullable: false),
                    slevetip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    bicak_var = table.Column<bool>(type: "boolean", nullable: false),
                    yenibicak = table.Column<bool>(type: "boolean", nullable: false),
                    baski_var = table.Column<bool>(type: "boolean", nullable: false),
                    renk = table.Column<byte>(type: "smallint", nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    makinakodub = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    bicakek = table.Column<short>(type: "smallint", nullable: false),
                    malzemeek = table.Column<short>(type: "smallint", nullable: false),
                    makinaek = table.Column<short>(type: "smallint", nullable: false),
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false, defaultValueSql: "('')"),
                    tekebadboy = table.Column<double>(type: "double precision", nullable: false),
                    tekebaden = table.Column<double>(type: "double precision", nullable: false),
                    tekebadyukseklik = table.Column<double>(type: "double precision", nullable: false),
                    yyadet = table.Column<short>(type: "smallint", nullable: false),
                    aabosluk = table.Column<double>(type: "double precision", nullable: false),
                    yybosluk = table.Column<double>(type: "double precision", nullable: false),
                    yybitisikadet = table.Column<short>(type: "smallint", nullable: false),
                    musteriyyadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    lf = table.Column<double>(type: "double precision", nullable: false),
                    cl = table.Column<double>(type: "double precision", nullable: false),
                    netenverimi = table.Column<double>(type: "double precision", nullable: false),
                    enverimi = table.Column<double>(type: "double precision", nullable: false),
                    bicakmasraf_ekle = table.Column<bool>(type: "boolean", nullable: false),
                    bicakmasraf = table.Column<double>(type: "double precision", nullable: false),
                    klisemasraf_ekle = table.Column<bool>(type: "boolean", nullable: false),
                    klisetutar = table.Column<double>(type: "double precision", nullable: false),
                    malzemecinsi = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    malzemecinsi_ekle = table.Column<bool>(type: "boolean", nullable: false),
                    malzemefiyat = table.Column<double>(type: "double precision", nullable: false),
                    gramaj = table.Column<double>(type: "double precision", nullable: false),
                    kalinlik = table.Column<double>(type: "double precision", nullable: false),
                    yogunluk = table.Column<double>(type: "double precision", nullable: false),
                    malzemecinsi2 = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    malzemecinsi_ekle2 = table.Column<bool>(type: "boolean", nullable: false),
                    malzemefiyat2 = table.Column<double>(type: "double precision", nullable: false),
                    gramaj2 = table.Column<double>(type: "double precision", nullable: false),
                    vade_ekle = table.Column<bool>(type: "boolean", nullable: false),
                    vade = table.Column<short>(type: "smallint", nullable: false),
                    vadevalor = table.Column<float>(type: "real", nullable: false),
                    boyayogunlugu_ekle = table.Column<bool>(type: "boolean", nullable: false),
                    boyayogunluk = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('C')"),
                    boyafiyat = table.Column<double>(type: "double precision", nullable: false),
                    laminasyoncinsi_ekle = table.Column<bool>(type: "boolean", nullable: false),
                    laminasyonadi = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    genelgidereur = table.Column<double>(type: "double precision", nullable: false),
                    genelgider = table.Column<double>(type: "double precision", nullable: false),
                    yonetimgideri = table.Column<double>(type: "double precision", nullable: false),
                    urunadi = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    ozelbilgi = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    onayagonderen = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    onayagondertarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    kontrol_maliyet = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    durum_kontrol = table.Column<bool>(type: "boolean", nullable: false),
                    teklifbirimi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('1')"),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    baskibicakayri = table.Column<bool>(type: "boolean", nullable: false),
                    bicaktipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    adettakim = table.Column<bool>(type: "boolean", nullable: false),
                    takimmiktar = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    rulobirim = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    adettakim2 = table.Column<bool>(type: "boolean", nullable: false),
                    takimmiktar2 = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    takimuretimmiktar = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    depolama = table.Column<double>(type: "double precision", nullable: false),
                    uruntipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ribon = table.Column<bool>(type: "boolean", nullable: false),
                    musterikod = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    onayliyan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    onaytarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    uruneken = table.Column<double>(type: "double precision", nullable: false),
                    maliyeteken = table.Column<double>(type: "double precision", nullable: false),
                    baglamaucreti = table.Column<float>(type: "real", nullable: false),
                    baglamaparabirimi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    baglamafaturaet = table.Column<bool>(type: "boolean", nullable: false),
                    urunbirimtip = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    alannet = table.Column<double>(type: "double precision", nullable: false),
                    alan = table.Column<double>(type: "double precision", nullable: false),
                    agirliknet = table.Column<double>(type: "double precision", nullable: false),
                    agirlik = table.Column<double>(type: "double precision", nullable: false),
                    tipi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('1')"),
                    hammaddefiyatbirimi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    uygulamasekli = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    yaldiz = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    holtmelt = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    perfore = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    laminasyon = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    acan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    rpt = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    cesit = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    montaj = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    yapistirmapayi = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "((7))"),
                    devamlilik = table.Column<bool>(type: "boolean", nullable: false),
                    ortfiyatvar = table.Column<bool>(type: "boolean", nullable: false),
                    fiyattarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    eurokur = table.Column<double>(type: "double precision", nullable: false),
                    dolarkur = table.Column<double>(type: "double precision", nullable: false),
                    eurobarite = table.Column<double>(type: "double precision", nullable: false),
                    sabitkur = table.Column<double>(type: "double precision", nullable: false),
                    genelgideryuzde = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek5 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek6 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_adet",
                columns: table => new
                {
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    adet = table.Column<double>(type: "double precision", nullable: false),
                    minadet = table.Column<double>(type: "double precision", nullable: false),
                    maxadet = table.Column<double>(type: "double precision", nullable: false),
                    carpannet = table.Column<double>(type: "double precision", nullable: false),
                    carpan = table.Column<double>(type: "double precision", nullable: false),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    teklifbirimi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    fire = table.Column<double>(type: "double precision", nullable: false),
                    artifire = table.Column<double>(type: "double precision", nullable: false),
                    makinagider = table.Column<double>(type: "double precision", nullable: false),
                    elektirkgider = table.Column<double>(type: "double precision", nullable: false),
                    iscilikgider = table.Column<double>(type: "double precision", nullable: false),
                    amortismangider = table.Column<double>(type: "double precision", nullable: false),
                    sarfmalzemefiyat = table.Column<double>(type: "double precision", nullable: false),
                    yardhammaddetutar = table.Column<double>(type: "double precision", nullable: false),
                    hammaddetutar = table.Column<double>(type: "double precision", nullable: false),
                    islemtutar = table.Column<double>(type: "double precision", nullable: false),
                    nakliyetutar = table.Column<double>(type: "double precision", nullable: false),
                    yonetimgider = table.Column<double>(type: "double precision", nullable: false),
                    yonetimgidernet = table.Column<double>(type: "double precision", nullable: false),
                    toplamfiyat = table.Column<bool>(type: "boolean", nullable: false),
                    toplamfiyattutar = table.Column<double>(type: "double precision", nullable: false),
                    vade = table.Column<short>(type: "smallint", nullable: false),
                    uzunluk = table.Column<double>(type: "double precision", nullable: false),
                    birimalanfiyat = table.Column<double>(type: "double precision", nullable: false),
                    birimagirlikfiyat = table.Column<double>(type: "double precision", nullable: false),
                    birimadetfiyat = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_carpan",
                columns: table => new
                {
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    carpan = table.Column<double>(type: "double precision", nullable: false),
                    adet = table.Column<double>(type: "double precision", nullable: false),
                    ek = table.Column<int>(type: "integer", nullable: true),
                    minadet = table.Column<double>(type: "double precision", nullable: false),
                    maxadet = table.Column<double>(type: "double precision", nullable: false),
                    mlzfiyat = table.Column<double>(type: "double precision", nullable: false),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    fiyatalan = table.Column<double>(type: "double precision", nullable: false),
                    fiyatagirlik = table.Column<double>(type: "double precision", nullable: false),
                    fiyatuzunluk = table.Column<double>(type: "double precision", nullable: false),
                    ttutar = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_indirim",
                columns: table => new
                {
                    indirimno = table.Column<int>(type: "integer", nullable: false),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    yuzdeindirim = table.Column<short>(type: "smallint", nullable: false),
                    sebep = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    iptal = table.Column<bool>(type: "boolean", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_islem",
                columns: table => new
                {
                    maliyetislemid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    ekgecis = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    sira = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    takipadi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    islemtipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    islemtekrari = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    ekstragideradi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ektragiderbirim = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    ekstragiderfiyat = table.Column<double>(type: "double precision", nullable: false),
                    ektradovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    aaadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    yyadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    dislidegeri = table.Column<float>(type: "real", nullable: false),
                    yuzdefire = table.Column<double>(type: "double precision", nullable: false),
                    setupfire = table.Column<double>(type: "double precision", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    setupfiyat = table.Column<double>(type: "double precision", nullable: false),
                    setupdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    artisaattehiz = table.Column<double>(type: "double precision", nullable: false),
                    boyabirimfiyat = table.Column<double>(type: "double precision", nullable: false),
                    boyadovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    boyayogunlugu = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_islem_urun",
                columns: table => new
                {
                    maliyetislemurunid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    maliyetislemid = table.Column<long>(type: "bigint", nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    uruntipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    birimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    birimtip = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    eniesit = table.Column<bool>(type: "boolean", nullable: false),
                    boyuesit = table.Column<bool>(type: "boolean", nullable: false),
                    en = table.Column<double>(type: "double precision", nullable: false),
                    boy = table.Column<double>(type: "double precision", nullable: false),
                    artien = table.Column<double>(type: "double precision", nullable: false),
                    artiboy = table.Column<double>(type: "double precision", nullable: false),
                    artitopen = table.Column<double>(type: "double precision", nullable: false),
                    artitopboy = table.Column<double>(type: "double precision", nullable: false),
                    yogunlukgram = table.Column<double>(type: "double precision", nullable: false),
                    yogunlukadet = table.Column<double>(type: "double precision", nullable: false),
                    yogunlukalan = table.Column<double>(type: "double precision", nullable: false),
                    hammaddefiyat = table.Column<double>(type: "double precision", nullable: false),
                    parabirimi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fiyateurokg = table.Column<double>(type: "double precision", nullable: false),
                    fiyateuroalan = table.Column<double>(type: "double precision", nullable: false),
                    malzemeuretimeni = table.Column<double>(type: "double precision", nullable: false),
                    urunyyadet = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    urunaaadet = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_islem_zorunlu",
                columns: table => new
                {
                    maliyetislemZid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    islemtipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_lf",
                columns: table => new
                {
                    maliyetlfid = table.Column<long>(type: "bigint", nullable: false),
                    maliyetkodu = table.Column<long>(type: "bigint", nullable: false),
                    lf = table.Column<double>(type: "double precision", nullable: false),
                    aramesafe = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_malzeme",
                columns: table => new
                {
                    maliyetmalzemeid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    maliyetkodu = table.Column<long>(type: "bigint", nullable: false),
                    sira = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1))"),
                    yapisalkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    urunbirimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    maliyetislemid = table.Column<long>(type: "bigint", nullable: false),
                    hammadde = table.Column<bool>(type: "boolean", nullable: false),
                    gramaj = table.Column<double>(type: "double precision", nullable: false),
                    hammaddefiyat = table.Column<double>(type: "double precision", nullable: false),
                    parabirimi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fiyateurokg = table.Column<double>(type: "double precision", nullable: false),
                    fiyateuroalan = table.Column<double>(type: "double precision", nullable: false),
                    malzemeuretimeni = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_onay",
                columns: table => new
                {
                    maliyetonayid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    miktar = table.Column<double>(type: "double precision", nullable: false),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    onaylayan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_maliyet_sabit",
                columns: table => new
                {
                    vadevalor = table.Column<float>(type: "real", nullable: true),
                    onaylicarpan = table.Column<float>(type: "real", nullable: true),
                    bobin = table.Column<float>(type: "real", nullable: true),
                    bobinfire = table.Column<float>(type: "real", nullable: true),
                    sonhareketno = table.Column<int>(type: "integer", nullable: true),
                    saonay = table.Column<float>(type: "real", nullable: true),
                    gorusmehafta = table.Column<byte>(type: "smallint", nullable: true),
                    yonetimgideri = table.Column<double>(type: "double precision", nullable: false),
                    yonetimgiderigercek = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_mamul_tip",
                columns: table => new
                {
                    mamultipkod = table.Column<int>(type: "integer", nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    hatsayisi = table.Column<byte>(type: "smallint", nullable: false),
                    cokyaprak = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    cilt = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    cesit = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    anatip = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    minimumaaaralik = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_mamul_tip_hat",
                columns: table => new
                {
                    mamultipkod = table.Column<int>(type: "integer", nullable: false),
                    hat = table.Column<byte>(type: "smallint", nullable: false),
                    hatadi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    minimumurun = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_muadil",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    muadilkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_odeme",
                columns: table => new
                {
                    odemekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_opaklik",
                columns: table => new
                {
                    opaklikkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_parametre",
                columns: table => new
                {
                    bolum = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    parametrekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    veri = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false),
                    bilgisayaradi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_parlaklik",
                columns: table => new
                {
                    parlaklikkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel",
                columns: table => new
                {
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    adisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    password = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    sup = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    maliyetonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    sorunlufirma = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    grafikonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    uretimonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu01_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu01_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu01_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu01_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu02_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu02_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu02_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu02_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu02_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu02_05 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu03_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu03_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu03_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu04_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu04_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu04_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu04_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu05_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu05_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu05_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu05_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu06_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu07_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu07_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_02_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_02_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_03_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_03_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu08_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_01_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_01_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_01_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_01_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_02_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_02_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_02_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_02_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_02_05 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_03_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_03_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_03_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu09_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_01_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_01_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_01_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_01_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_02_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_02_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_02_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_03_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_03_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_03_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_03_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_03_05 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_03_06 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_05 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_06 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_07 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_08 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_04_09 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_05 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_05_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_05_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_05_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_05_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_05_05 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_06 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_06_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_06_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_07 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_07_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_08 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_08_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_08_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_08_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_09 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_09_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_09_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_09_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_09_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_10 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_10_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_10_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_11 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_11_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_11_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_12 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_12_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_12_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_13 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_14 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_14_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_14_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_15 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu10_15_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu11_00 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu11_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu06_01 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu06_02 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu05_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu02_06 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu02_07 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu03_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu01_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu06_03 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    mnu06_04 = table.Column<string>(type: "character(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('H')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_bilgisayar",
                columns: table => new
                {
                    bilid = table.Column<long>(type: "bigint", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    adi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    cinsi = table.Column<string>(type: "text", nullable: false),
                    seviye = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_ceza",
                columns: table => new
                {
                    cezaid = table.Column<int>(type: "integer", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    adi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    ceza = table.Column<bool>(type: "boolean", nullable: true),
                    sebep = table.Column<string>(type: "text", nullable: true),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_dil",
                columns: table => new
                {
                    dilid = table.Column<long>(type: "bigint", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    dil = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    seviye = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false),
                    yer = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_egitim",
                columns: table => new
                {
                    personelEgitimId = table.Column<int>(type: "integer", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    verenadi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    konu = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    sure = table.Column<double>(type: "double precision", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false),
                    firmaici = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_egitim_personel",
                columns: table => new
                {
                    personelEgitimId = table.Column<int>(type: "integer", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_eposta",
                columns: table => new
                {
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    epostagrupkod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_firm",
                columns: table => new
                {
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    firmId = table.Column<short>(type: "smallint", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_grup",
                columns: table => new
                {
                    personelgrupkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_ihtiyac",
                columns: table => new
                {
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ihtiyac = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    planlama = table.Column<string>(type: "text", nullable: true),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_islem",
                columns: table => new
                {
                    perIslemId = table.Column<long>(type: "bigint", nullable: false),
                    takipId = table.Column<long>(type: "bigint", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    islemtipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_izin",
                columns: table => new
                {
                    izinkullanid = table.Column<long>(type: "bigint", nullable: false),
                    izinid = table.Column<int>(type: "integer", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    cikistarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    gelistarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    izingun = table.Column<short>(type: "smallint", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_izin_hak",
                columns: table => new
                {
                    izinid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ilktarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    sontarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    hakedilen = table.Column<short>(type: "smallint", nullable: false),
                    kullanilan = table.Column<short>(type: "smallint", nullable: false),
                    aciklama = table.Column<string>(type: "ntext", nullable: false, defaultValueSql: "('')"),
                    izintakibi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_kart",
                columns: table => new
                {
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    aktif = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "((1))"),
                    calisiyor = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "((1))"),
                    grup = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    doviz = table.Column<bool>(type: "boolean", nullable: false),
                    grafikyetkili = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    makinaadi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    oturumadi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    sifregir = table.Column<bool>(type: "boolean", nullable: false),
                    hizligir = table.Column<bool>(type: "boolean", nullable: false),
                    saonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    saonay2 = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    firmatemsilcisiatama = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')"),
                    personelgrupkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    unvan = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    sifre2 = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    baslatarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    sosyalno = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    dogumtarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    dogumyeri = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    medeni = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    askerlik = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    ehliyet = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    kan = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    adres = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    ceptelefon = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    telefon = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    telefon2 = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    saglik = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    ilkogretim = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    ilkyil = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    lise = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    liseyil = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    yuksekokul = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    yuksekyil = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    lisansustu = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    lisansustuyil = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    oryantasyontarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    oryantasyonkisi = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    nitelik = table.Column<bool>(type: "boolean", nullable: false),
                    niteliktarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    niteliknot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    foto = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    eposta = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    beden = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    ayakno = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    cocuk = table.Column<byte>(type: "smallint", nullable: false),
                    maas = table.Column<double>(type: "double precision", nullable: false),
                    bolum = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    izingun = table.Column<int>(type: "integer", nullable: false),
                    izinpotansiyel = table.Column<int>(type: "integer", nullable: false),
                    servis = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    firmId = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    cikistarih = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_kurs",
                columns: table => new
                {
                    kursid = table.Column<long>(type: "bigint", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kursadi = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    yer = table.Column<string>(type: "text", nullable: true),
                    sure = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_makina",
                columns: table => new
                {
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_makina_grup",
                columns: table => new
                {
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    makinagrupkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_personel_saglik",
                columns: table => new
                {
                    saglikid = table.Column<long>(type: "bigint", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    rahatsizlik = table.Column<string>(type: "text", nullable: false),
                    bulgu = table.Column<string>(type: "text", nullable: false),
                    tani = table.Column<string>(type: "text", nullable: false),
                    tedavi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_planlama",
                columns: table => new
                {
                    baslamatarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    baslamasaat = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: true),
                    bitistarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    bitissaat = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: true),
                    siparisno = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: true),
                    siralama = table.Column<short>(type: "smallint", nullable: true),
                    sure = table.Column<double>(type: "double precision", nullable: true),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_randevu",
                columns: table => new
                {
                    randevuno = table.Column<long>(type: "bigint", nullable: false),
                    gorid = table.Column<long>(type: "bigint", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    randevutarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    bas_saat = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    sure = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    randevu_saat = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    gorusmeno = table.Column<int>(type: "integer", nullable: false),
                    bilgi = table.Column<string>(type: "text", nullable: true),
                    gorusmetipno = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sa_istek",
                columns: table => new
                {
                    istekkod = table.Column<int>(type: "integer", nullable: false),
                    uruntip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: true),
                    bicak = table.Column<bool>(type: "boolean", nullable: true),
                    klise = table.Column<bool>(type: "boolean", nullable: true),
                    sabagkod = table.Column<string>(type: "character varying(15)", unicode: false, maxLength: 15, nullable: false),
                    urunadi = table.Column<string>(type: "character varying(250)", unicode: false, maxLength: 250, nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    termintarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    miktar1 = table.Column<double>(type: "double precision", nullable: true),
                    miktar2 = table.Column<double>(type: "double precision", nullable: true),
                    netmiktar = table.Column<double>(type: "double precision", nullable: true),
                    aciklama = table.Column<string>(type: "text", nullable: true),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    istenen = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    siparisedondu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sa_siparis",
                columns: table => new
                {
                    said = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sasiparisno = table.Column<int>(type: "integer", nullable: false),
                    sira = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    sabagkod = table.Column<string>(type: "character varying(15)", unicode: false, maxLength: 15, nullable: false),
                    istekkod = table.Column<int>(type: "integer", nullable: false),
                    sateklifkod = table.Column<int>(type: "integer", nullable: false),
                    uruntipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    bicak = table.Column<bool>(type: "boolean", nullable: false),
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false, defaultValueSql: "('')"),
                    satipi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    klise = table.Column<bool>(type: "boolean", nullable: false),
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: true, defaultValueSql: "('')"),
                    detaysiz = table.Column<bool>(type: "boolean", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    urunbirimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    birimoran = table.Column<double>(type: "double precision", nullable: false),
                    miktar1 = table.Column<double>(type: "double precision", nullable: false),
                    miktar2 = table.Column<double>(type: "double precision", nullable: false),
                    tabaka = table.Column<int>(type: "integer", nullable: false),
                    netmiktar = table.Column<double>(type: "double precision", nullable: false),
                    kagittipi = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    tutar = table.Column<double>(type: "double precision", nullable: false),
                    kur = table.Column<double>(type: "double precision", nullable: false),
                    fiyattl = table.Column<double>(type: "double precision", nullable: false),
                    tutartl = table.Column<double>(type: "double precision", nullable: false),
                    vade = table.Column<double>(type: "double precision", nullable: false),
                    kdv = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "((18))"),
                    siparistarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    termintarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    firmasiparisno = table.Column<string>(type: "character varying(9)", unicode: false, maxLength: 9, nullable: false, defaultValueSql: "('')"),
                    firmasip = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    aciklama2 = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    yonetimonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    yonetimonay2 = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    klisefirmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    klisegondermekod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    klisesaklamakod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    kromolin = table.Column<bool>(type: "boolean", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    numunesivar = table.Column<bool>(type: "boolean", nullable: false),
                    yeniurun = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "('')"),
                    gondermetarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    kontrol_kapat = table.Column<bool>(type: "boolean", nullable: false),
                    tasarimci = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    malzemekodu = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    en = table.Column<double>(type: "double precision", nullable: false),
                    boy = table.Column<double>(type: "double precision", nullable: false),
                    tekebaden = table.Column<double>(type: "double precision", nullable: false),
                    tekebadboy = table.Column<double>(type: "double precision", nullable: false),
                    tedarikcikodu = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false, defaultValueSql: "('')"),
                    tedarikciadi = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false, defaultValueSql: "('')"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sa_siparis_klise",
                columns: table => new
                {
                    sasiparisno = table.Column<int>(type: "integer", nullable: false),
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sa_siparis_siparis",
                columns: table => new
                {
                    sasaid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    said = table.Column<int>(type: "integer", nullable: false),
                    sasiparisno = table.Column<int>(type: "integer", nullable: false),
                    sira = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    sipihtiyacid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sa_siparis_teslim",
                columns: table => new
                {
                    teslimno = table.Column<long>(type: "bigint", nullable: false),
                    said = table.Column<long>(type: "bigint", nullable: false),
                    sasiparisno = table.Column<int>(type: "integer", nullable: false),
                    sira = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    teslimmiktar1 = table.Column<double>(type: "double precision", nullable: false),
                    teslimmiktar2 = table.Column<double>(type: "double precision", nullable: false),
                    teslimnetmiktar = table.Column<double>(type: "double precision", nullable: false),
                    teslimkur = table.Column<double>(type: "double precision", nullable: false),
                    teslimtarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    irsaliyeno = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    irsaliyetarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    hareketno = table.Column<int>(type: "integer", nullable: false),
                    faturano = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    faturatarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    faturafiyat = table.Column<double>(type: "double precision", nullable: false),
                    faturalandi = table.Column<bool>(type: "boolean", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    iskonto = table.Column<double>(type: "double precision", nullable: false),
                    kontroltarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ambalajbutunluk = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    sevkaraci = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    paletuygunluk = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    etiketkontrolu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    bobinsarimyonu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    korona = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    yapisma = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    cekmekontrolu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    olcukontrolu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    analizsertifikasi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    mikronkontolu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('U')"),
                    kabuldurumu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('K')"),
                    kontoleden = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('014')"),
                    onayliyan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('004')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sa_siparis_teslim_detay",
                columns: table => new
                {
                    detayno = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    said = table.Column<long>(type: "bigint", nullable: false),
                    sasiparisno = table.Column<int>(type: "integer", nullable: false),
                    sira = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    teslimno = table.Column<int>(type: "integer", nullable: false),
                    boy = table.Column<double>(type: "double precision", nullable: false),
                    partino = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sa_teklif",
                columns: table => new
                {
                    sateklifkod = table.Column<int>(type: "integer", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    sabagkod = table.Column<string>(type: "character varying(15)", unicode: false, maxLength: 15, nullable: false),
                    uruntipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: true),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    bicak = table.Column<bool>(type: "boolean", nullable: true),
                    klise = table.Column<bool>(type: "boolean", nullable: true),
                    baslatarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    bitistarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    vade = table.Column<short>(type: "smallint", nullable: true),
                    eksart = table.Column<string>(type: "text", nullable: true),
                    teslimatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    teslimatyeri = table.Column<string>(type: "text", nullable: true),
                    sevkiyatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    ambalaj = table.Column<string>(type: "text", nullable: true),
                    odemekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    garanti = table.Column<byte>(type: "smallint", nullable: true),
                    imalatcikod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    iptal = table.Column<bool>(type: "boolean", nullable: false),
                    tedarikcikodu = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    tedarikciadi = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sa_teklif_fiyat",
                columns: table => new
                {
                    sateklifkod = table.Column<int>(type: "integer", nullable: false),
                    sirano = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ustmiktar = table.Column<double>(type: "double precision", nullable: true),
                    netmiktar = table.Column<double>(type: "double precision", nullable: true),
                    altmiktar = table.Column<double>(type: "double precision", nullable: true),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sabagkod",
                columns: table => new
                {
                    sabagkod = table.Column<string>(type: "character varying(13)", unicode: false, maxLength: 13, nullable: false, defaultValueSql: "('')"),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false, defaultValueSql: "('')"),
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    klisetipkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sektor",
                columns: table => new
                {
                    SekID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sektorkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    sektoraltkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    sektoranaad = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    sektorad = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_sektor_1", x => x.SekID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_sevk",
                columns: table => new
                {
                    sevkno = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    belgetipi = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    durumu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    belgeserino = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    belgesirano = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    faturasevkno = table.Column<long>(type: "bigint", nullable: false),
                    firmId = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    carikod = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false, defaultValueSql: "('')"),
                    ilgilikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    subekod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    musterisano = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false, defaultValueSql: "('')"),
                    sevkiyatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    belgetarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    sevktarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    sevkiyatnotu = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    konsinyeno = table.Column<int>(type: "integer", nullable: false),
                    vade = table.Column<short>(type: "smallint", nullable: false),
                    belgedovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    faturakur = table.Column<double>(type: "double precision", nullable: false),
                    iskontoyuzde = table.Column<double>(type: "double precision", nullable: false),
                    iskontotutar = table.Column<double>(type: "double precision", nullable: false),
                    toplam = table.Column<double>(type: "double precision", nullable: false),
                    kdv = table.Column<double>(type: "double precision", nullable: false),
                    yekun = table.Column<double>(type: "double precision", nullable: false),
                    yaziyla = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    iptal = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    sevktipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sevk_alt",
                columns: table => new
                {
                    satirno = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sevkno = table.Column<long>(type: "bigint", nullable: false),
                    sirano = table.Column<byte>(type: "smallint", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    musterisano = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    urunno = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    birimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    sevkiyatno = table.Column<int>(type: "integer", nullable: false),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    urunsevkdetayid = table.Column<long>(type: "bigint", nullable: false),
                    koliadet = table.Column<int>(type: "integer", nullable: false),
                    ruloadet = table.Column<int>(type: "integer", nullable: false),
                    urunadet = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    toplamadet = table.Column<double>(type: "double precision", nullable: false),
                    siparisfiyat = table.Column<double>(type: "double precision", nullable: false),
                    siparisdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    kur = table.Column<double>(type: "double precision", nullable: false),
                    sabitkur = table.Column<double>(type: "double precision", nullable: false),
                    dovizalissatis = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('S')"),
                    faturafiyat = table.Column<double>(type: "double precision", nullable: false),
                    iskontoyuzde = table.Column<double>(type: "double precision", nullable: false),
                    iskontotutar = table.Column<double>(type: "double precision", nullable: false),
                    tutar = table.Column<double>(type: "double precision", nullable: false),
                    kdv = table.Column<double>(type: "double precision", nullable: false),
                    kdvtutar = table.Column<double>(type: "double precision", nullable: false),
                    kdvlitutar = table.Column<double>(type: "double precision", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    onaysiz = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sevk_detay",
                columns: table => new
                {
                    satirdetayid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    satirno = table.Column<long>(type: "bigint", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    urunsevkid = table.Column<long>(type: "bigint", nullable: false),
                    musterisano = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    urunno = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    sevkiyatno = table.Column<int>(type: "integer", nullable: false),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    koliadet = table.Column<int>(type: "integer", nullable: false),
                    ruloadet = table.Column<int>(type: "integer", nullable: false),
                    urunadet = table.Column<string>(type: "text", nullable: false),
                    adet = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sevk_tip",
                columns: table => new
                {
                    sevktipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sevkiyat",
                columns: table => new
                {
                    sevkiyatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_sevkiyat", x => x.sevkiyatkod);
                });

            migrationBuilder.CreateTable(
                name: "tbl_sikayet_gelen",
                columns: table => new
                {
                    sikayetno = table.Column<int>(type: "integer", nullable: false),
                    sikayettipi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    iadedurum = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    sikayettarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    teslimtarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    toplamadet = table.Column<double>(type: "double precision", nullable: false),
                    sevkiyatno = table.Column<int>(type: "integer", nullable: false),
                    sevkadet = table.Column<double>(type: "double precision", nullable: false),
                    irsaliyeno = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    sevkno = table.Column<long>(type: "bigint", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    dofkod = table.Column<string>(type: "character varying(9)", unicode: false, maxLength: 9, nullable: false, defaultValueSql: "('')"),
                    iadetarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    musterisikayetno = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    zarartutari = table.Column<double>(type: "double precision", nullable: false),
                    resim = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    bedelsiz = table.Column<bool>(type: "boolean", nullable: false),
                    acik = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    degerlendirme = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sikayet_gelen_tip",
                columns: table => new
                {
                    sikayetgelenkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    tipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: true),
                    kodaciklama = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sikayet_hareket",
                columns: table => new
                {
                    hareketID = table.Column<int>(type: "integer", nullable: false),
                    sikayetno = table.Column<int>(type: "integer", nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    anasikayet = table.Column<bool>(type: "boolean", nullable: true),
                    hareketadi = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    hareketno = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    aciklama = table.Column<string>(type: "text", nullable: false),
                    hareketmiktar = table.Column<double>(type: "double precision", nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sikayet_personel",
                columns: table => new
                {
                    sikayetno = table.Column<int>(type: "integer", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sikayet_sikayet_tip",
                columns: table => new
                {
                    sikayetno = table.Column<int>(type: "integer", nullable: false),
                    sikayetgelenkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_sikayet_tutar",
                columns: table => new
                {
                    sikayettutarid = table.Column<int>(type: "integer", nullable: false),
                    sikayetno = table.Column<int>(type: "integer", nullable: false),
                    aciklama = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    tutar = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    revizyonkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    siparismiktar = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    siparistarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    siparisbirim = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    siparisfiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    firmId = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    kdv = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "((18))"),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    ozelbilgi = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    bicakfiyat = table.Column<double>(type: "double precision", nullable: false),
                    bdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    bbirim = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    klisefiyat = table.Column<double>(type: "double precision", nullable: false),
                    kdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    kliseadet = table.Column<short>(type: "smallint", nullable: false),
                    bfaturaet = table.Column<bool>(type: "boolean", nullable: false),
                    bfaturaedildi = table.Column<bool>(type: "boolean", nullable: false),
                    kfaturaet = table.Column<bool>(type: "boolean", nullable: false),
                    kfaturaedildi = table.Column<bool>(type: "boolean", nullable: false),
                    uygulamamiktar = table.Column<double>(type: "double precision", nullable: false),
                    kontrol_kapat = table.Column<bool>(type: "boolean", nullable: false),
                    kapattarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    kontrol_depo = table.Column<bool>(type: "boolean", nullable: false),
                    kontrol_kapat2 = table.Column<bool>(type: "boolean", nullable: false),
                    toplamalan = table.Column<double>(type: "double precision", nullable: false),
                    toplamagirlik = table.Column<double>(type: "double precision", nullable: false),
                    toplamadet = table.Column<double>(type: "double precision", nullable: false),
                    toplamteslimmiktar = table.Column<double>(type: "double precision", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    temsilci = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    imalattakip = table.Column<bool>(type: "boolean", nullable: false),
                    tramyogunlugu = table.Column<int>(type: "integer", nullable: false),
                    gelirtutar = table.Column<double>(type: "double precision", nullable: false),
                    gelirtutarklise = table.Column<double>(type: "double precision", nullable: false),
                    gelirtutarbicak = table.Column<double>(type: "double precision", nullable: false),
                    gidertutar = table.Column<double>(type: "double precision", nullable: false),
                    gidertutarkur = table.Column<double>(type: "double precision", nullable: false),
                    maliyetadet = table.Column<double>(type: "double precision", nullable: false),
                    toplamteslim = table.Column<double>(type: "double precision", nullable: false),
                    muhtemeltarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    planlanantarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    depodan = table.Column<bool>(type: "boolean", nullable: false),
                    ilkdefa = table.Column<bool>(type: "boolean", nullable: false),
                    ilkdefauy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    revizyonvar = table.Column<bool>(type: "boolean", nullable: false),
                    eskifilmat = table.Column<bool>(type: "boolean", nullable: false),
                    revizyonfilmdegil = table.Column<bool>(type: "boolean", nullable: false),
                    revizyonnot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    irsaliyenot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    faturanot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    musterisano = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    onayadres = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    oncekilot = table.Column<int>(type: "integer", nullable: false),
                    iptal = table.Column<bool>(type: "boolean", nullable: false),
                    prova = table.Column<bool>(type: "boolean", nullable: false),
                    globalfiyat = table.Column<double>(type: "double precision", nullable: false),
                    yeniurun = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    urunacildi = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    satistltutar = table.Column<double>(type: "double precision", nullable: false),
                    bedelsiz = table.Column<bool>(type: "boolean", nullable: false),
                    satistipi = table.Column<byte>(type: "smallint", nullable: false),
                    testtipi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    numuneadet = table.Column<short>(type: "smallint", nullable: false),
                    urunalan = table.Column<double>(type: "double precision", nullable: false),
                    sabitkur = table.Column<double>(type: "double precision", nullable: false),
                    grafikpersonel = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    grafikonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    kardes = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    siparisurunadi = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    siparismusterikod = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    siparistekebadboy = table.Column<double>(type: "double precision", nullable: false),
                    siparistekebaden = table.Column<double>(type: "double precision", nullable: false),
                    siparistekebadyukseklik = table.Column<double>(type: "double precision", nullable: false),
                    siparisyyadet = table.Column<short>(type: "smallint", nullable: false),
                    siparisaabosluk = table.Column<double>(type: "double precision", nullable: false),
                    siparisyybosluk = table.Column<double>(type: "double precision", nullable: false),
                    siparisyybitisikadet = table.Column<short>(type: "smallint", nullable: false),
                    siparisbaskiaabosluk = table.Column<double>(type: "double precision", nullable: false),
                    siparislf = table.Column<double>(type: "double precision", nullable: false),
                    siparisyapistirmapayi = table.Column<double>(type: "double precision", nullable: false),
                    sipariscl = table.Column<double>(type: "double precision", nullable: false),
                    siparisuygulamasekli = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    siparisholtmelt = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    siparisperfore = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    siparisbicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false, defaultValueSql: "('')"),
                    siparisurunnot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    siparisadettakim = table.Column<bool>(type: "boolean", nullable: false),
                    siparistakimmiktar = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    siparisrulobirim = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    siparisadettakim2 = table.Column<bool>(type: "boolean", nullable: false),
                    siparistakimmiktar2 = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    siparisuruneken = table.Column<double>(type: "double precision", nullable: false),
                    siparisdevamlilik = table.Column<bool>(type: "boolean", nullable: false),
                    siparisarsivno = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    siparisboyayogunluk = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('C')"),
                    sipariskliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    onaydakibakiye = table.Column<double>(type: "double precision", nullable: false),
                    bakiyedovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    onaydakirisk = table.Column<double>(type: "double precision", nullable: false),
                    riskdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    muhasebeonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    muhasebeonaylayan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    muhasebeonaytarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    yonetimonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    yonetimonaylayan = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    yonetimonaytarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    yonetimonay2 = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    yonetimonaylayan2 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    yonetimonaytarih2 = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    bicakdurum = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    klisedurum = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    malzemedurum = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    planlamatermintarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    carikod = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false, defaultValueSql: "('')"),
                    planlamakabultarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    iskontoyuzde = table.Column<double>(type: "double precision", nullable: false),
                    kapanistarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_amb",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    amb = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_degisiklik",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    degisiklik = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_detay",
                columns: table => new
                {
                    siparisno = table.Column<double>(type: "double precision", nullable: true),
                    malzemekodu = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    tarih_cikis = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    en_cikis = table.Column<short>(type: "smallint", nullable: true),
                    boy_cikis = table.Column<short>(type: "smallint", nullable: true),
                    tarih_giris = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    en_giris = table.Column<short>(type: "smallint", nullable: true),
                    boy_giris = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_ekstragider",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    ekstragiderkod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    tutar = table.Column<double>(type: "double precision", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: true),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_gider",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    giderkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    miktar = table.Column<double>(type: "double precision", nullable: false),
                    tutar = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kur = table.Column<double>(type: "double precision", nullable: false),
                    planurunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    planlananfiyat = table.Column<double>(type: "double precision", nullable: false),
                    planlananmiktar = table.Column<double>(type: "double precision", nullable: false),
                    planlanantutar = table.Column<double>(type: "double precision", nullable: false),
                    planlanandovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    planlanankur = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_hareket",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    urunihtiyacid = table.Column<long>(type: "bigint", nullable: false),
                    hareketno = table.Column<int>(type: "integer", nullable: false),
                    harcananhareket = table.Column<double>(type: "double precision", nullable: false),
                    bitishareket = table.Column<double>(type: "double precision", nullable: false),
                    toplammiktar2 = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_ihtiyac",
                columns: table => new
                {
                    sipihtiyacid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urunihtiyacid = table.Column<long>(type: "bigint", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    miktar = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    birim = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    en = table.Column<double>(type: "double precision", nullable: false),
                    hammadde = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "((1))"),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fason = table.Column<bool>(type: "boolean", nullable: false),
                    fire = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "((1))"),
                    ihtiyactakip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    ihtiyacnotu = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_islem",
                columns: table => new
                {
                    siparisislemid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urunislemid = table.Column<long>(type: "bigint", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    siparismakinaid = table.Column<long>(type: "bigint", nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('000')"),
                    dislidegeri = table.Column<double>(type: "double precision", nullable: false),
                    aaadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    yyadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    islemsayisi = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_klise",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    pantoneno = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    kliseuyumkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    formul = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    aniloxkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_klise_alt",
                columns: table => new
                {
                    sipariskliseid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    siparisno = table.Column<long>(type: "bigint", nullable: false),
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    no = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    revizyonkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    baskitipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    klisetipkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    aaadet = table.Column<short>(type: "smallint", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_klise_pantone",
                columns: table => new
                {
                    siparispantoneid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    siparisno = table.Column<long>(type: "bigint", nullable: false),
                    klisepantoneid = table.Column<long>(type: "bigint", nullable: false),
                    klisekod = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    sonno = table.Column<int>(type: "integer", nullable: false),
                    pantoneno = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    kliseuyumkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    formul = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    aniloxkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_mak",
                columns: table => new
                {
                    siparismakid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    siparisno = table.Column<long>(type: "bigint", nullable: false),
                    siparisnobirles = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_makina",
                columns: table => new
                {
                    siparismakinaid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    sira = table.Column<short>(type: "smallint", nullable: false),
                    siralama = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1000))"),
                    ekgecis = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    bitti = table.Column<bool>(type: "boolean", nullable: false),
                    plantarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    topsetupsure = table.Column<int>(type: "integer", nullable: false),
                    topislemsure = table.Column<double>(type: "double precision", nullable: false),
                    islemmiktar = table.Column<double>(type: "double precision", nullable: false),
                    aktif = table.Column<bool>(type: "boolean", nullable: false),
                    sirada = table.Column<bool>(type: "boolean", nullable: false),
                    makinabirimkod = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    uretimnotu = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    uretimplanlama = table.Column<bool>(type: "boolean", nullable: false),
                    uretimtakip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    bitistarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    bitiren = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_onay",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    onay = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_onay_adres",
                columns: table => new
                {
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    onay = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_termin",
                columns: table => new
                {
                    terminid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    siparismiktar = table.Column<double>(type: "double precision", nullable: false),
                    termintarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    subekod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    stok = table.Column<bool>(type: "boolean", nullable: false),
                    iccap = table.Column<short>(type: "smallint", nullable: false),
                    discap = table.Column<short>(type: "smallint", nullable: false),
                    bobindeadet = table.Column<int>(type: "integer", nullable: false),
                    bobindebirim = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    akisyonu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    musteriyyadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    sevkiyatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    terminnot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_teslim",
                columns: table => new
                {
                    sevkiyatno = table.Column<int>(type: "integer", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    urunno = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    teslimtarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    koliadet = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1))"),
                    ruloadet = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1))"),
                    urunadet = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    toplamadet = table.Column<double>(type: "double precision", nullable: false),
                    musteri = table.Column<bool>(type: "boolean", nullable: false),
                    depo = table.Column<bool>(type: "boolean", nullable: false),
                    konsinye = table.Column<bool>(type: "boolean", nullable: false),
                    depodansevk = table.Column<bool>(type: "boolean", nullable: false),
                    depokod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    sevkedildi = table.Column<bool>(type: "boolean", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    koliagirlik = table.Column<double>(type: "double precision", nullable: false),
                    sevkmiktar = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_siparis_teslim2",
                columns: table => new
                {
                    sevkiyatno = table.Column<int>(type: "integer", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    urunno = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    teslimtarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    koliadet = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1))"),
                    ruloadet = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1))"),
                    urunadet = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    toplamadet = table.Column<double>(type: "double precision", nullable: false),
                    musteri = table.Column<bool>(type: "boolean", nullable: false),
                    depo = table.Column<bool>(type: "boolean", nullable: false),
                    konsinye = table.Column<bool>(type: "boolean", nullable: false),
                    depodansevk = table.Column<bool>(type: "boolean", nullable: false),
                    depokod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    sevkedildi = table.Column<bool>(type: "boolean", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    koliagirlik = table.Column<double>(type: "double precision", nullable: false),
                    sevkmiktar = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_Tanim",
                columns: table => new
                {
                    TID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tanim = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    Aciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    Tip = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    TipInt = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Tanim", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_tasiyici",
                columns: table => new
                {
                    tasiyicikod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teklif",
                columns: table => new
                {
                    kodu = table.Column<long>(type: "bigint", nullable: false),
                    gonderno = table.Column<int>(type: "integer", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    eksartlar = table.Column<string>(type: "ntext", nullable: false),
                    sevkiyatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    teslimatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    durumteklifkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: true),
                    arsiv = table.Column<bool>(type: "boolean", nullable: true),
                    hatirlatma = table.Column<bool>(type: "boolean", nullable: true),
                    hatirlatmatarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    hatirlatmanot = table.Column<string>(type: "text", nullable: true),
                    avans = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: true),
                    il = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    opsiyonkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    klisegoster = table.Column<bool>(type: "boolean", nullable: false),
                    klisemasraf = table.Column<double>(type: "double precision", nullable: false),
                    kdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teklif_fiyat",
                columns: table => new
                {
                    kodu = table.Column<long>(type: "bigint", nullable: false),
                    sirano = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    gonderkodu = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    gonderno = table.Column<int>(type: "integer", nullable: false),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    adet = table.Column<double>(type: "double precision", nullable: false),
                    minadet = table.Column<double>(type: "double precision", nullable: false),
                    maxadet = table.Column<double>(type: "double precision", nullable: false),
                    klisemasraf = table.Column<double>(type: "double precision", nullable: false),
                    bicakmasraf = table.Column<double>(type: "double precision", nullable: false),
                    urunnot = table.Column<string>(type: "character varying(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    urunnot2 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    teklifbirimi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    globalfiyat = table.Column<double>(type: "double precision", nullable: false),
                    toplamfiyat = table.Column<bool>(type: "boolean", nullable: false),
                    toplamfiyattutar = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teklif_gonder",
                columns: table => new
                {
                    kodu = table.Column<long>(type: "bigint", nullable: false),
                    gonderno = table.Column<int>(type: "integer", nullable: false),
                    gonderkodu = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    gondertarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    sonucteklifkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teklif_gonder_sonuc",
                columns: table => new
                {
                    sonucteklifkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(25)", unicode: false, maxLength: 25, nullable: false),
                    olumlu = table.Column<bool>(type: "boolean", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teklif_sira",
                columns: table => new
                {
                    teklifsiraid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    kodu = table.Column<long>(type: "bigint", nullable: false),
                    sirano = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    maliyetkodu = table.Column<long>(type: "bigint", nullable: false),
                    klisemasraf = table.Column<double>(type: "double precision", nullable: false),
                    kdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    bicakmasraf = table.Column<double>(type: "double precision", nullable: false),
                    bdovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    uruntipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    teklifonay = table.Column<bool>(type: "boolean", nullable: false),
                    urunnot = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    urunnot2 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teknik_ortam",
                columns: table => new
                {
                    teknikno = table.Column<int>(type: "integer", nullable: false),
                    ortam = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teknik_pantone",
                columns: table => new
                {
                    teknikno = table.Column<int>(type: "integer", nullable: false),
                    pantone = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teknik_yuzey",
                columns: table => new
                {
                    teknikno = table.Column<int>(type: "integer", nullable: false),
                    yuzey = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_teslimat",
                columns: table => new
                {
                    teslimatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_test",
                columns: table => new
                {
                    testtipi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    minadet = table.Column<int>(type: "integer", nullable: false),
                    maxadet = table.Column<int>(type: "integer", nullable: false),
                    minmetre = table.Column<int>(type: "integer", nullable: false),
                    maxmetre = table.Column<int>(type: "integer", nullable: false),
                    numuneadet = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_ulke",
                columns: table => new
                {
                    ulkekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ulkead = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ulkeadIngilizce = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ulke_1", x => x.ulkekod);
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    revizyonkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "((1))"),
                    uruntipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    musterikod = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    mamultip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    mamultipkod = table.Column<int>(type: "integer", nullable: false),
                    slevetip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    urunadi = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    urunfaturaadi = table.Column<string>(type: "character varying(64)", unicode: false, maxLength: 64, nullable: false),
                    urunadiIngilizce = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    spekkod = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    tekebadboy = table.Column<double>(type: "double precision", nullable: false),
                    tekebaden = table.Column<double>(type: "double precision", nullable: false),
                    tekebadyukseklik = table.Column<double>(type: "double precision", nullable: false),
                    yyadet = table.Column<short>(type: "smallint", nullable: false),
                    aabosluk = table.Column<double>(type: "double precision", nullable: false),
                    yybosluk = table.Column<double>(type: "double precision", nullable: false),
                    yybitisikadet = table.Column<short>(type: "smallint", nullable: false),
                    baskiaabosluk = table.Column<double>(type: "double precision", nullable: false),
                    lf = table.Column<double>(type: "double precision", nullable: false),
                    yapistirmapayi = table.Column<double>(type: "double precision", nullable: false),
                    cl = table.Column<double>(type: "double precision", nullable: false),
                    malzemekod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    malzemezorunlu = table.Column<bool>(type: "boolean", nullable: false),
                    malzemekod2 = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    malzemeek = table.Column<short>(type: "smallint", nullable: false),
                    bicakek = table.Column<short>(type: "smallint", nullable: false),
                    makinaek = table.Column<short>(type: "smallint", nullable: false),
                    kliseno = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    yapiskankod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    tasiyicikod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    laminasyoncinsi = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false, defaultValueSql: "('')"),
                    minstok = table.Column<double>(type: "double precision", nullable: false),
                    maxstok = table.Column<double>(type: "double precision", nullable: false),
                    siparismiktar = table.Column<double>(type: "double precision", nullable: false),
                    muhasebekod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    urunnot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    imalatcikod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    adettakim = table.Column<bool>(type: "boolean", nullable: false),
                    takimmiktar = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    rulobirim = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    adettakim2 = table.Column<bool>(type: "boolean", nullable: false),
                    takimmiktar2 = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    yarimamulkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    kullanimalanikod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    yapisalkod1 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    yapisalkod2 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    yapisalkod3 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    opaklikkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    parlaklikkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    cekeryuzde = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    yogunluk = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "('')"),
                    kalinlik = table.Column<short>(type: "smallint", nullable: false),
                    gramaj = table.Column<double>(type: "double precision", nullable: false),
                    gramajbutun = table.Column<double>(type: "double precision", nullable: false),
                    paketmiktar = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    paketbirimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    iccap = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    maliyetfiyat = table.Column<double>(type: "double precision", nullable: false),
                    acilisfiyat = table.Column<double>(type: "double precision", nullable: false),
                    uretimonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    uretimonaytarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    uretimpersonel = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    grafikonay = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    grafikonaytarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    grafikpersonel = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    alan = table.Column<double>(type: "double precision", nullable: false),
                    agirlik = table.Column<double>(type: "double precision", nullable: false),
                    ambalaj = table.Column<bool>(type: "boolean", nullable: false),
                    depolama = table.Column<double>(type: "double precision", nullable: false),
                    sabagkod = table.Column<string>(type: "character varying(13)", unicode: false, maxLength: 13, nullable: false, defaultValueSql: "('')"),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    adetagirlik = table.Column<double>(type: "double precision", nullable: false),
                    adeten = table.Column<double>(type: "double precision", nullable: false),
                    adetboy = table.Column<double>(type: "double precision", nullable: false),
                    genelkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    maliyetbirimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    imalatkod = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    imalatadi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    baskitipkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    eskiurunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    urunkullanilmiyor = table.Column<bool>(type: "boolean", nullable: false),
                    uruneken = table.Column<double>(type: "double precision", nullable: false),
                    tasiyicieken = table.Column<double>(type: "double precision", nullable: false),
                    gidergrupkod = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    konsinyemiktar = table.Column<double>(type: "double precision", nullable: false),
                    konsinyealan = table.Column<double>(type: "double precision", nullable: false),
                    konsinyetarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    hammaddefiyatbirimi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    resim = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    resimtarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    uygulamasekli = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    holtmelt = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    perfore = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    devamlilik = table.Column<bool>(type: "boolean", nullable: false),
                    arsivno = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    boyayogunluk = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('C')"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_agirlik",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    urunmiktar = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    tekebadboy = table.Column<double>(type: "double precision", nullable: false),
                    tekebaden = table.Column<double>(type: "double precision", nullable: false),
                    tekebadyukseklik = table.Column<double>(type: "double precision", nullable: false),
                    urunagirlik = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_amb",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: true),
                    amb = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_ambalaji",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    en = table.Column<float>(type: "real", nullable: true),
                    boy = table.Column<float>(type: "real", nullable: true),
                    yuk = table.Column<float>(type: "real", nullable: true),
                    hacim = table.Column<float>(type: "real", nullable: true),
                    agirlik = table.Column<float>(type: "real", nullable: true),
                    miktar = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_birim",
                columns: table => new
                {
                    birimno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    ekbirimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    miktar = table.Column<double>(type: "double precision", nullable: false),
                    ekmiktar = table.Column<double>(type: "double precision", nullable: false),
                    birimoran = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_ekbicak",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    bicakek = table.Column<short>(type: "smallint", nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_fire",
                columns: table => new
                {
                    urunfirekod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_firma",
                columns: table => new
                {
                    urunfirmaid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    maliyetkodu = table.Column<int>(type: "integer", nullable: false),
                    urunno = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    urunfaturaadi = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    urunmusterikod = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, defaultValueSql: "('')"),
                    uruncesidi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('M')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_hareket",
                columns: table => new
                {
                    hareketid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    hareketno = table.Column<int>(type: "integer", nullable: false),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    harekettipkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    cikistarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    cikismiktar1 = table.Column<double>(type: "double precision", nullable: false),
                    cikismiktar2 = table.Column<double>(type: "double precision", nullable: false),
                    cikistabaka = table.Column<int>(type: "integer", nullable: false),
                    netcikis = table.Column<double>(type: "double precision", nullable: false),
                    giristarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    girismiktar1 = table.Column<double>(type: "double precision", nullable: false),
                    girismiktar2 = table.Column<double>(type: "double precision", nullable: false),
                    giristabaka = table.Column<int>(type: "integer", nullable: false),
                    netgiris = table.Column<double>(type: "double precision", nullable: false),
                    muadil = table.Column<bool>(type: "boolean", nullable: false),
                    muadilurunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    fisno = table.Column<string>(type: "character varying(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    irsaliyeno = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    irsaliyetarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    aciklama = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    revizesiparisno = table.Column<int>(type: "integer", nullable: false),
                    kullanildi = table.Column<bool>(type: "boolean", nullable: false),
                    belgeno = table.Column<long>(type: "bigint", nullable: false),
                    terminno = table.Column<long>(type: "bigint", nullable: false),
                    said = table.Column<long>(type: "bigint", nullable: false),
                    sasiparisno = table.Column<int>(type: "integer", nullable: false),
                    sira = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    teslimno = table.Column<int>(type: "integer", nullable: false),
                    sevkiyatno = table.Column<int>(type: "integer", nullable: false),
                    yyadet = table.Column<short>(type: "smallint", nullable: false),
                    idealen = table.Column<double>(type: "double precision", nullable: false),
                    satirdetayid = table.Column<long>(type: "bigint", nullable: false),
                    sipihtiyacid = table.Column<long>(type: "bigint", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_ihtiyac",
                columns: table => new
                {
                    urunihtiyacid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    ambalajkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    adetoran = table.Column<double>(type: "double precision", nullable: false),
                    alanoran = table.Column<double>(type: "double precision", nullable: false),
                    agirlikoran = table.Column<double>(type: "double precision", nullable: false),
                    urunoran = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "((1))"),
                    ambalajoran = table.Column<double>(type: "double precision", nullable: false, defaultValueSql: "((1))"),
                    urunbirimtip = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    ambalajbirimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    siparisaktar = table.Column<bool>(type: "boolean", nullable: false),
                    ambalaj = table.Column<bool>(type: "boolean", nullable: false),
                    eni = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "((1))"),
                    en = table.Column<double>(type: "double precision", nullable: false),
                    hammadde = table.Column<bool>(type: "boolean", nullable: false),
                    urunislemid = table.Column<long>(type: "bigint", nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    urunmalzemeid = table.Column<long>(type: "bigint", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_kk",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    sira = table.Column<short>(type: "smallint", nullable: false),
                    iccap = table.Column<short>(type: "smallint", nullable: false),
                    discap = table.Column<short>(type: "smallint", nullable: false),
                    bobindeadet = table.Column<int>(type: "integer", nullable: false),
                    bobindebirim = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    akisyonu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    musteriyyadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_lf",
                columns: table => new
                {
                    urunlfid = table.Column<long>(type: "bigint", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    lf = table.Column<double>(type: "double precision", nullable: false),
                    aramesafe = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_makina",
                columns: table => new
                {
                    urunislemid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    sira = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    ekgecis = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    artisetupsure = table.Column<short>(type: "smallint", nullable: false),
                    artisaattehiz = table.Column<double>(type: "double precision", nullable: false),
                    dislidegeri = table.Column<double>(type: "double precision", nullable: false),
                    dislisayisi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    aaadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    yyadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    islemsayisi = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_malzeme",
                columns: table => new
                {
                    urunmalzemeid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    sira = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1))"),
                    yapisalkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    malzemekod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    urunbirimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    urunislemid = table.Column<long>(type: "bigint", nullable: false),
                    hammadde = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "((1))"),
                    gramaj = table.Column<double>(type: "double precision", nullable: false),
                    malzemeuretimeni = table.Column<double>(type: "double precision", nullable: false),
                    yyadet = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    hamyarimamul = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('H')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_mamul_tip",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    mamultipkod = table.Column<int>(type: "integer", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_onay",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: true),
                    uretimonaytarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    uretimpersonel = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true),
                    grafikonaytarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    grafikpersonel = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_resim",
                columns: table => new
                {
                    resimId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    resim = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    resimtarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_revizyon",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    revizyonkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    alan = table.Column<string>(type: "character varying(255)", unicode: false, maxLength: 255, nullable: false),
                    eskiveri = table.Column<string>(type: "text", nullable: true),
                    yeniveri = table.Column<string>(type: "text", nullable: true),
                    desigtirenadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    degistirmetarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_sevk",
                columns: table => new
                {
                    urunsevkid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    siparisno = table.Column<long>(type: "bigint", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    urunno = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    setmi = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    takimtek = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    subekod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    miktar = table.Column<double>(type: "double precision", nullable: false),
                    sevkedildi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    sevktaleptarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    koliadet = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1))"),
                    ruloadet = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "((1))"),
                    urunadet = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    birimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_sevk_detay",
                columns: table => new
                {
                    urunsevkdetayid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    aracid = table.Column<int>(type: "integer", nullable: false),
                    plaka = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    sevktarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    toplamagirlik = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_sevk_detay_alt",
                columns: table => new
                {
                    urunsevkaltid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urunsevkdetayid = table.Column<long>(type: "bigint", nullable: false),
                    urunsevkid = table.Column<long>(type: "bigint", nullable: false),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    siparisno = table.Column<long>(type: "bigint", nullable: false),
                    takimtek = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    setmi = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    subekod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    urunno = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    sevkmiktar = table.Column<double>(type: "double precision", nullable: false),
                    agirlik = table.Column<double>(type: "double precision", nullable: false),
                    belgekesildi = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    belgetipi = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    yenifiyat = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    onaysiz = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_stokkart",
                columns: table => new
                {
                    stokid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    uruntipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    urunno = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    miktar1 = table.Column<double>(type: "double precision", nullable: false),
                    miktar2 = table.Column<double>(type: "double precision", nullable: false),
                    tabaka = table.Column<int>(type: "integer", nullable: false),
                    netmiktar = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    stokgramaji = table.Column<double>(type: "double precision", nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    kagittipi = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    setmi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    tabakaboy = table.Column<double>(type: "double precision", nullable: false),
                    depokod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    uyarinotu = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    sevkiyatno = table.Column<int>(type: "integer", nullable: false),
                    sevkiyatno2 = table.Column<int>(type: "integer", nullable: false),
                    koliadet = table.Column<int>(type: "integer", nullable: false),
                    ruloadet = table.Column<int>(type: "integer", nullable: false),
                    urunadet = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    toplamadet = table.Column<double>(type: "double precision", nullable: false),
                    rafkodu = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    fiyat = table.Column<double>(type: "double precision", nullable: false),
                    dovizkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    fiyattl = table.Column<double>(type: "double precision", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    gideceksiparisno = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    giriskkno = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    teslimno = table.Column<int>(type: "integer", nullable: false),
                    kkpersonelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    dosyano = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    sevkbekleyenmiktar = table.Column<double>(type: "double precision", nullable: false),
                    faturaedildi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    faturasevkno = table.Column<long>(type: "bigint", nullable: false),
                    sarfedildi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    sikayetno = table.Column<long>(type: "bigint", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_stokkart_iade",
                columns: table => new
                {
                    vardiyano = table.Column<int>(type: "integer", nullable: false),
                    vardiyaaltno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    hareketno = table.Column<int>(type: "integer", nullable: false),
                    iademiktar1 = table.Column<double>(type: "double precision", nullable: false),
                    iademiktar2 = table.Column<double>(type: "double precision", nullable: false),
                    netiade = table.Column<double>(type: "double precision", nullable: false),
                    iadealindi = table.Column<bool>(type: "boolean", nullable: false),
                    iadealinditarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    etiketbasildi = table.Column<bool>(type: "boolean", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_stokkart_siparis",
                columns: table => new
                {
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    miktar1 = table.Column<double>(type: "double precision", nullable: false),
                    miktar2 = table.Column<double>(type: "double precision", nullable: true),
                    netmiktar = table.Column<double>(type: "double precision", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_tavsiye_en",
                columns: table => new
                {
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    yyadet = table.Column<byte>(type: "smallint", nullable: false),
                    en = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_urun_tip",
                columns: table => new
                {
                    uruntipkod = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_vardiya",
                columns: table => new
                {
                    vardiyano = table.Column<int>(type: "integer", nullable: false),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    zamanfiretoplami = table.Column<double>(type: "double precision", nullable: false),
                    urunfirealan = table.Column<double>(type: "double precision", nullable: false),
                    urunalan = table.Column<double>(type: "double precision", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_vardiya_bicak",
                columns: table => new
                {
                    vardiyaaltno = table.Column<int>(type: "integer", nullable: false),
                    bicakkodu = table.Column<string>(type: "character varying(8)", unicode: false, maxLength: 8, nullable: false),
                    yenilemeno = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    tursayisi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_vardiya_hareket",
                columns: table => new
                {
                    vardiyano = table.Column<int>(type: "integer", nullable: false),
                    vardiyaaltno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    hammadde = table.Column<bool>(type: "boolean", nullable: false),
                    hareketno = table.Column<int>(type: "integer", nullable: false),
                    harcananalan = table.Column<double>(type: "double precision", nullable: false),
                    firealan = table.Column<double>(type: "double precision", nullable: false),
                    harcananalan2 = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_vardiya_urun",
                columns: table => new
                {
                    vardiyano = table.Column<int>(type: "integer", nullable: false),
                    vardiyaaltno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    depocikis = table.Column<double>(type: "double precision", nullable: false),
                    depoiade = table.Column<double>(type: "double precision", nullable: false),
                    depoiadekontrol = table.Column<bool>(type: "boolean", nullable: false),
                    deviralinan = table.Column<double>(type: "double precision", nullable: false),
                    devirverilen = table.Column<double>(type: "double precision", nullable: false),
                    sarfiyat = table.Column<double>(type: "double precision", nullable: false),
                    harcanan = table.Column<double>(type: "double precision", nullable: false),
                    netharcanan = table.Column<double>(type: "double precision", nullable: false),
                    toplamadet = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    hammadde = table.Column<bool>(type: "boolean", nullable: false),
                    hareketno = table.Column<int>(type: "integer", nullable: false),
                    sira = table.Column<short>(type: "smallint", nullable: false),
                    birlesikadet = table.Column<short>(type: "smallint", nullable: false),
                    kullanildi = table.Column<bool>(type: "boolean", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_vardiya_urun_detay",
                columns: table => new
                {
                    vardiyano = table.Column<int>(type: "integer", nullable: false),
                    vardiyaaltno = table.Column<int>(type: "integer", nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    stokkod = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: false),
                    hareketno = table.Column<int>(type: "integer", nullable: false),
                    kullanilanmiktar1 = table.Column<double>(type: "double precision", nullable: false),
                    kullanilanmiktar2 = table.Column<double>(type: "double precision", nullable: false),
                    netkullanilan = table.Column<double>(type: "double precision", nullable: false),
                    hammaddeenadet = table.Column<short>(type: "smallint", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_vardiya_urun_fire",
                columns: table => new
                {
                    vardiyano = table.Column<int>(type: "integer", nullable: false),
                    vardiyaaltno = table.Column<int>(type: "integer", nullable: false),
                    urunfirekod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    urunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false),
                    siparisurunkod = table.Column<string>(type: "character varying(6)", unicode: false, maxLength: 6, nullable: false, defaultValueSql: "('')"),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    miktar = table.Column<double>(type: "double precision", nullable: false),
                    netmiktar = table.Column<double>(type: "double precision", nullable: false),
                    birimkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    siparisno = table.Column<int>(type: "integer", nullable: false),
                    islemkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_vardiya_zaman",
                columns: table => new
                {
                    vardiyano = table.Column<int>(type: "integer", nullable: false),
                    vardiyaaltno = table.Column<int>(type: "integer", nullable: false),
                    siparismakinaid = table.Column<long>(type: "bigint", nullable: false),
                    baslangicgun = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    baslangicsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    bitisgun = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    bitissaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sorumlupersonelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    netsure = table.Column<short>(type: "smallint", nullable: false),
                    makinakodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    sira = table.Column<short>(type: "smallint", nullable: false),
                    uretimmiktar = table.Column<double>(type: "double precision", nullable: false),
                    bicakyyadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    bicakaaadet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    neturetim = table.Column<double>(type: "double precision", nullable: false),
                    uretimmetraj = table.Column<double>(type: "double precision", nullable: false),
                    zamanfiretoplami = table.Column<double>(type: "double precision", nullable: false),
                    urunfirealan = table.Column<double>(type: "double precision", nullable: false),
                    urunalan = table.Column<double>(type: "double precision", nullable: false),
                    yikananunite = table.Column<short>(type: "smallint", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_vardiya_zaman_fire",
                columns: table => new
                {
                    vardiyaaltno = table.Column<int>(type: "integer", nullable: false),
                    zamanfirekod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    miktar = table.Column<short>(type: "smallint", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_versiyon",
                columns: table => new
                {
                    versiyonId = table.Column<int>(type: "integer", nullable: false),
                    versiyonAd = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    versiyonmajor = table.Column<short>(type: "smallint", nullable: false),
                    versiyonminor = table.Column<short>(type: "smallint", nullable: false),
                    versiyonrevize = table.Column<short>(type: "smallint", nullable: false),
                    versiyontarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    versiyonaciklama = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_yapisal1",
                columns: table => new
                {
                    yapisalkod1 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_yapisal2",
                columns: table => new
                {
                    yapisalkod1 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    yapisalkod2 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_yapisal3",
                columns: table => new
                {
                    yapisalkod1 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    yapisalkod2 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    yapisalkod3 = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_yapiskan",
                columns: table => new
                {
                    yapiskankod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_yarimamulkod",
                columns: table => new
                {
                    yarimamulkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_zaman_fire",
                columns: table => new
                {
                    zamanfirekod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    kodaciklama = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_firma",
                columns: table => new
                {
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    tip = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    statu = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false),
                    ozelkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    kisaad = table.Column<string>(type: "character varying(32)", unicode: false, maxLength: 32, nullable: false),
                    ticariad = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    faturaadres1 = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, defaultValueSql: "('')"),
                    faturaadres2 = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, defaultValueSql: "('')"),
                    postakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    ilcekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ilkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ulkekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    telefon1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    telefon2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    faks1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    faks2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    mail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    web = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    muhasebekod = table.Column<string>(type: "character varying(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    muhasebekodsatis = table.Column<string>(type: "character varying(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    sektorkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    sektoraltkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    grupkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    vergidairesi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    vergino = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    odemesekli = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    personelkodu2 = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    grafikperskod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    risklimiti = table.Column<double>(type: "double precision", nullable: false),
                    parabirimi = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    parabirimicari = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    durumfirmakod = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    sonaktiftarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ozelnot = table.Column<string>(type: "character varying(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    irsaliyenot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    faturanot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    istihbaratonay = table.Column<bool>(type: "boolean", nullable: false),
                    istihbaratnot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    istihbaratpersonelkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    tckimlikno = table.Column<string>(type: "character varying(11)", unicode: false, maxLength: 11, nullable: false, defaultValueSql: "('')"),
                    sorunlu = table.Column<bool>(type: "boolean", nullable: false),
                    sorunnot = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    valor = table.Column<double>(type: "double precision", nullable: false),
                    odemekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    sevkiyatkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    sevklimit = table.Column<short>(type: "smallint", nullable: false),
                    kalitefiyat = table.Column<short>(type: "smallint", nullable: false),
                    kaliteiletisim = table.Column<short>(type: "smallint", nullable: false),
                    ilksiparistarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ilksiparispersonel = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    sonsiparistarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    soniletisimtarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    faturatipi = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('S')"),
                    sabitkur = table.Column<double>(type: "double precision", nullable: false),
                    yuvarlama = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "((6))"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    sekId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_firma", x => x.firmakod);
                    table.ForeignKey(
                        name: "FK_tbl_firma_tbl_sektor",
                        column: x => x.sekId,
                        principalTable: "tbl_sektor",
                        principalColumn: "SekID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_firma_tbl_ulke",
                        column: x => x.ulkekod,
                        principalTable: "tbl_ulke",
                        principalColumn: "ulkekod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_firma_durum",
                columns: table => new
                {
                    durumno = table.Column<long>(type: "bigint", nullable: false),
                    tarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    durumfirmakod = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tbl_firma_durum_tbl_firma",
                        column: x => x.firmakod,
                        principalTable: "tbl_firma",
                        principalColumn: "firmakod",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Firma nin aktif veya pasif durumunu tutan tablo");

            migrationBuilder.CreateTable(
                name: "tbl_firma_firma",
                columns: table => new
                {
                    firmafirmaid = table.Column<int>(type: "integer", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    firma = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    alicikod = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    saticikod = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    firmId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_firma_firma", x => x.firmafirmaid);
                    table.ForeignKey(
                        name: "FK_tbl_firma_firma_tbl_firm",
                        column: x => x.firmId,
                        principalTable: "tbl_firm",
                        principalColumn: "firmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_firma_firma_tbl_firma",
                        column: x => x.firmakod,
                        principalTable: "tbl_firma",
                        principalColumn: "firmakod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_firma_gorusmeler",
                columns: table => new
                {
                    gorid = table.Column<long>(type: "bigint", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    gorusmeno = table.Column<short>(type: "smallint", nullable: false),
                    teknikno = table.Column<int>(type: "integer", nullable: false),
                    gorusmetarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    gorusmetipno = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    gorusmenotu = table.Column<string>(type: "text", nullable: false),
                    gorusmebitti = table.Column<bool>(type: "boolean", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_firma_gorusmeler", x => x.gorid);
                    table.ForeignKey(
                        name: "FK_tbl_firma_gorusmeler_tbl_firma",
                        column: x => x.firmakod,
                        principalTable: "tbl_firma",
                        principalColumn: "firmakod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_firma_kontakt",
                columns: table => new
                {
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    kisikod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    ad = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    iptalet = table.Column<string>(type: "character varying(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    departman = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    gorevi = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    dogumtarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    hobiler = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    adres1 = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, defaultValueSql: "('')"),
                    adres2 = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, defaultValueSql: "('')"),
                    postakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    ilcekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ilkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ulkekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    telefon1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    mail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    esadi = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    esdogum = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    evliliktarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    spor = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    takimi = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    evhayvani = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tbl_firma_kontakt_tbl_firma",
                        column: x => x.firmakod,
                        principalTable: "tbl_firma",
                        principalColumn: "firmakod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_firma_personel",
                columns: table => new
                {
                    firmaPersId = table.Column<long>(type: "bigint", nullable: false),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    firmId = table.Column<short>(type: "smallint", nullable: false),
                    personelkodu = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false),
                    personelgrupkod = table.Column<string>(type: "character varying(2)", unicode: false, maxLength: 2, nullable: false),
                    aciklama = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tbl_firma_personel_tbl_firma",
                        column: x => x.firmakod,
                        principalTable: "tbl_firma",
                        principalColumn: "firmakod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_firma_teslimat",
                columns: table => new
                {
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    subekod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    firmateslimatid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    subead = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    teslimatadres1 = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, defaultValueSql: "('')"),
                    teslimatadres2 = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, defaultValueSql: "('')"),
                    postakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "('')"),
                    ilcekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ilkod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    ulkekod = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    telefon1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    telefon2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    faks1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    faks2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    mail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    web = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    vergidairesi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    vergino = table.Column<string>(type: "character varying(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    tckimlikno = table.Column<string>(type: "character varying(11)", unicode: false, maxLength: 11, nullable: false, defaultValueSql: "('')"),
                    kullanilmiyor = table.Column<bool>(type: "boolean", nullable: false),
                    ek1 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek2 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek3 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    ek4 = table.Column<string>(type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    olusturanadisoyadi = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: false),
                    olusturmatarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_firma_teslimat", x => new { x.firmakod, x.subekod });
                    table.ForeignKey(
                        name: "FK_tbl_firma_teslimat_tbl_firma",
                        column: x => x.firmakod,
                        principalTable: "tbl_firma",
                        principalColumn: "firmakod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_firma_teslimat_etiket",
                columns: table => new
                {
                    firmaEtiketId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firmakod = table.Column<string>(type: "character varying(5)", unicode: false, maxLength: 5, nullable: false),
                    subekod = table.Column<string>(type: "character varying(4)", unicode: false, maxLength: 4, nullable: false),
                    etikettipi = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_firma_teslimat_etiket", x => x.firmaEtiketId);
                    table.ForeignKey(
                        name: "FK_tbl_firma_teslimat_etiket_tbl_firma_teslimat",
                        columns: x => new { x.firmakod, x.subekod },
                        principalTable: "tbl_firma_teslimat",
                        principalColumns: new[] { "firmakod", "subekod" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_sekId",
                table: "tbl_firma",
                column: "sekId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_ulkekod",
                table: "tbl_firma",
                column: "ulkekod");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_durum_firmakod",
                table: "tbl_firma_durum",
                column: "firmakod");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_firma_firmakod",
                table: "tbl_firma_firma",
                column: "firmakod");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_firma_firmId",
                table: "tbl_firma_firma",
                column: "firmId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_gorusmeler_firmakod",
                table: "tbl_firma_gorusmeler",
                column: "firmakod");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_kontakt_firmakod",
                table: "tbl_firma_kontakt",
                column: "firmakod");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_personel_firmakod",
                table: "tbl_firma_personel",
                column: "firmakod");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_firma_teslimat_etiket_firmakod_subekod",
                table: "tbl_firma_teslimat_etiket",
                columns: new[] { "firmakod", "subekod" });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_sektor",
                table: "tbl_sektor",
                columns: new[] { "sektorkod", "sektoraltkod" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_anilox");

            migrationBuilder.DropTable(
                name: "tbl_arac");

            migrationBuilder.DropTable(
                name: "tbl_bakim");

            migrationBuilder.DropTable(
                name: "tbl_baski_tip");

            migrationBuilder.DropTable(
                name: "tbl_baski_tip_detay");

            migrationBuilder.DropTable(
                name: "tbl_bicak");

            migrationBuilder.DropTable(
                name: "tbl_bicak_disli");

            migrationBuilder.DropTable(
                name: "tbl_bicak_iz");

            migrationBuilder.DropTable(
                name: "tbl_bicak_makina");

            migrationBuilder.DropTable(
                name: "tbl_bicak_sebep");

            migrationBuilder.DropTable(
                name: "tbl_bicak_sekil");

            migrationBuilder.DropTable(
                name: "tbl_bicak_tip");

            migrationBuilder.DropTable(
                name: "tbl_bicak_yenileme");

            migrationBuilder.DropTable(
                name: "tbl_birim");

            migrationBuilder.DropTable(
                name: "tbl_boy_hesap");

            migrationBuilder.DropTable(
                name: "tbl_carpan");

            migrationBuilder.DropTable(
                name: "tbl_degisen");

            migrationBuilder.DropTable(
                name: "tbl_depo");

            migrationBuilder.DropTable(
                name: "tbl_depo_firma");

            migrationBuilder.DropTable(
                name: "tbl_dilim");

            migrationBuilder.DropTable(
                name: "tbl_dilim_gecici");

            migrationBuilder.DropTable(
                name: "tbl_dilim_gecici1");

            migrationBuilder.DropTable(
                name: "tbl_dilim_kombine");

            migrationBuilder.DropTable(
                name: "tbl_disli_hesap");

            migrationBuilder.DropTable(
                name: "tbl_dof");

            migrationBuilder.DropTable(
                name: "tbl_dof_dagitim");

            migrationBuilder.DropTable(
                name: "tbl_dof_grup");

            migrationBuilder.DropTable(
                name: "tbl_dof_personel");

            migrationBuilder.DropTable(
                name: "tbl_dof_tip");

            migrationBuilder.DropTable(
                name: "tbl_doviz");

            migrationBuilder.DropTable(
                name: "tbl_doviz_kur");

            migrationBuilder.DropTable(
                name: "tbl_durum");

            migrationBuilder.DropTable(
                name: "tbl_durum_firma");

            migrationBuilder.DropTable(
                name: "tbl_durum_teklif");

            migrationBuilder.DropTable(
                name: "tbl_ekstragider_tip");

            migrationBuilder.DropTable(
                name: "tbl_fire_islem");

            migrationBuilder.DropTable(
                name: "tbl_fire_makina");

            migrationBuilder.DropTable(
                name: "tbl_firma_durum");

            migrationBuilder.DropTable(
                name: "tbl_firma_firma");

            migrationBuilder.DropTable(
                name: "tbl_firma_gorusmeler");

            migrationBuilder.DropTable(
                name: "tbl_firma_kontakt");

            migrationBuilder.DropTable(
                name: "tbl_firma_kontakt_cocuk");

            migrationBuilder.DropTable(
                name: "tbl_firma_personel");

            migrationBuilder.DropTable(
                name: "tbl_firma_teslimat_etiket");

            migrationBuilder.DropTable(
                name: "tbl_genel");

            migrationBuilder.DropTable(
                name: "tbl_gerceklesen_satis");

            migrationBuilder.DropTable(
                name: "tbl_gider");

            migrationBuilder.DropTable(
                name: "tbl_gorusme_teknik");

            migrationBuilder.DropTable(
                name: "tbl_gorusme_tip");

            migrationBuilder.DropTable(
                name: "tbl_grafik");

            migrationBuilder.DropTable(
                name: "tbl_grafik_durum");

            migrationBuilder.DropTable(
                name: "tbl_grafik_islem");

            migrationBuilder.DropTable(
                name: "tbl_grafik_onay");

            migrationBuilder.DropTable(
                name: "tbl_grup");

            migrationBuilder.DropTable(
                name: "tbl_hareket_tip");

            migrationBuilder.DropTable(
                name: "tbl_hatirlama");

            migrationBuilder.DropTable(
                name: "tbl_hatirlama_personel");

            migrationBuilder.DropTable(
                name: "tbl_hedef_satis");

            migrationBuilder.DropTable(
                name: "tbl_il");

            migrationBuilder.DropTable(
                name: "tbl_il_ilce");

            migrationBuilder.DropTable(
                name: "tbl_imalatci");

            migrationBuilder.DropTable(
                name: "tbl_islem");

            migrationBuilder.DropTable(
                name: "tbl_islem_tip");

            migrationBuilder.DropTable(
                name: "tbl_kalite_ilk");

            migrationBuilder.DropTable(
                name: "tbl_kalite_son");

            migrationBuilder.DropTable(
                name: "tbl_klise");

            migrationBuilder.DropTable(
                name: "tbl_klise_alt");

            migrationBuilder.DropTable(
                name: "tbl_klise_ebad");

            migrationBuilder.DropTable(
                name: "tbl_klise_film");

            migrationBuilder.DropTable(
                name: "tbl_klise_gonderme");

            migrationBuilder.DropTable(
                name: "tbl_klise_pantone");

            migrationBuilder.DropTable(
                name: "tbl_klise_revizyon");

            migrationBuilder.DropTable(
                name: "tbl_klise_revizyon_sebep");

            migrationBuilder.DropTable(
                name: "tbl_klise_sabagkod");

            migrationBuilder.DropTable(
                name: "tbl_klise_saklama");

            migrationBuilder.DropTable(
                name: "tbl_klise_sebep");

            migrationBuilder.DropTable(
                name: "tbl_klise_takim");

            migrationBuilder.DropTable(
                name: "tbl_klise_tip");

            migrationBuilder.DropTable(
                name: "tbl_klise_uyum");

            migrationBuilder.DropTable(
                name: "tbl_klise_yenileme");

            migrationBuilder.DropTable(
                name: "tbl_konsinye");

            migrationBuilder.DropTable(
                name: "tbl_kullanimalani");

            migrationBuilder.DropTable(
                name: "tbl_makina_bakim");

            migrationBuilder.DropTable(
                name: "tbl_makina_bakim_hareket");

            migrationBuilder.DropTable(
                name: "tbl_makina_bicaktip");

            migrationBuilder.DropTable(
                name: "tbl_makina_birim");

            migrationBuilder.DropTable(
                name: "tbl_makina_bol");

            migrationBuilder.DropTable(
                name: "tbl_makina_calisma");

            migrationBuilder.DropTable(
                name: "tbl_makina_calisma_hafta");

            migrationBuilder.DropTable(
                name: "tbl_makina_disli");

            migrationBuilder.DropTable(
                name: "tbl_makina_gider");

            migrationBuilder.DropTable(
                name: "tbl_makina_gider_grup");

            migrationBuilder.DropTable(
                name: "tbl_makina_grup");

            migrationBuilder.DropTable(
                name: "tbl_makina_islem");

            migrationBuilder.DropTable(
                name: "tbl_makina_islem_urun");

            migrationBuilder.DropTable(
                name: "tbl_makina_kart");

            migrationBuilder.DropTable(
                name: "tbl_maliyet");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_adet");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_carpan");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_indirim");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_islem");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_islem_urun");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_islem_zorunlu");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_lf");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_malzeme");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_onay");

            migrationBuilder.DropTable(
                name: "tbl_maliyet_sabit");

            migrationBuilder.DropTable(
                name: "tbl_mamul_tip");

            migrationBuilder.DropTable(
                name: "tbl_mamul_tip_hat");

            migrationBuilder.DropTable(
                name: "tbl_muadil");

            migrationBuilder.DropTable(
                name: "tbl_odeme");

            migrationBuilder.DropTable(
                name: "tbl_opaklik");

            migrationBuilder.DropTable(
                name: "tbl_parametre");

            migrationBuilder.DropTable(
                name: "tbl_parlaklik");

            migrationBuilder.DropTable(
                name: "tbl_personel");

            migrationBuilder.DropTable(
                name: "tbl_personel_bilgisayar");

            migrationBuilder.DropTable(
                name: "tbl_personel_ceza");

            migrationBuilder.DropTable(
                name: "tbl_personel_dil");

            migrationBuilder.DropTable(
                name: "tbl_personel_egitim");

            migrationBuilder.DropTable(
                name: "tbl_personel_egitim_personel");

            migrationBuilder.DropTable(
                name: "tbl_personel_eposta");

            migrationBuilder.DropTable(
                name: "tbl_personel_firm");

            migrationBuilder.DropTable(
                name: "tbl_personel_grup");

            migrationBuilder.DropTable(
                name: "tbl_personel_ihtiyac");

            migrationBuilder.DropTable(
                name: "tbl_personel_islem");

            migrationBuilder.DropTable(
                name: "tbl_personel_izin");

            migrationBuilder.DropTable(
                name: "tbl_personel_izin_hak");

            migrationBuilder.DropTable(
                name: "tbl_personel_kart");

            migrationBuilder.DropTable(
                name: "tbl_personel_kurs");

            migrationBuilder.DropTable(
                name: "tbl_personel_makina");

            migrationBuilder.DropTable(
                name: "tbl_personel_makina_grup");

            migrationBuilder.DropTable(
                name: "tbl_personel_saglik");

            migrationBuilder.DropTable(
                name: "tbl_planlama");

            migrationBuilder.DropTable(
                name: "tbl_randevu");

            migrationBuilder.DropTable(
                name: "tbl_sa_istek");

            migrationBuilder.DropTable(
                name: "tbl_sa_siparis");

            migrationBuilder.DropTable(
                name: "tbl_sa_siparis_klise");

            migrationBuilder.DropTable(
                name: "tbl_sa_siparis_siparis");

            migrationBuilder.DropTable(
                name: "tbl_sa_siparis_teslim");

            migrationBuilder.DropTable(
                name: "tbl_sa_siparis_teslim_detay");

            migrationBuilder.DropTable(
                name: "tbl_sa_teklif");

            migrationBuilder.DropTable(
                name: "tbl_sa_teklif_fiyat");

            migrationBuilder.DropTable(
                name: "tbl_sabagkod");

            migrationBuilder.DropTable(
                name: "tbl_sevk");

            migrationBuilder.DropTable(
                name: "tbl_sevk_alt");

            migrationBuilder.DropTable(
                name: "tbl_sevk_detay");

            migrationBuilder.DropTable(
                name: "tbl_sevk_tip");

            migrationBuilder.DropTable(
                name: "tbl_sevkiyat");

            migrationBuilder.DropTable(
                name: "tbl_sikayet_gelen");

            migrationBuilder.DropTable(
                name: "tbl_sikayet_gelen_tip");

            migrationBuilder.DropTable(
                name: "tbl_sikayet_hareket");

            migrationBuilder.DropTable(
                name: "tbl_sikayet_personel");

            migrationBuilder.DropTable(
                name: "tbl_sikayet_sikayet_tip");

            migrationBuilder.DropTable(
                name: "tbl_sikayet_tutar");

            migrationBuilder.DropTable(
                name: "tbl_siparis");

            migrationBuilder.DropTable(
                name: "tbl_siparis_amb");

            migrationBuilder.DropTable(
                name: "tbl_siparis_degisiklik");

            migrationBuilder.DropTable(
                name: "tbl_siparis_detay");

            migrationBuilder.DropTable(
                name: "tbl_siparis_ekstragider");

            migrationBuilder.DropTable(
                name: "tbl_siparis_gider");

            migrationBuilder.DropTable(
                name: "tbl_siparis_hareket");

            migrationBuilder.DropTable(
                name: "tbl_siparis_ihtiyac");

            migrationBuilder.DropTable(
                name: "tbl_siparis_islem");

            migrationBuilder.DropTable(
                name: "tbl_siparis_klise");

            migrationBuilder.DropTable(
                name: "tbl_siparis_klise_alt");

            migrationBuilder.DropTable(
                name: "tbl_siparis_klise_pantone");

            migrationBuilder.DropTable(
                name: "tbl_siparis_mak");

            migrationBuilder.DropTable(
                name: "tbl_siparis_makina");

            migrationBuilder.DropTable(
                name: "tbl_siparis_onay");

            migrationBuilder.DropTable(
                name: "tbl_siparis_onay_adres");

            migrationBuilder.DropTable(
                name: "tbl_siparis_termin");

            migrationBuilder.DropTable(
                name: "tbl_siparis_teslim");

            migrationBuilder.DropTable(
                name: "tbl_siparis_teslim2");

            migrationBuilder.DropTable(
                name: "tbl_Tanim");

            migrationBuilder.DropTable(
                name: "tbl_tasiyici");

            migrationBuilder.DropTable(
                name: "tbl_teklif");

            migrationBuilder.DropTable(
                name: "tbl_teklif_fiyat");

            migrationBuilder.DropTable(
                name: "tbl_teklif_gonder");

            migrationBuilder.DropTable(
                name: "tbl_teklif_gonder_sonuc");

            migrationBuilder.DropTable(
                name: "tbl_teklif_sira");

            migrationBuilder.DropTable(
                name: "tbl_teknik_ortam");

            migrationBuilder.DropTable(
                name: "tbl_teknik_pantone");

            migrationBuilder.DropTable(
                name: "tbl_teknik_yuzey");

            migrationBuilder.DropTable(
                name: "tbl_teslimat");

            migrationBuilder.DropTable(
                name: "tbl_test");

            migrationBuilder.DropTable(
                name: "tbl_urun");

            migrationBuilder.DropTable(
                name: "tbl_urun_agirlik");

            migrationBuilder.DropTable(
                name: "tbl_urun_amb");

            migrationBuilder.DropTable(
                name: "tbl_urun_ambalaji");

            migrationBuilder.DropTable(
                name: "tbl_urun_birim");

            migrationBuilder.DropTable(
                name: "tbl_urun_ekbicak");

            migrationBuilder.DropTable(
                name: "tbl_urun_fire");

            migrationBuilder.DropTable(
                name: "tbl_urun_firma");

            migrationBuilder.DropTable(
                name: "tbl_urun_hareket");

            migrationBuilder.DropTable(
                name: "tbl_urun_ihtiyac");

            migrationBuilder.DropTable(
                name: "tbl_urun_kk");

            migrationBuilder.DropTable(
                name: "tbl_urun_lf");

            migrationBuilder.DropTable(
                name: "tbl_urun_makina");

            migrationBuilder.DropTable(
                name: "tbl_urun_malzeme");

            migrationBuilder.DropTable(
                name: "tbl_urun_mamul_tip");

            migrationBuilder.DropTable(
                name: "tbl_urun_onay");

            migrationBuilder.DropTable(
                name: "tbl_urun_resim");

            migrationBuilder.DropTable(
                name: "tbl_urun_revizyon");

            migrationBuilder.DropTable(
                name: "tbl_urun_sevk");

            migrationBuilder.DropTable(
                name: "tbl_urun_sevk_detay");

            migrationBuilder.DropTable(
                name: "tbl_urun_sevk_detay_alt");

            migrationBuilder.DropTable(
                name: "tbl_urun_stokkart");

            migrationBuilder.DropTable(
                name: "tbl_urun_stokkart_iade");

            migrationBuilder.DropTable(
                name: "tbl_urun_stokkart_siparis");

            migrationBuilder.DropTable(
                name: "tbl_urun_tavsiye_en");

            migrationBuilder.DropTable(
                name: "tbl_urun_tip");

            migrationBuilder.DropTable(
                name: "tbl_vardiya");

            migrationBuilder.DropTable(
                name: "tbl_vardiya_bicak");

            migrationBuilder.DropTable(
                name: "tbl_vardiya_hareket");

            migrationBuilder.DropTable(
                name: "tbl_vardiya_urun");

            migrationBuilder.DropTable(
                name: "tbl_vardiya_urun_detay");

            migrationBuilder.DropTable(
                name: "tbl_vardiya_urun_fire");

            migrationBuilder.DropTable(
                name: "tbl_vardiya_zaman");

            migrationBuilder.DropTable(
                name: "tbl_vardiya_zaman_fire");

            migrationBuilder.DropTable(
                name: "tbl_versiyon");

            migrationBuilder.DropTable(
                name: "tbl_yapisal1");

            migrationBuilder.DropTable(
                name: "tbl_yapisal2");

            migrationBuilder.DropTable(
                name: "tbl_yapisal3");

            migrationBuilder.DropTable(
                name: "tbl_yapiskan");

            migrationBuilder.DropTable(
                name: "tbl_yarimamulkod");

            migrationBuilder.DropTable(
                name: "tbl_zaman_fire");

            migrationBuilder.DropTable(
                name: "tbl_firm");

            migrationBuilder.DropTable(
                name: "tbl_firma_teslimat");

            migrationBuilder.DropTable(
                name: "tbl_firma");

            migrationBuilder.DropTable(
                name: "tbl_sektor");

            migrationBuilder.DropTable(
                name: "tbl_ulke");
        }
    }
}
