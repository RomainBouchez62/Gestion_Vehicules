namespace Projet_Gestion_Vehicules
{
    partial class formPrinc
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Onglets = new System.Windows.Forms.TabControl();
            this.tabEmployes = new System.Windows.Forms.TabPage();
            this.btnSupprEmploye = new System.Windows.Forms.Button();
            this.dtGVEmployes = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpSexe = new System.Windows.Forms.GroupBox();
            this.rdMasculin = new System.Windows.Forms.RadioButton();
            this.rdFeminin = new System.Windows.Forms.RadioButton();
            this.btnAddEmploye = new System.Windows.Forms.Button();
            this.dtDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabVehicules = new System.Windows.Forms.TabPage();
            this.comboTypeVehicule = new System.Windows.Forms.ComboBox();
            this.datePickerMEC = new System.Windows.Forms.DateTimePicker();
            this.btnCreaVehicules = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxImmat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddEmployes = new System.Windows.Forms.Button();
            this.tabResa = new System.Windows.Forms.TabPage();
            this.cmbListingMinuteFin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbListingMinuteDbt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmrpunt = new System.Windows.Forms.Label();
            this.cmbListingVehicule = new System.Windows.Forms.ComboBox();
            this.btnResa = new System.Windows.Forms.Button();
            this.cmbListingHeureFin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbListingHeureDbt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateResa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbListingEmploye = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tabRecap = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReInit = new System.Windows.Forms.Button();
            this.btnRechercheEmployeEtVehicule = new System.Windows.Forms.Button();
            this.cmbListingVehiculeReservation = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbListingEmployeReservation = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRechercheEntreDeuxDates = new System.Windows.Forms.Button();
            this.dtSecondeDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtPremiereDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtGVConsultationGlobaleReservation = new System.Windows.Forms.DataGridView();
            this.NumRésa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImmatVehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateResa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heuredbt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heurefin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Onglets.SuspendLayout();
            this.tabEmployes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVEmployes)).BeginInit();
            this.gpSexe.SuspendLayout();
            this.tabVehicules.SuspendLayout();
            this.tabResa.SuspendLayout();
            this.tabRecap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVConsultationGlobaleReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // Onglets
            // 
            this.Onglets.Controls.Add(this.tabEmployes);
            this.Onglets.Controls.Add(this.tabVehicules);
            this.Onglets.Controls.Add(this.tabResa);
            this.Onglets.Controls.Add(this.tabRecap);
            this.Onglets.Location = new System.Drawing.Point(9, 10);
            this.Onglets.Margin = new System.Windows.Forms.Padding(2);
            this.Onglets.Name = "Onglets";
            this.Onglets.SelectedIndex = 0;
            this.Onglets.Size = new System.Drawing.Size(866, 406);
            this.Onglets.TabIndex = 0;
            // 
            // tabEmployes
            // 
            this.tabEmployes.BackColor = System.Drawing.Color.Silver;
            this.tabEmployes.Controls.Add(this.btnSupprEmploye);
            this.tabEmployes.Controls.Add(this.dtGVEmployes);
            this.tabEmployes.Controls.Add(this.gpSexe);
            this.tabEmployes.Controls.Add(this.btnAddEmploye);
            this.tabEmployes.Controls.Add(this.dtDateNaiss);
            this.tabEmployes.Controls.Add(this.txtBoxPrenom);
            this.tabEmployes.Controls.Add(this.txtBoxNom);
            this.tabEmployes.Controls.Add(this.label7);
            this.tabEmployes.Controls.Add(this.label8);
            this.tabEmployes.Controls.Add(this.label9);
            this.tabEmployes.Controls.Add(this.label10);
            this.tabEmployes.Controls.Add(this.label11);
            this.tabEmployes.Location = new System.Drawing.Point(4, 22);
            this.tabEmployes.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmployes.Name = "tabEmployes";
            this.tabEmployes.Padding = new System.Windows.Forms.Padding(2);
            this.tabEmployes.Size = new System.Drawing.Size(858, 380);
            this.tabEmployes.TabIndex = 0;
            this.tabEmployes.Text = "Gestion des employés";
            // 
            // btnSupprEmploye
            // 
            this.btnSupprEmploye.BackColor = System.Drawing.Color.Red;
            this.btnSupprEmploye.Location = new System.Drawing.Point(314, 344);
            this.btnSupprEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprEmploye.Name = "btnSupprEmploye";
            this.btnSupprEmploye.Size = new System.Drawing.Size(109, 34);
            this.btnSupprEmploye.TabIndex = 24;
            this.btnSupprEmploye.Text = "Supprimer cet employé";
            this.btnSupprEmploye.UseVisualStyleBackColor = false;
            this.btnSupprEmploye.Click += new System.EventHandler(this.btnSupprEmploye_Click);
            // 
            // dtGVEmployes
            // 
            this.dtGVEmployes.AllowUserToAddRows = false;
            this.dtGVEmployes.AllowUserToDeleteRows = false;
            this.dtGVEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prénom,
            this.DateNaissance});
            this.dtGVEmployes.Location = new System.Drawing.Point(315, 54);
            this.dtGVEmployes.Margin = new System.Windows.Forms.Padding(2);
            this.dtGVEmployes.Name = "dtGVEmployes";
            this.dtGVEmployes.ReadOnly = true;
            this.dtGVEmployes.RowHeadersWidth = 51;
            this.dtGVEmployes.RowTemplate.Height = 24;
            this.dtGVEmployes.Size = new System.Drawing.Size(426, 286);
            this.dtGVEmployes.TabIndex = 23;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 125;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.MinimumWidth = 6;
            this.Prénom.Name = "Prénom";
            this.Prénom.ReadOnly = true;
            this.Prénom.Width = 125;
            // 
            // DateNaissance
            // 
            this.DateNaissance.HeaderText = "Date de naissance";
            this.DateNaissance.MinimumWidth = 6;
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.ReadOnly = true;
            this.DateNaissance.Width = 125;
            // 
            // gpSexe
            // 
            this.gpSexe.Controls.Add(this.rdMasculin);
            this.gpSexe.Controls.Add(this.rdFeminin);
            this.gpSexe.Location = new System.Drawing.Point(122, 162);
            this.gpSexe.Margin = new System.Windows.Forms.Padding(2);
            this.gpSexe.Name = "gpSexe";
            this.gpSexe.Padding = new System.Windows.Forms.Padding(2);
            this.gpSexe.Size = new System.Drawing.Size(133, 45);
            this.gpSexe.TabIndex = 22;
            this.gpSexe.TabStop = false;
            // 
            // rdMasculin
            // 
            this.rdMasculin.AutoSize = true;
            this.rdMasculin.Location = new System.Drawing.Point(68, 17);
            this.rdMasculin.Margin = new System.Windows.Forms.Padding(2);
            this.rdMasculin.Name = "rdMasculin";
            this.rdMasculin.Size = new System.Drawing.Size(67, 17);
            this.rdMasculin.TabIndex = 12;
            this.rdMasculin.TabStop = true;
            this.rdMasculin.Text = "Masculin";
            this.rdMasculin.UseVisualStyleBackColor = true;
            // 
            // rdFeminin
            // 
            this.rdFeminin.AutoSize = true;
            this.rdFeminin.Location = new System.Drawing.Point(4, 17);
            this.rdFeminin.Margin = new System.Windows.Forms.Padding(2);
            this.rdFeminin.Name = "rdFeminin";
            this.rdFeminin.Size = new System.Drawing.Size(61, 17);
            this.rdFeminin.TabIndex = 11;
            this.rdFeminin.TabStop = true;
            this.rdFeminin.Text = "Feminin";
            this.rdFeminin.UseVisualStyleBackColor = true;
            // 
            // btnAddEmploye
            // 
            this.btnAddEmploye.Location = new System.Drawing.Point(44, 288);
            this.btnAddEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmploye.Name = "btnAddEmploye";
            this.btnAddEmploye.Size = new System.Drawing.Size(154, 50);
            this.btnAddEmploye.TabIndex = 21;
            this.btnAddEmploye.Text = "Créer un employé";
            this.btnAddEmploye.UseVisualStyleBackColor = true;
            this.btnAddEmploye.Click += new System.EventHandler(this.btnAddEmploye_Click);
            // 
            // dtDateNaiss
            // 
            this.dtDateNaiss.Location = new System.Drawing.Point(122, 235);
            this.dtDateNaiss.Margin = new System.Windows.Forms.Padding(2);
            this.dtDateNaiss.Name = "dtDateNaiss";
            this.dtDateNaiss.Size = new System.Drawing.Size(188, 20);
            this.dtDateNaiss.TabIndex = 20;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(122, 127);
            this.txtBoxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(145, 20);
            this.txtBoxPrenom.TabIndex = 19;
            this.txtBoxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPrenom_KeyPress);
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxNom.Location = new System.Drawing.Point(122, 81);
            this.txtBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(145, 20);
            this.txtBoxNom.TabIndex = 18;
            this.txtBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNom_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date de naissance : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sexe : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Prénom :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Création d\'un employé : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Nom : ";
            // 
            // tabVehicules
            // 
            this.tabVehicules.BackColor = System.Drawing.Color.Silver;
            this.tabVehicules.Controls.Add(this.comboTypeVehicule);
            this.tabVehicules.Controls.Add(this.datePickerMEC);
            this.tabVehicules.Controls.Add(this.btnCreaVehicules);
            this.tabVehicules.Controls.Add(this.label12);
            this.tabVehicules.Controls.Add(this.label13);
            this.tabVehicules.Controls.Add(this.txtBoxImmat);
            this.tabVehicules.Controls.Add(this.label14);
            this.tabVehicules.Controls.Add(this.label15);
            this.tabVehicules.Controls.Add(this.btnAddEmployes);
            this.tabVehicules.Location = new System.Drawing.Point(4, 22);
            this.tabVehicules.Margin = new System.Windows.Forms.Padding(2);
            this.tabVehicules.Name = "tabVehicules";
            this.tabVehicules.Padding = new System.Windows.Forms.Padding(2);
            this.tabVehicules.Size = new System.Drawing.Size(858, 380);
            this.tabVehicules.TabIndex = 1;
            this.tabVehicules.Text = "Gestion des véhicules";
            this.tabVehicules.Click += new System.EventHandler(this.tabVehicules_Click);
            // 
            // comboTypeVehicule
            // 
            this.comboTypeVehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeVehicule.FormattingEnabled = true;
            this.comboTypeVehicule.Location = new System.Drawing.Point(178, 61);
            this.comboTypeVehicule.Margin = new System.Windows.Forms.Padding(2);
            this.comboTypeVehicule.Name = "comboTypeVehicule";
            this.comboTypeVehicule.Size = new System.Drawing.Size(151, 21);
            this.comboTypeVehicule.TabIndex = 17;
            // 
            // datePickerMEC
            // 
            this.datePickerMEC.Location = new System.Drawing.Point(178, 139);
            this.datePickerMEC.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerMEC.Name = "datePickerMEC";
            this.datePickerMEC.Size = new System.Drawing.Size(151, 20);
            this.datePickerMEC.TabIndex = 16;
            // 
            // btnCreaVehicules
            // 
            this.btnCreaVehicules.Location = new System.Drawing.Point(80, 193);
            this.btnCreaVehicules.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreaVehicules.Name = "btnCreaVehicules";
            this.btnCreaVehicules.Size = new System.Drawing.Size(136, 73);
            this.btnCreaVehicules.TabIndex = 15;
            this.btnCreaVehicules.Text = "Créer le vehicule";
            this.btnCreaVehicules.UseVisualStyleBackColor = true;
            this.btnCreaVehicules.Click += new System.EventHandler(this.btnCreaVehicules_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Date mis en service du vehicule : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Immatriculation du vehicule : ";
            // 
            // txtBoxImmat
            // 
            this.txtBoxImmat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxImmat.Location = new System.Drawing.Point(178, 100);
            this.txtBoxImmat.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxImmat.Name = "txtBoxImmat";
            this.txtBoxImmat.Size = new System.Drawing.Size(151, 20);
            this.txtBoxImmat.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 63);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Type du vehicule : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 5);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(201, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Création d\'un véhicule : ";
            // 
            // btnAddEmployes
            // 
            this.btnAddEmployes.Enabled = false;
            this.btnAddEmployes.Location = new System.Drawing.Point(4, 336);
            this.btnAddEmployes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployes.Name = "btnAddEmployes";
            this.btnAddEmployes.Size = new System.Drawing.Size(109, 42);
            this.btnAddEmployes.TabIndex = 1;
            this.btnAddEmployes.Text = "Ajouter un employée";
            this.btnAddEmployes.UseVisualStyleBackColor = true;
            this.btnAddEmployes.Click += new System.EventHandler(this.BtnAddEmployes_Click);
            // 
            // tabResa
            // 
            this.tabResa.BackColor = System.Drawing.Color.Silver;
            this.tabResa.Controls.Add(this.cmbListingMinuteFin);
            this.tabResa.Controls.Add(this.label6);
            this.tabResa.Controls.Add(this.cmbListingMinuteDbt);
            this.tabResa.Controls.Add(this.label5);
            this.tabResa.Controls.Add(this.lblEmrpunt);
            this.tabResa.Controls.Add(this.cmbListingVehicule);
            this.tabResa.Controls.Add(this.btnResa);
            this.tabResa.Controls.Add(this.cmbListingHeureFin);
            this.tabResa.Controls.Add(this.label4);
            this.tabResa.Controls.Add(this.cmbListingHeureDbt);
            this.tabResa.Controls.Add(this.label3);
            this.tabResa.Controls.Add(this.dtDateResa);
            this.tabResa.Controls.Add(this.label2);
            this.tabResa.Controls.Add(this.label1);
            this.tabResa.Controls.Add(this.cmbListingEmploye);
            this.tabResa.Controls.Add(this.lblTitre);
            this.tabResa.Location = new System.Drawing.Point(4, 22);
            this.tabResa.Margin = new System.Windows.Forms.Padding(2);
            this.tabResa.Name = "tabResa";
            this.tabResa.Padding = new System.Windows.Forms.Padding(2);
            this.tabResa.Size = new System.Drawing.Size(858, 380);
            this.tabResa.TabIndex = 2;
            this.tabResa.Text = "Créer une réservation";
            // 
            // cmbListingMinuteFin
            // 
            this.cmbListingMinuteFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingMinuteFin.FormattingEnabled = true;
            this.cmbListingMinuteFin.Location = new System.Drawing.Point(159, 229);
            this.cmbListingMinuteFin.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListingMinuteFin.Name = "cmbListingMinuteFin";
            this.cmbListingMinuteFin.Size = new System.Drawing.Size(41, 21);
            this.cmbListingMinuteFin.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "h";
            // 
            // cmbListingMinuteDbt
            // 
            this.cmbListingMinuteDbt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingMinuteDbt.FormattingEnabled = true;
            this.cmbListingMinuteDbt.Location = new System.Drawing.Point(212, 176);
            this.cmbListingMinuteDbt.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListingMinuteDbt.Name = "cmbListingMinuteDbt";
            this.cmbListingMinuteDbt.Size = new System.Drawing.Size(41, 21);
            this.cmbListingMinuteDbt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "h";
            // 
            // lblEmrpunt
            // 
            this.lblEmrpunt.AutoSize = true;
            this.lblEmrpunt.Location = new System.Drawing.Point(11, 91);
            this.lblEmrpunt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmrpunt.Name = "lblEmrpunt";
            this.lblEmrpunt.Size = new System.Drawing.Size(103, 13);
            this.lblEmrpunt.TabIndex = 14;
            this.lblEmrpunt.Text = "Sera emprunté par : ";
            // 
            // cmbListingVehicule
            // 
            this.cmbListingVehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingVehicule.FormattingEnabled = true;
            this.cmbListingVehicule.Location = new System.Drawing.Point(82, 41);
            this.cmbListingVehicule.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListingVehicule.Name = "cmbListingVehicule";
            this.cmbListingVehicule.Size = new System.Drawing.Size(159, 21);
            this.cmbListingVehicule.TabIndex = 13;
            // 
            // btnResa
            // 
            this.btnResa.Location = new System.Drawing.Point(34, 275);
            this.btnResa.Margin = new System.Windows.Forms.Padding(2);
            this.btnResa.Name = "btnResa";
            this.btnResa.Size = new System.Drawing.Size(156, 58);
            this.btnResa.TabIndex = 12;
            this.btnResa.Text = "Créer la réservation";
            this.btnResa.UseVisualStyleBackColor = true;
            this.btnResa.Click += new System.EventHandler(this.btnResa_Click);
            // 
            // cmbListingHeureFin
            // 
            this.cmbListingHeureFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingHeureFin.FormattingEnabled = true;
            this.cmbListingHeureFin.Location = new System.Drawing.Point(99, 229);
            this.cmbListingHeureFin.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListingHeureFin.Name = "cmbListingHeureFin";
            this.cmbListingHeureFin.Size = new System.Drawing.Size(38, 21);
            this.cmbListingHeureFin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Et prendra fin à : ";
            // 
            // cmbListingHeureDbt
            // 
            this.cmbListingHeureDbt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingHeureDbt.FormattingEnabled = true;
            this.cmbListingHeureDbt.Location = new System.Drawing.Point(145, 176);
            this.cmbListingHeureDbt.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListingHeureDbt.Name = "cmbListingHeureDbt";
            this.cmbListingHeureDbt.Size = new System.Drawing.Size(41, 21);
            this.cmbListingHeureDbt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "La réservation débutera à : ";
            // 
            // dtDateResa
            // 
            this.dtDateResa.Location = new System.Drawing.Point(82, 133);
            this.dtDateResa.Margin = new System.Windows.Forms.Padding(2);
            this.dtDateResa.Name = "dtDateResa";
            this.dtDateResa.Size = new System.Drawing.Size(191, 20);
            this.dtDateResa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A la date du : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Le véhicule : ";
            // 
            // cmbListingEmploye
            // 
            this.cmbListingEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingEmploye.FormattingEnabled = true;
            this.cmbListingEmploye.Location = new System.Drawing.Point(120, 89);
            this.cmbListingEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListingEmploye.Name = "cmbListingEmploye";
            this.cmbListingEmploye.Size = new System.Drawing.Size(212, 21);
            this.cmbListingEmploye.TabIndex = 4;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(4, 2);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(240, 20);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Création d\'une réservation :  ";
            // 
            // tabRecap
            // 
            this.tabRecap.BackColor = System.Drawing.Color.Silver;
            this.tabRecap.Controls.Add(this.btnExport);
            this.tabRecap.Controls.Add(this.btnReInit);
            this.tabRecap.Controls.Add(this.btnRechercheEmployeEtVehicule);
            this.tabRecap.Controls.Add(this.cmbListingVehiculeReservation);
            this.tabRecap.Controls.Add(this.label19);
            this.tabRecap.Controls.Add(this.cmbListingEmployeReservation);
            this.tabRecap.Controls.Add(this.label18);
            this.tabRecap.Controls.Add(this.btnRechercheEntreDeuxDates);
            this.tabRecap.Controls.Add(this.dtSecondeDate);
            this.tabRecap.Controls.Add(this.label17);
            this.tabRecap.Controls.Add(this.dtPremiereDate);
            this.tabRecap.Controls.Add(this.label16);
            this.tabRecap.Controls.Add(this.dtGVConsultationGlobaleReservation);
            this.tabRecap.Location = new System.Drawing.Point(4, 22);
            this.tabRecap.Margin = new System.Windows.Forms.Padding(2);
            this.tabRecap.Name = "tabRecap";
            this.tabRecap.Padding = new System.Windows.Forms.Padding(2);
            this.tabRecap.Size = new System.Drawing.Size(858, 380);
            this.tabRecap.TabIndex = 3;
            this.tabRecap.Text = "Récapitulatif";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Red;
            this.btnExport.Location = new System.Drawing.Point(739, 58);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 43);
            this.btnExport.TabIndex = 32;
            this.btnExport.Text = "Exporter en PDF";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReInit
            // 
            this.btnReInit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnReInit.Location = new System.Drawing.Point(739, 6);
            this.btnReInit.Margin = new System.Windows.Forms.Padding(2);
            this.btnReInit.Name = "btnReInit";
            this.btnReInit.Size = new System.Drawing.Size(117, 43);
            this.btnReInit.TabIndex = 31;
            this.btnReInit.Text = "Réinitialiser";
            this.btnReInit.UseVisualStyleBackColor = false;
            this.btnReInit.Click += new System.EventHandler(this.btnReInit_Click);
            // 
            // btnRechercheEmployeEtVehicule
            // 
            this.btnRechercheEmployeEtVehicule.Location = new System.Drawing.Point(594, 33);
            this.btnRechercheEmployeEtVehicule.Margin = new System.Windows.Forms.Padding(2);
            this.btnRechercheEmployeEtVehicule.Name = "btnRechercheEmployeEtVehicule";
            this.btnRechercheEmployeEtVehicule.Size = new System.Drawing.Size(76, 19);
            this.btnRechercheEmployeEtVehicule.TabIndex = 30;
            this.btnRechercheEmployeEtVehicule.Text = "Rechercher";
            this.btnRechercheEmployeEtVehicule.UseVisualStyleBackColor = true;
            this.btnRechercheEmployeEtVehicule.Click += new System.EventHandler(this.btnRechercheEmployeEtVehicule_Click);
            // 
            // cmbListingVehiculeReservation
            // 
            this.cmbListingVehiculeReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingVehiculeReservation.FormattingEnabled = true;
            this.cmbListingVehiculeReservation.Location = new System.Drawing.Point(425, 32);
            this.cmbListingVehiculeReservation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListingVehiculeReservation.Name = "cmbListingVehiculeReservation";
            this.cmbListingVehiculeReservation.Size = new System.Drawing.Size(165, 21);
            this.cmbListingVehiculeReservation.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(333, 35);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "avec le véhicule :";
            // 
            // cmbListingEmployeReservation
            // 
            this.cmbListingEmployeReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingEmployeReservation.FormattingEnabled = true;
            this.cmbListingEmployeReservation.Location = new System.Drawing.Point(164, 32);
            this.cmbListingEmployeReservation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListingEmployeReservation.Name = "cmbListingEmployeReservation";
            this.cmbListingEmployeReservation.Size = new System.Drawing.Size(165, 21);
            this.cmbListingEmployeReservation.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 35);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Afficher les réservations pour : ";
            // 
            // btnRechercheEntreDeuxDates
            // 
            this.btnRechercheEntreDeuxDates.Location = new System.Drawing.Point(578, 5);
            this.btnRechercheEntreDeuxDates.Margin = new System.Windows.Forms.Padding(2);
            this.btnRechercheEntreDeuxDates.Name = "btnRechercheEntreDeuxDates";
            this.btnRechercheEntreDeuxDates.Size = new System.Drawing.Size(76, 19);
            this.btnRechercheEntreDeuxDates.TabIndex = 25;
            this.btnRechercheEntreDeuxDates.Text = "Rechercher";
            this.btnRechercheEntreDeuxDates.UseVisualStyleBackColor = true;
            this.btnRechercheEntreDeuxDates.Click += new System.EventHandler(this.btnRechercheEntreDeuxDates_Click);
            // 
            // dtSecondeDate
            // 
            this.dtSecondeDate.Location = new System.Drawing.Point(399, 6);
            this.dtSecondeDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtSecondeDate.Name = "dtSecondeDate";
            this.dtSecondeDate.Size = new System.Drawing.Size(175, 20);
            this.dtSecondeDate.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 6);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "et le : ";
            // 
            // dtPremiereDate
            // 
            this.dtPremiereDate.Location = new System.Drawing.Point(178, 6);
            this.dtPremiereDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtPremiereDate.Name = "dtPremiereDate";
            this.dtPremiereDate.Size = new System.Drawing.Size(178, 20);
            this.dtPremiereDate.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 6);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Afficher les réservations entre le : ";
            // 
            // dtGVConsultationGlobaleReservation
            // 
            this.dtGVConsultationGlobaleReservation.AllowUserToAddRows = false;
            this.dtGVConsultationGlobaleReservation.AllowUserToDeleteRows = false;
            this.dtGVConsultationGlobaleReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVConsultationGlobaleReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumRésa,
            this.NomEmploye,
            this.ImmatVehicule,
            this.dateResa,
            this.heuredbt,
            this.heurefin});
            this.dtGVConsultationGlobaleReservation.Location = new System.Drawing.Point(4, 106);
            this.dtGVConsultationGlobaleReservation.Margin = new System.Windows.Forms.Padding(2);
            this.dtGVConsultationGlobaleReservation.Name = "dtGVConsultationGlobaleReservation";
            this.dtGVConsultationGlobaleReservation.ReadOnly = true;
            this.dtGVConsultationGlobaleReservation.RowHeadersWidth = 51;
            this.dtGVConsultationGlobaleReservation.RowTemplate.Height = 24;
            this.dtGVConsultationGlobaleReservation.Size = new System.Drawing.Size(800, 271);
            this.dtGVConsultationGlobaleReservation.TabIndex = 20;
            // 
            // NumRésa
            // 
            this.NumRésa.HeaderText = "Numéro Réservation";
            this.NumRésa.MinimumWidth = 6;
            this.NumRésa.Name = "NumRésa";
            this.NumRésa.ReadOnly = true;
            this.NumRésa.Width = 125;
            // 
            // NomEmploye
            // 
            this.NomEmploye.HeaderText = "Nom de l\'employé";
            this.NomEmploye.MinimumWidth = 6;
            this.NomEmploye.Name = "NomEmploye";
            this.NomEmploye.ReadOnly = true;
            this.NomEmploye.Width = 125;
            // 
            // ImmatVehicule
            // 
            this.ImmatVehicule.HeaderText = "Immatriculation du véhicule";
            this.ImmatVehicule.MinimumWidth = 6;
            this.ImmatVehicule.Name = "ImmatVehicule";
            this.ImmatVehicule.ReadOnly = true;
            this.ImmatVehicule.Width = 125;
            // 
            // dateResa
            // 
            this.dateResa.HeaderText = "Date de la réservation";
            this.dateResa.MinimumWidth = 6;
            this.dateResa.Name = "dateResa";
            this.dateResa.ReadOnly = true;
            this.dateResa.Width = 125;
            // 
            // heuredbt
            // 
            this.heuredbt.HeaderText = "Heure de début";
            this.heuredbt.MinimumWidth = 6;
            this.heuredbt.Name = "heuredbt";
            this.heuredbt.ReadOnly = true;
            this.heuredbt.Width = 125;
            // 
            // heurefin
            // 
            this.heurefin.HeaderText = "Heure de fin";
            this.heurefin.MinimumWidth = 6;
            this.heurefin.Name = "heurefin";
            this.heurefin.ReadOnly = true;
            this.heurefin.Width = 125;
            // 
            // formPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(884, 419);
            this.Controls.Add(this.Onglets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formPrinc";
            this.Text = "Application de gestion interne des véhicules";
            this.Load += new System.EventHandler(this.FormPrinc_Load);
            this.Onglets.ResumeLayout(false);
            this.tabEmployes.ResumeLayout(false);
            this.tabEmployes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVEmployes)).EndInit();
            this.gpSexe.ResumeLayout(false);
            this.gpSexe.PerformLayout();
            this.tabVehicules.ResumeLayout(false);
            this.tabVehicules.PerformLayout();
            this.tabResa.ResumeLayout(false);
            this.tabResa.PerformLayout();
            this.tabRecap.ResumeLayout(false);
            this.tabRecap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVConsultationGlobaleReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Onglets;
        private System.Windows.Forms.TabPage tabEmployes;
        private System.Windows.Forms.TabPage tabVehicules;
        private System.Windows.Forms.Button btnAddEmployes;
        private System.Windows.Forms.TabPage tabResa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbListingHeureDbt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDateResa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbListingEmploye;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnResa;
        private System.Windows.Forms.ComboBox cmbListingHeureFin;
        private System.Windows.Forms.Label lblEmrpunt;
        private System.Windows.Forms.ComboBox cmbListingVehicule;
        private System.Windows.Forms.ComboBox cmbListingMinuteDbt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbListingMinuteFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpSexe;
        private System.Windows.Forms.RadioButton rdMasculin;
        private System.Windows.Forms.RadioButton rdFeminin;
        private System.Windows.Forms.Button btnAddEmploye;
        private System.Windows.Forms.DateTimePicker dtDateNaiss;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtGVEmployes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.ComboBox comboTypeVehicule;
        private System.Windows.Forms.DateTimePicker datePickerMEC;
        private System.Windows.Forms.Button btnCreaVehicules;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxImmat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabRecap;
        private System.Windows.Forms.DataGridView dtGVConsultationGlobaleReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRésa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImmatVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateResa;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuredbt;
        private System.Windows.Forms.DataGridViewTextBoxColumn heurefin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtPremiereDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRechercheEntreDeuxDates;
        private System.Windows.Forms.DateTimePicker dtSecondeDate;
        private System.Windows.Forms.ComboBox cmbListingEmployeReservation;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbListingVehiculeReservation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnRechercheEmployeEtVehicule;
        private System.Windows.Forms.Button btnReInit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSupprEmploye;
    }
}

