using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiceuApp
{
    public partial class updateElevi : Form
    {
        #region Data Handling
        public int idE { get; set; }
        public string numeE { get; set; }
        public string prenumeE { get; set; }
        public string adresaE { get; set; }
        public string numeME { get; set; }
        public string numeTE { get; set; }
        public string CNP { get; set; }
        public string telefon1 { get; set; }
        public string telefon2 { get; set; }
        public string clasaE { get; set; }
        #endregion
        public updateElevi(int idElev, string numeElev, string prenumeElev, string adresaElev, string numeMElev, string numeTElev, string CNP, string tel1, string tel2, string clasaElev)
        {
            InitializeComponent();
            this.idE = idElev;
            this.numeE = numeElev;
            this.prenumeE = prenumeElev;
            this.adresaE = adresaElev;
            this.numeME = numeMElev;
            this.numeTE = numeTElev;
            this.CNP = CNP;
            this.telefon1 = tel1;
            this.telefon2 = tel2;
            this.clasaE = clasaElev;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes;
            dlgRes = MessageBox.Show("Doriți să reveniți la pagina anterioară? \nToate datele nesalvate nu vor fi actualizate!", "Inapoi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes)
            {
                DataDisplay dataDisplayForm = new DataDisplay();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes;
            dlgRes = MessageBox.Show("Doriți să închideți aplicația? \nDatele nesalvate se vor pierde!", "Isire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection myDbConnection = new SqlConnection();
            myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

            SqlCommand myInsert = new SqlCommand();
            myInsert.Connection = myDbConnection;
            myInsert.CommandText = "UPDATE tElevi SET nume = '" + txtBoxNumeDataUpdate.Text + "', prenume = '" + txtBoxPrenumeDataUpdate.Text + "', adresa = '" + txtBoxAdresaUpdate.Text + "', nume_mama = '" + txtBoxNumeMamaDataUpdate.Text + "', nume_tata = '" + txtBoxNumeTataDataUpdate.Text + "', CNP = '" + txtBoxCNPDataUpdate.Text + "', telefon_1 = '" + txtBoxTel1DataUpdate.Text + "', telefon_2 = '" + txtBoxTel2DataUpdate.Text + "', clasa = '" + comboBoxClasaDataUpdate.Text + "' WHERE ID = " + idE;

            try
            {
                myDbConnection.Open();
                myInsert.ExecuteNonQuery();
                myDbConnection.Close();
                MessageBox.Show("Datele au fost actualizate!");

                DataDisplay dataDisplayForm = new DataDisplay();
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //sets values to the TextBoxes
        private void updateElevi_Load(object sender, EventArgs e)
        {
            txtBoxNumeDataUpdate.Text = numeE;
            txtBoxPrenumeDataUpdate.Text = prenumeE;
            txtBoxAdresaUpdate.Text = adresaE;
            txtBoxNumeMamaDataUpdate.Text = numeME;
            txtBoxNumeTataDataUpdate.Text = numeTE;
            txtBoxCNPDataUpdate.Text = CNP;
            txtBoxTel1DataUpdate.Text = telefon1;
            txtBoxTel2DataUpdate.Text = telefon2;
            comboBoxClasaDataUpdate.Text = clasaE;
        }
    }
}
