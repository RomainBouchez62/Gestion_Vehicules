using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_Gestion_Vehicules.Métier
{
    class BDD
    {
        private MySqlConnection connection;

        public BDD()
        {
            this.InitConnexion();
        }

        private void InitConnexion()
        {
            string connectionString = "SERVER=127.0.0.1;DATABASE=agence;UID=root;PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }


        /// <summary>
        /// Procédure qui ajoute un véhicule en bdd
        /// </summary>
        /// <param name="immat">immatriculatin du véhicule</param>
        /// <param name="DMEC">date de mise ne circulation du vehicule</param>
        public void AddV(String immat, DateTime DMEC,int idType)
        {
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "INSERT INTO vehicule(immatriculation,dateMiseEnCirculation,typeVehicule) VALUES(@immat,@dateMEC,@typeV)";

                maReq.Parameters.AddWithValue("@immat", immat);
                maReq.Parameters.AddWithValue("@dateMEC", DMEC);
                maReq.Parameters.AddWithValue("@typeV", idType);

                maReq.ExecuteNonQuery();

                this.connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        /// <summary>
        /// Procédure qui ajoute un employe en bdd
        /// </summary>
        /// <param name="nom">nom de l'employe</param>
        /// <param name="prenom">prenom de l'employe</param>
        /// <param name="sexe">sexe de l'employe</param>
        /// <param name="dateNaiss">date de naissance de l'employe</param>
        public void AddE(String nom,String prenom,bool sexe,DateTime dateNaiss)
        {
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "INSERT INTO employes(nom,prenom,sexe,dateNaissance) VALUES(@nom,@prenom,@sexe,@dateNaiss)";

                maReq.Parameters.AddWithValue("@nom", nom);
                maReq.Parameters.AddWithValue("@prenom", prenom);
                maReq.Parameters.AddWithValue("@sexe", sexe);
                maReq.Parameters.AddWithValue("@dateNaiss", dateNaiss);

                maReq.ExecuteNonQuery();

                this.connection.Close();
            }
            catch
            {

            }
        }



        /// <summary>
        /// Procédure qui ajoute une réservation en bdd
        /// </summary>
        /// <param name="idV">id du vehicule</param>
        /// <param name="idE">id de l'employe</param>
        /// <param name="dt">date de la réservation</param>
        /// <param name="hdbt">heure de début de la réservation</param>
        /// <param name="hfin">heure de fin de la réservation</param>
        public void AddReservation(int idV, int idE, DateTime dt, TimeSpan hdbt, TimeSpan hfin)
        {
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "INSERT INTO reservation(idEmploye,idVehicule,dateReservation,heureDebutReservation,heureFinReservation) " +
                    "VALUES(@idEmploye,@idVehicule,@dateReservation,@heureDebutReservation, @heureFinReservation)";

                maReq.Parameters.AddWithValue("@idEmploye", idE);
                maReq.Parameters.AddWithValue("@idVehicule", idV);
                maReq.Parameters.AddWithValue("@dateReservation", dt);
                maReq.Parameters.AddWithValue("@heureDebutReservation", hdbt);
                maReq.Parameters.AddWithValue("@heureFinReservation", hfin);

                maReq.ExecuteNonQuery();

                this.connection.Close();
            }
            catch
            {

            }
        }



        /// <summary>
        /// Fonction qui retourne l'ensemble des types de véhicules
        /// </summary>
        /// <returns>Liste de TypeVehicule</returns>
        public List<TypeVehicule> giveTypeVehicule()
        {
            List<TypeVehicule> mesTypesVehicules = new List<TypeVehicule>();
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "SELECT idTypeVehicule,nomTypeVehicule FROM typevehicule";
                maReq.ExecuteNonQuery();
                MySqlDataReader reader = maReq.ExecuteReader();

                while(reader.Read())
                {
                    String monType=reader[1].ToString();
                    String monTypeModifie = monType[0].ToString().ToUpper() + monType.Substring(1).ToLower();
                    mesTypesVehicules.Add(new TypeVehicule(int.Parse(reader[0].ToString()), monTypeModifie));
                }

                this.connection.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return mesTypesVehicules;
        }



        /// <summary>
        /// Fonction qui retourne l'ensemble des employés
        /// </summary>
        /// <returns>Liste de Employe</returns>
        public List<Employe> giveAllEmployes()
        {
            List<Employe> mesE = new List<Employe>();
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "SELECT idEmploye,nom,prenom,dateNaissance FROM employes";
                maReq.ExecuteNonQuery();
                MySqlDataReader reader = maReq.ExecuteReader();

                while (reader.Read())
                {
                    mesE.Add(new Employe(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(),DateTime.Parse(reader[3].ToString())));
                }

                this.connection.Close();
            }
            catch
            {

            }
            return mesE;
        }



        /// <summary>
        /// Fonction qui récupère l'ensemble des réservations présentes en base de données
        /// </summary>
        /// <returns></returns>
        public List<Reservation> giveAllReservations()
        {
            List<Reservation> maListeDeReservations = new List<Reservation>();
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "SELECT `idReservation`,R.`idEmploye`,R.`idVehicule`,E.nom,E.prenom,V.immatriculation," +
                    "`dateReservation`,`heureDebutReservation`,`HeureFinReservation` " +
                    "FROM `reservation` AS R " +
                    "INNER JOIN employes AS E " +
                    "ON R.idEmploye=E.idEmploye " +
                    "INNER JOIN vehicule AS V " +
                    "ON V.idVehicule=R.idVehicule";
                maReq.ExecuteNonQuery();
                MySqlDataReader reader = maReq.ExecuteReader();

                while (reader.Read())
                {
                    maListeDeReservations.Add(new Reservation(int.Parse(reader[0].ToString()), 
                        new Vehicule(int.Parse(reader[2].ToString()),reader[5].ToString()),
                        new Employe(reader[3].ToString(),reader[4].ToString()),
                        DateTime.Parse(reader[6].ToString()),
                        TimeSpan.Parse(reader[7].ToString()),
                        TimeSpan.Parse(reader[8].ToString())));
                }

                this.connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return maListeDeReservations;
        }



        public List<Vehicule> giveAllVehicules()
        {
            List<Vehicule> mesVehicules = new List<Vehicule>();
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "SELECT idVehicule,immatriculation,dateMiseEnCirculation,TV.nomTypeVehicule " +
                                    "FROM vehicule V " +
                                    "INNER JOIN typevehicule TV " +
                                    "ON V.typeVehicule=TV.idTypeVehicule";
                maReq.ExecuteNonQuery();
                MySqlDataReader reader = maReq.ExecuteReader();

                while (reader.Read())
                {
                    mesVehicules.Add(new Vehicule(int.Parse(reader[0].ToString()),reader[1].ToString(),DateTime.Parse(reader[2].ToString())));
                }

                this.connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return mesVehicules;
        }

        /// <summary>
        /// Fonction qui récupère les réservations entre deux dates 
        /// </summary>
        /// <param name="premiereDate">date de début</param>
        /// <param name="secondeDate">date de fin</param>
        /// <returns></returns>
        public List<Reservation>giveAllReservationsBetweenTwoDates(DateTime premiereDate, DateTime secondeDate)
        {
            String dt1;
            String dt2;
            
            dt1 = premiereDate.ToString("yyyy-MM-dd");
            dt2 = secondeDate.ToString("yyyy-MM-dd");
            
            List<Reservation> maListeDeReservations = new List<Reservation>();
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "SELECT `idReservation`,R.`idEmploye`,R.`idVehicule`,E.nom,E.prenom,V.immatriculation," +
                    "`dateReservation`,`heureDebutReservation`,`HeureFinReservation` " +
                    "FROM `reservation` AS R " +
                    "INNER JOIN employes AS E " +
                    "ON R.idEmploye=E.idEmploye " +
                    "INNER JOIN vehicule AS V " +
                    "ON V.idVehicule=R.idVehicule "+
                    "WHERE dateReservation "+
                    "BETWEEN @firstDate AND @secondDate";

                maReq.Parameters.AddWithValue("@firstDate", dt1);
                maReq.Parameters.AddWithValue("@secondDate",dt2);
                Console.WriteLine(maReq);
                maReq.ExecuteNonQuery();
                MySqlDataReader reader = maReq.ExecuteReader();

                while (reader.Read())
                {
                    maListeDeReservations.Add(new Reservation(int.Parse(reader[0].ToString()),
                        new Vehicule(int.Parse(reader[2].ToString()), reader[5].ToString()),
                        new Employe(reader[3].ToString(), reader[4].ToString()),
                        DateTime.Parse(reader[6].ToString()),
                        TimeSpan.Parse(reader[7].ToString()),
                        TimeSpan.Parse(reader[8].ToString())));
                }

                this.connection.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return maListeDeReservations;
        }



        /// <summary>
        /// Fonction qui récupère l'ensemble des réservations qui concerne un employé et un véhicule
        /// </summary>
        /// <param name="idE">Objet Employe</param>
        /// <param name="idV">Objet Vehicule</param>
        /// <returns>Liste de réservations</returns>
        public List<Reservation> giveAllReservationsEmployesAndVehicules(int idE,int idV)
        {
            List<Reservation>mesResaEmploysVehicules = new List<Reservation>();
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "SELECT `idReservation`,R.`idEmploye`,R.`idVehicule`,E.nom,E.prenom,V.immatriculation," +
                    "`dateReservation`,`heureDebutReservation`,`HeureFinReservation` " +
                    "FROM `reservation` AS R " +
                    "INNER JOIN employes AS E " +
                    "ON R.idEmploye=E.idEmploye " +
                    "INNER JOIN vehicule AS V " +
                    "ON V.idVehicule=R.idVehicule " +
                    "WHERE R.`idEmploye`=@idEmploye AND R.idVehicule=@idVehicule";

                maReq.Parameters.AddWithValue("@idEmploye", idE);
                maReq.Parameters.AddWithValue("@idVehicule", idV);
                
                maReq.ExecuteNonQuery();
                MySqlDataReader reader = maReq.ExecuteReader();

                while (reader.Read())
                {
                    mesResaEmploysVehicules.Add(new Reservation(int.Parse(reader[0].ToString()),
                        new Vehicule(int.Parse(reader[2].ToString()), reader[5].ToString()),
                        new Employe(reader[3].ToString(), reader[4].ToString()),
                        DateTime.Parse(reader[6].ToString()),
                        TimeSpan.Parse(reader[7].ToString()),
                        TimeSpan.Parse(reader[8].ToString())));
                }

                this.connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return mesResaEmploysVehicules;
        }



        /// <summary>
        /// Fonction qui récupère la liste des vehicules présent en base de données
        /// </summary>
        /// <returns>Liste de Vehicule</returns>
        public List<Vehicule>rempliComboBoxVehicules()
        {
            List<Vehicule> mesV = new List<Vehicule>();
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "SELECT idVehicule,immatriculation FROM vehicule";
                maReq.ExecuteNonQuery();
                MySqlDataReader reader = maReq.ExecuteReader();

                while (reader.Read())
                {
                    mesV.Add(new Vehicule(int.Parse(reader[0].ToString()),reader[1].ToString()));
                }

                this.connection.Close();
            }
            catch
            {

            }
            return mesV;
        }

        
        /// <summary>
        /// Fonction qui verifie la présence ou non d'une réservation recue en paramètre
        /// </summary>
        /// <param name="unV">Objet Vehicule</param>
        /// <param name="unE">Objet Employe</param>
        /// <param name="dtResa">date de réservation</param>
        /// <param name="hdbt">heure de debut</param>
        /// <param name="hfin">heure de fin</param>
        /// <returns>true/false</returns>
        public bool etatReservation(Vehicule unV, Employe unE, DateTime dtResa, TimeSpan hdbt, TimeSpan hfin)
        {
            String recup = "";
            bool possible = true;
            String DateModif = dtResa.ToString("yyyy-MM-dd");
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "SELECT COUNT(*) " +
                                    "FROM `reservation` " +
                                    "WHERE idEmploye=@idEmp " +
                                    "AND idVehicule=@idVeh "+
                                    "AND dateReservation=@dtResa " +
                                    "AND heureDebutReservation=@heuredbt " +
                                    "AND HeureFinReservation=@heurefin";

                maReq.Parameters.AddWithValue("@idEmp", unE.getId());
                maReq.Parameters.AddWithValue("@idVeh", unV.getId());
                maReq.Parameters.AddWithValue("@dtResa", DateModif);
                maReq.Parameters.AddWithValue("@heuredbt", hdbt);
                maReq.Parameters.AddWithValue("@heurefin", hfin);
                maReq.ExecuteNonQuery();
                Console.WriteLine(maReq);
                MySqlDataReader reader = maReq.ExecuteReader();

                while (reader.Read())
                {
                    recup = reader[0].ToString();
                    Console.WriteLine(reader[0]);
                    if(recup!="0")
                    {
                        possible = false;
                    }
                }

                this.connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return possible;
        }



        /// <summary>
        /// Fonction qui verifie la présence ou non d'un employé recu en paramètre
        /// </summary>
        /// <param name="unE">Objet Employe</param>
        /// <returns>true/false</returns>
        public bool verifPresenceEmploye(Employe unE)
        {
            bool present=false;
            String recup = "";
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();
                String date = unE.getDateNaiss().ToString("yyyy-MM-dd");
                maReq.CommandText = "SELECT COUNT(*) " +
                                    "FROM employes "+
                                    "WHERE nom=@nom "+
                                    "AND prenom=@prenom "+
                                    "AND dateNaissance=@dateNaiss";

                maReq.Parameters.AddWithValue("@nom", unE.getNom());
                maReq.Parameters.AddWithValue("@prenom", unE.getPrenom());
                maReq.Parameters.AddWithValue("@dateNaiss", date);
                maReq.ExecuteNonQuery();
                Console.WriteLine(maReq);
                MySqlDataReader reader = maReq.ExecuteReader();

                while (reader.Read())
                {
                    recup = reader[0].ToString();
                    Console.WriteLine(reader[0]);
                    if (recup != "0")
                    {
                        present = true;
                    }
                }

                this.connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return present;
        }

        public void deleteEmploye(Employe unE)
        {
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "DELETE FROM employes "+
                                    "WHERE nom=@nomEmp "+
                                    "AND prenom=@prenomEmp " +
                                    "AND dateNaissance=@dtNaiss";

                maReq.Parameters.AddWithValue("@nomEmp", unE.getNom());
                maReq.Parameters.AddWithValue("@prenomEmp", unE.getPrenom());
                maReq.Parameters.AddWithValue("@dtNaiss", unE.getDateNaiss());

                maReq.ExecuteNonQuery();
                
                this.connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void deleteVehicule(Vehicule unV)
        {
            try
            {
                this.connection.Open();
                MySqlCommand maReq = this.connection.CreateCommand();

                maReq.CommandText = "DELETE FROM employes " +
                                    "WHERE nom=@nomEmp " +
                                    "AND prenom=@prenomEmp " +
                                    "AND dateNaissance=@dtNaiss";

                maReq.Parameters.AddWithValue("@nomEmp", unV.getImmat());
                maReq.Parameters.AddWithValue("@prenomEmp", unV.getDateMEC());

                maReq.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
