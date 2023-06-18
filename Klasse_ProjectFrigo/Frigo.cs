using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_ProjectFrigo
{
    public class Frigo
    {
        //Velden
        string _product = "";
        int _aantal = -1;
        DateTime _vervalDag = DateTime.Now;

        //Properties
        public string PropProduct
        {
            get { return _product; }
            set { _product = value; }
        }

        public int PropAantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }

        public DateTime PropVervalDag
        {
            get { return _vervalDag; }
            set { _vervalDag = value; }
        }

        //Methods
        /// <summary>
        /// Zegt hoeveel dagen het product nog goed is
        /// </summary>
        /// <returns></returns>
        public String VervaltBinnenXDagen()
        {
            String antwoord = "";

            //Verminder de vervaldatum met huidige tijd
            TimeSpan TijdOver = _vervalDag - DateTime.Now;

            //Zeg binnen hoeveel dagen het product vervalt
            int aantalDagen = Convert.ToInt32(TijdOver);

            //Vorm een andwoord
            antwoord = $"Dit product is nog {aantalDagen} goed";

            return antwoord;
        }
        /// <summary>
        /// Geeft alle gegeven
        /// </summary>
        /// <returns></returns>
        public String AlleGegevens()
        {
            String antwoord = "";

            //Toon alle gegevens
            antwoord = $"{_product}  Aantal: {_aantal}{Environment.NewLine}Vervaldag:{_vervalDag}  Nog {VervaltBinnenXDagen()} goed";

            return antwoord;
        }

        //Constructors
        public Frigo() { }

        public Frigo(string ontvProduct)
        {
            _product = ontvProduct;
        }

        public Frigo(string ontvProduct, int ontvAantal)
        {
            _product = ontvProduct;
            _aantal = ontvAantal;
        }

        public Frigo(string ontvProduct, int ontvAantal, DateTime ontvVervalDag)
        {
            _product = ontvProduct;
            _aantal = ontvAantal;
            _vervalDag = ontvVervalDag;
        }
    }
}
