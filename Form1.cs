using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritmaOdev
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red700, MaterialSkin.Primary.Red700, MaterialSkin.Primary.Red700, MaterialSkin.Accent.Red700, MaterialSkin.TextShade.BLACK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int populasyonSayisi;
        public double CaprazlamaOrani;
        public double MutasyonOrani;
        public int Seckinlik;
        public int IterasyonSayisi;

       
        Kromozom kr = new Kromozom();
        List<double> SonPopulasyonUygunluklarix1 = new List<double>();
        List<double> SonPopulasyonUygunluklarix2 = new List<double>();
        Grafik gr = new Grafik();
        Random rnd = new Random();

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            populasyonSayisi = Convert.ToInt32(numericUpDownPopulasyon.Value);
            CaprazlamaOrani = Convert.ToDouble(numericUpDownCaprazlama.Value);
            MutasyonOrani = Convert.ToDouble(numericUpDownMutasyon.Value);
            Seckinlik = Convert.ToInt32(numericUpDownSeckinlik.Value);
            IterasyonSayisi = Convert.ToInt32(numericUpDown1.Value);

            GenetikAlgoritma ga = new GenetikAlgoritma(populasyonSayisi,Seckinlik);
            for (int i = 0; i < IterasyonSayisi; i++)
            {
                GenetikAlgoritmaCalistir();
            }
            //try
            //{
                gr.GrafikCiz(SonPopulasyonUygunluklarix1, chart1, "x1", Color.DarkOrange);
                gr.GrafikCiz(SonPopulasyonUygunluklarix2, chart1, "x2", Color.Red);
                materialLabel10.Text = SonPopulasyonUygunluklarix1.Last().ToString();
                materialLabel11.Text = SonPopulasyonUygunluklarix2.Last().ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("İşlemi tekrar başlatmak için uygulamayı yeniden başlatınız...");
            //}
            

            void GenetikAlgoritmaCalistir()
            {
                ga.Populasyon = ga.PopulasyonOlustur();
                ga.Populasyon = ga.UygunlukDegerleriHesapla();
                ga.Populasyon = ga.Seckinlik();
                ga.Populasyon = ga.TurnuvaSecimi();
                ga.Populasyon = CaprazlamaYap();
                ga.Populasyon = MutasyonYap();
                

                for (int i = 0; i < ga.Populasyon.Count; i++)
                {
                    SonPopulasyonUygunluklarix1.Add(ga.Populasyon[i].genDeger1);
                    SonPopulasyonUygunluklarix2.Add(ga.Populasyon[i].genDeger2);
                }
            }

            List<Kromozom> CaprazlamaYap()
            {
                double beta = rnd.Next(0, 1);
                if (beta < CaprazlamaOrani)
                {
                    ga.Populasyon = ga.Caprazlama();
                    return ga.Populasyon;
                }
                else
                {
                    return ga.Populasyon;
                }
            }

            List<Kromozom> MutasyonYap()
            {
                double beta = rnd.Next(0, 1);
                if (beta < MutasyonOrani)
                {
                    ga.Populasyon = ga.Mutasyon();
                    return ga.Populasyon;
                }
                else
                {
                    return ga.Populasyon;
                }
            }
        }
    }
}
