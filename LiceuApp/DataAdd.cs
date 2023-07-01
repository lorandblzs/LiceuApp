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
using System.Configuration;
using LiceuApp.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LiceuApp
{
    public partial class DataAdd : Form
    {
        public string mainConn = ConfigurationManager.ConnectionStrings["LiceuAppConnectionString"].ConnectionString;
        SqlConnection sqlConn;

        public DataAdd()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
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

            string mainConn = ConfigurationManager.ConnectionStrings["LiceuAppConnectionString"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainConn);

            if (currentTabPage == 0)
            {
                #region addProfesori
                SqlCommand myInsert = new SqlCommand();
                myInsert.Connection = sqlConn;
                myInsert.CommandText = "INSERT INTO tProfesori (nume, prenume, varsta, salar, ID_materie) VALUES ('" + textBoxNume.Text + "', '" + textBoxPrenume.Text + "', '" + int.Parse(textBoxVarsta.Text) + "', '" + int.Parse(textBoxSalar.Text) + "', '" + comboBoxIDMaterie.SelectedValue + "' )";

                try
                {
                    sqlConn.Open();
                    myInsert.ExecuteNonQuery();
                    sqlConn.Close();

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
                SqlCommand myInsert = new SqlCommand();
                myInsert.Connection = sqlConn;
                myInsert.CommandText = "INSERT INTO tElevi (nume, prenume, adresa, nume_mama, nume_tata, CNP, telefon_1, telefon_2, clasa) VALUES ('" + txtBoxNumeElev.Text + "', '" + txtBoxPrenumeElev.Text + "', '" + txtBoxAdresa.Text + "', '" + txtBoxNumeMama.Text + "', '" + txtBoxNumeTata.Text + "', '" + txtBoxCNP.Text + "', '" + txtBoxTel1.Text + "', '" + txtBoxTel2.Text + "', '" + comboBoxClasa.Text + "' )";

                try
                {
                    sqlConn.Open();
                    myInsert.ExecuteNonQuery();
                    sqlConn.Close();

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
                SqlCommand myInsert = new SqlCommand();
                myInsert.Connection = sqlConn;
                myInsert.CommandText = "INSERT INTO tMaterii VALUES ('" + txtBoxMaterieAdd.Text + "')";

                try
                {
                    sqlConn.Open();
                    myInsert.ExecuteNonQuery();
                    sqlConn.Close();

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
                else if (comboBoxProfesorNotaAdd.SelectedValue == null || string.IsNullOrEmpty(comboBoxProfesorNotaAdd.SelectedValue.ToString()))
                {
                    MessageBox.Show("Materia nu are niciun profesor alocat în baza de date.\r\nSetați mai întâi un profesor materialului, apoi nota poate fi adăugată.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand myInsert = new SqlCommand();
                    myInsert.Connection = sqlConn;
                    myInsert.CommandText = "INSERT INTO tNote VALUES ('" + int.Parse(comboBoxElevID.SelectedValue.ToString()) + "', '" + int.Parse(comboBoxProfesorNotaAdd.SelectedValue.ToString()) + "', '" + int.Parse(comboBoxNoteAdd.Text.ToString()) + "', '" + int.Parse(comboBoxMaterieNotaAdd.SelectedValue.ToString()) + "' )";

                    try
                    {
                        sqlConn.Open();
                        myInsert.ExecuteNonQuery();
                        sqlConn.Close();

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

            comboBoxIDMaterie.DisplayMember = "materie";
            comboBoxIDMaterie.ValueMember = "ID";
            comboBoxIDMaterie.DataSource = getMaterii();

            comboBoxElevID.DisplayMember = "numeCompletID";
            comboBoxElevID.ValueMember = "ID";
            comboBoxElevID.DataSource = getNumeElev();

            //comboBoxProfesorNotaAdd.DisplayMember = "numeProfCompletID";
            //comboBoxProfesorNotaAdd.ValueMember = "ID";
            //comboBoxProfesorNotaAdd.DataSource = getProfesori();
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
        private void comboBoxElevID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView rowView = comboBoxElevID.SelectedItem as DataRowView;
            if (rowView != null)
            {
                lblCNPNotaAddCNP.Text = rowView[2].ToString();
                lblClasaNoteAddText.Text = rowView[3].ToString();
            }
            comboBoxNoteAdd.Enabled = true;
        }
        private void comboBoxMaterieNotaAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable profesoriData = getProfesori().Select("ID_materie=" + comboBoxMaterieNotaAdd.SelectedValue.ToString()).CopyToDataTable();

                if (profesoriData.Rows.Count == 0)
                {
                    comboBoxProfesorNotaAdd.DataSource = null;
                    comboBoxProfesorNotaAdd.Items.Clear();
                    comboBoxProfesorNotaAdd.Items.Add("Nu există profesor ...");
                    comboBoxProfesorNotaAdd.SelectedIndex = 0;
                    comboBoxProfesorNotaAdd.Enabled = false;
                }
                else
                {
                    comboBoxProfesorNotaAdd.DataSource = profesoriData;
                    comboBoxProfesorNotaAdd.DisplayMember = "numeProfCompletID";
                    comboBoxProfesorNotaAdd.ValueMember = "ID";
                    comboBoxProfesorNotaAdd.Enabled = true;
                }
            }
            catch
            {
                comboBoxProfesorNotaAdd.DataSource = null;
                comboBoxProfesorNotaAdd.Items.Clear();
                comboBoxProfesorNotaAdd.Enabled = false;
            }
        }
        private void comboBoxNoteAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaterieNotaAdd.DisplayMember = "materie";
            comboBoxMaterieNotaAdd.ValueMember = "ID";
            comboBoxMaterieNotaAdd.DataSource = getMaterii();
            comboBoxMaterieNotaAdd.Enabled = true;
        }
        private void textBoxVarsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxSalar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBoxTel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBoxTel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBoxCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
