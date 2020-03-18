using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesClasses
{
    public class Vehicule
    {
        private string immatriculation;

        private DateTime dateMiseEnCirculation;

        public Vehicule(string i, DateTime dMEC)
        {
            this.immatriculation = i;
            this.dateMiseEnCirculation = dMEC;
        }

        public void setImmat(string uneImmat)
        {
            this.immatriculation = uneImmat;
        }

        public void setDMEC(DateTime dateMEC)
        {
            this.dateMiseEnCirculation = dateMEC;
        }

        public string getImmat()
        {
            return this.immatriculation;
        }

        public DateTime getDateMEC()
        {
            return this.dateMiseEnCirculation;
        }

        public string toString()
        {
            return this.immatriculation + " " + this.dateMiseEnCirculation;
        }

    }
}
