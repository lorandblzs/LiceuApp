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
    public partial class updateProfesori : Form
    {
        public string numeP { get; set; }
        public string prenumeP { get; set; }
        public string varstaP { get; set; }
        public string salarP { get; set; }
        public int idMatP { get; set; }  
        public int idP { get; set; }
        public updateProfesori(string numeProf, string prenumeProf, string varstaProf, string salarProf, int idMatProf, int idP)
        {
            InitializeComponent();
            this.numeP = numeProf;
            this.prenumeP = prenumeProf;
            this.varstaP = varstaProf;
            this.salarP = salarProf;
            this.idMatP = idMatProf;
            this.idP = idP;
        }

        public updateProfesori()
        {
            InitializeComponent();
        }

        private void comboBoxMaterii_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            myInsert.CommandText = "UPDATE tProfesori SET nume = '"+ txtBoxNume.Text +"', prenume = '"+ txtBoxPrenume.Text +"', salar = '"+ txtBoxSalar.Text +"', varsta = '"+ txtBoxVarsta.Text +"', ID_materie = '"+ int.Parse(comboBoxMaterii.SelectedValue.ToString()) +"' WHERE ID = "+ idP;

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

        private void updateProfesori_Load(object sender, EventArgs e)
        {
            txtBoxNume.Text = numeP;
            txtBoxPrenume.Text = prenumeP;
            txtBoxVarsta.Text = varstaP;
            txtBoxSalar.Text = salarP;
            comboBoxMaterii.DisplayMember = "materie";
            comboBoxMaterii.ValueMember = "ID";
            comboBoxMaterii.DataSource = fillDropdownMaterii();
            comboBoxMaterii.SelectedValue = idMatP;
        }
        public DataTable fillDropdownMaterii()
        {
            DataTable dt = new DataTable();

            SqlConnection myDbConnection = new SqlConnection();
            myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

            SqlCommand mySelect = new SqlCommand();
            mySelect.CommandText = "SELECT * FROM tMaterii";
            mySelect.Connection = myDbConnection;

            try
            {
                myDbConnection.Open();
                dt.Load(mySelect.ExecuteReader());
                myDbConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }
    }
}
