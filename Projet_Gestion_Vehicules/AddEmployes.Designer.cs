namespace Projet_Gestion_Vehicules
{
    partial class AddEmployes
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.dtDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.btnAddEmployes = new System.Windows.Forms.Button();
            this.rdFeminin = new System.Windows.Forms.RadioButton();
            this.gpSexe = new System.Windows.Forms.GroupBox();
            this.rdMasculin = new System.Windows.Forms.RadioButton();
            this.gpSexe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(247, 25);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Création d\'un employé : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexe : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date de naissance : ";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxNom.Location = new System.Drawing.Point(158, 93);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(192, 22);
            this.txtBoxNom.TabIndex = 6;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(158, 149);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(192, 22);
            this.txtBoxPrenom.TabIndex = 7;
            // 
            // dtDateNaiss
            // 
            this.dtDateNaiss.Location = new System.Drawing.Point(159, 282);
            this.dtDateNaiss.Name = "dtDateNaiss";
            this.dtDateNaiss.Size = new System.Drawing.Size(250, 22);
            this.dtDateNaiss.TabIndex = 9;
            // 
            // btnAddEmployes
            // 
            this.btnAddEmployes.Location = new System.Drawing.Point(583, 376);
            this.btnAddEmployes.Name = "btnAddEmployes";
            this.btnAddEmployes.Size = new System.Drawing.Size(205, 62);
            this.btnAddEmployes.TabIndex = 10;
            this.btnAddEmployes.Text = "Créer un employé";
            this.btnAddEmployes.UseVisualStyleBackColor = true;
            this.btnAddEmployes.Click += new System.EventHandler(this.BtnAddEmployes_Click);
            // 
            // rdFeminin
            // 
            this.rdFeminin.AutoSize = true;
            this.rdFeminin.Location = new System.Drawing.Point(6, 21);
            this.rdFeminin.Name = "rdFeminin";
            this.rdFeminin.Size = new System.Drawing.Size(78, 21);
            this.rdFeminin.TabIndex = 11;
            this.rdFeminin.TabStop = true;
            this.rdFeminin.Text = "Feminin";
            this.rdFeminin.UseVisualStyleBackColor = true;
            // 
            // gpSexe
            // 
            this.gpSexe.Controls.Add(this.rdMasculin);
            this.gpSexe.Controls.Add(this.rdFeminin);
            this.gpSexe.Location = new System.Drawing.Point(159, 192);
            this.gpSexe.Name = "gpSexe";
            this.gpSexe.Size = new System.Drawing.Size(177, 55);
            this.gpSexe.TabIndex = 12;
            this.gpSexe.TabStop = false;
            // 
            // rdMasculin
            // 
            this.rdMasculin.AutoSize = true;
            this.rdMasculin.Location = new System.Drawing.Point(91, 21);
            this.rdMasculin.Name = "rdMasculin";
            this.rdMasculin.Size = new System.Drawing.Size(84, 21);
            this.rdMasculin.TabIndex = 12;
            this.rdMasculin.TabStop = true;
            this.rdMasculin.Text = "Masculin";
            this.rdMasculin.UseVisualStyleBackColor = true;
            // 
            // AddEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 455);
            this.Controls.Add(this.gpSexe);
            this.Controls.Add(this.btnAddEmployes);
            this.Controls.Add(this.dtDateNaiss);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployes";
            this.Text = "Ajout d\'un employé";
            this.gpSexe.ResumeLayout(false);
            this.gpSexe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.DateTimePicker dtDateNaiss;
        private System.Windows.Forms.Button btnAddEmployes;
        private System.Windows.Forms.RadioButton rdFeminin;
        private System.Windows.Forms.GroupBox gpSexe;
        private System.Windows.Forms.RadioButton rdMasculin;
    }
}