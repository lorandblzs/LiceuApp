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

    public partial class updateMaterii : Form
    {
        public int idM{ get; set; }
        public string materieM { get; set; }
        public updateMaterii(int idMaterie, string materie)
        {
            InitializeComponent();
            this.idM = idMaterie;
            this.materieM = materie;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection myDbConnection = new SqlConnection();
            myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

            SqlCommand myInsert = new SqlCommand();
            myInsert.Connection = myDbConnection;
            myInsert.CommandText = "UPDATE tMaterii SET materie = '" + txtBoxMateriiUpdate.Text + "' WHERE ID = " + idM;

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

        private void updateMaterii_Load(object sender, EventArgs e)
        {
            txtBoxMateriiUpdate.Text = materieM;
        }
    }
}
