using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LiceuApp.Properties;

namespace LiceuApp
{
    public partial class updateProfesori : Form
    {
        public string mainConn = ConfigurationManager.ConnectionStrings["LiceuAppConnectionString"].ConnectionString;
        SqlConnection sqlConn;

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
            string mainConn = ConfigurationManager.ConnectionStrings["LiceuAppConnectionString"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainConn);

            SqlCommand myInsert = new SqlCommand();
            myInsert.Connection = sqlConn;
            myInsert.CommandText = "UPDATE tProfesori SET nume = '"+ txtBoxNume.Text +"', prenume = '"+ txtBoxPrenume.Text +"', salar = '"+ txtBoxSalar.Text +"', varsta = '"+ txtBoxVarsta.Text +"', ID_materie = '"+ int.Parse(comboBoxMaterii.SelectedValue.ToString()) +"' WHERE ID = "+ idP;

            try
            {
                sqlConn.Open();
                myInsert.ExecuteNonQuery();
                sqlConn.Close(); 
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

            #region button styling
            btnExit.BackColor = Color.FromArgb(100, Color.Red);
            btnExit.ForeColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, Color.Red);
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, Color.Red);
            btnExit.FlatStyle = FlatStyle.Flat;

            btnBack.BackColor = Color.FromArgb(150, 255, 161, 0);
            btnBack.ForeColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 255, 161, 0);
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 255, 161, 0);
            btnBack.FlatStyle = FlatStyle.Flat;

            btnSave.BackColor = Color.FromArgb(150, 88, 176, 50);
            btnSave.ForeColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 88, 176, 50);
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 88, 176, 50);
            btnSave.FlatStyle = FlatStyle.Flat;
            #endregion

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

            string mainConn = ConfigurationManager.ConnectionStrings["LiceuAppConnectionString"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainConn);

            SqlCommand mySelect = new SqlCommand();
            mySelect.CommandText = "SELECT * FROM tMaterii";
            mySelect.Connection = sqlConn;

            try
            {
                sqlConn.Open();
                dt.Load(mySelect.ExecuteReader());
                sqlConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }
    }
}
