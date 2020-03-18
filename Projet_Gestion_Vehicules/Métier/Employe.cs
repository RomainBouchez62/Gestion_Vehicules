using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_Vehicules.Métier
{
    class Employe
    {
        private int id;

        private String nom;

        private String prenom;

        private bool Sexe;

        private DateTime DateNaissance;

        public Employe()
        { }

        public Employe(int id)
        {
            this.id = id;
        }

        public Employe(String n, String p)
        {
            this.nom = n;
            this.prenom = p;
        }

        public Employe(int id,String n,String p,DateTime dtn)
        {
            this.id = id;
            this.nom = n;
            this.prenom = p;
            this.DateNaissance = dtn;
        }

        public Employe(String n, String p, DateTime dtN)
        {
            this.nom = n;
            this.prenom = p;
            this.DateNaissance = dtN;
        }

        public Employe(String n, String p, bool s,DateTime dn)
        {
            this.nom = n;
            this.prenom = p;
            this.Sexe = s;
            this.DateNaissance = dn;
        }

        public void setNom(String unN)
        {
            this.nom = unN;
        }

        public void setPrenom(String unP)
        {
            this.prenom = unP;
        }

        public void setSexe(bool unS)
        {
            this.Sexe = unS;
        }

        public void setDateNaiss(DateTime uneDN)
        {
            this.DateNaissance = uneDN;
        }

        public int getId()
        {
            return this.id;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public bool getSexe()
        {
            return this.Sexe;
        }

        public DateTime getDateNaiss()
        {
            return this.DateNaissance;
        }

        public String toString()
        {
            return this.nom + " " + this.prenom + " " + this.Sexe + " " + this.DateNaissance;
        }

    }
}
