using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class PostgreContext : DbContext
    {
        public PostgreContext()
        {
        }

        public PostgreContext(DbContextOptions<PostgreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAnilox> TblAniloxes { get; set; }
        public virtual DbSet<TblArac> TblAracs { get; set; }
        public virtual DbSet<TblBakim> TblBakims { get; set; }
        public virtual DbSet<TblBaskiTip> TblBaskiTips { get; set; }
        public virtual DbSet<TblBaskiTipDetay> TblBaskiTipDetays { get; set; }
        public virtual DbSet<TblBicak> TblBicaks { get; set; }
        public virtual DbSet<TblBicakDisli> TblBicakDislis { get; set; }
        public virtual DbSet<TblBicakIz> TblBicakIzs { get; set; }
        public virtual DbSet<TblBicakMakina> TblBicakMakinas { get; set; }
        public virtual DbSet<TblBicakSebep> TblBicakSebeps { get; set; }
        public virtual DbSet<TblBicakSekil> TblBicakSekils { get; set; }
        public virtual DbSet<TblBicakTip> TblBicakTips { get; set; }
        public virtual DbSet<TblBicakYenileme> TblBicakYenilemes { get; set; }
        public virtual DbSet<TblBirim> TblBirims { get; set; }
        public virtual DbSet<TblBoyHesap> TblBoyHesaps { get; set; }
        public virtual DbSet<TblCarpan> TblCarpans { get; set; }
        public virtual DbSet<TblDegisen> TblDegisens { get; set; }
        public virtual DbSet<TblDepo> TblDepos { get; set; }
        public virtual DbSet<TblDepoFirma> TblDepoFirmas { get; set; }
        public virtual DbSet<TblDilim> TblDilims { get; set; }
        public virtual DbSet<TblDilimGecici> TblDilimGecicis { get; set; }
        public virtual DbSet<TblDilimGecici1> TblDilimGecici1s { get; set; }
        public virtual DbSet<TblDilimKombine> TblDilimKombines { get; set; }
        public virtual DbSet<TblDisliHesap> TblDisliHesaps { get; set; }
        public virtual DbSet<TblDof> TblDofs { get; set; }
        public virtual DbSet<TblDofDagitim> TblDofDagitims { get; set; }
        public virtual DbSet<TblDofGrup> TblDofGrups { get; set; }
        public virtual DbSet<TblDofPersonel> TblDofPersonels { get; set; }
        public virtual DbSet<TblDofTip> TblDofTips { get; set; }
        public virtual DbSet<TblDoviz> TblDovizs { get; set; }
        public virtual DbSet<TblDovizKur> TblDovizKurs { get; set; }
        public virtual DbSet<TblDurum> TblDurums { get; set; }
        public virtual DbSet<TblDurumFirma> TblDurumFirmas { get; set; }
        public virtual DbSet<TblDurumTeklif> TblDurumTeklifs { get; set; }
        public virtual DbSet<TblEkstragiderTip> TblEkstragiderTips { get; set; }
        public virtual DbSet<TblFireIslem> TblFireIslems { get; set; }
        public virtual DbSet<TblFireMakina> TblFireMakinas { get; set; }
        public virtual DbSet<TblFirm> TblFirms { get; set; }
        public virtual DbSet<TblFirma> TblFirmas { get; set; }
        public virtual DbSet<TblFirmaDurum> TblFirmaDurums { get; set; }
        public virtual DbSet<TblFirmaFirma> TblFirmaFirmas { get; set; }
        public virtual DbSet<TblFirmaGorusmeler> TblFirmaGorusmelers { get; set; }
        public virtual DbSet<TblFirmaKontakt> TblFirmaKontakts { get; set; }
        public virtual DbSet<TblFirmaKontaktCocuk> TblFirmaKontaktCocuks { get; set; }
        public virtual DbSet<TblFirmaPersonel> TblFirmaPersonels { get; set; }
        public virtual DbSet<TblFirmaTeslimat> TblFirmaTeslimats { get; set; }
        public virtual DbSet<TblFirmaTeslimatEtiket> TblFirmaTeslimatEtikets { get; set; }
        public virtual DbSet<TblGenel> TblGenels { get; set; }
        public virtual DbSet<TblGerceklesenSati> TblGerceklesenSatis { get; set; }
        public virtual DbSet<TblGider> TblGiders { get; set; }
        public virtual DbSet<TblGorusmeTeknik> TblGorusmeTekniks { get; set; }
        public virtual DbSet<TblGorusmeTip> TblGorusmeTips { get; set; }
        public virtual DbSet<TblGrafik> TblGrafiks { get; set; }
        public virtual DbSet<TblGrafikDurum> TblGrafikDurums { get; set; }
        public virtual DbSet<TblGrafikIslem> TblGrafikIslems { get; set; }
        public virtual DbSet<TblGrafikOnay> TblGrafikOnays { get; set; }
        public virtual DbSet<TblGrup> TblGrups { get; set; }
        public virtual DbSet<TblHareketTip> TblHareketTips { get; set; }
        public virtual DbSet<TblHatirlama> TblHatirlamas { get; set; }
        public virtual DbSet<TblHatirlamaPersonel> TblHatirlamaPersonels { get; set; }
        public virtual DbSet<TblHedefSati> TblHedefSatis { get; set; }
        public virtual DbSet<TblIl> TblIls { get; set; }
        public virtual DbSet<TblIlIlce> TblIlIlces { get; set; }
        public virtual DbSet<TblImalatci> TblImalatcis { get; set; }
        public virtual DbSet<TblIslem> TblIslems { get; set; }
        public virtual DbSet<TblIslemTip> TblIslemTips { get; set; }
        public virtual DbSet<TblKaliteIlk> TblKaliteIlks { get; set; }
        public virtual DbSet<TblKaliteSon> TblKaliteSons { get; set; }
        public virtual DbSet<TblKlise> TblKlises { get; set; }
        public virtual DbSet<TblKliseAlt> TblKliseAlts { get; set; }
        public virtual DbSet<TblKliseEbad> TblKliseEbads { get; set; }
        public virtual DbSet<TblKliseFilm> TblKliseFilms { get; set; }
        public virtual DbSet<TblKliseGonderme> TblKliseGondermes { get; set; }
        public virtual DbSet<TblKlisePantone> TblKlisePantones { get; set; }
        public virtual DbSet<TblKliseRevizyon> TblKliseRevizyons { get; set; }
        public virtual DbSet<TblKliseRevizyonSebep> TblKliseRevizyonSebeps { get; set; }
        public virtual DbSet<TblKliseSabagkod> TblKliseSabagkods { get; set; }
        public virtual DbSet<TblKliseSaklama> TblKliseSaklamas { get; set; }
        public virtual DbSet<TblKliseSebep> TblKliseSebeps { get; set; }
        public virtual DbSet<TblKliseTakim> TblKliseTakims { get; set; }
        public virtual DbSet<TblKliseTip> TblKliseTips { get; set; }
        public virtual DbSet<TblKliseUyum> TblKliseUyums { get; set; }
        public virtual DbSet<TblKliseYenileme> TblKliseYenilemes { get; set; }
        public virtual DbSet<TblKonsinye> TblKonsinyes { get; set; }
        public virtual DbSet<TblKullanimalani> TblKullanimalanis { get; set; }
        public virtual DbSet<TblMakinaBakim> TblMakinaBakims { get; set; }
        public virtual DbSet<TblMakinaBakimHareket> TblMakinaBakimHarekets { get; set; }
        public virtual DbSet<TblMakinaBicaktip> TblMakinaBicaktips { get; set; }
        public virtual DbSet<TblMakinaBirim> TblMakinaBirims { get; set; }
        public virtual DbSet<TblMakinaBol> TblMakinaBols { get; set; }
        public virtual DbSet<TblMakinaCalisma> TblMakinaCalismas { get; set; }
        public virtual DbSet<TblMakinaCalismaHaftum> TblMakinaCalismaHafta { get; set; }
        public virtual DbSet<TblMakinaDisli> TblMakinaDislis { get; set; }
        public virtual DbSet<TblMakinaGider> TblMakinaGiders { get; set; }
        public virtual DbSet<TblMakinaGiderGrup> TblMakinaGiderGrups { get; set; }
        public virtual DbSet<TblMakinaGrup> TblMakinaGrups { get; set; }
        public virtual DbSet<TblMakinaIslem> TblMakinaIslems { get; set; }
        public virtual DbSet<TblMakinaIslemUrun> TblMakinaIslemUruns { get; set; }
        public virtual DbSet<TblMakinaKart> TblMakinaKarts { get; set; }
        public virtual DbSet<TblMaliyet> TblMaliyets { get; set; }
        public virtual DbSet<TblMaliyetAdet> TblMaliyetAdets { get; set; }
        public virtual DbSet<TblMaliyetCarpan> TblMaliyetCarpans { get; set; }
        public virtual DbSet<TblMaliyetIndirim> TblMaliyetIndirims { get; set; }
        public virtual DbSet<TblMaliyetIslem> TblMaliyetIslems { get; set; }
        public virtual DbSet<TblMaliyetIslemUrun> TblMaliyetIslemUruns { get; set; }
        public virtual DbSet<TblMaliyetIslemZorunlu> TblMaliyetIslemZorunlus { get; set; }
        public virtual DbSet<TblMaliyetLf> TblMaliyetLves { get; set; }
        public virtual DbSet<TblMaliyetMalzeme> TblMaliyetMalzemes { get; set; }
        public virtual DbSet<TblMaliyetOnay> TblMaliyetOnays { get; set; }
        public virtual DbSet<TblMaliyetSabit> TblMaliyetSabits { get; set; }
        public virtual DbSet<TblMamulTip> TblMamulTips { get; set; }
        public virtual DbSet<TblMamulTipHat> TblMamulTipHats { get; set; }
        public virtual DbSet<TblMuadil> TblMuadils { get; set; }
        public virtual DbSet<TblOdeme> TblOdemes { get; set; }
        public virtual DbSet<TblOpaklik> TblOpakliks { get; set; }
        public virtual DbSet<TblParametre> TblParametres { get; set; }
        public virtual DbSet<TblParlaklik> TblParlakliks { get; set; }
        public virtual DbSet<TblPersonel> TblPersonels { get; set; }
        public virtual DbSet<TblPersonelBilgisayar> TblPersonelBilgisayars { get; set; }
        public virtual DbSet<TblPersonelCeza> TblPersonelCezas { get; set; }
        public virtual DbSet<TblPersonelDil> TblPersonelDils { get; set; }
        public virtual DbSet<TblPersonelEgitim> TblPersonelEgitims { get; set; }
        public virtual DbSet<TblPersonelEgitimPersonel> TblPersonelEgitimPersonels { get; set; }
        public virtual DbSet<TblPersonelEpostum> TblPersonelEposta { get; set; }
        public virtual DbSet<TblPersonelFirm> TblPersonelFirms { get; set; }
        public virtual DbSet<TblPersonelGrup> TblPersonelGrups { get; set; }
        public virtual DbSet<TblPersonelIhtiyac> TblPersonelIhtiyacs { get; set; }
        public virtual DbSet<TblPersonelIslem> TblPersonelIslems { get; set; }
        public virtual DbSet<TblPersonelIzin> TblPersonelIzins { get; set; }
        public virtual DbSet<TblPersonelIzinHak> TblPersonelIzinHaks { get; set; }
        public virtual DbSet<TblPersonelKart> TblPersonelKarts { get; set; }
        public virtual DbSet<TblPersonelKur> TblPersonelKurs { get; set; }
        public virtual DbSet<TblPersonelMakina> TblPersonelMakinas { get; set; }
        public virtual DbSet<TblPersonelMakinaGrup> TblPersonelMakinaGrups { get; set; }
        public virtual DbSet<TblPersonelSaglik> TblPersonelSagliks { get; set; }
        public virtual DbSet<TblPlanlama> TblPlanlamas { get; set; }
        public virtual DbSet<TblRandevu> TblRandevus { get; set; }
        public virtual DbSet<TblSaIstek> TblSaIsteks { get; set; }
        public virtual DbSet<TblSaSipari> TblSaSiparis { get; set; }
        public virtual DbSet<TblSaSiparisKlise> TblSaSiparisKlises { get; set; }
        public virtual DbSet<TblSaSiparisSipari> TblSaSiparisSiparis { get; set; }
        public virtual DbSet<TblSaSiparisTeslim> TblSaSiparisTeslims { get; set; }
        public virtual DbSet<TblSaSiparisTeslimDetay> TblSaSiparisTeslimDetays { get; set; }
        public virtual DbSet<TblSaTeklif> TblSaTeklifs { get; set; }
        public virtual DbSet<TblSaTeklifFiyat> TblSaTeklifFiyats { get; set; }
        public virtual DbSet<TblSabagkod> TblSabagkods { get; set; }
        public virtual DbSet<TblSektor> TblSektors { get; set; }
        public virtual DbSet<TblSevk> TblSevks { get; set; }
        public virtual DbSet<TblSevkAlt> TblSevkAlts { get; set; }
        public virtual DbSet<TblSevkDetay> TblSevkDetays { get; set; }
        public virtual DbSet<TblSevkTip> TblSevkTips { get; set; }
        public virtual DbSet<TblSevkiyat> TblSevkiyats { get; set; }
        public virtual DbSet<TblSikayetGelen> TblSikayetGelens { get; set; }
        public virtual DbSet<TblSikayetGelenTip> TblSikayetGelenTips { get; set; }
        public virtual DbSet<TblSikayetHareket> TblSikayetHarekets { get; set; }
        public virtual DbSet<TblSikayetPersonel> TblSikayetPersonels { get; set; }
        public virtual DbSet<TblSikayetSikayetTip> TblSikayetSikayetTips { get; set; }
        public virtual DbSet<TblSikayetTutar> TblSikayetTutars { get; set; }
        public virtual DbSet<TblSipari> TblSiparis { get; set; }
        public virtual DbSet<TblSiparisAmb> TblSiparisAmbs { get; set; }
        public virtual DbSet<TblSiparisDegisiklik> TblSiparisDegisikliks { get; set; }
        public virtual DbSet<TblSiparisDetay> TblSiparisDetays { get; set; }
        public virtual DbSet<TblSiparisEkstragider> TblSiparisEkstragiders { get; set; }
        public virtual DbSet<TblSiparisGider> TblSiparisGiders { get; set; }
        public virtual DbSet<TblSiparisHareket> TblSiparisHarekets { get; set; }
        public virtual DbSet<TblSiparisIhtiyac> TblSiparisIhtiyacs { get; set; }
        public virtual DbSet<TblSiparisIslem> TblSiparisIslems { get; set; }
        public virtual DbSet<TblSiparisKlise> TblSiparisKlises { get; set; }
        public virtual DbSet<TblSiparisKliseAlt> TblSiparisKliseAlts { get; set; }
        public virtual DbSet<TblSiparisKlisePantone> TblSiparisKlisePantones { get; set; }
        public virtual DbSet<TblSiparisMak> TblSiparisMaks { get; set; }
        public virtual DbSet<TblSiparisMakina> TblSiparisMakinas { get; set; }
        public virtual DbSet<TblSiparisOnay> TblSiparisOnays { get; set; }
        public virtual DbSet<TblSiparisOnayAdre> TblSiparisOnayAdres { get; set; }
        public virtual DbSet<TblSiparisTermin> TblSiparisTermins { get; set; }
        public virtual DbSet<TblSiparisTeslim> TblSiparisTeslims { get; set; }
        public virtual DbSet<TblSiparisTeslim2> TblSiparisTeslim2s { get; set; }
        public virtual DbSet<TblTanim> TblTanims { get; set; }
        public virtual DbSet<TblTasiyici> TblTasiyicis { get; set; }
        public virtual DbSet<TblTeklif> TblTeklifs { get; set; }
        public virtual DbSet<TblTeklifFiyat> TblTeklifFiyats { get; set; }
        public virtual DbSet<TblTeklifGonder> TblTeklifGonders { get; set; }
        public virtual DbSet<TblTeklifGonderSonuc> TblTeklifGonderSonucs { get; set; }
        public virtual DbSet<TblTeklifSira> TblTeklifSiras { get; set; }
        public virtual DbSet<TblTeknikOrtam> TblTeknikOrtams { get; set; }
        public virtual DbSet<TblTeknikPantone> TblTeknikPantones { get; set; }
        public virtual DbSet<TblTeknikYuzey> TblTeknikYuzeys { get; set; }
        public virtual DbSet<TblTeslimat> TblTeslimats { get; set; }
        public virtual DbSet<TblTest> TblTests { get; set; }
        public virtual DbSet<TblUlke> TblUlkes { get; set; }
        public virtual DbSet<TblUrun> TblUruns { get; set; }
        public virtual DbSet<TblUrunAgirlik> TblUrunAgirliks { get; set; }
        public virtual DbSet<TblUrunAmb> TblUrunAmbs { get; set; }
        public virtual DbSet<TblUrunAmbalaji> TblUrunAmbalajis { get; set; }
        public virtual DbSet<TblUrunBirim> TblUrunBirims { get; set; }
        public virtual DbSet<TblUrunEkbicak> TblUrunEkbicaks { get; set; }
        public virtual DbSet<TblUrunFire> TblUrunFires { get; set; }
        public virtual DbSet<TblUrunFirma> TblUrunFirmas { get; set; }
        public virtual DbSet<TblUrunHareket> TblUrunHarekets { get; set; }
        public virtual DbSet<TblUrunIhtiyac> TblUrunIhtiyacs { get; set; }
        public virtual DbSet<TblUrunKk> TblUrunKks { get; set; }
        public virtual DbSet<TblUrunLf> TblUrunLves { get; set; }
        public virtual DbSet<TblUrunMakina> TblUrunMakinas { get; set; }
        public virtual DbSet<TblUrunMalzeme> TblUrunMalzemes { get; set; }
        public virtual DbSet<TblUrunMamulTip> TblUrunMamulTips { get; set; }
        public virtual DbSet<TblUrunOnay> TblUrunOnays { get; set; }
        public virtual DbSet<TblUrunResim> TblUrunResims { get; set; }
        public virtual DbSet<TblUrunRevizyon> TblUrunRevizyons { get; set; }
        public virtual DbSet<TblUrunSevk> TblUrunSevks { get; set; }
        public virtual DbSet<TblUrunSevkDetay> TblUrunSevkDetays { get; set; }
        public virtual DbSet<TblUrunSevkDetayAlt> TblUrunSevkDetayAlts { get; set; }
        public virtual DbSet<TblUrunStokkart> TblUrunStokkarts { get; set; }
        public virtual DbSet<TblUrunStokkartIade> TblUrunStokkartIades { get; set; }
        public virtual DbSet<TblUrunStokkartSipari> TblUrunStokkartSiparis { get; set; }
        public virtual DbSet<TblUrunTavsiyeEn> TblUrunTavsiyeEns { get; set; }
        public virtual DbSet<TblUrunTip> TblUrunTips { get; set; }
        public virtual DbSet<TblVardiya> TblVardiyas { get; set; }
        public virtual DbSet<TblVardiyaBicak> TblVardiyaBicaks { get; set; }
        public virtual DbSet<TblVardiyaHareket> TblVardiyaHarekets { get; set; }
        public virtual DbSet<TblVardiyaUrun> TblVardiyaUruns { get; set; }
        public virtual DbSet<TblVardiyaUrunDetay> TblVardiyaUrunDetays { get; set; }
        public virtual DbSet<TblVardiyaUrunFire> TblVardiyaUrunFires { get; set; }
        public virtual DbSet<TblVardiyaZaman> TblVardiyaZamen { get; set; }
        public virtual DbSet<TblVardiyaZamanFire> TblVardiyaZamanFires { get; set; }
        public virtual DbSet<TblVersiyon> TblVersiyons { get; set; }
        public virtual DbSet<TblYapisal1> TblYapisal1s { get; set; }
        public virtual DbSet<TblYapisal2> TblYapisal2s { get; set; }
        public virtual DbSet<TblYapisal3> TblYapisal3s { get; set; }
        public virtual DbSet<TblYapiskan> TblYapiskans { get; set; }
        public virtual DbSet<TblYarimamulkod> TblYarimamulkods { get; set; }
        public virtual DbSet<TblZamanFire> TblZamanFires { get; set; }
        public virtual DbSet<VwMakinaSiralama> VwMakinaSiralamas { get; set; }
        public virtual DbSet<VwRprSaSipari> VwRprSaSiparis { get; set; }
        public virtual DbSet<VwRprStokkart> VwRprStokkarts { get; set; }
        public virtual DbSet<VwSaSiparisOnay> VwSaSiparisOnays { get; set; }
        public virtual DbSet<VwSatisPlan> VwSatisPlans { get; set; }
        public virtual DbSet<VwSipari> VwSiparis { get; set; }
        public virtual DbSet<VwSiparisArsiv> VwSiparisArsivs { get; set; }
        public virtual DbSet<VwSiparisOnay> VwSiparisOnays { get; set; }
        public virtual DbSet<VwVardiya> VwVardiyas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=127.0.0.1;Database=Viopack_Erp;User Id=postgres;password=qweasd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblAnilox>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_anilox");

                entity.Property(e => e.Aniloxkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("aniloxkod");

                entity.Property(e => e.Boyaaktarimi).HasColumnName("boyaaktarimi");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Linecm).HasColumnName("linecm");

                entity.Property(e => e.Lineinch).HasColumnName("lineinch");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<TblArac>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_arac");

                entity.Property(e => e.Aracid).HasColumnName("aracid");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("kodaciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kullanma)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kullanma")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Tonaj).HasColumnName("tonaj");
            });

            modelBuilder.Entity<TblBakim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bakim");

                entity.Property(e => e.Bakimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bakimkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblBaskiTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_baski_tip");

                entity.Property(e => e.Baskitipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baskitipkod");

                entity.Property(e => e.Boyadovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("boyadovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Boyafiyat).HasColumnName("boyafiyat");

                entity.Property(e => e.Boyayogunlugu).HasColumnName("boyayogunlugu");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Klisedovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("klisedovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisefiyat).HasColumnName("klisefiyat");

                entity.Property(e => e.Klisefiyatbirim)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("klisefiyatbirim")
                    .HasDefaultValueSql("('cm2')");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblBaskiTipDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_baski_tip_detay");

                entity.Property(e => e.Azyogunluk).HasColumnName("azyogunluk");

                entity.Property(e => e.BaskitipaltId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("baskitipaltID");

                entity.Property(e => e.Baskitipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baskitipkod");

                entity.Property(e => e.Cokyogunluk).HasColumnName("cokyogunluk");

                entity.Property(e => e.Mamultipkod).HasColumnName("mamultipkod");
            });

            modelBuilder.Entity<TblBicak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bicak");

                entity.Property(e => e.Aaadet).HasColumnName("aaadet");

                entity.Property(e => e.Aabosluk).HasColumnName("aabosluk");

                entity.Property(e => e.Arsivno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("arsivno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BicakId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("bicakId");

                entity.Property(e => e.Bicakek).HasColumnName("bicakek");

                entity.Property(e => e.Bicakiz)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("bicakiz")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bicakiztarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("bicakiztarihi");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Bicakno)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("bicakno");

                entity.Property(e => e.Bicaksekilkod).HasColumnName("bicaksekilkod");

                entity.Property(e => e.Bicaktipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bicaktipkod");

                entity.Property(e => e.Bicakuzunkod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("bicakuzunkod");

                entity.Property(e => e.Bicakyonu).HasColumnName("bicakyonu");

                entity.Property(e => e.Dislisayisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ds)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ds")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grafikonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grafikonay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kisakod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kisakod");

                entity.Property(e => e.Kullanimalanikod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kullanimalanikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ozelbilgi)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ozelbilgi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Radus).HasColumnName("radus");

                entity.Property(e => e.Sabagkod)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yenibicak)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yenibicak")
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Yyadet).HasColumnName("yyadet");

                entity.Property(e => e.Yybitisikadet).HasColumnName("yybitisikadet");

                entity.Property(e => e.Yybosluk).HasColumnName("yybosluk");
            });

            modelBuilder.Entity<TblBicakDisli>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bicak_disli");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Dislidegeri).HasColumnName("dislidegeri");

                entity.Property(e => e.Dislisayisi)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi");

                entity.Property(e => e.Dislisayisi2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi2");
            });

            modelBuilder.Entity<TblBicakIz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bicak_iz");

                entity.Property(e => e.BicakId).HasColumnName("bicakId");

                entity.Property(e => e.Bicakiz)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("bicakiz");

                entity.Property(e => e.BicakizId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("bicakizId");

                entity.Property(e => e.Bicakiztarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("bicakiztarihi");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblBicakMakina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bicak_makina");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");
            });

            modelBuilder.Entity<TblBicakSebep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bicak_sebep");

                entity.Property(e => e.Bicaksebepkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("bicaksebepkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblBicakSekil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bicak_sekil");

                entity.Property(e => e.Bicaksekilkod).HasColumnName("bicaksekilkod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblBicakTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bicak_tip");

                entity.Property(e => e.Bicaktipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bicaktipkod");

                entity.Property(e => e.Dislidegeri).HasColumnName("dislidegeri");

                entity.Property(e => e.Dislisizvar).HasColumnName("dislisizvar");

                entity.Property(e => e.Dislivar).HasColumnName("dislivar");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Maksboy).HasColumnName("maksboy");

                entity.Property(e => e.Maksen).HasColumnName("maksen");

                entity.Property(e => e.Minboy).HasColumnName("minboy");

                entity.Property(e => e.Minen).HasColumnName("minen");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Simge)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("simge");

                entity.Property(e => e.Yandondur).HasColumnName("yandondur");
            });

            modelBuilder.Entity<TblBicakYenileme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bicak_yenileme");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Bicaksebepkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("bicaksebepkod");

                entity.Property(e => e.Durumkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("durumkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Fiilitarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fiilitarih");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Imaltarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("imaltarihi");

                entity.Property(e => e.Imhatarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("imhatarihi");

                entity.Property(e => e.Iptal).HasColumnName("iptal");

                entity.Property(e => e.Kullanimda).HasColumnName("kullanimda");

                entity.Property(e => e.Olusturanadisoyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Serino)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("serino");

                entity.Property(e => e.Sipariste).HasColumnName("sipariste");

                entity.Property(e => e.Tursayisi).HasColumnName("tursayisi");

                entity.Property(e => e.Yenilemeno)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yenilemeno");
            });

            modelBuilder.Entity<TblBirim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_birim");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Birimtip)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("birimtip");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Kodaciklamaing)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklamaing");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Oran).HasColumnName("oran");

                entity.Property(e => e.Simge)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("simge");

                entity.Property(e => e.Simgeing)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("simgeing");

                entity.Property(e => e.Teklifbirimikullan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("teklifbirimikullan");
            });

            modelBuilder.Entity<TblBoyHesap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_boy_hesap");

                entity.Property(e => e.Baskisaat).HasColumnName("baskisaat");

                entity.Property(e => e.Cekim).HasColumnName("cekim");

                entity.Property(e => e.Makinakodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Metredakika).HasColumnName("metredakika");
            });

            modelBuilder.Entity<TblCarpan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_carpan");

                entity.Property(e => e.Carpan).HasColumnName("carpan");
            });

            modelBuilder.Entity<TblDegisen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_degisen");

                entity.Property(e => e.Bagla)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("bagla");

                entity.Property(e => e.Degisenalan)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("degisenalan");

                entity.Property(e => e.Degisenbolum)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("degisenbolum");

                entity.Property(e => e.Degisenid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("degisenid");

                entity.Property(e => e.Degisenveri)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("degisenveri");

                entity.Property(e => e.Degistirmetarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("degistirmetarihi");

                entity.Property(e => e.Desigtirenadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("desigtirenadisoyadi");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Yeniveri)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("yeniveri");
            });

            modelBuilder.Entity<TblDepo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_depo");

                entity.Property(e => e.Depokod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("depokod");

                entity.Property(e => e.Depotipi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("depotipi");

                entity.Property(e => e.Durumu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("durumu");

                entity.Property(e => e.FirmId)
                    .HasColumnName("firmId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblDepoFirma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_depo_firma");

                entity.Property(e => e.Depokod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("depokod");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");
            });

            modelBuilder.Entity<TblDilim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dilim");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Dilmekod).HasColumnName("dilmekod");

                entity.Property(e => e.Dilmeno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("dilmeno");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Eskimiktar1).HasColumnName("eskimiktar1");

                entity.Property(e => e.Eskimiktar2).HasColumnName("eskimiktar2");

                entity.Property(e => e.Gideceksiparisno)
                    .HasMaxLength(255)
                    .HasColumnName("gideceksiparisno");

                entity.Property(e => e.Miktar1).HasColumnName("miktar1");

                entity.Property(e => e.Miktar2).HasColumnName("miktar2");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Seviye).HasColumnName("seviye");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Stokno)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("stokno");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblDilimGecici>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dilim_gecici");

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");
            });

            modelBuilder.Entity<TblDilimGecici1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dilim_gecici1");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");
            });

            modelBuilder.Entity<TblDilimKombine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dilim_kombine");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Sutun).HasColumnName("sutun");

                entity.Property(e => e.Urunkod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblDisliHesap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_disli_hesap");

                entity.Property(e => e.Aaadet).HasColumnName("aaadet");

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Cevre).HasColumnName("cevre");

                entity.Property(e => e.Dislidegeri).HasColumnName("dislidegeri");

                entity.Property(e => e.Dislisayisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi");

                entity.Property(e => e.Dislisayisi2)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi2");

                entity.Property(e => e.Dislisayisi3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi3");
            });

            modelBuilder.Entity<TblDof>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dof");

                entity.Property(e => e.Acanbolum)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("acanbolum");

                entity.Property(e => e.Acankisi)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("acankisi");

                entity.Property(e => e.Acanpersonel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("acanpersonel");

                entity.Property(e => e.Dfgerekli).HasColumnName("dfgerekli");

                entity.Property(e => e.Dfno)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dfno");

                entity.Property(e => e.Dfof)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dfof");

                entity.Property(e => e.Dofkod)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dofkod");

                entity.Property(e => e.Dofno).HasColumnName("dofno");

                entity.Property(e => e.Doftipi)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("doftipi");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Eylem)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eylem");

                entity.Property(e => e.Eylembildirim)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eylembildirim");

                entity.Property(e => e.Eylemplanlama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eylemplanlama");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Hatanedeni)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hatanedeni");

                entity.Property(e => e.Hatanedenibildirim)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hatanedenibildirim");

                entity.Property(e => e.Ilgilibolum)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ilgilibolum");

                entity.Property(e => e.Ilgilikisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilgilikisi");

                entity.Property(e => e.Irsaliyeno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("irsaliyeno");

                entity.Property(e => e.Kapatankisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kapatankisi");

                entity.Property(e => e.Kapattarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("kapattarih");

                entity.Property(e => e.KontrolKapat).HasColumnName("kontrol_kapat");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Onayliyankisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("onayliyankisi");

                entity.Property(e => e.Onaytarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("onaytarih");

                entity.Property(e => e.Raporno)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("raporno");

                entity.Property(e => e.Sevktarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("sevktarihi");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Sonuc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sonuc");

                entity.Property(e => e.Tanimi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tanimi");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblDofDagitim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dof_dagitim");

                entity.Property(e => e.Dagitim)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("dagitim");

                entity.Property(e => e.Dofkod)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dofkod");

                entity.Property(e => e.Firmakod)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Kisikod)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblDofGrup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dof_grup");

                entity.Property(e => e.Dofkod)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dofkod");

                entity.Property(e => e.Personelgrupkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("personelgrupkod");
            });

            modelBuilder.Entity<TblDofPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dof_personel");

                entity.Property(e => e.Dofkod)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dofkod");

                entity.Property(e => e.Firmakod)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Kisikod)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Personel)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("personel");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblDofTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_dof_tip");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Dofkod)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dofkod");

                entity.Property(e => e.Nedeneylem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nedeneylem");

                entity.Property(e => e.Tipkod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipkod");
            });

            modelBuilder.Entity<TblDoviz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_doviz");

                entity.Property(e => e.Dovizaciklama)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dovizaciklama");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Dovizsimge)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dovizsimge");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblDovizKur>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_doviz_kur");

                entity.Property(e => e.Dovizalisf).HasColumnName("dovizalisf");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Dovizsatisf).HasColumnName("dovizsatisf");

                entity.Property(e => e.Efektifalisf1).HasColumnName("efektifalisf1");

                entity.Property(e => e.Efektifsatisf1).HasColumnName("efektifsatisf1");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<TblDurum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_durum");

                entity.Property(e => e.Durumkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("durumkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Kullanimda).HasColumnName("kullanimda");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sipariste).HasColumnName("sipariste");
            });

            modelBuilder.Entity<TblDurumFirma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_durum_firma");

                entity.Property(e => e.Durumfirmakod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("durumfirmakod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblDurumTeklif>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_durum_teklif");

                entity.Property(e => e.Durumteklifkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("durumteklifkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblEkstragiderTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ekstragider_tip");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ekstragiderkod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ekstragiderkod");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblFireIslem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_fire_islem");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Urunfirekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("urunfirekod");
            });

            modelBuilder.Entity<TblFireMakina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_fire_makina");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Urunfirekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("urunfirekod");
            });

            modelBuilder.Entity<TblFirm>(entity =>
            {
                entity.HasKey(e => e.FirmId);

                entity.ToTable("tbl_firm");

                entity.Property(e => e.FirmId).HasColumnName("firmId");

                entity.Property(e => e.FirmAd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firmAd");
            });

            modelBuilder.Entity<TblFirma>(entity =>
            {
                entity.HasKey(e => e.Firmakod);

                entity.ToTable("tbl_firma");

                entity.Property(e => e.Firmakod)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Durumfirmakod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("durumfirmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Faks1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("faks1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faks2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("faks2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faturaadres1)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("faturaadres1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faturaadres2)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("faturaadres2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faturanot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("faturanot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faturatipi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("faturatipi")
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Grafikperskod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grafikperskod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grupkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grupkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilcekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilcekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilksiparispersonel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilksiparispersonel")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilksiparistarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ilksiparistarihi");

                entity.Property(e => e.Irsaliyenot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("irsaliyenot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Istihbaratnot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("istihbaratnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Istihbaratonay).HasColumnName("istihbaratonay");

                entity.Property(e => e.Istihbaratpersonelkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("istihbaratpersonelkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kalitefiyat).HasColumnName("kalitefiyat");

                entity.Property(e => e.Kaliteiletisim).HasColumnName("kaliteiletisim");

                entity.Property(e => e.Kisaad)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mail")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Muhasebekod)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("muhasebekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Muhasebekodsatis)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("muhasebekodsatis")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Odemekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("odemekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Odemesekli)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("odemesekli")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ozelkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ozelkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ozelnot)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ozelnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Parabirimi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("parabirimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Parabirimicari)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("parabirimicari")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Personelkodu2)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Postakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("postakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Risklimiti).HasColumnName("risklimiti");

                entity.Property(e => e.Sabitkur).HasColumnName("sabitkur");

                entity.Property(e => e.SekId).HasColumnName("sekId");

                entity.Property(e => e.Sektoraltkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sektoraltkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sektorkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sektorkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sevkiyatkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sevkiyatkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sevklimit).HasColumnName("sevklimit");

                entity.Property(e => e.Sonaktiftarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("sonaktiftarih");

                entity.Property(e => e.Soniletisimtarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("soniletisimtarihi");

                entity.Property(e => e.Sonsiparistarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("sonsiparistarihi");

                entity.Property(e => e.Sorunlu).HasColumnName("sorunlu");

                entity.Property(e => e.Sorunnot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sorunnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Statu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("statu");

                entity.Property(e => e.Tckimlikno)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("tckimlikno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefon1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("telefon1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefon2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("telefon2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ticariad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ticariad")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tip");

                entity.Property(e => e.Ulkekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ulkekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Vergidairesi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("vergidairesi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vergino)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vergino")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Web)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("web")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yuvarlama)
                    .HasColumnName("yuvarlama")
                    .HasDefaultValueSql("((6))");

                entity.HasOne(d => d.Sek)
                    .WithMany(p => p.TblFirmas)
                    .HasForeignKey(d => d.SekId)
                    .HasConstraintName("FK_tbl_firma_tbl_sektor");

                entity.HasOne(d => d.UlkekodNavigation)
                    .WithMany(p => p.TblFirmas)
                    .HasForeignKey(d => d.Ulkekod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_tbl_ulke");
            });

            modelBuilder.Entity<TblFirmaDurum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_firma_durum");

                entity.HasComment("Firma nin aktif veya pasif durumunu tutan tablo");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Durumfirmakod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("durumfirmakod");

                entity.Property(e => e.Durumno).HasColumnName("durumno");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.HasOne(d => d.FirmakodNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Firmakod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_durum_tbl_firma");
            });

            modelBuilder.Entity<TblFirmaFirma>(entity =>
            {
                entity.HasKey(e => e.Firmafirmaid);

                entity.ToTable("tbl_firma_firma");

                entity.Property(e => e.Firmafirmaid)
                    .ValueGeneratedNever()
                    .HasColumnName("firmafirmaid");

                entity.Property(e => e.Alicikod)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("alicikod");

                entity.Property(e => e.FirmId).HasColumnName("firmId");

                entity.Property(e => e.Firma)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("firma");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Saticikod)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("saticikod");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.TblFirmaFirmas)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_firma_tbl_firm");

                entity.HasOne(d => d.FirmakodNavigation)
                    .WithMany(p => p.TblFirmaFirmas)
                    .HasForeignKey(d => d.Firmakod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_firma_tbl_firma");
            });

            modelBuilder.Entity<TblFirmaGorusmeler>(entity =>
            {
                entity.HasKey(e => e.Gorid);

                entity.ToTable("tbl_firma_gorusmeler");

                entity.Property(e => e.Gorid)
                    .ValueGeneratedNever()
                    .HasColumnName("gorid");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Gorusmebitti).HasColumnName("gorusmebitti");

                entity.Property(e => e.Gorusmeno).HasColumnName("gorusmeno");

                entity.Property(e => e.Gorusmenotu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("gorusmenotu");

                entity.Property(e => e.Gorusmetarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("gorusmetarihi");

                entity.Property(e => e.Gorusmetipno)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("gorusmetipno");

                entity.Property(e => e.Kisikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Teknikno).HasColumnName("teknikno");

                entity.HasOne(d => d.FirmakodNavigation)
                    .WithMany(p => p.TblFirmaGorusmelers)
                    .HasForeignKey(d => d.Firmakod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_gorusmeler_tbl_firma");
            });

            modelBuilder.Entity<TblFirmaKontakt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_firma_kontakt");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ad")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Adres1)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("adres1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Adres2)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("adres2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Departman)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("departman")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dogumtarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dogumtarihi");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Esadi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("esadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Esdogum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("esdogum");

                entity.Property(e => e.Evhayvani)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("evhayvani")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Evliliktarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("evliliktarih");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Gorevi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("gorevi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hobiler)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hobiler")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilcekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilcekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iptalet)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("iptalet")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kisikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mail")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Postakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("postakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Spor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("spor")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Takimi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("takimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefon1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("telefon1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ulkekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ulkekod")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.FirmakodNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Firmakod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_kontakt_tbl_firma");
            });

            modelBuilder.Entity<TblFirmaKontaktCocuk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_firma_kontakt_cocuk");

                entity.Property(e => e.Bilgi)
                    .HasColumnType("text")
                    .HasColumnName("bilgi");

                entity.Property(e => e.Cocukadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cocukadi");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Hatirno).HasColumnName("hatirno");

                entity.Property(e => e.Kisikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<TblFirmaPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_firma_personel");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("aciklama");

                entity.Property(e => e.FirmId).HasColumnName("firmId");

                entity.Property(e => e.FirmaPersId).HasColumnName("firmaPersId");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelgrupkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("personelgrupkod");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.HasOne(d => d.FirmakodNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Firmakod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_personel_tbl_firma");
            });

            modelBuilder.Entity<TblFirmaTeslimat>(entity =>
            {
                entity.HasKey(e => new { e.Firmakod, e.Subekod });

                entity.ToTable("tbl_firma_teslimat");

                entity.Property(e => e.Firmakod)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Subekod)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("subekod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Faks1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("faks1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faks2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("faks2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Firmateslimatid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("firmateslimatid");

                entity.Property(e => e.Ilcekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilcekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kullanilmiyor).HasColumnName("kullanilmiyor");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mail")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Postakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("postakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subead)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("subead");

                entity.Property(e => e.Tckimlikno)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("tckimlikno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefon1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("telefon1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefon2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("telefon2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Teslimatadres1)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("teslimatadres1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Teslimatadres2)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("teslimatadres2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ulkekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ulkekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vergidairesi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("vergidairesi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vergino)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vergino")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Web)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("web")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.FirmakodNavigation)
                    .WithMany(p => p.TblFirmaTeslimats)
                    .HasForeignKey(d => d.Firmakod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_teslimat_tbl_firma");
            });

            modelBuilder.Entity<TblFirmaTeslimatEtiket>(entity =>
            {
                entity.HasKey(e => e.FirmaEtiketId);

                entity.ToTable("tbl_firma_teslimat_etiket");

                entity.Property(e => e.FirmaEtiketId).HasColumnName("firmaEtiketId");

                entity.Property(e => e.Etikettipi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("etikettipi");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Subekod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("subekod");

                entity.HasOne(d => d.TblFirmaTeslimat)
                    .WithMany(p => p.TblFirmaTeslimatEtikets)
                    .HasForeignKey(d => new { d.Firmakod, d.Subekod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_firma_teslimat_etiket_tbl_firma_teslimat");
            });

            modelBuilder.Entity<TblGenel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_genel");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Genelkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("genelkod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblGerceklesenSati>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_gerceklesen_satis");

                entity.Property(e => e.Ay)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fatura).HasColumnName("fatura");

                entity.Property(e => e.Gerceklesen).HasColumnName("gerceklesen");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Yil)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("yil")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblGider>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_gider");

                entity.Property(e => e.Giderkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("giderkod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblGorusmeTeknik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_gorusme_teknik");

                entity.Property(e => e.Aabosluk).HasColumnName("aabosluk");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Akisyonu)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("akisyonu");

                entity.Property(e => e.Ambalaj)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ambalaj");

                entity.Property(e => e.Ambalajnot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ambalajnot");

                entity.Property(e => e.Aylikkulanim)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aylikkulanim");

                entity.Property(e => e.Baskiadi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("baskiadi");

                entity.Property(e => e.Baskili).HasColumnName("baskili");

                entity.Property(e => e.Bicak)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bicak");

                entity.Property(e => e.Bobindeadet).HasColumnName("bobindeadet");

                entity.Property(e => e.Cifttaraf).HasColumnName("cifttaraf");

                entity.Property(e => e.Degiskenbaski).HasColumnName("degiskenbaski");

                entity.Property(e => e.Discap).HasColumnName("discap");

                entity.Property(e => e.Iccap).HasColumnName("iccap");

                entity.Property(e => e.Koliadet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("koliadet");

                entity.Property(e => e.Lak).HasColumnName("lak");

                entity.Property(e => e.Malzemeadi)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("malzemeadi");

                entity.Property(e => e.Musterikod)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("musterikod");

                entity.Property(e => e.Nasilyapis)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nasilyapis");

                entity.Property(e => e.Olusturanadisoyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ozelsart)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ozelsart");

                entity.Property(e => e.Radus).HasColumnName("radus");

                entity.Property(e => e.Rafomru)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("rafomru");

                entity.Property(e => e.Rulotabaka)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("rulotabaka");

                entity.Property(e => e.Serigafi).HasColumnName("serigafi");

                entity.Property(e => e.Tasiyicien).HasColumnName("tasiyicien");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Teknikno).HasColumnName("teknikno");

                entity.Property(e => e.Trignomi).HasColumnName("trignomi");

                entity.Property(e => e.Urunadi)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yapiskan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yapiskan");

                entity.Property(e => e.Yapiskanadi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("yapiskanadi");

                entity.Property(e => e.Yuzey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("yuzey");
            });

            modelBuilder.Entity<TblGorusmeTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_gorusme_tip");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Gorusmetipno)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("gorusmetipno");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Tipaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tipaciklama");
            });

            modelBuilder.Entity<TblGrafik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_grafik");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Akisyonu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("akisyonu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Baslatarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("baslatarih");

                entity.Property(e => e.Bitistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("bitistarih");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Gecikme)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("gecikme")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gelenorjinal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gelenorjinal")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grafikadi)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("grafikadi");

                entity.Property(e => e.Grafikdurumkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grafikdurumkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grafikno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("grafikno");

                entity.Property(e => e.Hat)
                    .HasColumnName("hat")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isinsekli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isinsekli")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Montaj)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("montaj")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Netsure).HasColumnName("netsure");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Sirala)
                    .HasColumnName("sirala")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.Siralagrafiker)
                    .HasColumnName("siralagrafiker")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.Takip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("takip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uygulamasekli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uygulamasekli")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblGrafikDurum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_grafik_durum");

                entity.Property(e => e.Grafikdurumkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grafikdurumkod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblGrafikIslem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_grafik_islem");

                entity.Property(e => e.Grafikislemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grafikislemkod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblGrafikOnay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_grafik_onay");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Gelistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("gelistarih");

                entity.Property(e => e.Gidistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("gidistarih");

                entity.Property(e => e.Grafikislemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grafikislemkod");

                entity.Property(e => e.Grafikno).HasColumnName("grafikno");

                entity.Property(e => e.Grafno).HasColumnName("grafno");
            });

            modelBuilder.Entity<TblGrup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_grup");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Grupad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("grupad");

                entity.Property(e => e.Grupkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grupkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblHareketTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_hareket_tip");

                entity.Property(e => e.Dis).HasColumnName("dis");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Hareketsekli).HasColumnName("hareketsekli");

                entity.Property(e => e.Harekettipkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("harekettipkod");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Siparis).HasColumnName("siparis");
            });

            modelBuilder.Entity<TblHatirlama>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_hatirlama");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Altiay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("altiay");

                entity.Property(e => e.Ay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ay");

                entity.Property(e => e.Cocuk).HasColumnName("cocuk");

                entity.Property(e => e.Firmakod)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Gorid).HasColumnName("gorid");

                entity.Property(e => e.Gun)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("gun");

                entity.Property(e => e.Hafta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hafta");

                entity.Property(e => e.Hatirid).HasColumnName("hatirid");

                entity.Property(e => e.Hatirlama)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("hatirlama");

                entity.Property(e => e.Hatirno).HasColumnName("hatirno");

                entity.Property(e => e.Iptal).HasColumnName("iptal");

                entity.Property(e => e.Kisikod)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Kisinin).HasColumnName("kisinin");

                entity.Property(e => e.Siklik).HasColumnName("siklik");

                entity.Property(e => e.Siklikadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("siklikadi");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Ucay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ucay");

                entity.Property(e => e.Yil)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("yil");
            });

            modelBuilder.Entity<TblHatirlamaPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_hatirlama_personel");

                entity.Property(e => e.Hatirno).HasColumnName("hatirno");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblHedefSati>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_hedef_satis");

                entity.Property(e => e.Ay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ay");

                entity.Property(e => e.Hedef).HasColumnName("hedef");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Yil)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("yil");
            });

            modelBuilder.Entity<TblIl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_il");

                entity.Property(e => e.Ilad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ilad");

                entity.Property(e => e.Ilkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ulkekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ulkekod");
            });

            modelBuilder.Entity<TblIlIlce>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_il_ilce");

                entity.Property(e => e.Ilcead)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ilcead");

                entity.Property(e => e.Ilcekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilcekod");

                entity.Property(e => e.Ilkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ilkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ulkekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ulkekod");
            });

            modelBuilder.Entity<TblImalatci>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_imalatci");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Imalatcikod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("imalatcikod");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblIslem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_islem");

                entity.Property(e => e.Baskitipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baskitipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bicaktipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bicaktipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bilgi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bilgi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Fiyatbirim)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fiyatbirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Islemaktif)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("islemaktif")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Islemtipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemtipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maksalan).HasColumnName("maksalan");

                entity.Property(e => e.Minalan).HasColumnName("minalan");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Teklifteyaz)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("teklifteyaz")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yaldiz).HasColumnName("yaldiz");

                entity.Property(e => e.Yaldizbaski).HasColumnName("yaldizbaski");
            });

            modelBuilder.Entity<TblIslemTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_islem_tip");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Islemtipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemtipkod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Maliyetsorgu).HasColumnName("maliyetsorgu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblKaliteIlk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_kalite_ilk");

                entity.Property(e => e.Ambalajbutunluk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ambalajbutunluk")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Analizsertifikasi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("analizsertifikasi")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Bobinsarimyonu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bobinsarimyonu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Cekmekontrolu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cekmekontrolu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Etiketkontrolu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("etiketkontrolu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Kabuldurumu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kabuldurumu")
                    .HasDefaultValueSql("('K')");

                entity.Property(e => e.Kaliteilkid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("kaliteilkid");

                entity.Property(e => e.Kontoleden)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kontoleden");

                entity.Property(e => e.Korona)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("korona")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Mikronkontolu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mikronkontolu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Olcukontrolu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("olcukontrolu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Onayliyan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("onayliyan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Paletuygunluk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("paletuygunluk")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Sevkaraci)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sevkaraci")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Teslimno).HasColumnName("teslimno");

                entity.Property(e => e.Yapisma)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yapisma")
                    .HasDefaultValueSql("('U')");
            });

            modelBuilder.Entity<TblKaliteSon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_kalite_son");

                entity.Property(e => e.Aql0)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql0");

                entity.Property(e => e.Aql1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql1");

                entity.Property(e => e.Aql10)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql10");

                entity.Property(e => e.Aql11)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql11");

                entity.Property(e => e.Aql12)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql12");

                entity.Property(e => e.Aql13)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql13");

                entity.Property(e => e.Aql14)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql14");

                entity.Property(e => e.Aql15)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql15");

                entity.Property(e => e.Aql2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql2");

                entity.Property(e => e.Aql3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql3");

                entity.Property(e => e.Aql4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql4");

                entity.Property(e => e.Aql5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql5");

                entity.Property(e => e.Aql6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql6");

                entity.Property(e => e.Aql7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql7");

                entity.Property(e => e.Aql8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql8");

                entity.Property(e => e.Aql9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aql9");

                entity.Property(e => e.Aqlkritik)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("aqlkritik");

                entity.Property(e => e.Aqlmajor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("aqlmajor");

                entity.Property(e => e.Aqlminor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("aqlminor");

                entity.Property(e => e.Bulgu0)
                    .HasMaxLength(200)
                    .HasColumnName("bulgu0");

                entity.Property(e => e.Bulgu1).HasColumnName("bulgu1");

                entity.Property(e => e.Bulgu2).HasColumnName("bulgu2");

                entity.Property(e => e.Bulgu3).HasColumnName("bulgu3");

                entity.Property(e => e.Bulgu4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bulgu4");

                entity.Property(e => e.Bulgu5).HasColumnName("bulgu5");

                entity.Property(e => e.Bulgu6)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bulgu6");

                entity.Property(e => e.Bulgu7)
                    .HasMaxLength(50)
                    .HasColumnName("bulgu7");

                entity.Property(e => e.Bulgu8)
                    .HasMaxLength(50)
                    .HasColumnName("bulgu8");

                entity.Property(e => e.Bulgu9).HasColumnName("bulgu9");

                entity.Property(e => e.Dusunceler)
                    .HasColumnType("text")
                    .HasColumnName("dusunceler");

                entity.Property(e => e.Irsaliyeno)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("irsaliyeno");

                entity.Property(e => e.Kabul)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kabul");

                entity.Property(e => e.Kalitesonno).HasColumnName("kalitesonno");

                entity.Property(e => e.Kritik)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kritik");

                entity.Property(e => e.Major)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("major");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Minor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("minor");

                entity.Property(e => e.Musteripartino)
                    .HasMaxLength(50)
                    .HasColumnName("musteripartino");

                entity.Property(e => e.Ornekbirim).HasColumnName("ornekbirim");

                entity.Property(e => e.Ornekrulo).HasColumnName("ornekrulo");

                entity.Property(e => e.Paketleme).HasColumnName("paketleme");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Renk0)
                    .HasMaxLength(50)
                    .HasColumnName("renk0");

                entity.Property(e => e.Renk1)
                    .HasMaxLength(50)
                    .HasColumnName("renk1");

                entity.Property(e => e.Renk2)
                    .HasMaxLength(50)
                    .HasColumnName("renk2");

                entity.Property(e => e.Renk3)
                    .HasMaxLength(50)
                    .HasColumnName("renk3");

                entity.Property(e => e.Renk4)
                    .HasMaxLength(50)
                    .HasColumnName("renk4");

                entity.Property(e => e.Renk5)
                    .HasMaxLength(50)
                    .HasColumnName("renk5");

                entity.Property(e => e.Renk6)
                    .HasMaxLength(50)
                    .HasColumnName("renk6");

                entity.Property(e => e.Renk7)
                    .HasMaxLength(50)
                    .HasColumnName("renk7");

                entity.Property(e => e.Sano)
                    .HasMaxLength(100)
                    .HasColumnName("sano");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Sonuc0)
                    .HasColumnType("text")
                    .HasColumnName("sonuc0");

                entity.Property(e => e.Sonuc1)
                    .HasColumnType("text")
                    .HasColumnName("sonuc1");

                entity.Property(e => e.Sonuc10)
                    .HasColumnType("text")
                    .HasColumnName("sonuc10");

                entity.Property(e => e.Sonuc11)
                    .HasColumnType("text")
                    .HasColumnName("sonuc11");

                entity.Property(e => e.Sonuc12)
                    .HasColumnType("text")
                    .HasColumnName("sonuc12");

                entity.Property(e => e.Sonuc13)
                    .HasColumnType("text")
                    .HasColumnName("sonuc13");

                entity.Property(e => e.Sonuc14)
                    .HasColumnType("text")
                    .HasColumnName("sonuc14");

                entity.Property(e => e.Sonuc15)
                    .HasColumnType("text")
                    .HasColumnName("sonuc15");

                entity.Property(e => e.Sonuc2)
                    .HasColumnType("text")
                    .HasColumnName("sonuc2");

                entity.Property(e => e.Sonuc3)
                    .HasColumnType("text")
                    .HasColumnName("sonuc3");

                entity.Property(e => e.Sonuc4)
                    .HasColumnType("text")
                    .HasColumnName("sonuc4");

                entity.Property(e => e.Sonuc5)
                    .HasColumnType("text")
                    .HasColumnName("sonuc5");

                entity.Property(e => e.Sonuc6)
                    .HasColumnType("text")
                    .HasColumnName("sonuc6");

                entity.Property(e => e.Sonuc7)
                    .HasColumnType("text")
                    .HasColumnName("sonuc7");

                entity.Property(e => e.Sonuc8)
                    .HasColumnType("text")
                    .HasColumnName("sonuc8");

                entity.Property(e => e.Sonuc9)
                    .HasColumnType("text")
                    .HasColumnName("sonuc9");

                entity.Property(e => e.Standart0)
                    .HasMaxLength(200)
                    .HasColumnName("standart0");

                entity.Property(e => e.Standart1).HasColumnName("standart1");

                entity.Property(e => e.Standart2).HasColumnName("standart2");

                entity.Property(e => e.Standart3).HasColumnName("standart3");

                entity.Property(e => e.Standart4)
                    .HasMaxLength(50)
                    .HasColumnName("standart4");

                entity.Property(e => e.Standart5).HasColumnName("standart5");

                entity.Property(e => e.Standart6)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("standart6");

                entity.Property(e => e.Standart7)
                    .HasMaxLength(50)
                    .HasColumnName("standart7");

                entity.Property(e => e.Standart8)
                    .HasMaxLength(50)
                    .HasColumnName("standart8");

                entity.Property(e => e.Standart9).HasColumnName("standart9");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Urunbirim).HasColumnName("urunbirim");

                entity.Property(e => e.Urunrulo).HasColumnName("urunrulo");
            });

            modelBuilder.Entity<TblKlise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise");

                entity.Property(e => e.Arsivno).HasColumnName("arsivno");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Grafikonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grafikonay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kliseadi)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("kliseadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Onaykisi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("onaykisi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ozelbilgi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ozelbilgi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tram)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tram")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblKliseAlt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_alt");

                entity.Property(e => e.Aaadet).HasColumnName("aaadet");

                entity.Property(e => e.Baskitipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baskitipkod");

                entity.Property(e => e.Dislisayisi)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Kliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno");

                entity.Property(e => e.Klisetipkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("klisetipkod");

                entity.Property(e => e.Makinakodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("no");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Revizyonkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("revizyonkod");
            });

            modelBuilder.Entity<TblKliseEbad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_ebad");

                entity.Property(e => e.Aaadet).HasColumnName("aaadet");

                entity.Property(e => e.Aabosluk).HasColumnName("aabosluk");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Alan).HasColumnName("alan");

                entity.Property(e => e.Calismano)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("calismano");

                entity.Property(e => e.Calismatarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("calismatarih");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Malzemekod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemekod");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Yyadet).HasColumnName("yyadet");

                entity.Property(e => e.Yybitisikadet).HasColumnName("yybitisikadet");

                entity.Property(e => e.Yybosluk).HasColumnName("yybosluk");
            });

            modelBuilder.Entity<TblKliseFilm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_film");

                entity.Property(e => e.Bdovizkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bdovizkod");

                entity.Property(e => e.Bfaturaet).HasColumnName("bfaturaet");

                entity.Property(e => e.Bicakfiyat).HasColumnName("bicakfiyat");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Depodan).HasColumnName("depodan");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Ek5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek5");

                entity.Property(e => e.Ek6)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek6");

                entity.Property(e => e.Ek7)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek7");

                entity.Property(e => e.Ek8)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek8");

                entity.Property(e => e.Ek9)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek9");

                entity.Property(e => e.Ekstragidertutar).HasColumnName("ekstragidertutar");

                entity.Property(e => e.Eskifilmat).HasColumnName("eskifilmat");

                entity.Property(e => e.Faturanot)
                    .HasColumnType("text")
                    .HasColumnName("faturanot");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Genelgidertutar).HasColumnName("genelgidertutar");

                entity.Property(e => e.Globalfiyat).HasColumnName("globalfiyat");

                entity.Property(e => e.Ilkdefa).HasColumnName("ilkdefa");

                entity.Property(e => e.Ilkdefauy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ilkdefauy");

                entity.Property(e => e.Imalattakip).HasColumnName("imalattakip");

                entity.Property(e => e.Iptal).HasColumnName("iptal");

                entity.Property(e => e.Irsaliyenot)
                    .HasColumnType("text")
                    .HasColumnName("irsaliyenot");

                entity.Property(e => e.Kapattarih)
                    .HasColumnType("datetime")
                    .HasColumnName("kapattarih");

                entity.Property(e => e.Kdovizkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kdovizkod");

                entity.Property(e => e.Kfaturaet).HasColumnName("kfaturaet");

                entity.Property(e => e.Kisikod)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Kliseadet).HasColumnName("kliseadet");

                entity.Property(e => e.Klisefiyat).HasColumnName("klisefiyat");

                entity.Property(e => e.KontrolDepo).HasColumnName("kontrol_depo");

                entity.Property(e => e.KontrolKapat).HasColumnName("kontrol_kapat");

                entity.Property(e => e.Makinatutar).HasColumnName("makinatutar");

                entity.Property(e => e.Malzemetutar).HasColumnName("malzemetutar");

                entity.Property(e => e.Muhtemeltarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("muhtemeltarih");

                entity.Property(e => e.Musterisano)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("musterisano");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Onayadres)
                    .HasColumnType("text")
                    .HasColumnName("onayadres");

                entity.Property(e => e.Oncekilot)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("oncekilot");

                entity.Property(e => e.Ozelbilgi)
                    .HasColumnType("text")
                    .HasColumnName("ozelbilgi");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Planlanantarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("planlanantarih");

                entity.Property(e => e.Prova).HasColumnName("prova");

                entity.Property(e => e.Revizyonfilmdegil).HasColumnName("revizyonfilmdegil");

                entity.Property(e => e.Revizyonkod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("revizyonkod");

                entity.Property(e => e.Revizyonnot)
                    .HasColumnType("text")
                    .HasColumnName("revizyonnot");

                entity.Property(e => e.Revizyonvar).HasColumnName("revizyonvar");

                entity.Property(e => e.Satistltutar).HasColumnName("satistltutar");

                entity.Property(e => e.Siparisbirim)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("siparisbirim");

                entity.Property(e => e.Siparisfiyat).HasColumnName("siparisfiyat");

                entity.Property(e => e.Siparismiktar).HasColumnName("siparismiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("siparistarih");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Toplamagirlik).HasColumnName("toplamagirlik");

                entity.Property(e => e.Toplamalan).HasColumnName("toplamalan");

                entity.Property(e => e.Toplamteslim).HasColumnName("toplamteslim");

                entity.Property(e => e.Toplamteslimmiktar).HasColumnName("toplamteslimmiktar");

                entity.Property(e => e.Tramyogunlugu).HasColumnName("tramyogunlugu");

                entity.Property(e => e.Urunacildi)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunacildi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yeniurun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yeniurun");
            });

            modelBuilder.Entity<TblKliseGonderme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_gonderme");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Klisegondermekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisegondermekod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblKlisePantone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_pantone");

                entity.Property(e => e.Aniloxkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("aniloxkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Formul)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("formul")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Klisepantoneid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("klisepantoneid");

                entity.Property(e => e.Kliseuyumkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kliseuyumkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Pantoneno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pantoneno");

                entity.Property(e => e.Sonno).HasColumnName("sonno");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblKliseRevizyon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_revizyon");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Kliserevizyonsebepkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kliserevizyonsebepkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Revizyonkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("revizyonkod");
            });

            modelBuilder.Entity<TblKliseRevizyonSebep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_revizyon_sebep");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kliserevizyonsebepkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kliserevizyonsebepkod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblKliseSabagkod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_sabagkod");

                entity.Property(e => e.Kliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno");

                entity.Property(e => e.Klisetipkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisetipkod");

                entity.Property(e => e.Sabagkod)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod");
            });

            modelBuilder.Entity<TblKliseSaklama>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_saklama");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Klisesaklamakod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisesaklamakod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblKliseSebep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_sebep");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Klisesebepkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisesebepkod");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblKliseTakim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_takim");

                entity.Property(e => e.Kliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno");

                entity.Property(e => e.Takimadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("takimadi");

                entity.Property(e => e.Takimkod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("takimkod");

                entity.Property(e => e.Takimno)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("takimno");
            });

            modelBuilder.Entity<TblKliseTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_tip");

                entity.Property(e => e.Baskitipkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baskitipkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Fiyatmaliyet).HasColumnName("fiyatmaliyet");

                entity.Property(e => e.Klisetipkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisetipkod");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sabagkod)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod");
            });

            modelBuilder.Entity<TblKliseUyum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_uyum");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kliseuyumkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kliseuyumkod");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblKliseYenileme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_klise_yenileme");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("birimdovizkod")
                    .HasDefaultValueSql("('002')");

                entity.Property(e => e.Birimfiyat).HasColumnName("birimfiyat");

                entity.Property(e => e.Cekirdekvar).HasColumnName("cekirdekvar");

                entity.Property(e => e.Durumkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("durumkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Gondertarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("gondertarihi");

                entity.Property(e => e.Imaltarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("imaltarihi");

                entity.Property(e => e.Imhasebepkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("imhasebepkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imhatarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("imhatarihi");

                entity.Property(e => e.Iptal).HasColumnName("iptal");

                entity.Property(e => e.Isteyen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("isteyen")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Klisesebepkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisesebepkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisetakip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("klisetakip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisetipkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("klisetipkod");

                entity.Property(e => e.Kullanimda).HasColumnName("kullanimda");

                entity.Property(e => e.Miktar1).HasColumnName("miktar1");

                entity.Property(e => e.Miktar2).HasColumnName("miktar2");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Said).HasColumnName("said");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Sebepkisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sebepkisi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("siparisno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sipariste).HasColumnName("sipariste");

                entity.Property(e => e.Sira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sira")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Teslimalan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("teslimalan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Teslimtarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("teslimtarihi");

                entity.Property(e => e.Tursayisi).HasColumnName("tursayisi");

                entity.Property(e => e.Uretimyeri)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uretimyeri")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yenilemeno)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yenilemeno");
            });

            modelBuilder.Entity<TblKonsinye>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_konsinye");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Faturadovizkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("faturadovizkod");

                entity.Property(e => e.Faturafiyat).HasColumnName("faturafiyat");

                entity.Property(e => e.Faturakoliadet).HasColumnName("faturakoliadet");

                entity.Property(e => e.Faturano)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("faturano");

                entity.Property(e => e.Faturaruloadet).HasColumnName("faturaruloadet");

                entity.Property(e => e.Faturatoplamadet).HasColumnName("faturatoplamadet");

                entity.Property(e => e.Faturaurunadet)
                    .HasColumnType("text")
                    .HasColumnName("faturaurunadet");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Geriiadeadet).HasColumnName("geriiadeadet");

                entity.Property(e => e.Iadeadet).HasColumnName("iadeadet");

                entity.Property(e => e.Iadeirsaliyeno)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("iadeirsaliyeno");

                entity.Property(e => e.Iadenot)
                    .HasColumnType("text")
                    .HasColumnName("iadenot");

                entity.Property(e => e.Irsaliyeno)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("irsaliyeno");

                entity.Property(e => e.Koliadet).HasColumnName("koliadet");

                entity.Property(e => e.Konsinyeno).HasColumnName("konsinyeno");

                entity.Property(e => e.Nettoplamadet).HasColumnName("nettoplamadet");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ruloadet).HasColumnName("ruloadet");

                entity.Property(e => e.Sevkfiyat).HasColumnName("sevkfiyat");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Sikayetno).HasColumnName("sikayetno");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Urunadet)
                    .HasColumnType("text")
                    .HasColumnName("urunadet");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblKullanimalani>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_kullanimalani");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Kullanimalanikod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kullanimalanikod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblMakinaBakim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_bakim");

                entity.Property(e => e.Aciliyet)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("aciliyet");

                entity.Property(e => e.Arizatanimi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("arizatanimi");

                entity.Property(e => e.Bakimiyapan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bakimiyapan");

                entity.Property(e => e.Bakimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bakimkod");

                entity.Property(e => e.Bakimno).HasColumnName("bakimno");

                entity.Property(e => e.Bakimtanimi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bakimtanimi");

                entity.Property(e => e.Baslasaat)
                    .HasColumnType("datetime")
                    .HasColumnName("baslasaat");

                entity.Property(e => e.Baslatarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("baslatarih");

                entity.Property(e => e.Bitissaat)
                    .HasColumnType("datetime")
                    .HasColumnName("bitissaat");

                entity.Property(e => e.Bitistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("bitistarih");

                entity.Property(e => e.Durumu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("durumu");

                entity.Property(e => e.Hareketno).HasColumnName("hareketno");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("saat");

                entity.Property(e => e.Sonuc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sonuc");

                entity.Property(e => e.Sure).HasColumnName("sure");

                entity.Property(e => e.Talepeden)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("talepeden");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Uretimdurdu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uretimdurdu");
            });

            modelBuilder.Entity<TblMakinaBakimHareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_bakim_hareket");

                entity.Property(e => e.Bakimhareketno).HasColumnName("bakimhareketno");

                entity.Property(e => e.Bakimno).HasColumnName("bakimno");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblMakinaBicaktip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_bicaktip");

                entity.Property(e => e.Bicaktipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bicaktipkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblMakinaBirim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_birim");

                entity.Property(e => e.Birimadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("birimadi");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Makinabirimkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("makinabirimkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblMakinaBol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_bol");

                entity.Property(e => e.Bol).HasColumnName("bol");

                entity.Property(e => e.Cekim).HasColumnName("cekim");

                entity.Property(e => e.Islemkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Makinakodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");
            });

            modelBuilder.Entity<TblMakinaCalisma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_calisma");

                entity.Property(e => e.Baslamasaat)
                    .HasColumnType("datetime")
                    .HasColumnName("baslamasaat");

                entity.Property(e => e.Bitissaat)
                    .HasColumnType("datetime")
                    .HasColumnName("bitissaat");

                entity.Property(e => e.Calisiyor).HasColumnName("calisiyor");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<TblMakinaCalismaHaftum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_calisma_hafta");

                entity.Property(e => e.Baslamasaat)
                    .HasColumnType("datetime")
                    .HasColumnName("baslamasaat");

                entity.Property(e => e.Bitissaat)
                    .HasColumnType("datetime")
                    .HasColumnName("bitissaat");

                entity.Property(e => e.Calisiyor).HasColumnName("calisiyor");

                entity.Property(e => e.Gun)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gun");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");
            });

            modelBuilder.Entity<TblMakinaDisli>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_disli");

                entity.Property(e => e.Dislidegeri).HasColumnName("dislidegeri");

                entity.Property(e => e.Dislisayisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dislisayisi2)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dislisayisi3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Islemunitesayisi)
                    .HasColumnName("islemunitesayisi")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Manyetiken).HasColumnName("manyetiken");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblMakinaGider>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_gider");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Elektrikgideri).HasColumnName("elektrikgideri");

                entity.Property(e => e.Genelgiderpayi).HasColumnName("genelgiderpayi");

                entity.Property(e => e.Gidergrupkod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gidergrupkod");

                entity.Property(e => e.Iscilikgideri).HasColumnName("iscilikgideri");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblMakinaGiderGrup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_gider_grup");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Gidergrupkod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gidergrupkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblMakinaGrup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_grup");

                entity.Property(e => e.Adetforma)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("adetforma");

                entity.Property(e => e.FirmId).HasColumnName("firmId");

                entity.Property(e => e.Kalipbilgi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("kalipbilgi");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Makinagrupkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinagrupkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Tanimsira).HasColumnName("tanimsira");

                entity.Property(e => e.UretimdeTakipEt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("uretimdeTakipEt");
            });

            modelBuilder.Entity<TblMakinaIslem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_islem");

                entity.Property(e => e.Baski).HasColumnName("baski");

                entity.Property(e => e.Baskitipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baskitipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bicaktipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bicaktipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bol).HasColumnName("bol");

                entity.Property(e => e.Dislidegeri)
                    .HasColumnName("dislidegeri")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dislisizvar).HasColumnName("dislisizvar");

                entity.Property(e => e.Dislivar).HasColumnName("dislivar");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Elisciligi).HasColumnName("elisciligi");

                entity.Property(e => e.Fason).HasColumnName("fason");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Fiyatbirim)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fiyatbirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iptal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("iptal")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Islemtipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemtipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Islemunitesayisi).HasColumnName("islemunitesayisi");

                entity.Property(e => e.Kesim).HasColumnName("kesim");

                entity.Property(e => e.Makinabirimkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("makinabirimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makinaislemkod).HasColumnName("makinaislemkod");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Maksboy).HasColumnName("maksboy");

                entity.Property(e => e.Maksen).HasColumnName("maksen");

                entity.Property(e => e.Minboy).HasColumnName("minboy");

                entity.Property(e => e.Minen).HasColumnName("minen");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ortsaatehiz).HasColumnName("ortsaatehiz");

                entity.Property(e => e.Ortsetupdakika).HasColumnName("ortsetupdakika");

                entity.Property(e => e.Semirot).HasColumnName("semirot");

                entity.Property(e => e.Setupdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("setupdovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Setupfire).HasColumnName("setupfire");

                entity.Property(e => e.Setupfiyat).HasColumnName("setupfiyat");

                entity.Property(e => e.Urunyyadetorani)
                    .HasColumnName("urunyyadetorani")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Yandondur).HasColumnName("yandondur");

                entity.Property(e => e.Yuzdefire).HasColumnName("yuzdefire");
            });

            modelBuilder.Entity<TblMakinaIslemUrun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_islem_urun");

                entity.Property(e => e.Artiboy).HasColumnName("artiboy");

                entity.Property(e => e.Artien).HasColumnName("artien");

                entity.Property(e => e.Artitopboy).HasColumnName("artitopboy");

                entity.Property(e => e.Artitopen).HasColumnName("artitopen");

                entity.Property(e => e.Boyubelirsiz).HasColumnName("boyubelirsiz");

                entity.Property(e => e.Boyubelli).HasColumnName("boyubelli");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Enibelirsiz).HasColumnName("enibelirsiz");

                entity.Property(e => e.Enibelli).HasColumnName("enibelli");

                entity.Property(e => e.Makinaislemkod).HasColumnName("makinaislemkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yogunlukadet).HasColumnName("yogunlukadet");

                entity.Property(e => e.Yogunlukalan).HasColumnName("yogunlukalan");

                entity.Property(e => e.Yogunlukgram).HasColumnName("yogunlukgram");
            });

            modelBuilder.Entity<TblMakinaKart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_makina_kart");

                entity.Property(e => e.Aktif)
                    .IsRequired()
                    .HasColumnName("aktif")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Anaislemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("anaislemkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bakiunitesi).HasColumnName("bakiunitesi");

                entity.Property(e => e.Durumkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("durumkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Elektrikgideri).HasColumnName("elektrikgideri");

                entity.Property(e => e.Genelgiderpayi).HasColumnName("genelgiderpayi");

                entity.Property(e => e.Giderkatsayisi).HasColumnName("giderkatsayisi");

                entity.Property(e => e.Gidersaatucret).HasColumnName("gidersaatucret");

                entity.Property(e => e.Iscilikgideri).HasColumnName("iscilikgideri");

                entity.Property(e => e.Kkontrol).HasColumnName("kkontrol");

                entity.Property(e => e.Makinaadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("makinaadi");

                entity.Property(e => e.Makinaek).HasColumnName("makinaek");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Maksboy).HasColumnName("maksboy");

                entity.Property(e => e.Maksen).HasColumnName("maksen");

                entity.Property(e => e.Minboy).HasColumnName("minboy");

                entity.Property(e => e.Minen).HasColumnName("minen");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Planlamasirasi).HasColumnName("planlamasirasi");

                entity.Property(e => e.Saatucret).HasColumnName("saatucret");

                entity.Property(e => e.Setup).HasColumnName("setup");

                entity.Property(e => e.Setupfire).HasColumnName("setupfire");

                entity.Property(e => e.Uretimplanlamaadet)
                    .HasColumnName("uretimplanlamaadet")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Yuzdefire).HasColumnName("yuzdefire");
            });

            modelBuilder.Entity<TblMaliyet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet");

                entity.Property(e => e.Aabosluk).HasColumnName("aabosluk");

                entity.Property(e => e.Acan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("acan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Adettakim).HasColumnName("adettakim");

                entity.Property(e => e.Adettakim2).HasColumnName("adettakim2");

                entity.Property(e => e.Agirlik).HasColumnName("agirlik");

                entity.Property(e => e.Agirliknet).HasColumnName("agirliknet");

                entity.Property(e => e.Alan).HasColumnName("alan");

                entity.Property(e => e.Alannet).HasColumnName("alannet");

                entity.Property(e => e.Baglamafaturaet).HasColumnName("baglamafaturaet");

                entity.Property(e => e.Baglamaparabirimi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baglamaparabirimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Baglamaucreti).HasColumnName("baglamaucreti");

                entity.Property(e => e.BaskiVar).HasColumnName("baski_var");

                entity.Property(e => e.Baskibicakayri).HasColumnName("baskibicakayri");

                entity.Property(e => e.BicakVar).HasColumnName("bicak_var");

                entity.Property(e => e.Bicakek).HasColumnName("bicakek");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bicakmasraf).HasColumnName("bicakmasraf");

                entity.Property(e => e.BicakmasrafEkle).HasColumnName("bicakmasraf_ekle");

                entity.Property(e => e.Bicaktipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bicaktipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Boyafiyat).HasColumnName("boyafiyat");

                entity.Property(e => e.BoyayogunluguEkle).HasColumnName("boyayogunlugu_ekle");

                entity.Property(e => e.Boyayogunluk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("boyayogunluk")
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.Cesit)
                    .HasColumnName("cesit")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cl).HasColumnName("cl");

                entity.Property(e => e.Depolama).HasColumnName("depolama");

                entity.Property(e => e.Devamlilik).HasColumnName("devamlilik");

                entity.Property(e => e.Dolarkur).HasColumnName("dolarkur");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DurumKontrol).HasColumnName("durum_kontrol");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Ek5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek5");

                entity.Property(e => e.Ek6)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek6");

                entity.Property(e => e.Enverimi).HasColumnName("enverimi");

                entity.Property(e => e.Eurobarite).HasColumnName("eurobarite");

                entity.Property(e => e.Eurokur).HasColumnName("eurokur");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Fiyattarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fiyattarih");

                entity.Property(e => e.Genelgider).HasColumnName("genelgider");

                entity.Property(e => e.Genelgidereur).HasColumnName("genelgidereur");

                entity.Property(e => e.Genelgideryuzde).HasColumnName("genelgideryuzde");

                entity.Property(e => e.Gramaj).HasColumnName("gramaj");

                entity.Property(e => e.Gramaj2).HasColumnName("gramaj2");

                entity.Property(e => e.Hammaddefiyatbirimi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("hammaddefiyatbirimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Holtmelt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("holtmelt")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kalinlik).HasColumnName("kalinlik");

                entity.Property(e => e.KlisemasrafEkle).HasColumnName("klisemasraf_ekle");

                entity.Property(e => e.Klisetutar).HasColumnName("klisetutar");

                entity.Property(e => e.KontrolMaliyet)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kontrol_maliyet")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Laminasyon)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("laminasyon")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Laminasyonadi)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("laminasyonadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaminasyoncinsiEkle).HasColumnName("laminasyoncinsi_ekle");

                entity.Property(e => e.Lf).HasColumnName("lf");

                entity.Property(e => e.Makinaek).HasColumnName("makinaek");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makinakodub)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodub")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maliyetadet).HasColumnName("maliyetadet");

                entity.Property(e => e.Maliyetboy).HasColumnName("maliyetboy");

                entity.Property(e => e.Maliyeteken).HasColumnName("maliyeteken");

                entity.Property(e => e.Maliyeten).HasColumnName("maliyeten");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Maliyetrenk).HasColumnName("maliyetrenk");

                entity.Property(e => e.Malzemecinsi)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemecinsi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Malzemecinsi2)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemecinsi2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MalzemecinsiEkle).HasColumnName("malzemecinsi_ekle");

                entity.Property(e => e.MalzemecinsiEkle2).HasColumnName("malzemecinsi_ekle2");

                entity.Property(e => e.Malzemeek).HasColumnName("malzemeek");

                entity.Property(e => e.Malzemefiyat).HasColumnName("malzemefiyat");

                entity.Property(e => e.Malzemefiyat2).HasColumnName("malzemefiyat2");

                entity.Property(e => e.Mamultipkod).HasColumnName("mamultipkod");

                entity.Property(e => e.Montaj)
                    .HasColumnName("montaj")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Musterikod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("musterikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Musteriyyadet)
                    .HasColumnName("musteriyyadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Netenverimi).HasColumnName("netenverimi");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Onayagonderen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("onayagonderen")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Onayagondertarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("onayagondertarih");

                entity.Property(e => e.Onayliyan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("onayliyan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Onaytarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("onaytarih");

                entity.Property(e => e.Ortfiyatvar).HasColumnName("ortfiyatvar");

                entity.Property(e => e.Ozelbilgi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ozelbilgi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Perfore)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perfore")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Renk).HasColumnName("renk");

                entity.Property(e => e.Ribon).HasColumnName("ribon");

                entity.Property(e => e.Rpt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("rpt")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rulobirim)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rulobirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sabitkur).HasColumnName("sabitkur");

                entity.Property(e => e.Slevetip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("slevetip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Takimmiktar)
                    .HasColumnName("takimmiktar")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Takimmiktar2)
                    .HasColumnName("takimmiktar2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Takimuretimmiktar)
                    .HasColumnName("takimuretimmiktar")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Tekebadyukseklik).HasColumnName("tekebadyukseklik");

                entity.Property(e => e.Teklifbirimi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("teklifbirimi")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Tipi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipi")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Urunadi)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("urunadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunbirimtip)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("urunbirimtip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uruneken).HasColumnName("uruneken");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uygulamasekli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uygulamasekli")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vade).HasColumnName("vade");

                entity.Property(e => e.VadeEkle).HasColumnName("vade_ekle");

                entity.Property(e => e.Vadevalor).HasColumnName("vadevalor");

                entity.Property(e => e.Yaldiz)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yaldiz")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yapistirmapayi)
                    .HasColumnName("yapistirmapayi")
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.Yenibicak).HasColumnName("yenibicak");

                entity.Property(e => e.Yogunluk).HasColumnName("yogunluk");

                entity.Property(e => e.Yonetimgideri).HasColumnName("yonetimgideri");

                entity.Property(e => e.Yyadet).HasColumnName("yyadet");

                entity.Property(e => e.Yybitisikadet).HasColumnName("yybitisikadet");

                entity.Property(e => e.Yybosluk).HasColumnName("yybosluk");
            });

            modelBuilder.Entity<TblMaliyetAdet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_adet");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Amortismangider).HasColumnName("amortismangider");

                entity.Property(e => e.Artifire).HasColumnName("artifire");

                entity.Property(e => e.Birimadetfiyat).HasColumnName("birimadetfiyat");

                entity.Property(e => e.Birimagirlikfiyat).HasColumnName("birimagirlikfiyat");

                entity.Property(e => e.Birimalanfiyat).HasColumnName("birimalanfiyat");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Carpan).HasColumnName("carpan");

                entity.Property(e => e.Carpannet).HasColumnName("carpannet");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Elektirkgider).HasColumnName("elektirkgider");

                entity.Property(e => e.Fire).HasColumnName("fire");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Hammaddetutar).HasColumnName("hammaddetutar");

                entity.Property(e => e.Iscilikgider).HasColumnName("iscilikgider");

                entity.Property(e => e.Islemtutar).HasColumnName("islemtutar");

                entity.Property(e => e.Makinagider).HasColumnName("makinagider");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Maxadet).HasColumnName("maxadet");

                entity.Property(e => e.Minadet).HasColumnName("minadet");

                entity.Property(e => e.Nakliyetutar).HasColumnName("nakliyetutar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sarfmalzemefiyat).HasColumnName("sarfmalzemefiyat");

                entity.Property(e => e.Teklifbirimi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("teklifbirimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Toplamfiyat).HasColumnName("toplamfiyat");

                entity.Property(e => e.Toplamfiyattutar).HasColumnName("toplamfiyattutar");

                entity.Property(e => e.Uzunluk).HasColumnName("uzunluk");

                entity.Property(e => e.Vade).HasColumnName("vade");

                entity.Property(e => e.Yardhammaddetutar).HasColumnName("yardhammaddetutar");

                entity.Property(e => e.Yonetimgider).HasColumnName("yonetimgider");

                entity.Property(e => e.Yonetimgidernet).HasColumnName("yonetimgidernet");
            });

            modelBuilder.Entity<TblMaliyetCarpan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_carpan");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Carpan).HasColumnName("carpan");

                entity.Property(e => e.Ek).HasColumnName("ek");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Fiyatagirlik).HasColumnName("fiyatagirlik");

                entity.Property(e => e.Fiyatalan).HasColumnName("fiyatalan");

                entity.Property(e => e.Fiyatuzunluk).HasColumnName("fiyatuzunluk");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Maxadet).HasColumnName("maxadet");

                entity.Property(e => e.Minadet).HasColumnName("minadet");

                entity.Property(e => e.Mlzfiyat).HasColumnName("mlzfiyat");

                entity.Property(e => e.Ttutar).HasColumnName("ttutar");
            });

            modelBuilder.Entity<TblMaliyetIndirim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_indirim");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Indirimno).HasColumnName("indirimno");

                entity.Property(e => e.Iptal).HasColumnName("iptal");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sebep)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sebep");

                entity.Property(e => e.Yuzdeindirim).HasColumnName("yuzdeindirim");
            });

            modelBuilder.Entity<TblMaliyetIslem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_islem");

                entity.Property(e => e.Aaadet)
                    .HasColumnName("aaadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Artisaattehiz).HasColumnName("artisaattehiz");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Boyabirimfiyat).HasColumnName("boyabirimfiyat");

                entity.Property(e => e.Boyadovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("boyadovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Boyayogunlugu).HasColumnName("boyayogunlugu");

                entity.Property(e => e.Dislidegeri).HasColumnName("dislidegeri");

                entity.Property(e => e.Dislisayisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ekgecis)
                    .HasColumnName("ekgecis")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ekstragideradi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ekstragideradi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ekstragiderfiyat).HasColumnName("ekstragiderfiyat");

                entity.Property(e => e.Ektradovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ektradovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ektragiderbirim)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ektragiderbirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Islemtekrari)
                    .HasColumnName("islemtekrari")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Islemtipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemtipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maliyetislemid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("maliyetislemid");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Setupdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("setupdovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Setupfire).HasColumnName("setupfire");

                entity.Property(e => e.Setupfiyat).HasColumnName("setupfiyat");

                entity.Property(e => e.Sira)
                    .HasColumnName("sira")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Takipadi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("takipadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yuzdefire).HasColumnName("yuzdefire");

                entity.Property(e => e.Yyadet)
                    .HasColumnName("yyadet")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblMaliyetIslemUrun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_islem_urun");

                entity.Property(e => e.Artiboy).HasColumnName("artiboy");

                entity.Property(e => e.Artien).HasColumnName("artien");

                entity.Property(e => e.Artitopboy).HasColumnName("artitopboy");

                entity.Property(e => e.Artitopen).HasColumnName("artitopen");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimtip)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("birimtip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Boyuesit).HasColumnName("boyuesit");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Eniesit).HasColumnName("eniesit");

                entity.Property(e => e.Fiyateuroalan).HasColumnName("fiyateuroalan");

                entity.Property(e => e.Fiyateurokg).HasColumnName("fiyateurokg");

                entity.Property(e => e.Hammaddefiyat).HasColumnName("hammaddefiyat");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maliyetislemid).HasColumnName("maliyetislemid");

                entity.Property(e => e.Maliyetislemurunid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("maliyetislemurunid");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Malzemeuretimeni).HasColumnName("malzemeuretimeni");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Parabirimi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("parabirimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunaaadet)
                    .HasColumnName("urunaaadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunyyadet)
                    .HasColumnName("urunyyadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Yogunlukadet).HasColumnName("yogunlukadet");

                entity.Property(e => e.Yogunlukalan).HasColumnName("yogunlukalan");

                entity.Property(e => e.Yogunlukgram).HasColumnName("yogunlukgram");
            });

            modelBuilder.Entity<TblMaliyetIslemZorunlu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_islem_zorunlu");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Islemtipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemtipkod");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaliyetislemZid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("maliyetislemZid");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");
            });

            modelBuilder.Entity<TblMaliyetLf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_lf");

                entity.Property(e => e.Aramesafe).HasColumnName("aramesafe");

                entity.Property(e => e.Lf).HasColumnName("lf");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Maliyetlfid).HasColumnName("maliyetlfid");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblMaliyetMalzeme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_malzeme");

                entity.Property(e => e.Fiyateuroalan).HasColumnName("fiyateuroalan");

                entity.Property(e => e.Fiyateurokg).HasColumnName("fiyateurokg");

                entity.Property(e => e.Gramaj).HasColumnName("gramaj");

                entity.Property(e => e.Hammadde).HasColumnName("hammadde");

                entity.Property(e => e.Hammaddefiyat).HasColumnName("hammaddefiyat");

                entity.Property(e => e.Maliyetislemid).HasColumnName("maliyetislemid");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Maliyetmalzemeid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("maliyetmalzemeid");

                entity.Property(e => e.Malzemeuretimeni).HasColumnName("malzemeuretimeni");

                entity.Property(e => e.Parabirimi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("parabirimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sira)
                    .HasColumnName("sira")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Urunbirimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("urunbirimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yapisalkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblMaliyetOnay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_onay");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Maliyetonayid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("maliyetonayid");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Onaylayan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("onaylayan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<TblMaliyetSabit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_maliyet_sabit");

                entity.Property(e => e.Bobin).HasColumnName("bobin");

                entity.Property(e => e.Bobinfire).HasColumnName("bobinfire");

                entity.Property(e => e.Gorusmehafta).HasColumnName("gorusmehafta");

                entity.Property(e => e.Onaylicarpan).HasColumnName("onaylicarpan");

                entity.Property(e => e.Saonay).HasColumnName("saonay");

                entity.Property(e => e.Sonhareketno).HasColumnName("sonhareketno");

                entity.Property(e => e.Vadevalor).HasColumnName("vadevalor");

                entity.Property(e => e.Yonetimgideri).HasColumnName("yonetimgideri");

                entity.Property(e => e.Yonetimgiderigercek).HasColumnName("yonetimgiderigercek");
            });

            modelBuilder.Entity<TblMamulTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_mamul_tip");

                entity.Property(e => e.Anatip)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("anatip");

                entity.Property(e => e.Cesit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cesit");

                entity.Property(e => e.Cilt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cilt");

                entity.Property(e => e.Cokyaprak)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("cokyaprak");

                entity.Property(e => e.Hatsayisi).HasColumnName("hatsayisi");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Mamultipkod).HasColumnName("mamultipkod");

                entity.Property(e => e.Minimumaaaralik).HasColumnName("minimumaaaralik");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblMamulTipHat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_mamul_tip_hat");

                entity.Property(e => e.Hat).HasColumnName("hat");

                entity.Property(e => e.Hatadi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("hatadi");

                entity.Property(e => e.Mamultipkod).HasColumnName("mamultipkod");

                entity.Property(e => e.Minimumurun).HasColumnName("minimumurun");
            });

            modelBuilder.Entity<TblMuadil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_muadil");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Muadilkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("muadilkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblOdeme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_odeme");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Odemekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("odemekod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblOpaklik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_opaklik");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Opaklikkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("opaklikkod");
            });

            modelBuilder.Entity<TblParametre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_parametre");

                entity.Property(e => e.Bilgisayaradi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bilgisayaradi");

                entity.Property(e => e.Bolum)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bolum");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Parametrekod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("parametrekod");

                entity.Property(e => e.Veri)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("veri");
            });

            modelBuilder.Entity<TblParlaklik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_parlaklik");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Parlaklikkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("parlaklikkod");
            });

            modelBuilder.Entity<TblPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel");

                entity.Property(e => e.Adisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("adisoyadi");

                entity.Property(e => e.Grafikonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grafikonay")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Maliyetonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("maliyetonay")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Mnu0100)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu01_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0101)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu01_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0102)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu01_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0103)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu01_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0104)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu01_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0200)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu02_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0201)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu02_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0202)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu02_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0203)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu02_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0204)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu02_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0205)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu02_05")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0206)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu02_06")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0207)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu02_07")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0300)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu03_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0301)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu03_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0302)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu03_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0303)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu03_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0400)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu04_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0401)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu04_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0402)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu04_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0403)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu04_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0500)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu05_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0501)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu05_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0502)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu05_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0503)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu05_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0504)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu05_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0600)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu06_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0601)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu06_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0602)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu06_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0603)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu06_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0604)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu06_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0700)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu07_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0701)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu07_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0800)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0801)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0802)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu080201)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_02_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu080202)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_02_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0803)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu080301)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_03_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu080302)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_03_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0804)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu08_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0900)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0901)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090101)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_01_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090102)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_01_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090103)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_01_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090104)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_01_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0902)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090201)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_02_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090202)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_02_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090203)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_02_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090204)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_02_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090205)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_02_05")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0903)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090301)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_03_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090302)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_03_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu090303)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_03_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu0904)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu09_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1000)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1001)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100101)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_01_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100102)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_01_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100103)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_01_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100104)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_01_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1002)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100201)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_02_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100202)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_02_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100203)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_02_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1003)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100301)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_03_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100302)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_03_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100303)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_03_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100304)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_03_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100305)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_03_05")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100306)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_03_06")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1004)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100401)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100402)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100403)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100404)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100405)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_05")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100406)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_06")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100407)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_07")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100408)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_08")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100409)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_04_09")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1005)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_05")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100501)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_05_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100502)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_05_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100503)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_05_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100504)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_05_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100505)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_05_05")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1006)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_06")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100601)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_06_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100602)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_06_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1007)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_07")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100701)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_07_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1008)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_08")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100801)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_08_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100802)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_08_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100803)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_08_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1009)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_09")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100901)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_09_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100902)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_09_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100903)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_09_03")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu100904)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_09_04")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1010)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_10")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101001)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_10_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101002)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_10_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1011)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_11")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101101)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_11_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101102)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_11_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1012)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_12")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101201)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_12_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101202)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_12_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1013)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_13")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1014)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_14")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101401)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_14_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101402)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_14_02")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1015)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_15")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu101501)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu10_15_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1100)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu11_00")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Mnu1101)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnu11_01")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sorunlufirma)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sorunlufirma")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Sup)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sup")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Uretimonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uretimonay")
                    .HasDefaultValueSql("('H')");
            });

            modelBuilder.Entity<TblPersonelBilgisayar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_bilgisayar");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adi");

                entity.Property(e => e.Bilid).HasColumnName("bilid");

                entity.Property(e => e.Cinsi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cinsi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Seviye)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("seviye");
            });

            modelBuilder.Entity<TblPersonelCeza>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_ceza");

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adi");

                entity.Property(e => e.Ceza).HasColumnName("ceza");

                entity.Property(e => e.Cezaid).HasColumnName("cezaid");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sebep)
                    .HasColumnType("text")
                    .HasColumnName("sebep");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<TblPersonelDil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_dil");

                entity.Property(e => e.Dil)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dil");

                entity.Property(e => e.Dilid).HasColumnName("dilid");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Seviye)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("seviye");

                entity.Property(e => e.Yer)
                    .HasColumnType("text")
                    .HasColumnName("yer");
            });

            modelBuilder.Entity<TblPersonelEgitim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_egitim");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Firmaici).HasColumnName("firmaici");

                entity.Property(e => e.Konu)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("konu");

                entity.Property(e => e.PersonelEgitimId).HasColumnName("personelEgitimId");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sure).HasColumnName("sure");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Verenadi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("verenadi");
            });

            modelBuilder.Entity<TblPersonelEgitimPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_egitim_personel");

                entity.Property(e => e.PersonelEgitimId).HasColumnName("personelEgitimId");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblPersonelEpostum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_eposta");

                entity.Property(e => e.Epostagrupkod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("epostagrupkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblPersonelFirm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_firm");

                entity.Property(e => e.FirmId).HasColumnName("firmId");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblPersonelGrup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_grup");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelgrupkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("personelgrupkod");
            });

            modelBuilder.Entity<TblPersonelIhtiyac>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_ihtiyac");

                entity.Property(e => e.Ihtiyac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ihtiyac");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Planlama)
                    .HasColumnType("text")
                    .HasColumnName("planlama");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<TblPersonelIslem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_islem");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Islemtipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemtipkod");

                entity.Property(e => e.PerIslemId).HasColumnName("perIslemId");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.TakipId).HasColumnName("takipId");
            });

            modelBuilder.Entity<TblPersonelIzin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_izin");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Cikistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("cikistarih");

                entity.Property(e => e.Gelistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("gelistarih");

                entity.Property(e => e.Izingun).HasColumnName("izingun");

                entity.Property(e => e.Izinid).HasColumnName("izinid");

                entity.Property(e => e.Izinkullanid).HasColumnName("izinkullanid");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblPersonelIzinHak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_izin_hak");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hakedilen).HasColumnName("hakedilen");

                entity.Property(e => e.Ilktarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ilktarih");

                entity.Property(e => e.Izinid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("izinid");

                entity.Property(e => e.Izintakibi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("izintakibi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kullanilan).HasColumnName("kullanilan");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sontarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("sontarih");
            });

            modelBuilder.Entity<TblPersonelKart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_kart");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("adres")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Aktif)
                    .IsRequired()
                    .HasColumnName("aktif")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Askerlik)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("askerlik")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ayakno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("ayakno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Baslatarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("baslatarih");

                entity.Property(e => e.Beden)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("beden")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bolum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bolum")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Calisiyor)
                    .IsRequired()
                    .HasColumnName("calisiyor")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ceptelefon)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ceptelefon")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cikistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("cikistarih");

                entity.Property(e => e.Cocuk).HasColumnName("cocuk");

                entity.Property(e => e.Dogumtarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dogumtarih");

                entity.Property(e => e.Dogumyeri)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dogumyeri")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Doviz).HasColumnName("doviz");

                entity.Property(e => e.Ehliyet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ehliyet")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Eposta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("eposta")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirmId)
                    .HasColumnName("firmId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Firmatemsilcisiatama)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("firmatemsilcisiatama")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("foto")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grafikyetkili)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grafikyetkili")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Grup)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("grup")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hizligir).HasColumnName("hizligir");

                entity.Property(e => e.Ilkogretim)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ilkogretim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilkyil)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ilkyil")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Izingun).HasColumnName("izingun");

                entity.Property(e => e.Izinpotansiyel).HasColumnName("izinpotansiyel");

                entity.Property(e => e.Kan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lisansustu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("lisansustu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lisansustuyil)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("lisansustuyil")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lise)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("lise")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Liseyil)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("liseyil")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maas).HasColumnName("maas");

                entity.Property(e => e.Makinaadi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("makinaadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Medeni)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("medeni")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nitelik).HasColumnName("nitelik");

                entity.Property(e => e.Niteliknot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("niteliknot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Niteliktarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("niteliktarih");

                entity.Property(e => e.Oryantasyonkisi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("oryantasyonkisi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Oryantasyontarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("oryantasyontarih");

                entity.Property(e => e.Oturumadi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("oturumadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Personelgrupkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("personelgrupkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Saglik)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("saglik")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Saonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("saonay")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Saonay2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("saonay2")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Servis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("servis")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sifre2)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sifre2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sifregir).HasColumnName("sifregir");

                entity.Property(e => e.Sosyalno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sosyalno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("telefon")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefon2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("telefon2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Unvan)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("unvan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yuksekokul)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("yuksekokul")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yuksekyil)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("yuksekyil")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblPersonelKur>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_kurs");

                entity.Property(e => e.Kursadi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kursadi");

                entity.Property(e => e.Kursid).HasColumnName("kursid");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sure)
                    .HasColumnType("text")
                    .HasColumnName("sure");

                entity.Property(e => e.Yer)
                    .HasColumnType("text")
                    .HasColumnName("yer");
            });

            modelBuilder.Entity<TblPersonelMakina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_makina");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblPersonelMakinaGrup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_makina_grup");

                entity.Property(e => e.Makinagrupkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinagrupkod");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");
            });

            modelBuilder.Entity<TblPersonelSaglik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_personel_saglik");

                entity.Property(e => e.Bulgu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bulgu");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Rahatsizlik)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("rahatsizlik");

                entity.Property(e => e.Saglikid).HasColumnName("saglikid");

                entity.Property(e => e.Tani)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tani");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Tedavi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tedavi");
            });

            modelBuilder.Entity<TblPlanlama>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_planlama");

                entity.Property(e => e.Baslamasaat)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("baslamasaat");

                entity.Property(e => e.Baslamatarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("baslamatarih");

                entity.Property(e => e.Bitissaat)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("bitissaat");

                entity.Property(e => e.Bitistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("bitistarih");

                entity.Property(e => e.Islemkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Makinakodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Siparisno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("siparisno");

                entity.Property(e => e.Siralama).HasColumnName("siralama");

                entity.Property(e => e.Sure).HasColumnName("sure");
            });

            modelBuilder.Entity<TblRandevu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_randevu");

                entity.Property(e => e.BasSaat)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("bas_saat");

                entity.Property(e => e.Bilgi)
                    .HasColumnType("text")
                    .HasColumnName("bilgi");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Gorid).HasColumnName("gorid");

                entity.Property(e => e.Gorusmeno).HasColumnName("gorusmeno");

                entity.Property(e => e.Gorusmetipno)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("gorusmetipno");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.RandevuSaat)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("randevu_saat");

                entity.Property(e => e.Randevuno).HasColumnName("randevuno");

                entity.Property(e => e.Randevutarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("randevutarihi");

                entity.Property(e => e.Sure)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sure");
            });

            modelBuilder.Entity<TblSaIstek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sa_istek");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Bicak).HasColumnName("bicak");

                entity.Property(e => e.Birimkod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Istekkod).HasColumnName("istekkod");

                entity.Property(e => e.Istenen)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("istenen");

                entity.Property(e => e.Klise).HasColumnName("klise");

                entity.Property(e => e.Miktar1).HasColumnName("miktar1");

                entity.Property(e => e.Miktar2).HasColumnName("miktar2");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sabagkod)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod");

                entity.Property(e => e.Siparisedondu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siparisedondu");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Termintarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("termintarih");

                entity.Property(e => e.Urunadi)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Uruntip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntip");
            });

            modelBuilder.Entity<TblSaSipari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sa_siparis");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Aciklama2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bicak).HasColumnName("bicak");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimoran).HasColumnName("birimoran");

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Detaysiz).HasColumnName("detaysiz");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Firmasip)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("firmasip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Firmasiparisno)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("firmasiparisno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Fiyattl).HasColumnName("fiyattl");

                entity.Property(e => e.Gondermetarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("gondermetarih");

                entity.Property(e => e.Istekkod).HasColumnName("istekkod");

                entity.Property(e => e.Kagittipi)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("kagittipi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kdv)
                    .HasColumnName("kdv")
                    .HasDefaultValueSql("((18))");

                entity.Property(e => e.Kisikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klise).HasColumnName("klise");

                entity.Property(e => e.Klisefirmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("klisefirmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisegondermekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisegondermekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kliseno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisesaklamakod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisesaklamakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KontrolKapat).HasColumnName("kontrol_kapat");

                entity.Property(e => e.Kromolin).HasColumnName("kromolin");

                entity.Property(e => e.Kur).HasColumnName("kur");

                entity.Property(e => e.Malzemekodu)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemekodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Miktar1).HasColumnName("miktar1");

                entity.Property(e => e.Miktar2).HasColumnName("miktar2");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Numunesivar).HasColumnName("numunesivar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sabagkod)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod");

                entity.Property(e => e.Said)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("said");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Sateklifkod).HasColumnName("sateklifkod");

                entity.Property(e => e.Satipi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("satipi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("siparistarih");

                entity.Property(e => e.Sira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sira");

                entity.Property(e => e.Tabaka).HasColumnName("tabaka");

                entity.Property(e => e.Tasarimci)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tasarimci")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tedarikciadi)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("tedarikciadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tedarikcikodu)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("tedarikcikodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Termintarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("termintarih");

                entity.Property(e => e.Tutar).HasColumnName("tutar");

                entity.Property(e => e.Tutartl).HasColumnName("tutartl");

                entity.Property(e => e.Urunbirimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("urunbirimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vade).HasColumnName("vade");

                entity.Property(e => e.Yeniurun)
                    .IsRequired()
                    .HasColumnName("yeniurun")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yonetimonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yonetimonay2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay2")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblSaSiparisKlise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sa_siparis_klise");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");
            });

            modelBuilder.Entity<TblSaSiparisSipari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sa_siparis_siparis");

                entity.Property(e => e.Said).HasColumnName("said");

                entity.Property(e => e.Sasaid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sasaid");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Sipihtiyacid).HasColumnName("sipihtiyacid");

                entity.Property(e => e.Sira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sira");
            });

            modelBuilder.Entity<TblSaSiparisTeslim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sa_siparis_teslim");

                entity.Property(e => e.Ambalajbutunluk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ambalajbutunluk")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Analizsertifikasi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("analizsertifikasi")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Bobinsarimyonu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bobinsarimyonu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Cekmekontrolu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cekmekontrolu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Etiketkontrolu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("etiketkontrolu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Faturafiyat).HasColumnName("faturafiyat");

                entity.Property(e => e.Faturalandi).HasColumnName("faturalandi");

                entity.Property(e => e.Faturano)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("faturano")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faturatarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("faturatarih");

                entity.Property(e => e.Hareketno).HasColumnName("hareketno");

                entity.Property(e => e.Irsaliyeno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("irsaliyeno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Irsaliyetarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("irsaliyetarih");

                entity.Property(e => e.Iskonto).HasColumnName("iskonto");

                entity.Property(e => e.Kabuldurumu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kabuldurumu")
                    .HasDefaultValueSql("('K')");

                entity.Property(e => e.Kontoleden)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kontoleden")
                    .HasDefaultValueSql("('014')");

                entity.Property(e => e.Kontroltarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("kontroltarih");

                entity.Property(e => e.Korona)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("korona")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Mikronkontolu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mikronkontolu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Olcukontrolu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("olcukontrolu")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Onayliyan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("onayliyan")
                    .HasDefaultValueSql("('004')");

                entity.Property(e => e.Paletuygunluk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("paletuygunluk")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Said).HasColumnName("said");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Sevkaraci)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sevkaraci")
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.Sira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sira");

                entity.Property(e => e.Teslimkur).HasColumnName("teslimkur");

                entity.Property(e => e.Teslimmiktar1).HasColumnName("teslimmiktar1");

                entity.Property(e => e.Teslimmiktar2).HasColumnName("teslimmiktar2");

                entity.Property(e => e.Teslimnetmiktar).HasColumnName("teslimnetmiktar");

                entity.Property(e => e.Teslimno).HasColumnName("teslimno");

                entity.Property(e => e.Teslimtarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("teslimtarih");

                entity.Property(e => e.Yapisma)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yapisma")
                    .HasDefaultValueSql("('U')");
            });

            modelBuilder.Entity<TblSaSiparisTeslimDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sa_siparis_teslim_detay");

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Detayno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("detayno");

                entity.Property(e => e.Partino)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("partino")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Said).HasColumnName("said");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Sira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sira");

                entity.Property(e => e.Teslimno).HasColumnName("teslimno");
            });

            modelBuilder.Entity<TblSaTeklif>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sa_teklif");

                entity.Property(e => e.Ambalaj)
                    .HasColumnType("text")
                    .HasColumnName("ambalaj");

                entity.Property(e => e.Baslatarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("baslatarih");

                entity.Property(e => e.Bicak).HasColumnName("bicak");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Bitistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("bitistarih");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Eksart)
                    .HasColumnType("text")
                    .HasColumnName("eksart");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Garanti).HasColumnName("garanti");

                entity.Property(e => e.Imalatcikod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("imalatcikod");

                entity.Property(e => e.Iptal).HasColumnName("iptal");

                entity.Property(e => e.Klise).HasColumnName("klise");

                entity.Property(e => e.Odemekod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("odemekod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sabagkod)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod");

                entity.Property(e => e.Sateklifkod).HasColumnName("sateklifkod");

                entity.Property(e => e.Sevkiyatkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sevkiyatkod");

                entity.Property(e => e.Tedarikciadi)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("tedarikciadi");

                entity.Property(e => e.Tedarikcikodu)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("tedarikcikodu");

                entity.Property(e => e.Teslimatkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("teslimatkod");

                entity.Property(e => e.Teslimatyeri)
                    .HasColumnType("text")
                    .HasColumnName("teslimatyeri");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Uruntipkod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod");

                entity.Property(e => e.Vade).HasColumnName("vade");
            });

            modelBuilder.Entity<TblSaTeklifFiyat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sa_teklif_fiyat");

                entity.Property(e => e.Altmiktar).HasColumnName("altmiktar");

                entity.Property(e => e.Birimkod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Sateklifkod).HasColumnName("sateklifkod");

                entity.Property(e => e.Sirano)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sirano");

                entity.Property(e => e.Ustmiktar).HasColumnName("ustmiktar");
            });

            modelBuilder.Entity<TblSabagkod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sabagkod");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisetipkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisetipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sabagkod)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblSektor>(entity =>
            {
                entity.HasKey(e => e.SekId)
                    .HasName("PK_tbl_sektor_1");

                entity.ToTable("tbl_sektor");

                entity.HasIndex(e => new { e.Sektorkod, e.Sektoraltkod }, "IX_tbl_sektor")
                    .IsUnique();

                entity.Property(e => e.SekId).HasColumnName("SekID");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sektorad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sektorad");

                entity.Property(e => e.Sektoraltkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sektoraltkod");

                entity.Property(e => e.Sektoranaad)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sektoranaad");

                entity.Property(e => e.Sektorkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sektorkod");
            });

            modelBuilder.Entity<TblSevk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sevk");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Belgedovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("belgedovizkod");

                entity.Property(e => e.Belgeserino)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("belgeserino");

                entity.Property(e => e.Belgesirano)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("belgesirano");

                entity.Property(e => e.Belgetarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("belgetarih");

                entity.Property(e => e.Belgetipi)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("belgetipi");

                entity.Property(e => e.Carikod)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("carikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Durumu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("durumu");

                entity.Property(e => e.Faturakur).HasColumnName("faturakur");

                entity.Property(e => e.Faturasevkno).HasColumnName("faturasevkno");

                entity.Property(e => e.FirmId)
                    .HasColumnName("firmId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Ilgilikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ilgilikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iptal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("iptal")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iskontotutar).HasColumnName("iskontotutar");

                entity.Property(e => e.Iskontoyuzde).HasColumnName("iskontoyuzde");

                entity.Property(e => e.Kdv).HasColumnName("kdv");

                entity.Property(e => e.Konsinyeno).HasColumnName("konsinyeno");

                entity.Property(e => e.Musterisano)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("musterisano")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sevkiyatkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sevkiyatkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sevkiyatnotu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sevkiyatnotu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sevkno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sevkno");

                entity.Property(e => e.Sevktarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("sevktarih");

                entity.Property(e => e.Sevktipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sevktipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subekod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("subekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Toplam).HasColumnName("toplam");

                entity.Property(e => e.Vade).HasColumnName("vade");

                entity.Property(e => e.Yaziyla)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("yaziyla")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yekun).HasColumnName("yekun");
            });

            modelBuilder.Entity<TblSevkAlt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sevk_alt");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dovizalissatis)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dovizalissatis")
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Faturafiyat).HasColumnName("faturafiyat");

                entity.Property(e => e.Iskontotutar).HasColumnName("iskontotutar");

                entity.Property(e => e.Iskontoyuzde).HasColumnName("iskontoyuzde");

                entity.Property(e => e.Kdv).HasColumnName("kdv");

                entity.Property(e => e.Kdvlitutar).HasColumnName("kdvlitutar");

                entity.Property(e => e.Kdvtutar).HasColumnName("kdvtutar");

                entity.Property(e => e.Koliadet).HasColumnName("koliadet");

                entity.Property(e => e.Kur).HasColumnName("kur");

                entity.Property(e => e.Musterisano)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("musterisano")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Onaysiz).HasColumnName("onaysiz");

                entity.Property(e => e.Ruloadet).HasColumnName("ruloadet");

                entity.Property(e => e.Sabitkur).HasColumnName("sabitkur");

                entity.Property(e => e.Satirno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("satirno");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Sevkno).HasColumnName("sevkno");

                entity.Property(e => e.Siparisdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("siparisdovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisfiyat).HasColumnName("siparisfiyat");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Sirano).HasColumnName("sirano");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Tutar).HasColumnName("tutar");

                entity.Property(e => e.Urunadet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("urunadet")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunno)
                    .HasColumnName("urunno")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Urunsevkdetayid).HasColumnName("urunsevkdetayid");
            });

            modelBuilder.Entity<TblSevkDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sevk_detay");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Koliadet).HasColumnName("koliadet");

                entity.Property(e => e.Musterisano)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("musterisano");

                entity.Property(e => e.Ruloadet).HasColumnName("ruloadet");

                entity.Property(e => e.Satirdetayid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("satirdetayid");

                entity.Property(e => e.Satirno).HasColumnName("satirno");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Urunadet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("urunadet");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunno)
                    .HasColumnName("urunno")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Urunsevkid).HasColumnName("urunsevkid");
            });

            modelBuilder.Entity<TblSevkTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sevk_tip");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sevktipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sevktipkod");
            });

            modelBuilder.Entity<TblSevkiyat>(entity =>
            {
                entity.HasKey(e => e.Sevkiyatkod);

                entity.ToTable("tbl_sevkiyat");

                entity.Property(e => e.Sevkiyatkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sevkiyatkod");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");
            });

            modelBuilder.Entity<TblSikayetGelen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sikayet_gelen");

                entity.Property(e => e.Acik)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("acik");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bedelsiz).HasColumnName("bedelsiz");

                entity.Property(e => e.Degerlendirme)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("degerlendirme")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dofkod)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dofkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Iadedurum)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("iadedurum");

                entity.Property(e => e.Iadetarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("iadetarihi");

                entity.Property(e => e.Irsaliyeno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("irsaliyeno");

                entity.Property(e => e.Kisikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Musterisikayetno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("musterisikayetno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Resim)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("resim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sevkadet).HasColumnName("sevkadet");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Sevkno).HasColumnName("sevkno");

                entity.Property(e => e.Sikayetno).HasColumnName("sikayetno");

                entity.Property(e => e.Sikayettarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("sikayettarih");

                entity.Property(e => e.Sikayettipi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sikayettipi");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Teslimtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("teslimtarih");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Zarartutari).HasColumnName("zarartutari");
            });

            modelBuilder.Entity<TblSikayetGelenTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sikayet_gelen_tip");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sikayetgelenkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sikayetgelenkod");

                entity.Property(e => e.Tipkod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipkod");
            });

            modelBuilder.Entity<TblSikayetHareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sikayet_hareket");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Anasikayet).HasColumnName("anasikayet");

                entity.Property(e => e.HareketId).HasColumnName("hareketID");

                entity.Property(e => e.Hareketadi)
                    .HasMaxLength(25)
                    .HasColumnName("hareketadi");

                entity.Property(e => e.Hareketmiktar).HasColumnName("hareketmiktar");

                entity.Property(e => e.Hareketno)
                    .HasMaxLength(30)
                    .HasColumnName("hareketno");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sikayetno).HasColumnName("sikayetno");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<TblSikayetPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sikayet_personel");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sikayetno).HasColumnName("sikayetno");
            });

            modelBuilder.Entity<TblSikayetSikayetTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sikayet_sikayet_tip");

                entity.Property(e => e.Sikayetgelenkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sikayetgelenkod");

                entity.Property(e => e.Sikayetno).HasColumnName("sikayetno");
            });

            modelBuilder.Entity<TblSikayetTutar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sikayet_tutar");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Sikayetno).HasColumnName("sikayetno");

                entity.Property(e => e.Sikayettutarid).HasColumnName("sikayettutarid");

                entity.Property(e => e.Tutar).HasColumnName("tutar");
            });

            modelBuilder.Entity<TblSipari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis");

                entity.Property(e => e.Bakiyedovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bakiyedovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bbirim)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bbirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bdovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bedelsiz).HasColumnName("bedelsiz");

                entity.Property(e => e.Bfaturaedildi).HasColumnName("bfaturaedildi");

                entity.Property(e => e.Bfaturaet).HasColumnName("bfaturaet");

                entity.Property(e => e.Bicakdurum)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bicakdurum")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bicakfiyat).HasColumnName("bicakfiyat");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Carikod)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("carikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Depodan).HasColumnName("depodan");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Eskifilmat).HasColumnName("eskifilmat");

                entity.Property(e => e.Faturanot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("faturanot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirmId)
                    .HasColumnName("firmId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Gelirtutar).HasColumnName("gelirtutar");

                entity.Property(e => e.Gelirtutarbicak).HasColumnName("gelirtutarbicak");

                entity.Property(e => e.Gelirtutarklise).HasColumnName("gelirtutarklise");

                entity.Property(e => e.Gidertutar).HasColumnName("gidertutar");

                entity.Property(e => e.Gidertutarkur).HasColumnName("gidertutarkur");

                entity.Property(e => e.Globalfiyat).HasColumnName("globalfiyat");

                entity.Property(e => e.Grafikonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grafikonay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grafikpersonel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grafikpersonel")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ilkdefa).HasColumnName("ilkdefa");

                entity.Property(e => e.Ilkdefauy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ilkdefauy")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imalattakip).HasColumnName("imalattakip");

                entity.Property(e => e.Iptal).HasColumnName("iptal");

                entity.Property(e => e.Irsaliyenot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("irsaliyenot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iskontoyuzde).HasColumnName("iskontoyuzde");

                entity.Property(e => e.Kapanistarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("kapanistarihi");

                entity.Property(e => e.Kapattarih)
                    .HasColumnType("datetime")
                    .HasColumnName("kapattarih");

                entity.Property(e => e.Kardes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kardes")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kdovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kdv)
                    .HasColumnName("kdv")
                    .HasDefaultValueSql("((18))");

                entity.Property(e => e.Kfaturaedildi).HasColumnName("kfaturaedildi");

                entity.Property(e => e.Kfaturaet).HasColumnName("kfaturaet");

                entity.Property(e => e.Kisikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kliseadet).HasColumnName("kliseadet");

                entity.Property(e => e.Klisedurum)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("klisedurum")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisefiyat).HasColumnName("klisefiyat");

                entity.Property(e => e.KontrolDepo).HasColumnName("kontrol_depo");

                entity.Property(e => e.KontrolKapat).HasColumnName("kontrol_kapat");

                entity.Property(e => e.KontrolKapat2).HasColumnName("kontrol_kapat2");

                entity.Property(e => e.Maliyetadet).HasColumnName("maliyetadet");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Malzemedurum)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("malzemedurum")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Muhasebeonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("muhasebeonay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Muhasebeonaylayan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("muhasebeonaylayan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Muhasebeonaytarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("muhasebeonaytarih");

                entity.Property(e => e.Muhtemeltarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("muhtemeltarih");

                entity.Property(e => e.Musterisano)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("musterisano")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Numuneadet).HasColumnName("numuneadet");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Onayadres)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("onayadres")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Onaydakibakiye).HasColumnName("onaydakibakiye");

                entity.Property(e => e.Onaydakirisk).HasColumnName("onaydakirisk");

                entity.Property(e => e.Oncekilot).HasColumnName("oncekilot");

                entity.Property(e => e.Ozelbilgi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ozelbilgi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Planlamakabultarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("planlamakabultarihi");

                entity.Property(e => e.Planlamatermintarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("planlamatermintarihi");

                entity.Property(e => e.Planlanantarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("planlanantarih");

                entity.Property(e => e.Prova).HasColumnName("prova");

                entity.Property(e => e.Revizyonfilmdegil).HasColumnName("revizyonfilmdegil");

                entity.Property(e => e.Revizyonkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("revizyonkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Revizyonnot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("revizyonnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Revizyonvar).HasColumnName("revizyonvar");

                entity.Property(e => e.Riskdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("riskdovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sabitkur).HasColumnName("sabitkur");

                entity.Property(e => e.Satistipi).HasColumnName("satistipi");

                entity.Property(e => e.Satistltutar).HasColumnName("satistltutar");

                entity.Property(e => e.Siparisaabosluk).HasColumnName("siparisaabosluk");

                entity.Property(e => e.Siparisadettakim).HasColumnName("siparisadettakim");

                entity.Property(e => e.Siparisadettakim2).HasColumnName("siparisadettakim2");

                entity.Property(e => e.Siparisarsivno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("siparisarsivno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisbaskiaabosluk).HasColumnName("siparisbaskiaabosluk");

                entity.Property(e => e.Siparisbicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("siparisbicakkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisbirim)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("siparisbirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisboyayogunluk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siparisboyayogunluk")
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.Sipariscl).HasColumnName("sipariscl");

                entity.Property(e => e.Siparisdevamlilik).HasColumnName("siparisdevamlilik");

                entity.Property(e => e.Siparisfiyat).HasColumnName("siparisfiyat");

                entity.Property(e => e.Siparisholtmelt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siparisholtmelt")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sipariskliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sipariskliseno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparislf).HasColumnName("siparislf");

                entity.Property(e => e.Siparismiktar).HasColumnName("siparismiktar");

                entity.Property(e => e.Siparismusterikod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("siparismusterikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparisperfore)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siparisperfore")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisrulobirim)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("siparisrulobirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparistakimmiktar)
                    .HasColumnName("siparistakimmiktar")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Siparistakimmiktar2)
                    .HasColumnName("siparistakimmiktar2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Siparistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("siparistarih");

                entity.Property(e => e.Siparistekebadboy).HasColumnName("siparistekebadboy");

                entity.Property(e => e.Siparistekebaden).HasColumnName("siparistekebaden");

                entity.Property(e => e.Siparistekebadyukseklik).HasColumnName("siparistekebadyukseklik");

                entity.Property(e => e.Siparisurunadi)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("siparisurunadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisuruneken).HasColumnName("siparisuruneken");

                entity.Property(e => e.Siparisurunnot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("siparisurunnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisuygulamasekli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siparisuygulamasekli")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisyapistirmapayi).HasColumnName("siparisyapistirmapayi");

                entity.Property(e => e.Siparisyyadet).HasColumnName("siparisyyadet");

                entity.Property(e => e.Siparisyybitisikadet).HasColumnName("siparisyybitisikadet");

                entity.Property(e => e.Siparisyybosluk).HasColumnName("siparisyybosluk");

                entity.Property(e => e.Temsilci)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("temsilci")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Testtipi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("testtipi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Toplamagirlik).HasColumnName("toplamagirlik");

                entity.Property(e => e.Toplamalan).HasColumnName("toplamalan");

                entity.Property(e => e.Toplamteslim).HasColumnName("toplamteslim");

                entity.Property(e => e.Toplamteslimmiktar).HasColumnName("toplamteslimmiktar");

                entity.Property(e => e.Tramyogunlugu).HasColumnName("tramyogunlugu");

                entity.Property(e => e.Urunacildi)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunacildi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunalan).HasColumnName("urunalan");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Uygulamamiktar).HasColumnName("uygulamamiktar");

                entity.Property(e => e.Yeniurun)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yeniurun")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yonetimonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yonetimonay2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yonetimonaylayan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonaylayan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yonetimonaylayan2)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonaylayan2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yonetimonaytarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("yonetimonaytarih");

                entity.Property(e => e.Yonetimonaytarih2)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("yonetimonaytarih2");
            });

            modelBuilder.Entity<TblSiparisAmb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_amb");

                entity.Property(e => e.Amb)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amb")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");
            });

            modelBuilder.Entity<TblSiparisDegisiklik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_degisiklik");

                entity.Property(e => e.Degisiklik)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("degisiklik");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");
            });

            modelBuilder.Entity<TblSiparisDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_detay");

                entity.Property(e => e.BoyCikis).HasColumnName("boy_cikis");

                entity.Property(e => e.BoyGiris).HasColumnName("boy_giris");

                entity.Property(e => e.EnCikis).HasColumnName("en_cikis");

                entity.Property(e => e.EnGiris).HasColumnName("en_giris");

                entity.Property(e => e.Malzemekodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("malzemekodu");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.TarihCikis)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih_cikis");

                entity.Property(e => e.TarihGiris)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih_giris");
            });

            modelBuilder.Entity<TblSiparisEkstragider>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_ekstragider");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ekstragiderkod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ekstragiderkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Tutar).HasColumnName("tutar");
            });

            modelBuilder.Entity<TblSiparisGider>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_gider");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Giderkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("giderkod");

                entity.Property(e => e.Kur).HasColumnName("kur");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Planlanandovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("planlanandovizkod");

                entity.Property(e => e.Planlananfiyat).HasColumnName("planlananfiyat");

                entity.Property(e => e.Planlanankur).HasColumnName("planlanankur");

                entity.Property(e => e.Planlananmiktar).HasColumnName("planlananmiktar");

                entity.Property(e => e.Planlanantutar).HasColumnName("planlanantutar");

                entity.Property(e => e.Planurunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("planurunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Tutar).HasColumnName("tutar");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblSiparisHareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_hareket");

                entity.Property(e => e.Bitishareket).HasColumnName("bitishareket");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Harcananhareket).HasColumnName("harcananhareket");

                entity.Property(e => e.Hareketno).HasColumnName("hareketno");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Toplammiktar2).HasColumnName("toplammiktar2");

                entity.Property(e => e.Urunihtiyacid).HasColumnName("urunihtiyacid");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblSiparisIhtiyac>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_ihtiyac");

                entity.Property(e => e.Birim)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("birim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Fason).HasColumnName("fason");

                entity.Property(e => e.Fire)
                    .HasColumnName("fire")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Hammadde)
                    .IsRequired()
                    .HasColumnName("hammadde")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ihtiyacnotu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ihtiyacnotu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ihtiyactakip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ihtiyactakip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Sipihtiyacid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sipihtiyacid");

                entity.Property(e => e.Urunihtiyacid).HasColumnName("urunihtiyacid");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblSiparisIslem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_islem");

                entity.Property(e => e.Aaadet)
                    .HasColumnName("aaadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Dislidegeri).HasColumnName("dislidegeri");

                entity.Property(e => e.Dislisayisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi")
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Islemsayisi)
                    .HasColumnName("islemsayisi")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Siparisislemid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("siparisislemid");

                entity.Property(e => e.Siparismakinaid).HasColumnName("siparismakinaid");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Urunislemid).HasColumnName("urunislemid");

                entity.Property(e => e.Yyadet)
                    .HasColumnName("yyadet")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblSiparisKlise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_klise");

                entity.Property(e => e.Aniloxkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("aniloxkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Formul)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("formul")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Kliseuyumkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kliseuyumkod");

                entity.Property(e => e.Pantoneno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pantoneno");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblSiparisKliseAlt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_klise_alt");

                entity.Property(e => e.Aaadet).HasColumnName("aaadet");

                entity.Property(e => e.Baskitipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baskitipkod");

                entity.Property(e => e.Dislisayisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Kliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno");

                entity.Property(e => e.Klisetipkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("klisetipkod");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("no");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Revizyonkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("revizyonkod");

                entity.Property(e => e.Sipariskliseid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sipariskliseid");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");
            });

            modelBuilder.Entity<TblSiparisKlisePantone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_klise_pantone");

                entity.Property(e => e.Aniloxkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("aniloxkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Formul)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("formul")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisekod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("klisekod");

                entity.Property(e => e.Klisepantoneid).HasColumnName("klisepantoneid");

                entity.Property(e => e.Kliseuyumkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kliseuyumkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Pantoneno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pantoneno");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparispantoneid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("siparispantoneid");

                entity.Property(e => e.Sonno).HasColumnName("sonno");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblSiparisMak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_mak");

                entity.Property(e => e.Siparismakid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("siparismakid");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparisnobirles).HasColumnName("siparisnobirles");
            });

            modelBuilder.Entity<TblSiparisMakina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_makina");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.Bitiren)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bitiren")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bitistarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("bitistarihi");

                entity.Property(e => e.Bitti).HasColumnName("bitti");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ekgecis)
                    .HasColumnName("ekgecis")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Islemmiktar).HasColumnName("islemmiktar");

                entity.Property(e => e.Makinabirimkod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("makinabirimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Plantarih)
                    .HasColumnType("datetime")
                    .HasColumnName("plantarih");

                entity.Property(e => e.Siparismakinaid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("siparismakinaid");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Sirada).HasColumnName("sirada");

                entity.Property(e => e.Siralama)
                    .HasColumnName("siralama")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.Topislemsure).HasColumnName("topislemsure");

                entity.Property(e => e.Topsetupsure).HasColumnName("topsetupsure");

                entity.Property(e => e.Uretimnotu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("uretimnotu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uretimplanlama).HasColumnName("uretimplanlama");

                entity.Property(e => e.Uretimtakip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uretimtakip")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblSiparisOnay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_onay");

                entity.Property(e => e.Onay)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("onay");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");
            });

            modelBuilder.Entity<TblSiparisOnayAdre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_onay_adres");

                entity.Property(e => e.Onay)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("onay");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");
            });

            modelBuilder.Entity<TblSiparisTermin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_termin");

                entity.Property(e => e.Akisyonu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("akisyonu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bobindeadet).HasColumnName("bobindeadet");

                entity.Property(e => e.Bobindebirim)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("bobindebirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Discap).HasColumnName("discap");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iccap).HasColumnName("iccap");

                entity.Property(e => e.Musteriyyadet)
                    .HasColumnName("musteriyyadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sevkiyatkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sevkiyatkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparismiktar).HasColumnName("siparismiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Stok).HasColumnName("stok");

                entity.Property(e => e.Subekod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("subekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Terminid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("terminid");

                entity.Property(e => e.Terminnot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("terminnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Termintarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("termintarih");
            });

            modelBuilder.Entity<TblSiparisTeslim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_teslim");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Depo).HasColumnName("depo");

                entity.Property(e => e.Depodansevk).HasColumnName("depodansevk");

                entity.Property(e => e.Depokod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("depokod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Koliadet)
                    .HasColumnName("koliadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Koliagirlik).HasColumnName("koliagirlik");

                entity.Property(e => e.Konsinye).HasColumnName("konsinye");

                entity.Property(e => e.Musteri).HasColumnName("musteri");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ruloadet)
                    .HasColumnName("ruloadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sevkedildi).HasColumnName("sevkedildi");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Sevkmiktar).HasColumnName("sevkmiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Teslimtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("teslimtarih");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Urunadet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("urunadet")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunno)
                    .HasColumnName("urunno")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblSiparisTeslim2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_siparis_teslim2");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Depo).HasColumnName("depo");

                entity.Property(e => e.Depodansevk).HasColumnName("depodansevk");

                entity.Property(e => e.Depokod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("depokod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Koliadet)
                    .HasColumnName("koliadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Koliagirlik).HasColumnName("koliagirlik");

                entity.Property(e => e.Konsinye).HasColumnName("konsinye");

                entity.Property(e => e.Musteri).HasColumnName("musteri");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ruloadet)
                    .HasColumnName("ruloadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sevkedildi).HasColumnName("sevkedildi");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Sevkmiktar).HasColumnName("sevkmiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Teslimtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("teslimtarih");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Urunadet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("urunadet")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunno)
                    .HasColumnName("urunno")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblTanim>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("tbl_Tanim");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tanim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTasiyici>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_tasiyici");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Tasiyicikod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tasiyicikod");
            });

            modelBuilder.Entity<TblTeklif>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teklif");

                entity.Property(e => e.Arsiv).HasColumnName("arsiv");

                entity.Property(e => e.Avans)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("avans");

                entity.Property(e => e.Durumteklifkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("durumteklifkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Eksartlar)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("eksartlar");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Gonderno).HasColumnName("gonderno");

                entity.Property(e => e.Hatirlatma).HasColumnName("hatirlatma");

                entity.Property(e => e.Hatirlatmanot)
                    .HasColumnType("text")
                    .HasColumnName("hatirlatmanot");

                entity.Property(e => e.Hatirlatmatarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("hatirlatmatarih");

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("il");

                entity.Property(e => e.Kdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kdovizkod");

                entity.Property(e => e.Kisikod)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Klisegoster).HasColumnName("klisegoster");

                entity.Property(e => e.Klisemasraf).HasColumnName("klisemasraf");

                entity.Property(e => e.Kodu).HasColumnName("kodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Opsiyonkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("opsiyonkod");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sevkiyatkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sevkiyatkod");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Teslimatkod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("teslimatkod");
            });

            modelBuilder.Entity<TblTeklifFiyat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teklif_fiyat");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Bicakmasraf).HasColumnName("bicakmasraf");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Globalfiyat).HasColumnName("globalfiyat");

                entity.Property(e => e.Gonderkodu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gonderkodu");

                entity.Property(e => e.Gonderno).HasColumnName("gonderno");

                entity.Property(e => e.Klisemasraf).HasColumnName("klisemasraf");

                entity.Property(e => e.Kodu).HasColumnName("kodu");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Maxadet).HasColumnName("maxadet");

                entity.Property(e => e.Minadet).HasColumnName("minadet");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sirano)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sirano");

                entity.Property(e => e.Teklifbirimi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("teklifbirimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Toplamfiyat).HasColumnName("toplamfiyat");

                entity.Property(e => e.Toplamfiyattutar).HasColumnName("toplamfiyattutar");

                entity.Property(e => e.Urunnot)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("urunnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunnot2)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("urunnot2")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblTeklifGonder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teklif_gonder");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Gonderkodu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gonderkodu");

                entity.Property(e => e.Gonderno).HasColumnName("gonderno");

                entity.Property(e => e.Gondertarih)
                    .HasColumnType("datetime")
                    .HasColumnName("gondertarih");

                entity.Property(e => e.Kodu).HasColumnName("kodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sonucteklifkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sonucteklifkod");
            });

            modelBuilder.Entity<TblTeklifGonderSonuc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teklif_gonder_sonuc");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olumlu).HasColumnName("olumlu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sonucteklifkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sonucteklifkod");
            });

            modelBuilder.Entity<TblTeklifSira>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teklif_sira");

                entity.Property(e => e.Bdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bdovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bicakmasraf).HasColumnName("bicakmasraf");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Kdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kdovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Klisemasraf).HasColumnName("klisemasraf");

                entity.Property(e => e.Kodu).HasColumnName("kodu");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sirano)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sirano");

                entity.Property(e => e.Teklifonay).HasColumnName("teklifonay");

                entity.Property(e => e.Teklifsiraid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("teklifsiraid");

                entity.Property(e => e.Urunnot)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("urunnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunnot2)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("urunnot2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblTeknikOrtam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teknik_ortam");

                entity.Property(e => e.Ortam)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ortam");

                entity.Property(e => e.Teknikno).HasColumnName("teknikno");
            });

            modelBuilder.Entity<TblTeknikPantone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teknik_pantone");

                entity.Property(e => e.Pantone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pantone");

                entity.Property(e => e.Teknikno).HasColumnName("teknikno");
            });

            modelBuilder.Entity<TblTeknikYuzey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teknik_yuzey");

                entity.Property(e => e.Teknikno).HasColumnName("teknikno");

                entity.Property(e => e.Yuzey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("yuzey");
            });

            modelBuilder.Entity<TblTeslimat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_teslimat");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Teslimatkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("teslimatkod");
            });

            modelBuilder.Entity<TblTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_test");

                entity.Property(e => e.Maxadet).HasColumnName("maxadet");

                entity.Property(e => e.Maxmetre).HasColumnName("maxmetre");

                entity.Property(e => e.Minadet).HasColumnName("minadet");

                entity.Property(e => e.Minmetre).HasColumnName("minmetre");

                entity.Property(e => e.Numuneadet).HasColumnName("numuneadet");

                entity.Property(e => e.Testtipi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("testtipi");
            });

            modelBuilder.Entity<TblUlke>(entity =>
            {
                entity.HasKey(e => e.Ulkekod)
                    .HasName("PK_tbl_ulke_1");

                entity.ToTable("tbl_ulke");

                entity.Property(e => e.Ulkekod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ulkekod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ulkead)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ulkead");

                entity.Property(e => e.UlkeadIngilizce)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ulkeadIngilizce");
            });

            modelBuilder.Entity<TblUrun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun");

                entity.Property(e => e.Aabosluk).HasColumnName("aabosluk");

                entity.Property(e => e.Acilisfiyat).HasColumnName("acilisfiyat");

                entity.Property(e => e.Adetagirlik).HasColumnName("adetagirlik");

                entity.Property(e => e.Adetboy).HasColumnName("adetboy");

                entity.Property(e => e.Adeten).HasColumnName("adeten");

                entity.Property(e => e.Adettakim).HasColumnName("adettakim");

                entity.Property(e => e.Adettakim2).HasColumnName("adettakim2");

                entity.Property(e => e.Agirlik).HasColumnName("agirlik");

                entity.Property(e => e.Alan).HasColumnName("alan");

                entity.Property(e => e.Ambalaj).HasColumnName("ambalaj");

                entity.Property(e => e.Arsivno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("arsivno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Baskiaabosluk).HasColumnName("baskiaabosluk");

                entity.Property(e => e.Baskitipkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("baskitipkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bicakek).HasColumnName("bicakek");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Boyayogunluk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("boyayogunluk")
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.Cekeryuzde)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cekeryuzde")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cl).HasColumnName("cl");

                entity.Property(e => e.Depolama).HasColumnName("depolama");

                entity.Property(e => e.Devamlilik).HasColumnName("devamlilik");

                entity.Property(e => e.Eskiurunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("eskiurunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Genelkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("genelkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gidergrupkod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gidergrupkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grafikonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grafikonay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grafikonaytarih)
                    .HasColumnType("datetime")
                    .HasColumnName("grafikonaytarih");

                entity.Property(e => e.Grafikpersonel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grafikpersonel")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gramaj).HasColumnName("gramaj");

                entity.Property(e => e.Gramajbutun).HasColumnName("gramajbutun");

                entity.Property(e => e.Hammaddefiyatbirimi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("hammaddefiyatbirimi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Holtmelt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("holtmelt")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iccap)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("iccap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imalatadi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("imalatadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imalatcikod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("imalatcikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imalatkod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("imalatkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kalinlik).HasColumnName("kalinlik");

                entity.Property(e => e.Kliseno)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Konsinyealan).HasColumnName("konsinyealan");

                entity.Property(e => e.Konsinyemiktar).HasColumnName("konsinyemiktar");

                entity.Property(e => e.Konsinyetarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("konsinyetarih");

                entity.Property(e => e.Kullanimalanikod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kullanimalanikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Laminasyoncinsi)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("laminasyoncinsi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lf).HasColumnName("lf");

                entity.Property(e => e.Makinaek).HasColumnName("makinaek");

                entity.Property(e => e.Maliyetbirimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("maliyetbirimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maliyetfiyat).HasColumnName("maliyetfiyat");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Malzemeek).HasColumnName("malzemeek");

                entity.Property(e => e.Malzemekod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Malzemekod2)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemekod2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Malzemezorunlu).HasColumnName("malzemezorunlu");

                entity.Property(e => e.Mamultip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mamultip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mamultipkod).HasColumnName("mamultipkod");

                entity.Property(e => e.Maxstok).HasColumnName("maxstok");

                entity.Property(e => e.Minstok).HasColumnName("minstok");

                entity.Property(e => e.Muhasebekod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("muhasebekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Musterikod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("musterikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Opaklikkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("opaklikkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Paketbirimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("paketbirimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Paketmiktar)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("paketmiktar")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Parlaklikkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("parlaklikkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Perfore)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perfore")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Resim)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("resim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Resimtarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("resimtarihi");

                entity.Property(e => e.Revizyonkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("revizyonkod")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rulobirim)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rulobirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sabagkod)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparismiktar).HasColumnName("siparismiktar");

                entity.Property(e => e.Slevetip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("slevetip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Spekkod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("spekkod");

                entity.Property(e => e.Takimmiktar)
                    .HasColumnName("takimmiktar")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Takimmiktar2)
                    .HasColumnName("takimmiktar2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tasiyicieken).HasColumnName("tasiyicieken");

                entity.Property(e => e.Tasiyicikod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tasiyicikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Tekebadyukseklik).HasColumnName("tekebadyukseklik");

                entity.Property(e => e.Uretimonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uretimonay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uretimonaytarih)
                    .HasColumnType("datetime")
                    .HasColumnName("uretimonaytarih");

                entity.Property(e => e.Uretimpersonel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("uretimpersonel")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunadi)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.UrunadiIngilizce)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("urunadiIngilizce")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uruneken).HasColumnName("uruneken");

                entity.Property(e => e.Urunfaturaadi)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("urunfaturaadi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunkullanilmiyor).HasColumnName("urunkullanilmiyor");

                entity.Property(e => e.Urunnot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("urunnot")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod");

                entity.Property(e => e.Uygulamasekli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uygulamasekli")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yapisalkod1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yapisalkod2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yapisalkod3)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yapiskankod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapiskankod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yapistirmapayi).HasColumnName("yapistirmapayi");

                entity.Property(e => e.Yarimamulkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yarimamulkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yogunluk)
                    .HasColumnName("yogunluk")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yyadet).HasColumnName("yyadet");

                entity.Property(e => e.Yybitisikadet).HasColumnName("yybitisikadet");

                entity.Property(e => e.Yybosluk).HasColumnName("yybosluk");
            });

            modelBuilder.Entity<TblUrunAgirlik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_agirlik");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Tekebadyukseklik).HasColumnName("tekebadyukseklik");

                entity.Property(e => e.Urunagirlik).HasColumnName("urunagirlik");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunmiktar).HasColumnName("urunmiktar");
            });

            modelBuilder.Entity<TblUrunAmb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_amb");

                entity.Property(e => e.Amb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amb");

                entity.Property(e => e.Urunkod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblUrunAmbalaji>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_ambalaji");

                entity.Property(e => e.Agirlik).HasColumnName("agirlik");

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Hacim).HasColumnName("hacim");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yuk).HasColumnName("yuk");
            });

            modelBuilder.Entity<TblUrunBirim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_birim");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Birimno).HasColumnName("birimno");

                entity.Property(e => e.Birimoran).HasColumnName("birimoran");

                entity.Property(e => e.Ekbirimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ekbirimkod");

                entity.Property(e => e.Ekmiktar).HasColumnName("ekmiktar");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblUrunEkbicak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_ekbicak");

                entity.Property(e => e.Bicakek).HasColumnName("bicakek");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblUrunFire>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_fire");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Urunfirekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("urunfirekod");
            });

            modelBuilder.Entity<TblUrunFirma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_firma");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Maliyetkodu).HasColumnName("maliyetkodu");

                entity.Property(e => e.Uruncesidi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruncesidi")
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Urunfaturaadi)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("urunfaturaadi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunfirmaid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunfirmaid");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunmusterikod)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("urunmusterikod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunno)
                    .HasColumnName("urunno")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblUrunHareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_hareket");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Belgeno).HasColumnName("belgeno");

                entity.Property(e => e.Cikismiktar1).HasColumnName("cikismiktar1");

                entity.Property(e => e.Cikismiktar2).HasColumnName("cikismiktar2");

                entity.Property(e => e.Cikistabaka).HasColumnName("cikistabaka");

                entity.Property(e => e.Cikistarih)
                    .HasColumnType("datetime")
                    .HasColumnName("cikistarih");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Fisno)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("fisno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Girismiktar1).HasColumnName("girismiktar1");

                entity.Property(e => e.Girismiktar2).HasColumnName("girismiktar2");

                entity.Property(e => e.Giristabaka).HasColumnName("giristabaka");

                entity.Property(e => e.Giristarih)
                    .HasColumnType("datetime")
                    .HasColumnName("giristarih");

                entity.Property(e => e.Hareketid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("hareketid");

                entity.Property(e => e.Hareketno).HasColumnName("hareketno");

                entity.Property(e => e.Harekettipkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("harekettipkod");

                entity.Property(e => e.Idealen).HasColumnName("idealen");

                entity.Property(e => e.Irsaliyeno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("irsaliyeno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Irsaliyetarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("irsaliyetarih");

                entity.Property(e => e.Kullanildi).HasColumnName("kullanildi");

                entity.Property(e => e.Muadil).HasColumnName("muadil");

                entity.Property(e => e.Muadilurunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("muadilurunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Netcikis).HasColumnName("netcikis");

                entity.Property(e => e.Netgiris).HasColumnName("netgiris");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Revizesiparisno).HasColumnName("revizesiparisno");

                entity.Property(e => e.Said).HasColumnName("said");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Satirdetayid).HasColumnName("satirdetayid");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Sipihtiyacid).HasColumnName("sipihtiyacid");

                entity.Property(e => e.Sira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sira")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Terminno).HasColumnName("terminno");

                entity.Property(e => e.Teslimno).HasColumnName("teslimno");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yyadet).HasColumnName("yyadet");
            });

            modelBuilder.Entity<TblUrunIhtiyac>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_ihtiyac");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Adetoran).HasColumnName("adetoran");

                entity.Property(e => e.Agirlikoran).HasColumnName("agirlikoran");

                entity.Property(e => e.Alanoran).HasColumnName("alanoran");

                entity.Property(e => e.Ambalaj).HasColumnName("ambalaj");

                entity.Property(e => e.Ambalajbirimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ambalajbirimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ambalajkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ambalajkod");

                entity.Property(e => e.Ambalajoran)
                    .HasColumnName("ambalajoran")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Eni)
                    .IsRequired()
                    .HasColumnName("eni")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Hammadde).HasColumnName("hammadde");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Siparisaktar).HasColumnName("siparisaktar");

                entity.Property(e => e.Urunbirimtip)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("urunbirimtip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunihtiyacid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunihtiyacid");

                entity.Property(e => e.Urunislemid).HasColumnName("urunislemid");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunmalzemeid).HasColumnName("urunmalzemeid");

                entity.Property(e => e.Urunoran)
                    .HasColumnName("urunoran")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblUrunKk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_kk");

                entity.Property(e => e.Akisyonu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("akisyonu");

                entity.Property(e => e.Bobindeadet).HasColumnName("bobindeadet");

                entity.Property(e => e.Bobindebirim)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("bobindebirim")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Discap).HasColumnName("discap");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Iccap).HasColumnName("iccap");

                entity.Property(e => e.Musteriyyadet)
                    .HasColumnName("musteriyyadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblUrunLf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_lf");

                entity.Property(e => e.Aramesafe).HasColumnName("aramesafe");

                entity.Property(e => e.Lf).HasColumnName("lf");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunlfid).HasColumnName("urunlfid");
            });

            modelBuilder.Entity<TblUrunMakina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_makina");

                entity.Property(e => e.Aaadet)
                    .HasColumnName("aaadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Artisaattehiz).HasColumnName("artisaattehiz");

                entity.Property(e => e.Artisetupsure).HasColumnName("artisetupsure");

                entity.Property(e => e.Dislidegeri).HasColumnName("dislidegeri");

                entity.Property(e => e.Dislisayisi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dislisayisi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ekgecis)
                    .HasColumnName("ekgecis")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod");

                entity.Property(e => e.Islemsayisi)
                    .HasColumnName("islemsayisi")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Sira)
                    .HasColumnName("sira")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Urunislemid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunislemid");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yyadet)
                    .HasColumnName("yyadet")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblUrunMalzeme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_malzeme");

                entity.Property(e => e.Gramaj).HasColumnName("gramaj");

                entity.Property(e => e.Hammadde)
                    .IsRequired()
                    .HasColumnName("hammadde")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Hamyarimamul)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hamyarimamul")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Malzemekod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemekod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Malzemeuretimeni).HasColumnName("malzemeuretimeni");

                entity.Property(e => e.Sira)
                    .HasColumnName("sira")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Urunbirimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("urunbirimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunislemid).HasColumnName("urunislemid");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunmalzemeid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunmalzemeid");

                entity.Property(e => e.Yapisalkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Yyadet)
                    .HasColumnName("yyadet")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblUrunMamulTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_mamul_tip");

                entity.Property(e => e.Mamultipkod).HasColumnName("mamultipkod");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblUrunOnay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_onay");

                entity.Property(e => e.Grafikonaytarih)
                    .HasColumnType("datetime")
                    .HasColumnName("grafikonaytarih");

                entity.Property(e => e.Grafikpersonel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("grafikpersonel");

                entity.Property(e => e.Uretimonaytarih)
                    .HasColumnType("datetime")
                    .HasColumnName("uretimonaytarih");

                entity.Property(e => e.Uretimpersonel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("uretimpersonel");

                entity.Property(e => e.Urunkod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblUrunResim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_resim");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Resim)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.ResimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("resimId");

                entity.Property(e => e.Resimtarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("resimtarihi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<TblUrunRevizyon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_revizyon");

                entity.Property(e => e.Alan)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("alan");

                entity.Property(e => e.Degistirmetarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("degistirmetarihi");

                entity.Property(e => e.Desigtirenadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("desigtirenadisoyadi");

                entity.Property(e => e.Eskiveri)
                    .HasColumnType("text")
                    .HasColumnName("eskiveri");

                entity.Property(e => e.Revizyonkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("revizyonkod");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yeniveri)
                    .HasColumnType("text")
                    .HasColumnName("yeniveri");
            });

            modelBuilder.Entity<TblUrunSevk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_sevk");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Koliadet)
                    .HasColumnName("koliadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Ruloadet)
                    .HasColumnName("ruloadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Setmi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("setmi");

                entity.Property(e => e.Sevkedildi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sevkedildi");

                entity.Property(e => e.Sevktaleptarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("sevktaleptarihi");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Subekod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("subekod");

                entity.Property(e => e.Takimtek)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("takimtek")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunadet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("urunadet")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunno)
                    .HasColumnName("urunno")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Urunsevkid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunsevkid");
            });

            modelBuilder.Entity<TblUrunSevkDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_sevk_detay");

                entity.Property(e => e.Aracid).HasColumnName("aracid");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Plaka)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("plaka")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sevktarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("sevktarih");

                entity.Property(e => e.Toplamagirlik).HasColumnName("toplamagirlik");

                entity.Property(e => e.Urunsevkdetayid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunsevkdetayid");
            });

            modelBuilder.Entity<TblUrunSevkDetayAlt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_sevk_detay_alt");

                entity.Property(e => e.Agirlik).HasColumnName("agirlik");

                entity.Property(e => e.Belgekesildi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("belgekesildi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Belgetipi)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("belgetipi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Onaysiz).HasColumnName("onaysiz");

                entity.Property(e => e.Setmi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("setmi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sevkmiktar).HasColumnName("sevkmiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subekod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("subekod");

                entity.Property(e => e.Takimtek)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("takimtek")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunno)
                    .HasColumnName("urunno")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Urunsevkaltid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunsevkaltid");

                entity.Property(e => e.Urunsevkdetayid).HasColumnName("urunsevkdetayid");

                entity.Property(e => e.Urunsevkid).HasColumnName("urunsevkid");

                entity.Property(e => e.Yenifiyat).HasColumnName("yenifiyat");
            });

            modelBuilder.Entity<TblUrunStokkart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_stokkart");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Depokod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("depokod");

                entity.Property(e => e.Dosyano)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dosyano")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faturaedildi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("faturaedildi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faturasevkno).HasColumnName("faturasevkno");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Fiyattl).HasColumnName("fiyattl");

                entity.Property(e => e.Gideceksiparisno)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("gideceksiparisno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giriskkno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("giriskkno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kagittipi)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("kagittipi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kkpersonelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kkpersonelkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Koliadet).HasColumnName("koliadet");

                entity.Property(e => e.Miktar1).HasColumnName("miktar1");

                entity.Property(e => e.Miktar2).HasColumnName("miktar2");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Rafkodu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rafkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ruloadet).HasColumnName("ruloadet");

                entity.Property(e => e.Sarfedildi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sarfedildi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Setmi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("setmi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sevkbekleyenmiktar).HasColumnName("sevkbekleyenmiktar");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Sevkiyatno2).HasColumnName("sevkiyatno2");

                entity.Property(e => e.Sikayetno).HasColumnName("sikayetno");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Stokgramaji).HasColumnName("stokgramaji");

                entity.Property(e => e.Stokid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("stokid");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Tabaka).HasColumnName("tabaka");

                entity.Property(e => e.Tabakaboy).HasColumnName("tabakaboy");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Teslimno).HasColumnName("teslimno");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Urunadet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("urunadet")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Urunno)
                    .HasColumnName("urunno")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod");

                entity.Property(e => e.Uyarinotu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("uyarinotu")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblUrunStokkartIade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_stokkart_iade");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Etiketbasildi).HasColumnName("etiketbasildi");

                entity.Property(e => e.Hareketno).HasColumnName("hareketno");

                entity.Property(e => e.Iadealindi).HasColumnName("iadealindi");

                entity.Property(e => e.Iadealinditarih)
                    .HasColumnType("datetime")
                    .HasColumnName("iadealinditarih");

                entity.Property(e => e.Iademiktar1).HasColumnName("iademiktar1");

                entity.Property(e => e.Iademiktar2).HasColumnName("iademiktar2");

                entity.Property(e => e.Netiade).HasColumnName("netiade");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Vardiyano).HasColumnName("vardiyano");
            });

            modelBuilder.Entity<TblUrunStokkartSipari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_stokkart_siparis");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Miktar1).HasColumnName("miktar1");

                entity.Property(e => e.Miktar2).HasColumnName("miktar2");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");
            });

            modelBuilder.Entity<TblUrunTavsiyeEn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_tavsiye_en");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yyadet).HasColumnName("yyadet");
            });

            modelBuilder.Entity<TblUrunTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_urun_tip");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod");
            });

            modelBuilder.Entity<TblVardiya>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vardiya");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Urunalan).HasColumnName("urunalan");

                entity.Property(e => e.Urunfirealan).HasColumnName("urunfirealan");

                entity.Property(e => e.Vardiyano).HasColumnName("vardiyano");

                entity.Property(e => e.Zamanfiretoplami).HasColumnName("zamanfiretoplami");
            });

            modelBuilder.Entity<TblVardiyaBicak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vardiya_bicak");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Tursayisi).HasColumnName("tursayisi");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Yenilemeno)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yenilemeno");
            });

            modelBuilder.Entity<TblVardiyaHareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vardiya_hareket");

                entity.Property(e => e.Firealan).HasColumnName("firealan");

                entity.Property(e => e.Hammadde).HasColumnName("hammadde");

                entity.Property(e => e.Harcananalan).HasColumnName("harcananalan");

                entity.Property(e => e.Harcananalan2).HasColumnName("harcananalan2");

                entity.Property(e => e.Hareketno).HasColumnName("hareketno");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Vardiyano).HasColumnName("vardiyano");
            });

            modelBuilder.Entity<TblVardiyaUrun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vardiya_urun");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birlesikadet).HasColumnName("birlesikadet");

                entity.Property(e => e.Depocikis).HasColumnName("depocikis");

                entity.Property(e => e.Depoiade).HasColumnName("depoiade");

                entity.Property(e => e.Depoiadekontrol).HasColumnName("depoiadekontrol");

                entity.Property(e => e.Deviralinan).HasColumnName("deviralinan");

                entity.Property(e => e.Devirverilen).HasColumnName("devirverilen");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Hammadde).HasColumnName("hammadde");

                entity.Property(e => e.Harcanan).HasColumnName("harcanan");

                entity.Property(e => e.Hareketno).HasColumnName("hareketno");

                entity.Property(e => e.Kullanildi).HasColumnName("kullanildi");

                entity.Property(e => e.Netharcanan).HasColumnName("netharcanan");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sarfiyat).HasColumnName("sarfiyat");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Vardiyano).HasColumnName("vardiyano");
            });

            modelBuilder.Entity<TblVardiyaUrunDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vardiya_urun_detay");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Hammaddeenadet).HasColumnName("hammaddeenadet");

                entity.Property(e => e.Hareketno).HasColumnName("hareketno");

                entity.Property(e => e.Kullanilanmiktar1).HasColumnName("kullanilanmiktar1");

                entity.Property(e => e.Kullanilanmiktar2).HasColumnName("kullanilanmiktar2");

                entity.Property(e => e.Netkullanilan).HasColumnName("netkullanilan");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Vardiyano).HasColumnName("vardiyano");
            });

            modelBuilder.Entity<TblVardiyaUrunFire>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vardiya_urun_fire");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Islemkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("islemkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparisurunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("siparisurunkod")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urunfirekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("urunfirekod");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Vardiyano).HasColumnName("vardiyano");
            });

            modelBuilder.Entity<TblVardiyaZaman>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vardiya_zaman");

                entity.Property(e => e.Baslangicgun)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("baslangicgun");

                entity.Property(e => e.Baslangicsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("baslangicsaat");

                entity.Property(e => e.Bicakaaadet)
                    .HasColumnName("bicakaaadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bicakyyadet)
                    .HasColumnName("bicakyyadet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bitisgun)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("bitisgun");

                entity.Property(e => e.Bitissaat)
                    .HasColumnType("datetime")
                    .HasColumnName("bitissaat");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Ek3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek3");

                entity.Property(e => e.Ek4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek4");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Netsure).HasColumnName("netsure");

                entity.Property(e => e.Neturetim).HasColumnName("neturetim");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Siparismakinaid).HasColumnName("siparismakinaid");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Sorumlupersonelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sorumlupersonelkodu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uretimmetraj).HasColumnName("uretimmetraj");

                entity.Property(e => e.Uretimmiktar).HasColumnName("uretimmiktar");

                entity.Property(e => e.Urunalan).HasColumnName("urunalan");

                entity.Property(e => e.Urunfirealan).HasColumnName("urunfirealan");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Vardiyano).HasColumnName("vardiyano");

                entity.Property(e => e.Yikananunite).HasColumnName("yikananunite");

                entity.Property(e => e.Zamanfiretoplami).HasColumnName("zamanfiretoplami");
            });

            modelBuilder.Entity<TblVardiyaZamanFire>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vardiya_zaman_fire");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Zamanfirekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("zamanfirekod");
            });

            modelBuilder.Entity<TblVersiyon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_versiyon");

                entity.Property(e => e.VersiyonAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("versiyonAd");

                entity.Property(e => e.VersiyonId).HasColumnName("versiyonId");

                entity.Property(e => e.Versiyonaciklama)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("versiyonaciklama");

                entity.Property(e => e.Versiyonmajor).HasColumnName("versiyonmajor");

                entity.Property(e => e.Versiyonminor).HasColumnName("versiyonminor");

                entity.Property(e => e.Versiyonrevize).HasColumnName("versiyonrevize");

                entity.Property(e => e.Versiyontarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("versiyontarih");
            });

            modelBuilder.Entity<TblYapisal1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_yapisal1");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Yapisalkod1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod1");
            });

            modelBuilder.Entity<TblYapisal2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_yapisal2");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Yapisalkod1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod1");

                entity.Property(e => e.Yapisalkod2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod2");
            });

            modelBuilder.Entity<TblYapisal3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_yapisal3");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Yapisalkod1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod1");

                entity.Property(e => e.Yapisalkod2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod2");

                entity.Property(e => e.Yapisalkod3)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod3");
            });

            modelBuilder.Entity<TblYapiskan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_yapiskan");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Yapiskankod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapiskankod");
            });

            modelBuilder.Entity<TblYarimamulkod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_yarimamulkod");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Yarimamulkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yarimamulkod");
            });

            modelBuilder.Entity<TblZamanFire>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_zaman_fire");

                entity.Property(e => e.Ek1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek1");

                entity.Property(e => e.Ek2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ek2");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Zamanfirekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("zamanfirekod");
            });

            modelBuilder.Entity<VwMakinaSiralama>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_makina_siralama");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.Bicakdurum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bicakdurum");

                entity.Property(e => e.Bicakkodu)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Birimadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("birimadi");

                entity.Property(e => e.Bitiren)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bitiren");

                entity.Property(e => e.Bitistarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("bitistarihi");

                entity.Property(e => e.Bitti).HasColumnName("bitti");

                entity.Property(e => e.Depodan).HasColumnName("depodan");

                entity.Property(e => e.Ekgecis).HasColumnName("ekgecis");

                entity.Property(e => e.Eskifilmat).HasColumnName("eskifilmat");

                entity.Property(e => e.Faturanot)
                    .HasColumnType("text")
                    .HasColumnName("faturanot");

                entity.Property(e => e.Firmakod)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Grafikonay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grafikonay");

                entity.Property(e => e.Ilkdefa).HasColumnName("ilkdefa");

                entity.Property(e => e.Ilkdefauy)
                    .HasMaxLength(50)
                    .HasColumnName("ilkdefauy");

                entity.Property(e => e.Irsaliyenot)
                    .HasColumnType("text")
                    .HasColumnName("irsaliyenot");

                entity.Property(e => e.Islemmiktar).HasColumnName("islemmiktar");

                entity.Property(e => e.Kisaad)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.Klisedurum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("klisedurum");

                entity.Property(e => e.Kliseno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Makinaadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("makinaadi");

                entity.Property(e => e.Makinabirimkod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("makinabirimkod");

                entity.Property(e => e.Makinakodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Malzemedurum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("malzemedurum");

                entity.Property(e => e.Mamultipadi)
                    .HasMaxLength(50)
                    .HasColumnName("mamultipadi");

                entity.Property(e => e.Musterikod)
                    .HasMaxLength(50)
                    .HasColumnName("musterikod");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Planlamakabultarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("planlamakabultarihi");

                entity.Property(e => e.Planlamatermintarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("planlamatermintarihi");

                entity.Property(e => e.Plantarih)
                    .HasColumnType("datetime")
                    .HasColumnName("plantarih");

                entity.Property(e => e.Prova).HasColumnName("prova");

                entity.Property(e => e.Revizyonfilmdegil).HasColumnName("revizyonfilmdegil");

                entity.Property(e => e.Revizyonnot)
                    .HasColumnType("text")
                    .HasColumnName("revizyonnot");

                entity.Property(e => e.Revizyonvar).HasColumnName("revizyonvar");

                entity.Property(e => e.Siparismakinaid).HasColumnName("siparismakinaid");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("siparistarih");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Sirada).HasColumnName("sirada");

                entity.Property(e => e.Siralama).HasColumnName("siralama");

                entity.Property(e => e.Temsilci)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("temsilci");

                entity.Property(e => e.Topislemsure).HasColumnName("topislemsure");

                entity.Property(e => e.Topsetupsure).HasColumnName("topsetupsure");

                entity.Property(e => e.Uretimnotu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("uretimnotu");

                entity.Property(e => e.Uretimplanlama).HasColumnName("uretimplanlama");

                entity.Property(e => e.Uretimtakip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uretimtakip");

                entity.Property(e => e.Urunadi)
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Urunkod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<VwRprSaSipari>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_rpr_sa_siparis");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Aciklama2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama2");

                entity.Property(e => e.Bicak).HasColumnName("bicak");

                entity.Property(e => e.BicakBoy).HasColumnName("bicakBoy");

                entity.Property(e => e.BicakEn).HasColumnName("bicakEn");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Birimadi)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("birimadi");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Birimoran).HasColumnName("birimoran");

                entity.Property(e => e.Birimtip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("birimtip");

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Detaysiz).HasColumnName("detaysiz");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.En).HasColumnName("en");

                entity.Property(e => e.Firmakisi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("firmakisi");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Firmasip)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("firmasip");

                entity.Property(e => e.Firmasiparisno)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("firmasiparisno");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Fiyattl).HasColumnName("fiyattl");

                entity.Property(e => e.Gondermetarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("gondermetarih");

                entity.Property(e => e.Ilad)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ilad");

                entity.Property(e => e.Ilcead)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ilcead");

                entity.Property(e => e.Istekkod).HasColumnName("istekkod");

                entity.Property(e => e.Kagittipi)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("kagittipi");

                entity.Property(e => e.Kdv).HasColumnName("kdv");

                entity.Property(e => e.Kisikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Klise).HasColumnName("klise");

                entity.Property(e => e.Klisefirmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("klisefirmakod");

                entity.Property(e => e.Klisegondermekod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisegondermekod");

                entity.Property(e => e.Kliseno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno");

                entity.Property(e => e.Klisesaklamakod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("klisesaklamakod");

                entity.Property(e => e.KontrolKapat).HasColumnName("kontrol_kapat");

                entity.Property(e => e.Kromolin).HasColumnName("kromolin");

                entity.Property(e => e.Kur).HasColumnName("kur");

                entity.Property(e => e.Malzemekodu)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemekodu");

                entity.Property(e => e.Miktar1).HasColumnName("miktar1");

                entity.Property(e => e.Miktar2).HasColumnName("miktar2");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Numunesivar).HasColumnName("numunesivar");

                entity.Property(e => e.Odeme)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("odeme");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Oran).HasColumnName("oran");

                entity.Property(e => e.Personelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Sabagkod)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sabagkod");

                entity.Property(e => e.Said).HasColumnName("said");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Sateklifkod).HasColumnName("sateklifkod");

                entity.Property(e => e.Sevksekli)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sevksekli");

                entity.Property(e => e.Simge)
                    .HasMaxLength(20)
                    .HasColumnName("simge");

                entity.Property(e => e.Sipariseden)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sipariseden");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("siparistarih");

                entity.Property(e => e.Sira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sira");

                entity.Property(e => e.Tabaka).HasColumnName("tabaka");

                entity.Property(e => e.Tasarimci)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tasarimci");

                entity.Property(e => e.Tedarikciadi)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("tedarikciadi");

                entity.Property(e => e.Tedarikcifirmaadi)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("tedarikcifirmaadi");

                entity.Property(e => e.Tedarikcikodu)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("tedarikcikodu");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Termintarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("termintarih");

                entity.Property(e => e.Tutar).HasColumnName("tutar");

                entity.Property(e => e.Tutartl).HasColumnName("tutartl");

                entity.Property(e => e.Ulkead)
                    .HasMaxLength(50)
                    .HasColumnName("ulkead");

                entity.Property(e => e.Urunadi)
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Urunbirimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("urunbirimkod");

                entity.Property(e => e.Urunboyu).HasColumnName("urunboyu");

                entity.Property(e => e.Uruneni).HasColumnName("uruneni");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod");

                entity.Property(e => e.Vade).HasColumnName("vade");

                entity.Property(e => e.Yeniurun).HasColumnName("yeniurun");

                entity.Property(e => e.Yonetimonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay");
            });

            modelBuilder.Entity<VwRprStokkart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_rpr_stokkart");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Birimadi)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("birimadi");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Birimtip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("birimtip");

                entity.Property(e => e.Cekeryuzde)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cekeryuzde");

                entity.Property(e => e.Depokod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("depokod");

                entity.Property(e => e.Dosyano)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dosyano");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Faturaedildi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("faturaedildi");

                entity.Property(e => e.Faturasevkno).HasColumnName("faturasevkno");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Fiyattl).HasColumnName("fiyattl");

                entity.Property(e => e.Gideceksiparisno)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("gideceksiparisno");

                entity.Property(e => e.Giriskkno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("giriskkno");

                entity.Property(e => e.Gramaj).HasColumnName("gramaj");

                entity.Property(e => e.Iccap)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("iccap");

                entity.Property(e => e.Imalatadi)
                    .HasMaxLength(50)
                    .HasColumnName("imalatadi");

                entity.Property(e => e.Imalatcikod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("imalatcikod");

                entity.Property(e => e.Imalatkod)
                    .HasMaxLength(50)
                    .HasColumnName("imalatkod");

                entity.Property(e => e.Kagittipi)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("kagittipi");

                entity.Property(e => e.Kalinlik).HasColumnName("kalinlik");

                entity.Property(e => e.Kisaad)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.Kkpersonelkodu)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kkpersonelkodu");

                entity.Property(e => e.Kodaciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kodaciklama");

                entity.Property(e => e.Koliadet).HasColumnName("koliadet");

                entity.Property(e => e.Kullanimalanikod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kullanimalanikod");

                entity.Property(e => e.Miktar1).HasColumnName("miktar1");

                entity.Property(e => e.Miktar2).HasColumnName("miktar2");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Opaklikkod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("opaklikkod");

                entity.Property(e => e.Paketbirimkod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("paketbirimkod");

                entity.Property(e => e.Paketmiktar)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("paketmiktar");

                entity.Property(e => e.Parlaklikkod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("parlaklikkod");

                entity.Property(e => e.Rafkodu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rafkodu");

                entity.Property(e => e.Ruloadet).HasColumnName("ruloadet");

                entity.Property(e => e.Setmi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("setmi");

                entity.Property(e => e.Sevkbekleyenmiktar).HasColumnName("sevkbekleyenmiktar");

                entity.Property(e => e.Sevkiyatno).HasColumnName("sevkiyatno");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Stokgramaji).HasColumnName("stokgramaji");

                entity.Property(e => e.Stokid).HasColumnName("stokid");

                entity.Property(e => e.Stokkod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stokkod");

                entity.Property(e => e.Stokno)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("stokno");

                entity.Property(e => e.Tabaka).HasColumnName("tabaka");

                entity.Property(e => e.Tabakaboy).HasColumnName("tabakaboy");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.Tasiyiciad)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tasiyiciad");

                entity.Property(e => e.Tasiyicikod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tasiyicikod");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Teslimno).HasColumnName("teslimno");

                entity.Property(e => e.Ticariad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ticariad");

                entity.Property(e => e.Toplamadet).HasColumnName("toplamadet");

                entity.Property(e => e.Urunadet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("urunadet");

                entity.Property(e => e.Urunadi)
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Uruntipkod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uruntipkod");

                entity.Property(e => e.Uyarinotu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("uyarinotu");

                entity.Property(e => e.Yapisalkod1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod1");

                entity.Property(e => e.Yapisalkod2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod2");

                entity.Property(e => e.Yapisalkod3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapisalkod3");

                entity.Property(e => e.Yapiskanad)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("yapiskanad");

                entity.Property(e => e.Yapiskankod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yapiskankod");

                entity.Property(e => e.Yarimamulkod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("yarimamulkod");
            });

            modelBuilder.Entity<VwSaSiparisOnay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_sa_siparis_onay");

                entity.Property(e => e.Bicak).HasColumnName("bicak");

                entity.Property(e => e.Bicakkodu)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("bicakkodu");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Dovizaciklama)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dovizaciklama");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Fiyattl).HasColumnName("fiyattl");

                entity.Property(e => e.Kisaad)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.Netmiktar).HasColumnName("netmiktar");

                entity.Property(e => e.Said).HasColumnName("said");

                entity.Property(e => e.Sasiparisno).HasColumnName("sasiparisno");

                entity.Property(e => e.Satipi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("satipi");

                entity.Property(e => e.Simge)
                    .HasMaxLength(20)
                    .HasColumnName("simge");

                entity.Property(e => e.Sira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sira");

                entity.Property(e => e.Tutar).HasColumnName("tutar");

                entity.Property(e => e.Tutartl).HasColumnName("tutartl");

                entity.Property(e => e.Urunadi)
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yonetimonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay");

                entity.Property(e => e.Yonetimonay2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay2");
            });

            modelBuilder.Entity<VwSatisPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_satis_plan");

                entity.Property(e => e.Ad)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ad");

                entity.Property(e => e.Adisoyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("adisoyadi");

                entity.Property(e => e.Adisoyadigorusme)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("adisoyadigorusme");

                entity.Property(e => e.BasSaat)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("bas_saat");

                entity.Property(e => e.Bilgi)
                    .HasColumnType("text")
                    .HasColumnName("bilgi");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Gorid).HasColumnName("gorid");

                entity.Property(e => e.Gorusmebitti).HasColumnName("gorusmebitti");

                entity.Property(e => e.Gorusmeno).HasColumnName("gorusmeno");

                entity.Property(e => e.Gorusmenotu)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("gorusmenotu");

                entity.Property(e => e.Gorusmetarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("gorusmetarihi");

                entity.Property(e => e.Gorusmetipno)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("gorusmetipno");

                entity.Property(e => e.Kisaad)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.Kisikod)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kisikod");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Personelkodugorusme)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodugorusme");

                entity.Property(e => e.RandevuSaat)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("randevu_saat");

                entity.Property(e => e.Randevuno).HasColumnName("randevuno");

                entity.Property(e => e.Randevutarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("randevutarihi");

                entity.Property(e => e.Sure)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sure");

                entity.Property(e => e.Teknikno).HasColumnName("teknikno");

                entity.Property(e => e.Tipaciklama)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tipaciklama");
            });

            modelBuilder.Entity<VwSipari>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_siparis");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Kisaad)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.KontrolKapat).HasColumnName("kontrol_kapat");

                entity.Property(e => e.Musterikod)
                    .HasMaxLength(50)
                    .HasColumnName("musterikod");

                entity.Property(e => e.Siparisbirim)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("siparisbirim");

                entity.Property(e => e.Siparisfiyat).HasColumnName("siparisfiyat");

                entity.Property(e => e.Siparismiktar).HasColumnName("siparismiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("siparistarih");

                entity.Property(e => e.Ticariad)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ticariad");

                entity.Property(e => e.Urunadi)
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<VwSiparisArsiv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_siparis_arsiv");

                entity.Property(e => e.Dovizaciklama)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dovizaciklama");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Firmakod)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Iptal).HasColumnName("iptal");

                entity.Property(e => e.Kisaad)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.Olusturanadisoyadi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("olusturanadisoyadi");

                entity.Property(e => e.Olusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("olusturmatarihi");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Personelkodu2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu2");

                entity.Property(e => e.Siparisfiyat).HasColumnName("siparisfiyat");

                entity.Property(e => e.Siparismiktar).HasColumnName("siparismiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("siparistarih");

                entity.Property(e => e.Toplamteslim).HasColumnName("toplamteslim");

                entity.Property(e => e.Urunadi)
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");
            });

            modelBuilder.Entity<VwSiparisOnay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_siparis_onay");

                entity.Property(e => e.Bakiyedovizad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("bakiyedovizad");

                entity.Property(e => e.Bakiyedovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bakiyedovizkod");

                entity.Property(e => e.Birimkod)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("birimkod");

                entity.Property(e => e.Dovizaciklama)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dovizaciklama");

                entity.Property(e => e.Dovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dovizkod");

                entity.Property(e => e.Firmakod)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firmakod");

                entity.Property(e => e.Kisaad)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.KontrolKapat).HasColumnName("kontrol_kapat");

                entity.Property(e => e.Muhasebekod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("muhasebekod");

                entity.Property(e => e.Muhasebeonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("muhasebeonay");

                entity.Property(e => e.Muhasebeonaylayan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("muhasebeonaylayan");

                entity.Property(e => e.Muhasebeonaytarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("muhasebeonaytarih");

                entity.Property(e => e.Musterikod)
                    .HasMaxLength(50)
                    .HasColumnName("musterikod");

                entity.Property(e => e.Odemeadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("odemeadi");

                entity.Property(e => e.Odemekod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("odemekod");

                entity.Property(e => e.Odemesekli)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("odemesekli");

                entity.Property(e => e.Onaydakibakiye).HasColumnName("onaydakibakiye");

                entity.Property(e => e.Onaydakirisk).HasColumnName("onaydakirisk");

                entity.Property(e => e.Prova).HasColumnName("prova");

                entity.Property(e => e.Riskdovizad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("riskdovizad");

                entity.Property(e => e.Riskdovizkod)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("riskdovizkod");

                entity.Property(e => e.Satisadisoyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("satisadisoyadi");

                entity.Property(e => e.Satisadisoyadi2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("satisadisoyadi2");

                entity.Property(e => e.Satistltutar).HasColumnName("satistltutar");

                entity.Property(e => e.Simge)
                    .HasMaxLength(20)
                    .HasColumnName("simge");

                entity.Property(e => e.Siparisbirim)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("siparisbirim");

                entity.Property(e => e.Siparisfiyat).HasColumnName("siparisfiyat");

                entity.Property(e => e.Siparismiktar).HasColumnName("siparismiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparistarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("siparistarih");

                entity.Property(e => e.Ticariad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ticariad");

                entity.Property(e => e.Urunadi)
                    .HasMaxLength(200)
                    .HasColumnName("urunadi");

                entity.Property(e => e.Urunkod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Yonetimonay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay");

                entity.Property(e => e.Yonetimonay2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonay2");

                entity.Property(e => e.Yonetimonaylayan)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonaylayan");

                entity.Property(e => e.Yonetimonaylayan2)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("yonetimonaylayan2");

                entity.Property(e => e.Yonetimonaytarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("yonetimonaytarih");

                entity.Property(e => e.Yonetimonaytarih2)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("yonetimonaytarih2");
            });

            modelBuilder.Entity<VwVardiya>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_vardiya");

                entity.Property(e => e.Aabosluk).HasColumnName("aabosluk");

                entity.Property(e => e.Adisoyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("adisoyadi");

                entity.Property(e => e.Alan).HasColumnName("alan");

                entity.Property(e => e.Baslangicgun)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("baslangicgun");

                entity.Property(e => e.Baslangicsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("baslangicsaat");

                entity.Property(e => e.Bicakaaadet).HasColumnName("bicakaaadet");

                entity.Property(e => e.Bitisgun)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("bitisgun");

                entity.Property(e => e.Bitissaat)
                    .HasColumnType("datetime")
                    .HasColumnName("bitissaat");

                entity.Property(e => e.Harcananurunadi)
                    .HasMaxLength(200)
                    .HasColumnName("harcananurunadi");

                entity.Property(e => e.Kisaad)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("kisaad");

                entity.Property(e => e.Kkontrol).HasColumnName("kkontrol");

                entity.Property(e => e.Kliseno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kliseno");

                entity.Property(e => e.Laminasyoncinsi)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("laminasyoncinsi");

                entity.Property(e => e.Makinaadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("makinaadi");

                entity.Property(e => e.Makinabirimkod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("makinabirimkod");

                entity.Property(e => e.Makinakodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("makinakodu");

                entity.Property(e => e.Malzemekod2)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("malzemekod2");

                entity.Property(e => e.Netsure).HasColumnName("netsure");

                entity.Property(e => e.Neturetim).HasColumnName("neturetim");

                entity.Property(e => e.Personelkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("personelkodu");

                entity.Property(e => e.Planlamasirasi).HasColumnName("planlamasirasi");

                entity.Property(e => e.Planmiktar).HasColumnName("planmiktar");

                entity.Property(e => e.Plansure).HasColumnName("plansure");

                entity.Property(e => e.Siparismiktar).HasColumnName("siparismiktar");

                entity.Property(e => e.Siparisno).HasColumnName("siparisno");

                entity.Property(e => e.Siparisurunadi)
                    .HasMaxLength(200)
                    .HasColumnName("siparisurunadi");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Tekebadboy).HasColumnName("tekebadboy");

                entity.Property(e => e.Tekebaden).HasColumnName("tekebaden");

                entity.Property(e => e.Topalan).HasColumnName("topalan");

                entity.Property(e => e.Topsetupsure).HasColumnName("topsetupsure");

                entity.Property(e => e.Uretimmiktar).HasColumnName("uretimmiktar");

                entity.Property(e => e.Urunalan).HasColumnName("urunalan");

                entity.Property(e => e.Urunfirealan).HasColumnName("urunfirealan");

                entity.Property(e => e.Urunkod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("urunkod");

                entity.Property(e => e.Vardiyaaltno).HasColumnName("vardiyaaltno");

                entity.Property(e => e.Vardiyano).HasColumnName("vardiyano");

                entity.Property(e => e.Yikananunite).HasColumnName("yikananunite");

                entity.Property(e => e.Zamanfiretoplami).HasColumnName("zamanfiretoplami");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
