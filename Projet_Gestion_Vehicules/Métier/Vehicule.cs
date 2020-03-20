using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_Vehicules.Métier
{
    public class Vehicule
    {
        private int id;
        private string immatriculation;
        private DateTime dateMiseEnCirculation;
        private TypeVehicule unType;

        public Vehicule()
        { }

        public Vehicule(int id)
        {
            this.id = id;
        }

        public Vehicule(string immat, DateTime DMEC)
        {
            this.immatriculation = immat;
            this.dateMiseEnCirculation = DMEC;
        }

        public Vehicule(int id, string i)
        {
            this.id = id;
            this.immatriculation = i;
        }

        public Vehicule(int id, string i, DateTime dMEC)
        {
            this.id = id;
            this.immatriculation = i;
            this.dateMiseEnCirculation = dMEC;
        }

        public Vehicule(string i, DateTime dMEC, TypeVehicule unType)
        {
            this.immatriculation = i;
            this.dateMiseEnCirculation = dMEC;
            this.unType = unType;
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
        
        public void setTypeVehicule(TypeVehicule unT)
        {
            this.unType = unT;
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

        public TypeVehicule getTypeV()
        {
            return this.unType;
        }
        public string toString()
        {
            return this.immatriculation + " " + this.dateMiseEnCirculation;
        }

    }
}
