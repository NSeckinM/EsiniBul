using EsiniBul.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBul
{
    public partial class Form1 : Form
    {
        int satirAdet = 4;
        int sutunAdet = 4;
        int kartBoyut = 75;
        int kartArasi = 5;
        int[] bayrakHavuzu;
        int[] bayraklar;
        List<PictureBox> acilanlar;
        List<PictureBox> kartlar;

        readonly ZorlukSeviye _zorlukSeviye;

        public int KartAdet { get { return satirAdet * sutunAdet; } }

        public Form1(ZorlukSeviye zorlukSeviye)
        {
            _zorlukSeviye = zorlukSeviye;
            SeviyeAyarla();
            InitializeComponent();
            acilanlar = new List<PictureBox>();
            BayrakHavuzunuDoldur();
            KartlariDiz();

        }

        private void KartlariKisaSureliGoster()
        {
            pnlKartlar.Enabled = false;
            foreach (PictureBox pictureBox in kartlar)
            {
                KartiAc(pictureBox);

            }

            Thread.Sleep(2000); //todo: süre kart adetine göre ayarlanabilir.

            foreach (PictureBox pictureBox in kartlar)
            {
                KartiKapat(pictureBox);

            }

            Application.DoEvents();
            //Thread programı uyuttugunda tetiklenen(tıklamalar) eventleri sıraya alıp uyanır uyanmaz işleme alınıyordu
            //tekrardan aynı noktalara tıklamaya gerek kalmadan resimler eşleşip yok oluyordu
            // ** DoEvents threaddan uyanır uyanmaz bütün eventleri uyguluyor
            //ve daha sonra panel  aktif hale getiriliyor.

            pnlKartlar.Enabled = true;

        }

        private void SeviyeAyarla()
        {
            switch (_zorlukSeviye)
            {
                case ZorlukSeviye.Kolay:
                    satirAdet = sutunAdet = 4;
                    break;
                case ZorlukSeviye.Orta:
                    satirAdet = sutunAdet = 6;
                    break;
                case ZorlukSeviye.Zor:
                    satirAdet = sutunAdet = 8;
                    break;

                default:
                    throw new Exception("Olmayan bir seviye seçimi yapıldı.");
            }

        }

        private void BayraklariDoldur()
        {
            
            bayraklar = new int[KartAdet];
            Array.Copy(bayrakHavuzu, bayraklar, KartAdet / 2);
            Array.Copy(bayrakHavuzu, 0, bayraklar, KartAdet / 2, KartAdet / 2);
            Islemler.Karistir(bayraklar);
        }

        private void BayrakHavuzunuDoldur()
        {
            bayrakHavuzu = Enumerable.Range(1, 263).ToArray();
            Islemler.Karistir(bayrakHavuzu);
        }

        private void KartlariDiz()
        {
            BayraklariDoldur();

            kartlar = new List<PictureBox>();
            pnlKartlar.Width = sutunAdet * (kartBoyut + kartArasi) - kartArasi;
            pnlKartlar.Height = satirAdet * (kartBoyut + kartArasi) - kartArasi;
            ClientSize = new Size(pnlKartlar.Width + 20, pnlKartlar.Height + 20);

            for (int i = 0; i < KartAdet; i++)
            {
                PictureBox pb = new PictureBox();
                kartlar.Add(pb);
                pb.Tag = i;
                pb.Click += Pb_Click;
                //pb.Image = Properties.Resources._87;
                //pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + rnd.Next(0, 264));
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                // pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + bayraklar[i]);
                pb.Image = Resources.block;
                pb.BackColor = Color.Pink;
                pb.Width = kartBoyut;
                pb.Height = kartBoyut;
                pb.Left = i % sutunAdet * (kartBoyut + kartArasi);
                pb.Top = i / sutunAdet * (kartBoyut + kartArasi);
                pnlKartlar.Controls.Add(pb);

            }
        }
        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            //açılana tekrar tıklandıysa
            if (acilanlar.Count ==1 && pb == acilanlar[0])
            {
                return; // dikkate almadan metotdan çık;
            }

            if (acilanlar.Count == 2)
            {
                AcikKartlariKapat();
            }

            acilanlar.Add(pb);

            KartiAc(pb);

            if (acilanlar.Count == 2 && AcilanlarAyniysa())
            {
                Thread.Sleep(500);
                AcikKartlariGizle();
            }
        }

        void KartiAc(PictureBox pb)
        {
            int index = (int)pb.Tag;
            int bayrakNo = bayraklar[index];
            pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + bayrakNo);
            pb.Refresh();//picture box ı güncelliyor yeniden boyuyyor.
        }

        private void KartiKapat(PictureBox pb)
        {
            pb.Image = Resources.block;
            
        }

        private bool AcilanlarAyniysa()
        {
            int index1 = (int)acilanlar[0].Tag;
            int index2 = (int)acilanlar[1].Tag;
            return bayraklar[index1] == bayraklar[index2];

        }

        private void AcikKartlariGizle()
        {
            foreach (PictureBox pictureBox in acilanlar)
            {
                pictureBox.Hide();
            }

            acilanlar.Clear();
        }

        private void AcikKartlariKapat()
        {
            foreach (PictureBox pictureBox in acilanlar)
            {
                KartiKapat(pictureBox);
            }

            acilanlar.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            KartlariKisaSureliGoster();
        }
    }
}
