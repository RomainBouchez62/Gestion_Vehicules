namespace Projet_Gestion_Vehicules
{
    partial class AddVehicules
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxImmat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreaVehicules = new System.Windows.Forms.Button();
            this.datePickerMEC = new System.Windows.Forms.DateTimePicker();
            this.comboTypeVehicule = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(246, 25);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Création d\'un véhicule : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type du vehicule : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Immatriculation du vehicule : ";
            // 
            // txtBoxImmat
            // 
            this.txtBoxImmat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxImmat.Location = new System.Drawing.Point(243, 123);
            this.txtBoxImmat.Name = "txtBoxImmat";
            this.txtBoxImmat.Size = new System.Drawing.Size(200, 22);
            this.txtBoxImmat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date mis en service du vehicule : ";
            // 
            // btnCreaVehicules
            // 
            this.btnCreaVehicules.Location = new System.Drawing.Point(443, 274);
            this.btnCreaVehicules.Name = "btnCreaVehicules";
            this.btnCreaVehicules.Size = new System.Drawing.Size(181, 90);
            this.btnCreaVehicules.TabIndex = 7;
            this.btnCreaVehicules.Text = "Créer le vehicule";
            this.btnCreaVehicules.UseVisualStyleBackColor = true;
            this.btnCreaVehicules.Click += new System.EventHandler(this.BtnCreaVehicules_Click);
            // 
            // datePickerMEC
            // 
            this.datePickerMEC.Location = new System.Drawing.Point(243, 171);
            this.datePickerMEC.Name = "datePickerMEC";
            this.datePickerMEC.Size = new System.Drawing.Size(200, 22);
            this.datePickerMEC.TabIndex = 8;
            // 
            // comboTypeVehicule
            // 
            this.comboTypeVehicule.FormattingEnabled = true;
            this.comboTypeVehicule.Location = new System.Drawing.Point(243, 75);
            this.comboTypeVehicule.Name = "comboTypeVehicule";
            this.comboTypeVehicule.Size = new System.Drawing.Size(200, 24);
            this.comboTypeVehicule.TabIndex = 9;
            this.comboTypeVehicule.SelectedIndexChanged += new System.EventHandler(this.ComboTypeVehicule_SelectedIndexChanged);
            // 
            // AddVehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 371);
            this.Controls.Add(this.comboTypeVehicule);
            this.Controls.Add(this.datePickerMEC);
            this.Controls.Add(this.btnCreaVehicules);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxImmat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitre);
            this.Name = "AddVehicules";
            this.Text = "Ajout d\'un véhicule";
            this.Load += new System.EventHandler(this.AddVehicules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxImmat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreaVehicules;
        private System.Windows.Forms.DateTimePicker datePickerMEC;
        private System.Windows.Forms.ComboBox comboTypeVehicule;
    }
}