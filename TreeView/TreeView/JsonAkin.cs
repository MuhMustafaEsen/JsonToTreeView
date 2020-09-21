using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{
    public class JsonAkin
    {

        public class Rootobject
        {
            public bool success { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public MODULLER[] MODULLER { get; set; }
            public object HABERLER { get; set; }
            public KAMPANYALAR[] KAMPANYALAR { get; set; }
            public int DOWNLOAD_SAYISI { get; set; }
            public float KODU { get; set; }
            public int YERLESKE_KODU { get; set; }
            public string PROG_KODU { get; set; }
            public string PROG_KISA_ADI { get; set; }
            public string PROG_DILI { get; set; }
            public string PROG_ANEASURUM { get; set; }
            public string SON_TARIH { get; set; }
            public string GRUBU { get; set; }
            public string GRUBU_ALT { get; set; }
            public string GRUBU_ALT_2 { get; set; }
            public string VERS_DLL { get; set; }
            public string PROG_KISAKOD { get; set; }
            public string LISANS_MODELI { get; set; }
            public string PROG_TURU { get; set; }
            public string UCRETSIZ { get; set; }
            public string DOSYA_BOYUTU { get; set; }
            public string DIL_DEST { get; set; }
            public string WEBDE_GOZUKSUN { get; set; }
            public string WEBDE_SONTARIH { get; set; }
            public string ABAKUSYERALSIN { get; set; }
            public string ARGE_PERSONELI { get; set; }
            public string BARKODU { get; set; }
            public string BENZER_PROGRAMLAR { get; set; }
            public string DEMO_TALEBI { get; set; }
            public string DIGER_PROGRAMLAR { get; set; }
            public string DIL_DESTEGI { get; set; }
            public int E_TICARET { get; set; }
            public int E_TICARET_LSNOTURU { get; set; }
            public string FTP_DOMAIN { get; set; }
            public string FTP_OTO_OLUSTUR { get; set; }
            public string FTP_UPLOAD_ADRES { get; set; }
            public object IKONINDEKS { get; set; }
            public string INSTALLER_PROGKODU { get; set; }
            public string ISTEK_ONERI { get; set; }
            public string KK_PERSONELI { get; set; }
            public string LISANS_ENT { get; set; }
            public string LISANS_MODUL_KODU { get; set; }
            public string LISANS_PRO { get; set; }
            public string LISANS_STD { get; set; }
            public string MAILLIST { get; set; }
            public string ONLINE_LISANS { get; set; }
            public string OZEL_KODU { get; set; }
            public int PAKET_SATISI { get; set; }
            public string PROGRAMCI { get; set; }
            public string PROGRAM_HABER_YERALSIN { get; set; }
            public string PROG_SURUM { get; set; }
            public string REFERANS { get; set; }
            public string SIRALAMA { get; set; }
            public int SUNUCU_KURULUMU { get; set; }
            public int UCRETSIZ_MI { get; set; }
            public int URUNMD_YERALSIN { get; set; }
            public string UST_PROGKODU { get; set; }
            public string VERITABANI { get; set; }
            public string WEBDE_SURUM { get; set; }
            public int WEB_GRUBUNDA_YERALSIN { get; set; }
            public string PROG_ADI { get; set; }
            public string PROGRAM_ADI_WEB { get; set; }
            public string KURULUM { get; set; }
            public string ICERDIGI_MODULLER { get; set; }
            public string KULLANIM_ALANLARI { get; set; }
            public string ANAHTAR_KELIMELER { get; set; }
            public string LINK_ACIKLAMA_1 { get; set; }
            public string LINK_ACIKLAMA_2 { get; set; }
            public string LINK_ACIKLAMA_3 { get; set; }
            public string LINK_ACIKLAMA_4 { get; set; }
            public string LINK_AKTIF_1 { get; set; }
            public string LINK_AKTIF_2 { get; set; }
            public string LINK_AKTIF_3 { get; set; }
            public string LINK_AKTIF_4 { get; set; }
            public string LINK_AKTIF_5 { get; set; }
            public string LINK_BASLIK_1 { get; set; }
            public string LINK_BASLIK_2 { get; set; }
            public string LINK_BASLIK_3 { get; set; }
            public string LINK_BASLIK_4 { get; set; }
            public string LINK_DWNADI_1 { get; set; }
            public string LINK_DWNADI_2 { get; set; }
            public string LINK_DWNADI_3 { get; set; }
            public string LINK_DWNADI_4 { get; set; }
            public string LINK_DWNADI_5 { get; set; }
            public string LINK_LINKADI_1 { get; set; }
            public string LINK_LINKADI_2 { get; set; }
            public string LINK_LINKADI_3 { get; set; }
            public string LINK_LINKADI_4 { get; set; }
            public string LINK_LINKADI_5 { get; set; }
            public int LINK2_AKTIF { get; set; }
            public int LINK3_AKTIF { get; set; }
            public int LINK4_AKTIF { get; set; }
            public string LINK_EKATALOG { get; set; }
            public string AYRINTILI_TANITIM { get; set; }
            public string OZELLIKLER { get; set; }
            public bool SANAL_KAYIT { get; set; }
            public string FIYATLAR_LINK { get; set; }
            public string MUSTERI_VIDEOLARI { get; set; }
            public string TANITIM_VIDEOLARI { get; set; }
            public string YARDIM_LINKI { get; set; }
            public string EGITIM_LINKI { get; set; }
            public string DONANIM_LINKI { get; set; }
            public object[] FAALIYETLER { get; set; }
        }

        public class MODULLER
        {
            public int BLFYTKODU { get; set; }
            public string MODUL_ADI { get; set; }
            public string MODUL_KODU { get; set; }
            public float PAKET_FIYAT { get; set; }
            public float PAKET_FIYAT_KAMP { get; set; }
            public float ENT_FIYAT { get; set; }
            public float ENT_FIYAT_KAMP { get; set; }
            public string PARA_SIMGE { get; set; }
            public object EGITIM_SURESI { get; set; }
            public int FIYATGIZLE { get; set; }
            public int DURUMU { get; set; }
            public int MODULPAKET { get; set; }
        }

        public class KAMPANYALAR
        {
            public float KODU { get; set; }
            public string KAMP_ADI { get; set; }
            public string KAMP_BSTARIHI { get; set; }
            public string KAMP_BTTARIHI { get; set; }
            public string KAYDEDEN { get; set; }
            public string KAYIT_TARIHI { get; set; }
            public string DEGISTIREN { get; set; }
            public string DEGISTIRME_TARIHI { get; set; }
            public string ACIKLAMA { get; set; }
            public object PAKET_BTSTARIHI { get; set; }
            public string KMP_KODU { get; set; }
            public string LINK { get; set; }
            public string PERSONEL_NOT { get; set; }
            public string TAHMINI_BTTARIHI { get; set; }
            public string BOLGESI { get; set; }
            public string OZEL_KODU { get; set; }
            public string WEBDE_GORUNSUN { get; set; }
            public bool WEBDE_GORUNSUN_BOOL { get; set; }
            public string ILLER { get; set; }
            public string PROGRAMLAR { get; set; }
            public string RESIM_YOLU_1 { get; set; }
            public string RESIM_YOLU_2 { get; set; }
            public string RESIM_YOLU_3 { get; set; }
            public string RESIM_YOLU_4 { get; set; }
            public string RESIM_YOLU_5 { get; set; }
            public string KEYWORD { get; set; }
            public string OZEL_BASLIK { get; set; }
            public bool BugunIleBitisArasindaPazarVarmi { get; set; }
            public int KAMPANYA_BITIS_KALAN_GUN { get; set; }
            public string KAMP_KATEGORI { get; set; }
            public string[] KAMP_KATEGORI_LIST { get; set; }
            public bool ONE_CIKAN_KAMPANYA_BOOL { get; set; }
            public int BU_KAMPANYA_UZATILMAYACAKTIR { get; set; }
            public bool BU_KAMPANYA_UZATILMAYACAKTIR_BOOL { get; set; }
            public int ONE_CIKAN_KAMPANYA { get; set; }
            public object SIRA { get; set; }
            public string ILGILI_PROGRAMLAR { get; set; }
            public string META_DESCTRIPTION { get; set; }
            public string KAMPANYA_DETAYLARI { get; set; }
            public string[] KAMPANYA_DETAYLARI_LIST { get; set; }
            public string RENK_KODU { get; set; }
            public int SABLON_TIPI { get; set; }
            public string DIL { get; set; }
            public object ORAN { get; set; }
        }

    }
}
