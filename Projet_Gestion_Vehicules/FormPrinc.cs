using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Projet_Gestion_Vehicules.Métier;

namespace Projet_Gestion_Vehicules
{
    public partial class formPrinc : Form
    {
        AddVehicules secondForm;
        AddEmployes thirdForm;

        //Initialisation et instanciation d'une connexion à la base
        BDD uneCo = new BDD();
        public formPrinc()
        {
            InitializeComponent();
        }

        private void BtnAddEmployes_Click(object sender, EventArgs e)
        {
            thirdForm = new AddEmployes();
            thirdForm.ShowDialog(this);
        }

        private void BtnAddVehicules_Click(object sender, EventArgs e)
        {
            secondForm = new AddVehicules();
            secondForm.ShowDialog(this);
        }

        private void FormPrinc_Load(object sender, EventArgs e)
        {
            //############################# REMPLISSAGE DATA GRID VIEW EMPLOYE ###################################
            //dtGVEmployes.ColumnCount = 1;
            //BindingSource unBDS = new BindingSource();

            LoadDtgEmploye();
            //dtGVEmployes.Columns[0].Name = "Nom";
            //dtGVEmployes.DataSource = unBDS;
            //######################## FIN REMPLISSAGE ###################################

            //############################# REMPLISSAGE DATA GRID VIEW RESERVATION ###################################
            LoadDtgReservation();
            //######################## FIN REMPLISSAGE ###################################

            //############################# REMPLISSAGE COMBOBOX EMPLOYE ################################
            LoadCmbEmploye();
            //######################## FIN REMPLISSAGE #################################

            //############################# REMPLISSAGE COMBOBOX VEHICULE ################################
            LoadCmbVehicule();
            //######################## FIN REMPLISSAGE #################################

            //############################# REMPLISSAGE COMBOBOX TYPE_VEHICULE ################################
            LoadCmbTypeVehicule();
            //######################## FIN REMPLISSAGE #################################

            List<String> mesH = new List<string>();
            mesH = ListingHeures();
            for(int i=0;i<mesH.Count;i++)
            {
                cmbListingHeureDbt.Items.Add(mesH[i]);
                cmbListingHeureFin.Items.Add(mesH[i]);
            }

            List<String> mesM = new List<string>();
            mesM = ListingMinutes();
            for (int i = 0; i < mesM.Count; i++)
            {
                cmbListingMinuteDbt.Items.Add(mesM[i]);
                cmbListingMinuteFin.Items.Add(mesM[i]);
                //cmbListingHeureFin.Items.Add(mesH[i]);
            }
        }

        /// <summary>
        /// procédure qui rempli le datagridview des employes
        /// </summary>
        public void LoadDtgEmploye()
        {
            dtGVEmployes.Rows.Clear();
            dtGVEmployes.Refresh();
            List<Employe> mesE = new List<Employe>();

            mesE = uneCo.giveAllEmployes();

            foreach (Employe unE in mesE)
            {
                dtGVEmployes.Rows.Add(unE.getNom(), unE.getPrenom(), unE.getDateNaiss().ToString("dd-MM-yyyy"));
            }
        }

        /// <summary>
        /// procédure qui rempli le datagridview des réservations
        /// </summary>
        public void LoadDtgReservation()
        {
            clearDGV();
            List<Reservation> mesR = new List<Reservation>();

            mesR = uneCo.giveAllReservations();

            foreach (Reservation unR in mesR)
            {
                dtGVConsultationGlobaleReservation.Rows.Add(unR.getIdResa(), unR.getIdEmploye().getNom()+" "+unR.getIdEmploye().getPrenom(), 
                    unR.getIdVehicule().getImmat(), unR.getDateResa().ToString("dd-MM-yyyy"), unR.getHeureDbt(), unR.getHeureFin());
            }
        }

