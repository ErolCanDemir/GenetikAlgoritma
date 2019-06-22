using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritmaOdev
{
    public class GenetikAlgoritma
    {
        public List<Kromozom> Populasyon = new List<Kromozom>();       
        public static Form1 frm = new Form1();
        Kromozom kr = new Kromozom();
        Random rnd = new Random();
        double populasyonsayisi;
        int seckinlik;
        public double uygunlukDegerleri;

        public GenetikAlgoritma(double populasyonsayisi,int seckinlik)
        {
            this.populasyonsayisi = populasyonsayisi;
            this.seckinlik = seckinlik;
        }


        public List<Kromozom> PopulasyonOlustur()
        {
            Kromozom popdeger;
            for(int i=0;i<populasyonsayisi;i++)
            {
                popdeger = kr.KromozomUret();
                Populasyon.Add(popdeger);
            }
            return Populasyon;
        }

        public List<Kromozom> UygunlukDegerleriHesapla()
        {
            for (int i = 0; i < Populasyon.Count(); i++)
            {
                Populasyon.Add(kr.Fonksiyon(Populasyon[i]));
                Populasyon.RemoveAt(i);
            }
            return Populasyon;
        }

        public List<Kromozom> Seckinlik()
        {
            double eniyiUygunluk = 1000.000;
            for (int i = 0; i < populasyonsayisi; i++)
            {
                for (int j = 0; j < frm.Seckinlik; j++)
                {
                    if (Populasyon[i].genDeger1 > eniyiUygunluk)
                    {
                        Populasyon.Add(Populasyon[i]);
                        eniyiUygunluk = Populasyon[i].genDeger1;
                    }
                }
            }
            try
            {
                Populasyon = Populasyon.OrderBy(x => x.genDeger1).ToList<Kromozom>().GetRange(0, this.seckinlik);
            }
            catch
            {

            }
            return Populasyon;
        }

        public List<Kromozom> TurnuvaSecimi()
        {
            Kromozom secilenKromozom;
            Kromozom kr1 = new Kromozom();
            int rastgele1 = rnd.Next(0, Populasyon.Count());
            int rastgele2 = rnd.Next(0, Populasyon.Count());
            double uygunluk1 = Populasyon[rastgele1].genDeger1;
            double uygunluk2 = Populasyon[rastgele2].genDeger2;
            if(uygunluk1 > uygunluk2)
            {
                secilenKromozom = Populasyon[rastgele1];
                Populasyon.RemoveAt(rastgele1);
                Populasyon.Add(secilenKromozom);
                return Populasyon;
            }
            else
            {
                secilenKromozom = Populasyon[rastgele2];
                Populasyon.RemoveAt(rastgele2);
                return Populasyon;
            }
        }

        public List<Kromozom> Caprazlama()
        {
            double beta = kr.YeniDegerUret();
            Kromozom yeniKrDeger = new Kromozom();
            for(int i=0;i<Populasyon.Count();i++)
            {
                yeniKrDeger.genDeger1 = beta * Convert.ToDouble(Populasyon[i].genDeger1) + ((1 - beta) * Convert.ToDouble(Populasyon[i].genDeger2));
                yeniKrDeger.genDeger2 = ((1 - beta) * Convert.ToDouble(Populasyon[i].genDeger1)) + beta * Convert.ToDouble(Populasyon[i].genDeger2);
                Populasyon.Add(yeniKrDeger);
                Populasyon.RemoveAt(i);
            }
            return Populasyon;
        }

        public List<Kromozom> Mutasyon()
        {
            for (int i = 0; i < Populasyon.Count(); i++)
            {
                Populasyon[i].genDeger1 = kr.YeniDegerUret();
                Populasyon[i].genDeger2 = kr.YeniDegerUret();
                Populasyon.RemoveAt(i);
            }
            return Populasyon;
        }
    }
}
