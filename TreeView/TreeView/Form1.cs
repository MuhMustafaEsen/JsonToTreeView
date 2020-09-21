using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TreeView.JsonAkin;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rootobject rootobject;

        private void Form1_Load(object sender, EventArgs e)
        {
            rootobject = new Rootobject();
            
        }
        private void LoadTree()
        {
            var jsonData = new WebClient().DownloadString("http://eliza.akinsoft.net/module/api/programapi/programdetayi?prog_kodu=ISC1");

            var data = JsonConvert.DeserializeObject<Rootobject>(jsonData);
            try
            {
                foreach (var item in data.data.MODULLER)
                {

                    TreeNode node = new TreeNode(item.MODUL_ADI.ToString());
                    node.Nodes.Add(item.MODUL_KODU.ToString());
                    node.Nodes.Add(item.PAKET_FIYAT.ToString());
                    node.Nodes.Add(item.PAKET_FIYAT_KAMP.ToString());
                    node.Nodes.Add(item.ENT_FIYAT.ToString());
                    node.Nodes.Add(item.ENT_FIYAT_KAMP.ToString());
                    node.Nodes.Add(item.PARA_SIMGE.ToString());
                    if (item.EGITIM_SURESI != null)
                    {
                        node.Nodes.Add(item.EGITIM_SURESI.ToString());
                    }
                    node.Nodes.Add(item.FIYATGIZLE.ToString());
                    node.Nodes.Add(item.DURUMU.ToString());
                    node.Nodes.Add(item.MODULPAKET.ToString());
                    node.Nodes.Add(item.BLFYTKODU.ToString());
                    treeView1.Nodes.Add(node);


                }
                foreach (var item in data.data.KAMPANYALAR)
                {
                    TreeNode node = new TreeNode(item.ACIKLAMA.ToString());
                    node.Nodes.Add(item.BOLGESI.ToString());
                    node.Nodes.Add(item.BugunIleBitisArasindaPazarVarmi.ToString());
                    node.Nodes.Add(item.BU_KAMPANYA_UZATILMAYACAKTIR.ToString());
                    node.Nodes.Add(item.BU_KAMPANYA_UZATILMAYACAKTIR_BOOL.ToString());
                    node.Nodes.Add(item.DEGISTIREN.ToString());
                    node.Nodes.Add(item.DEGISTIRME_TARIHI.ToString());
                    node.Nodes.Add(item.DIL.ToString());
                    node.Nodes.Add(item.ILGILI_PROGRAMLAR.ToString());
                    node.Nodes.Add(item.ILLER.ToString());
                    node.Nodes.Add(item.KAMPANYA_BITIS_KALAN_GUN.ToString());
                    node.Nodes.Add(item.KAMPANYA_DETAYLARI.ToString());
                    node.Nodes.Add(item.KAMPANYA_DETAYLARI_LIST.ToString());
                    node.Nodes.Add(item.KAMP_ADI.ToString());
                    node.Nodes.Add(item.KAMP_BSTARIHI.ToString());
                    node.Nodes.Add(item.KAMP_BTTARIHI.ToString());
                    node.Nodes.Add(item.KAMP_KATEGORI.ToString());
                    node.Nodes.Add(item.KAMP_KATEGORI_LIST.ToString());
                    node.Nodes.Add(item.KAYDEDEN.ToString());
                    node.Nodes.Add(item.KAYIT_TARIHI.ToString());
                    node.Nodes.Add(item.KEYWORD.ToString());
                    node.Nodes.Add(item.KMP_KODU.ToString());
                    node.Nodes.Add(item.KODU.ToString());
                    node.Nodes.Add(item.LINK.ToString());
                    node.Nodes.Add(item.META_DESCTRIPTION.ToString());
                    node.Nodes.Add(item.ONE_CIKAN_KAMPANYA.ToString());
                    node.Nodes.Add(item.ONE_CIKAN_KAMPANYA_BOOL.ToString());

                    node.Nodes.Add(item.OZEL_BASLIK.ToString());
                    if (item.PAKET_BTSTARIHI != null)
                    {
                        node.Nodes.Add(item.PAKET_BTSTARIHI.ToString());
                    }

                    node.Nodes.Add(item.PERSONEL_NOT.ToString());

                    node.Nodes.Add(item.PROGRAMLAR.ToString());
                    node.Nodes.Add(item.RENK_KODU.ToString());
                    node.Nodes.Add(item.RESIM_YOLU_1.ToString());
                    node.Nodes.Add(item.RESIM_YOLU_2.ToString());
                    node.Nodes.Add(item.RESIM_YOLU_3.ToString());
                    node.Nodes.Add(item.RESIM_YOLU_4.ToString());
                    node.Nodes.Add(item.RESIM_YOLU_5.ToString());
                    node.Nodes.Add(item.SABLON_TIPI.ToString());
                    if (item.SIRA != null)
                    {
                        node.Nodes.Add(item.SIRA.ToString());
                    }

                    node.Nodes.Add(item.TAHMINI_BTTARIHI.ToString());
                    node.Nodes.Add(item.WEBDE_GORUNSUN.ToString());
                    node.Nodes.Add(item.WEBDE_GORUNSUN_BOOL.ToString());
                    treeView1.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnTreeView_Click(object sender, EventArgs e)
        {
            LoadTree();
        }

    }
}
