using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_Vehicules
{
    public class Vehicule
    {
        private int id;
        private string immatriculation;

        private DateTime dateMiseEnCirculation;

        public Vehicule()
        { }

        public Vehicule(int id)
        {
            this.id = id;
        }

        public Vehicule(int id, string i)
        {
            this.id = id;
            this.immatriculation = i;
        }

        public Vehicule(string i, DateTime dMEC)
        {
            this.immatriculation = i;
            this.dateMiseEnCirculation = dMEC;
        }

        public void setId(int unId)
        {
            this.id = unId;
        }

        public void setImmat(string uneImmat)
        {
            this.immatriculation = uneImmat;
        }

        public void setDMEC(DateTime dateMEC)
        {
            this.dateMiseEnCirculation = dateMEC;
        }

        public int getId()
        {
            return this.id;
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