        /// <summary>
        /// Procédure qui rempli le combobox des types de vehicules
        /// </summary>
        public void LoadCmbTypeVehicule()
        {
            List<TypeVehicule> mesTypesV = new List<TypeVehicule>();
            mesTypesV = uneCo.giveTypeVehicule();
            comboTypeVehicule.Items.Clear();
            foreach (TypeVehicule unTV in mesTypesV)
            {
                comboTypeVehicule.Items.Add(unTV.toString());
            }
        }

        /// <summary>
        /// Procédure qui rempli le combobox des vehiicules
        /// </summary>
        public void LoadCmbVehicule()
        {
            List<Vehicule> mesVehicules = new List<Vehicule>();
            mesVehicules = uneCo.rempliComboBoxVehicules();
            cmbListingVehicule.Items.Clear();
            foreach (Vehicule unV in mesVehicules)
            {
                cmbListingVehicule.ValueMember = unV.getId().ToString();
                cmbListingVehicule.Items.Add(unV.getImmat());
                cmbListingVehiculeReservation.ValueMember = unV.getId().ToString();
                cmbListingVehiculeReservation.Items.Add(unV.getImmat());
            }
        }

        /// <summary>
        /// Procédure qui rempli le combobox des employe pour la creation et la consultation de réservation
        /// </summary>
        public void LoadCmbEmploye()
        {
            List<Employe> mesEmployes = new List<Employe>();
            mesEmployes = uneCo.giveAllEmployes();
            cmbListingEmploye.Items.Clear();
            foreach (Employe unE in mesEmployes)
            {
                //cmb création réservation
                cmbListingEmploye.ValueMember = unE.getId().ToString();
                cmbListingEmploye.Items.Add(unE.getNom() + " - " + unE.getPrenom());

                //cmb consultation réservation
                cmbListingEmployeReservation.ValueMember = unE.getId().ToString();
                cmbListingEmployeReservation.Items.Add(unE.getNom() + " - " + unE.getPrenom());
            }
        }

        /// <summary>
        /// Fonction qui liste des heures dans un intervalle
        /// </summary>
        /// <returns>Liste de string qui contient des heures</returns>
        public List<String> ListingHeures()
        {
            List<String> mesHoraires = new List<string>();
            int heuresDbt = 8;
            while (heuresDbt <= 17)
            {
                mesHoraires.Add(heuresDbt.ToString());
                //mesHoraires.Add(heuresDbt.ToString() + "h30");
                heuresDbt += 1;
            }
            return mesHoraires;
        }

        /// <summary>
        /// Fonction qui liste des minutes dans un intervalle
        /// </summary>
        /// <returns>Liste de string qui contient des minutes</returns>
        public List<String> ListingMinutes()
        {
            List<String> mesMinutes = new List<string>();
            int heuresDbt = 00;
            while (heuresDbt <= 45)
            {
                mesMinutes.Add(heuresDbt.ToString());
                heuresDbt += 15;
            }
            return mesMinutes;
        }

        /// <summary>
        /// Procédure qui vide et redessine le datagridview des reservations
        /// </summary>
        public void clearDGV()
        {
            dtGVConsultationGlobaleReservation.Rows.Clear();
            dtGVConsultationGlobaleReservation.Refresh();
        }

