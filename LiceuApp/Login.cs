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
using static System.Net.Mime.MediaTypeNames;


namespace LiceuApp
{


    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            #region Buttons styling
            btnX.BackColor = Color.FromArgb(100, Color.White);
            btnX.ForeColor = Color.White;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, Color.Red);
            btnX.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, Color.Red);
            btnX.FlatStyle = FlatStyle.Flat;

            btnClear.BackColor = Color.FromArgb(150, 88, 176, 50);
            btnClear.ForeColor = Color.White;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 88, 176, 50);
            btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 88, 176, 50);
            btnClear.FlatStyle = FlatStyle.Flat;

            btnLogin.BackColor = Color.FromArgb(150, 88, 176, 50);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 88, 176, 50);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 88, 176, 50);
            btnLogin.FlatStyle = FlatStyle.Flat;
            #endregion
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection myDbConnection = new SqlConnection();
            myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

            String userName, password;

            userName = txtUserName.Text;
            password = txtPassword.Text;

            try
            {
                String querry = "SELECT * FROM tUsers WHERE userName = '" + txtUserName.Text + "' AND password = '"+txtPassword.Text +"'";
                SqlDataAdapter userCheck = new SqlDataAdapter(querry, myDbConnection);

                DataTable dataTable = new DataTable();
                userCheck.Fill(dataTable);

                if(dataTable.Rows.Count > 0)
                {
                    userName = txtUserName.Text;
                    password = txtPassword.Text;

                    // code to load next form here
                    DataDisplay dataDisplayForm =  new DataDisplay();
                    dataDisplayForm.Show();
                    this.Hide();
                }    
                else
                {
                    MessageBox.Show("Autentificare greșită!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Eroare de conexiune!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          
            //check how MessageBoxButton text can be changed

            DialogResult dlgRes;
            dlgRes = MessageBox.Show("Doriți să închideți aplicația?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
        }
    }
}
