using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xdd
{
     class Rower
    {
        private string kolor;
        private Producent producent;
        private Material material;
        public void jedz()
        {
            Console.WriteLine("Jadymy na kur*y");
        }
        public void setColor(string akolor)
        {
            this.kolor = akolor;
        }
        public string getColor()
        {
            
        }
        public void setMaterial(Material amaterial)
        {
            this.material = amaterial;
        }
        public Rower(Producent aproducent)
        {
            this.producent = aproducent;
        }
    }
    internal class Producent
    {
        private string nazwa;
        private string nip;
        public string getNazwa()
        {
            
        }
        public string getNip()
        {
           
        }
        public void setNazwa(string anazwa)
        {
            this.nazwa = anazwa;
        }
    }
    internal class Material
    {
        private string typ;
        private int id;
        private double cena;
        public void setTyp(string atyp)
        {
            this.typ = atyp;
        }
        public string getTyp()
        {
            
        }
        public double getCena()
        {
            
        }
        public void setId(int aid)
        {
            this.id = aid;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
