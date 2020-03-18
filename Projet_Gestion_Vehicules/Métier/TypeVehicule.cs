using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_Vehicules.Métier
{
    class TypeVehicule
    {
        private String nomTypeVehicule;

        public TypeVehicule(string unNom)
        {
            this.nomTypeVehicule = unNom;
        }

        public string toString()
        {
            return this.nomTypeVehicule;
        }
    }
}
