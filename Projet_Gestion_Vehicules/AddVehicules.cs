using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projet_Gestion_Vehicules.Métier;

namespace Projet_Gestion_Vehicules
{
    public partial class AddVehicules : Form
    {
        List<Vehicule> mesV = new List<Vehicule>();
        public AddVehicules()
        {
            InitializeComponent();
        }

        private void BtnCreaVehicules_Click(object sender, EventArgs e)
        {
            if(txtBoxImmat.Text=="" || comboTypeVehicule.SelectedItem==null)
            {
                MessageBox.Show("Impossible de créer ce véhicule. Veuillez remplir tout les champs");
            }
            else
            {
                Vehicule unV = new Vehicule(txtBoxImmat.Text, datePickerMEC.Value);
                BDD uneB = new BDD();
                uneB.AddV(unV.getImmat(), unV.getDateMEC());
                MessageBox.Show("Véhicule inséré ! ");
                txtBoxImmat.Text = "";
                comboTypeVehicule.Text = "";
            }
        }

        private void AddVehicules_Load(object sender, EventArgs e)
        {
            BDD maCo = new BDD();
            List<TypeVehicule> mesTypesV = new List<TypeVehicule>();
            mesTypesV=maCo.giveTypeVehicule();
            comboTypeVehicule.Items.Clear();
            foreach(TypeVehicule unTV in mesTypesV)
            {
                comboTypeVehicule.Items.Add(unTV.toString());
            }
        }

        private void ComboTypeVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