        private void btnResa_Click(object sender, EventArgs e)
        {
            int indexHeureDbt, indexHeureFin, indexMinuteDbt, indexMinuteFin;

            indexHeureDbt = cmbListingHeureDbt.SelectedIndex;
            indexHeureFin = cmbListingHeureFin.SelectedIndex;

            indexMinuteDbt = cmbListingMinuteDbt.SelectedIndex;
            indexMinuteFin = cmbListingMinuteFin.SelectedIndex;

            //Variable servant à gérer l'avancement des validations
            //Passe à false lorsque une erreur est rencontrée
            bool verif = true;

            //Verif que chaque champs de saisie n'est pas vide
            if (cmbListingVehicule.SelectedItem==null || cmbListingEmploye.SelectedItem == null || cmbListingHeureDbt.SelectedItem == null || cmbListingHeureFin.SelectedItem == null ||cmbListingMinuteDbt.SelectedItem==null || cmbListingMinuteFin.SelectedItem==null)
            {
                verif = false;
                MessageBox.Show("Veuillez remplir tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                verif = true;
            }

            //Verif date choisie est égale ou supérieur à la date du jour
            //TODO

            //Verif heure pas egale
            //TODO

            //Verif que heure debut est inf a heure fin
            if (verif && indexHeureDbt > indexHeureFin)
            {
                verif = false;
                MessageBox.Show("Erreur dans la séléction des horaires ! L'heure de début ne peux pas étre supérieur à l'heure de fin !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
            }

            //Verif : si les heures sélectionnées sont identiques alors s'assurer que les minutes debut ne sont pas supérieurs aux minutes fin
            // Exemple : Saisie heure debut : 9h45 || saisie heure fin : 9h15
            //Impossible car pas dans le bon ordre
            if (verif && indexHeureDbt == indexHeureFin)
            {
                if (indexMinuteDbt > indexMinuteFin)
                {
                    MessageBox.Show("Erreur dans la séléction des horaires ! ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verif = false;
                }
            }

            if(verif)
            {
                //Verif de la possibilité de réservation
                if (uneCo.etatReservation(new Vehicule(int.Parse(cmbListingVehicule.DisplayMember.ToString())), new Employe(int.Parse(cmbListingEmploye.DisplayMember.ToString())), dtDateResa.Value, new TimeSpan(int.Parse(cmbListingHeureDbt.Text), int.Parse(cmbListingMinuteDbt.Text), 00), new TimeSpan(int.Parse(cmbListingHeureFin.Text), int.Parse(cmbListingMinuteFin.Text), 00)) == false)
                {
                    MessageBox.Show("Une réservation est déjà existante !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Inscription de la réservation
                    Reservation uneResa = new Reservation();

                    uneResa.setIdEmploye(new Employe(int.Parse(cmbListingEmploye.DisplayMember.ToString())));
                    uneResa.setIdVehicule(new Vehicule(int.Parse(cmbListingVehicule.DisplayMember.ToString())));
                    uneResa.setDateResa(dtDateResa.Value);
                    uneResa.setHeureDbt(new TimeSpan(int.Parse(cmbListingHeureDbt.Text), int.Parse(cmbListingMinuteDbt.Text), 00));
                    uneResa.setHeureFin(new TimeSpan(int.Parse(cmbListingHeureFin.Text), int.Parse(cmbListingMinuteFin.Text), 00));
                    uneCo.AddReservation(uneResa.getIdVehicule().getId(), uneResa.getIdEmploye().getId(), uneResa.getDateResa(), uneResa.getHeureDbt(), uneResa.getHeureFin());
                    MessageBox.Show("Réservation effectuée avec succès !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDtgReservation();
                    //Remise à zéro des champs de saisie
                    cmbListingVehicule.Text = "";
                    cmbListingEmploye.Text = "";
                    cmbListingHeureDbt.Text = "";
                    cmbListingHeureFin.Text = "";
                    cmbListingMinuteDbt.Text = "";
                    cmbListingMinuteFin.Text = "";
                }
            }
        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            if (txtBoxNom.Text == "" || txtBoxPrenom.Text == "")
            {
                MessageBox.Show("Impossible de créer un employé. Tout les champs doivent être remplis !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Employe unE = new Employe();
                if (rdFeminin.Checked)
                {
                    unE.setSexe(false);
                }
                else
                {
                    unE.setSexe(true);
                }

                //Attribution des valeurs à l'meployé créer précédemment
                unE.setNom(txtBoxNom.Text);
                unE.setPrenom(txtBoxPrenom.Text[0].ToString().ToUpper() + txtBoxPrenom.Text.Substring(1).ToLower());
                unE.setDateNaiss(dtDateNaiss.Value);
                
                //verif existence 
                bool verif;
                verif=uneCo.verifPresenceEmploye(unE);
                if(verif==false)
                {
                    uneCo.AddE(unE.getNom(), unE.getPrenom(), unE.getSexe(), unE.getDateNaiss());
                    MessageBox.Show("Employé inséré avec succès !","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtBoxNom.Text = "";
                    txtBoxPrenom.Text = "";
                    LoadDtgEmploye();
                }
                else
                {
                    MessageBox.Show("Inscripiton impossible employé déjà existant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnCreaVehicules_Click(object sender, EventArgs e)
        {
            if (txtBoxImmat.Text == "" || comboTypeVehicule.SelectedItem == null)
            {
                MessageBox.Show("Impossible de créer ce véhicule. Veuillez remplir tout les champs !","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //TODO Ajouter type véhicule
                Vehicule unV = new Vehicule(txtBoxImmat.Text, datePickerMEC.Value);
                uneCo.AddV(unV.getImmat(), unV.getDateMEC());
                MessageBox.Show("Véhicule inséré ! ");
                txtBoxImmat.Text = "";
                comboTypeVehicule.Text = "";
            }
        }

        private void btnRechercheEntreDeuxDates_Click(object sender, EventArgs e)
        {
            clearDGV();
            List<Reservation> mesR = new List<Reservation>();
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            date1 = dtPremiereDate.Value;
            date2 = dtSecondeDate.Value;

            //MessageBox.Show(date1.ToString("yyyyMMdd")+" "+date2.ToString("yyyyMMdd"), "Dates");


            mesR = uneCo.giveAllReservationsBetweenTwoDates(date1,date2);

            foreach (Reservation unR in mesR)
            {
                dtGVConsultationGlobaleReservation.Rows.Add(unR.getIdResa(), unR.getIdEmploye().getNom() + " " + unR.getIdEmploye().getPrenom(),
                    unR.getIdVehicule().getImmat(), unR.getDateResa().ToString("dd-MM-yyyy"), unR.getHeureDbt(), unR.getHeureFin());
            }
        }

        private void btnRechercheEmployeEtVehicule_Click(object sender, EventArgs e)
        {
            clearDGV();
            int idE, idV;
            idE = int.Parse(cmbListingEmployeReservation.DisplayMember.ToString());
            idV = int.Parse(cmbListingVehiculeReservation.DisplayMember.ToString());
            List<Reservation> mesResaEmpVeh = new List<Reservation>();

            mesResaEmpVeh = uneCo.giveAllReservationsEmployesAndVehicules(idE, idV);
            foreach (Reservation unR in mesResaEmpVeh)
            {
                dtGVConsultationGlobaleReservation.Rows.Add(unR.getIdResa(), unR.getIdEmploye().getNom() + " " + unR.getIdEmploye().getPrenom(),
                    unR.getIdVehicule().getImmat(), unR.getDateResa().ToString("dd-MM-yyyy"), unR.getHeureDbt(), unR.getHeureFin());
            }
        }

        private void btnReInit_Click(object sender, EventArgs e)
        {
            LoadDtgReservation();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dtGVConsultationGlobaleReservation.Rows.Count>0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch(IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show(ex.Message);

                        }
                    }
                    if(!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtGVConsultationGlobaleReservation.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            
                            foreach(DataGridViewColumn column in dtGVConsultationGlobaleReservation.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach(DataGridViewRow row in dtGVConsultationGlobaleReservation.Rows)
                            {
                                foreach(DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName,FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.AddTitle("Export de données");
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Données exportées avec succès !", "Info");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Erreur : " + ex);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Données non exportées !!", "Erreur");
            }
        }

        private void txtBoxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSupprEmploye_Click(object sender, EventArgs e)
        {
            String index = dtGVEmployes.CurrentRow.ToString();
        }

        private void tabVehicules_Click(object sender, EventArgs e)
        {

        }
    }
}
