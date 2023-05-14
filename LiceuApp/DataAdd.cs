using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiceuApp
{
    public partial class DataAdd : Form
    {
        public DataAdd()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           // DataDisplay dataDisplayForm = new DataDisplay();
           // dataDisplayForm.Show();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes;
            dlgRes = MessageBox.Show("Doriți să închideți aplicația? \nDatele nesalvate se vor pierde!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            int currentTabPage;
            currentTabPage = tabControlDataAdd.SelectedIndex;

            if (currentTabPage == 0)
            {
                #region addProfesori
                SqlConnection myDbConnection = new SqlConnection();
                myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

                SqlCommand myInsert = new SqlCommand();
                myInsert.Connection = myDbConnection;
                myInsert.CommandText = "INSERT INTO tProfesori VALUES ('" + textBoxNume.Text + "', '" + textBoxPrenume.Text + "', '" + textBoxVarsta.Text + "', '" + textBoxSalar.Text + "', '" + int.Parse(comboBoxIDMaterie.SelectedValue.ToString()) + "' )";

                try
                {
                    myDbConnection.Open();
                    // MessageBox.Show("connection Open");
                    myInsert.ExecuteNonQuery();
                    myDbConnection.Close();

                    MessageBox.Show("Profesor adaugat in baza de date!", "Succes", MessageBoxButtons.OK);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }
            if (currentTabPage == 1)
            {
                #region addElevi
                SqlConnection myDbConnection = new SqlConnection();
                myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

                SqlCommand myInsert = new SqlCommand();
                myInsert.Connection = myDbConnection;
                myInsert.CommandText = "INSERT INTO tElevi VALUES ('" + txtBoxNumeElev.Text + "', '" + txtBoxPrenumeElev.Text + "', '" + txtBoxAdresa.Text + "', '" + txtBoxNumeMama.Text + "', '" + txtBoxNumeTata.Text + "', '" + txtBoxCNP.Text + "', '" + txtBoxTel1.Text + "', '" + txtBoxTel2.Text + "', '" + comboBoxClasa.Text + "' )";

                try
                {
                    myDbConnection.Open();
                    // MessageBox.Show("connection Open");
                    myInsert.ExecuteNonQuery();
                    myDbConnection.Close();

                    MessageBox.Show("Elev adaugat in baza de date!", "Succes", MessageBoxButtons.OK);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }
            if (currentTabPage == 2)
            {
                #region addMaterii
                SqlConnection myDbConnection = new SqlConnection();
                myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

                SqlCommand myInsert = new SqlCommand();
                myInsert.Connection = myDbConnection;
                myInsert.CommandText = "INSERT INTO tMaterii VALUES ('" + txtBoxMaterieAdd.Text + "')";

                try
                {
                    myDbConnection.Open();
                    // MessageBox.Show("connection Open");
                    myInsert.ExecuteNonQuery();
                    myDbConnection.Close();

                    MessageBox.Show("Materia adaugata in baza de date!", "Succes", MessageBoxButtons.OK);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }
            if (currentTabPage == 3)
            {
                #region addNote
                if (int.Parse(comboBoxElevID.SelectedValue.ToString()) == 0)
                {
                    MessageBox.Show("Nu ati selectat nota!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection myDbConnection = new SqlConnection();
                    myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

                    SqlCommand myInsert = new SqlCommand();
                    myInsert.Connection = myDbConnection;
                    myInsert.CommandText = "INSERT INTO tNote VALUES ('" + int.Parse(comboBoxElevID.SelectedValue.ToString()) + "', '" + int.Parse(comboBoxProfesorNotaAdd.SelectedValue.ToString()) + "', '" + int.Parse(comboBoxNoteAdd.Text.ToString()) + "', '" + int.Parse(comboBoxMaterieNotaAdd.SelectedValue.ToString()) + "' )";

                    try
                    {
                        myDbConnection.Open();
                        // MessageBox.Show("connection Open");
                        myInsert.ExecuteNonQuery();
                        myDbConnection.Close();

                        MessageBox.Show("Nota adaugata in baza de date!", "Succes", MessageBoxButtons.OK);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion
            }
        }
        private void DataAdd_Load(object sender, EventArgs e)
        {
            comboBoxIDMaterie.DisplayMember = "materie";
            comboBoxIDMaterie.ValueMember = "ID";
            comboBoxIDMaterie.DataSource = getMaterii();

            comboBoxMaterieNotaAdd.DisplayMember = "materie";
            comboBoxMaterieNotaAdd.ValueMember = "ID";
            comboBoxMaterieNotaAdd.DataSource = getMaterii();

            comboBoxElevID.DisplayMember = "numeCompletID";
            comboBoxElevID.ValueMember = "ID";
            comboBoxElevID.DataSource = getNumeElev();
            
            comboBoxProfesorNotaAdd.DisplayMember = "numeProfCompletID";
            comboBoxProfesorNotaAdd.ValueMember = "ID";
            comboBoxProfesorNotaAdd.DataSource = getProfesori();
        }
        public DataTable getMaterii()
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
        public DataTable getNumeElev()
        {
            DataTable dtE = new DataTable();

            SqlConnection myDbConnection = new SqlConnection();
            myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

            SqlCommand mySelect = new SqlCommand();
            mySelect.CommandText = "SELECT ID,\r\n\t nume + ' ' + prenume AS numeCompletID,\r\n\t CNP,\r\n\t clasa\r\nFROM tElevi;";
            mySelect.Connection = myDbConnection;

            try
            {
                myDbConnection.Open();
                dtE.Load(mySelect.ExecuteReader());
                myDbConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtE;
        }
        public DataTable getProfesori()
        {
            DataTable dtE = new DataTable();

            SqlConnection myDbConnection = new SqlConnection();
            myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

            SqlCommand mySelect = new SqlCommand();
            mySelect.CommandText = "SELECT tProfesori.ID, \r\n nume + ' ' + prenume AS numeProfCompletID,\r\n\t ID_materie\r\n\t FROM tProfesori INNER JOIN tMaterii on tProfesori.ID_materie=tMaterii.ID;";
            mySelect.Connection = myDbConnection;

            try
            {
                myDbConnection.Open();
                dtE.Load(mySelect.ExecuteReader());
                myDbConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtE;
        }
        private void tabElevi_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxElevID_Format(object sender, ListControlConvertEventArgs e)
        {

        }
        private void comboBoxElevID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView rowView = comboBoxElevID.SelectedItem as DataRowView;
            if (rowView != null)
            {
                lblCNPNotaAddCNP.Text = rowView[2].ToString();
                lblClasaNoteAddText.Text = rowView[3].ToString();
            }
        }
        private void comboBoxMaterieNotaAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBoxProfesorNotaAdd.DataSource = getProfesori().Select("ID_materie=" + comboBoxMaterieNotaAdd.SelectedValue.ToString()).CopyToDataTable();
                comboBoxProfesorNotaAdd.DisplayMember = "numeProfCompletID";
                comboBoxProfesorNotaAdd.ValueMember = "ID";
        }
        private void comboBoxNoteAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
