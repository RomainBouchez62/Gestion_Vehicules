using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_Vehicules.Métier
{
    public class TypeVehicule
    {
        private int id;
        private String nomTypeVehicule;

        public TypeVehicule(int id)
        {
            this.id = id;
        }

        public TypeVehicule(int id,string unNom)
        {
            this.id = id;
            this.nomTypeVehicule = unNom;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setNom(String unN)
        {
            this.nomTypeVehicule = unN;
        }
        
        public int getId()
        {
            return this.id;
        }

        public string getNom()
        {
            return this.nomTypeVehicule;
        }

        public string toString()
        {
            return this.nomTypeVehicule;
        }
    }
}
