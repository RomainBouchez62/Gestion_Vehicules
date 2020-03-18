using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Gestion_Vehicules.Métier;

namespace Projet_Gestion_Vehicules
{
    public partial class AddEmployes : Form
    {
        public AddEmployes()
        {
            InitializeComponent();
        }

        private void BtnAddEmployes_Click(object sender, EventArgs e)
        {
            if (txtBoxNom.Text == "" || txtBoxPrenom.Text == "")
            {
                MessageBox.Show("Impossible de créer un employé. Tout les champs doivent être remplis !");
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
                
                unE.setNom(txtBoxNom.Text);
                unE.setPrenom(txtBoxPrenom.Text);
                unE.setDateNaiss(dtDateNaiss.Value);
                BDD uneCo = new BDD();
                uneCo.AddE(unE.getNom(), unE.getPrenom(), unE.getSexe(), unE.getDateNaiss());
                MessageBox.Show("Employé inséré avec succès !");
                txtBoxNom.Text = "";
                txtBoxPrenom.Text = "";
            }
        }
    }
}
