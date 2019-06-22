using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritmaOdev
{
    public class Kromozom
    {
        public double gx1=-1.5, gx2=-3, hx=4;
        public double genDeger1,genDeger2;
        Random rnd = new Random();
        double fx;
        public double[] gen;


        public Kromozom()
        {

        }

        public Kromozom(double genDeger1,double genDeger2,double gx1, double gx2, double hx)
        {
            this.genDeger1 = genDeger1;
            this.genDeger2 = genDeger2;
            this.gx1 = gx1;
            this.gx2 = gx2;
            this.hx = hx;
        }

        public Kromozom(double gx1, double gx2,double hx)
        {
            this.gx1 = gx1;
            this.gx2 = gx2;
            this.hx = hx;
        }

        public Kromozom(double genDeger1,double genDeger2)
        {
            this.genDeger1 = genDeger1;
            this.genDeger2 = genDeger2;
        }

        public Kromozom KromozomUret()
        {
            return (new Kromozom());
        }


        public Kromozom Fonksiyon(Kromozom kr1)
        {
            
            genDeger1 = rnd.Next(Convert.ToInt32(gx1), Convert.ToInt32(hx));
            genDeger2 = rnd.Next(Convert.ToInt32(gx2), Convert.ToInt32(hx));
            kr1.fx = Math.Sin(genDeger1 + genDeger2) - (genDeger1 * 2) - 1.5 * genDeger1 + 2.5 * genDeger2 + 1;
            return kr1;
        }

        public double YeniDegerUret()
        {
            genDeger1 = rnd.Next(Convert.ToInt32(gx1), Convert.ToInt32(hx));
            return genDeger1;
        }
    }
}
