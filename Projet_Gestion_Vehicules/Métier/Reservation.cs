using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_Vehicules.Métier
{
    class Reservation
    {
        private int idResa;

        private Vehicule unVehicule;

        private Employe unEmploye;

        private DateTime dateResa;

        private TimeSpan heureDebutResa;

        private TimeSpan heureFinResa;

        public Reservation()
        { }

        public Reservation(int idR, Vehicule IdV, Employe IdE, DateTime dtResa, TimeSpan hDbt, TimeSpan hFin)
        {
            this.idResa = idR;
            this.unVehicule = IdV;
            this.unEmploye = IdE;
            this.dateResa = dtResa;
            this.heureDebutResa = hDbt;
            this.heureFinResa = hFin;
        }

        public void setIdResa(int idR)
        {
            this.idResa = idR;
        }

        public int getIdResa()
        {
            return this.idResa;
        }

        public void setIdVehicule(Vehicule idV)
        {
            this.unVehicule = idV;
        }

        public Vehicule getIdVehicule()
        {
            return this.unVehicule;
        }

        public void setIdEmploye(Employe idE)
        {
            this.unEmploye = idE;
        }

        public Employe getIdEmploye()
        {
            return this.unEmploye;
        }

        public void setDateResa(DateTime dtR)
        {
            this.dateResa = dtR;
        }

        public DateTime getDateResa()
        {
            return this.dateResa;
        }

        public void setHeureDbt(TimeSpan hdbt)
        {
            this.heureDebutResa = hdbt;
        }

        public TimeSpan getHeureDbt()
        {
            return this.heureDebutResa;
        }

        public void setHeureFin(TimeSpan hfin)
        {
            this.heureFinResa = hfin;
        }

        public TimeSpan getHeureFin()
        {
            return this.heureFinResa;
        }
    }
}
