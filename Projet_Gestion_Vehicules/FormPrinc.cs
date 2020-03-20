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
        //AddVehicules secondForm;
        //AddEmployes thirdForm;

        //Initialisation et instanciation d'une connexion à la base
        BDD uneCo = new BDD();
        public formPrinc()
        {
            InitializeComponent();
        }

        private void BtnAddEmployes_Click(object sender, EventArgs e)
        {
            //thirdForm = new AddEmployes();
            //thirdForm.ShowDialog(this);
        }

        private void BtnAddVehicules_Click(object sender, EventArgs e)
        {
            //secondForm = new AddVehicules();
            //secondForm.ShowDialog(this);
        }

        private void FormPrinc_Load(object sender, EventArgs e)
        {
            //############################# REMPLISSAGE DATA GRID VIEW EMPLOYE ##########################
            LoadDtgEmploye();
            //######################## FIN REMPLISSAGE ###################################

            //############################# REMPLISSAGE DATA GRID VIEW RESERVATION ######################
            LoadDtgReservation();
            //######################## FIN REMPLISSAGE ###################################

            //############################# REMPLISSAGE DATA GRID VIEW VEHICULES ########################
            LoadDtgVehicules();
            //######################## FIN REMPLISSAGE ###################################

            //############################# REMPLISSAGE COMBOBOX EMPLOYE ################################
            LoadCmbEmploye();
            //######################## FIN REMPLISSAGE #################################

            //############################# REMPLISSAGE COMBOBOX VEHICULE ###############################
            LoadCmbVehicule();
            //######################## FIN REMPLISSAGE #################################

            //############################# REMPLISSAGE COMBOBOX TYPE_VEHICULE ##########################
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
        ///  procédure qui rempli le datagridview des véhicules
        /// </summary>
        public void LoadDtgVehicules()
        {
            dtGVVehicules.Rows.Clear();
            dtGVVehicules.Refresh();
            List<Vehicule> mesE = new List<Vehicule>();

            mesE = uneCo.giveAllVehicules();

            foreach (Vehicule unV in mesE)
            {
                dtGVVehicules.Rows.Add(unV.getImmat(),unV.getDateMEC().ToString("dd-MM-yyyy"));
            }
        }
        /// <summary>
        /// Procédure qui rempli le combobox des types de vehicules
        /// </summary>
        public void LoadCmbTypeVehicule()
        {
            List<TypeVehicule> mesTypesV = new List<TypeVehicule>();
            mesTypesV = uneCo.giveTypeVehicule();
            cmbTypeVehicule.Items.Clear();
            foreach (TypeVehicule unTV in mesTypesV)
            {
                cmbTypeVehicule.ValueMember = unTV.getId().ToString();
                cmbTypeVehicule.Items.Add(unTV.getNom());
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

            //Verif que la date choisie est égale ou supérieur à la date du jour
            DateTime dateDuJour = new DateTime();
            dateDuJour = DateTime.Today;
            if(verif && dtDateResa.Value<dateDuJour)
            {
                MessageBox.Show("La date de réservation ne peut pas être inférieur à  la date du jour !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verif = false;
            }
            else
            {

            }


            //Verif que les heures de début et de fin ne sont pas identiques
            TimeSpan heureDbt = new TimeSpan(int.Parse(cmbListingHeureDbt.Text), int.Parse(cmbListingMinuteDbt.Text), 00);
            TimeSpan heureFin = new TimeSpan(int.Parse(cmbListingHeureFin.Text), int.Parse(cmbListingMinuteFin.Text), 00);
            if(verif && TimeSpan.Compare(heureDbt,heureFin)==0)
            {
                verif = false;
                MessageBox.Show("Erreur dans la séléction des horaires ! L'heure de début ne peux pas être identique à l'heure de fin !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }

            //Verif que l'heure de debut est inferieure a l'heure de fin
            if (verif && indexHeureDbt > indexHeureFin)
            {
                verif = false;
                MessageBox.Show("Erreur dans la séléction des horaires ! L'heure de début ne peux pas être supérieur à l'heure de fin !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DateTime dtResa = new DateTime();
                    dtResa = dtDateResa.Value;
                    uneResa.setIdEmploye(new Employe(int.Parse(cmbListingEmploye.DisplayMember.ToString())));
                    uneResa.setIdVehicule(new Vehicule(int.Parse(cmbListingVehicule.DisplayMember.ToString())));
                    uneResa.setDateResa(dtDateResa.Value);
                    
                    uneResa.setHeureDbt(new TimeSpan(int.Parse(cmbListingHeureDbt.Text), int.Parse(cmbListingMinuteDbt.Text), 00));
                    uneResa.setHeureDbt(new TimeSpan(int.Parse(cmbListingHeureDbt.Text), int.Parse(cmbListingMinuteDbt.Text), 00));
                    uneResa.setHeureFin(new TimeSpan(int.Parse(cmbListingHeureFin.Text), int.Parse(cmbListingMinuteFin.Text), 00));
                    uneCo.AddReservation(uneResa.getIdVehicule().getId(), uneResa.getIdEmploye().getId(), uneResa.getDateResa(), uneResa.getHeureDbt(), uneResa.getHeureFin());
                    MessageBox.Show("Réservation effectuée avec succès !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshAll();
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
                    refreshAll();
                }
                else
                {
                    MessageBox.Show("Inscripiton impossible employé déjà existant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnCreaVehicules_Click(object sender, EventArgs e)
        {
            if (txtBoxImmat.Text == "" || cmbTypeVehicule.SelectedItem == null)
            {
                MessageBox.Show("Impossible de créer ce véhicule. Veuillez remplir tout les champs !","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                MessageBox.Show(cmbTypeVehicule.DisplayMember.ToString());
                Vehicule unV = new Vehicule(txtBoxImmat.Text, datePickerMEC.Value,new TypeVehicule(int.Parse(cmbTypeVehicule.DisplayMember.ToString())));
                uneCo.AddV(unV.getImmat(), unV.getDateMEC(), unV.getTypeV().getId());
                MessageBox.Show("Véhicule inséré ! ");
                txtBoxImmat.Text = "";
                cmbTypeVehicule.Text = "";
                refreshAll();
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
            int rowIndex = dtGVEmployes.CurrentCell.RowIndex;
            String nomEploye = dtGVEmployes.Rows[rowIndex].Cells[0].Value.ToString();
            String prenomEmploye = dtGVEmployes.Rows[rowIndex].Cells[1].Value.ToString();
            String dateNaissanceEmploye = dtGVEmployes.Rows[rowIndex].Cells[2].Value.ToString();
            Employe employeASupprimer = new Employe(nomEploye, prenomEmploye, DateTime.Parse(dateNaissanceEmploye));
            
            var result = MessageBox.Show("Etes-vous sur de vouloir supprimés l'employé : " + nomEploye + " " + prenomEmploye + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result== DialogResult.Yes)
            {
                uneCo.deleteEmploye(employeASupprimer);
                MessageBox.Show("Employé supprimé avec succès !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshAll();
        }

        private void tabVehicules_Click(object sender, EventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Feuil1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dtGVConsultationGlobaleReservation.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtGVConsultationGlobaleReservation.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtGVConsultationGlobaleReservation.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtGVConsultationGlobaleReservation.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtGVConsultationGlobaleReservation.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void btnSupprVehicule_Click(object sender, EventArgs e)
        {
            int rowIndex = dtGVVehicules.CurrentCell.RowIndex;
            String immat = dtGVVehicules.Rows[rowIndex].Cells[0].Value.ToString();
            DateTime DMEC = DateTime.Parse(dtGVVehicules.Rows[rowIndex].Cells[1].Value.ToString());
            Vehicule vehiculeASupprr = new Vehicule(immat,DMEC);

            var result = MessageBox.Show("Etes-vous sur de vouloir supprimés le véhicule : " + immat + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                uneCo.deleteVehicule(vehiculeASupprr);
                MessageBox.Show("Véhicule supprimé avec succès !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshAll();
        }

        /// <summary>
        /// Procédure qui permet de "rafraichir" tout les composants affichant des données de la base
        /// </summary>
        public void refreshAll()
        {
            LoadCmbEmploye();
            LoadCmbTypeVehicule();
            LoadCmbVehicule();
            LoadDtgEmploye();
            LoadDtgReservation();
            LoadDtgVehicules();
        }
    }
}
