using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;
using System.Runtime.CompilerServices;
using LiceuApp.Properties;
using System.Security.Cryptography;

namespace LiceuApp
{
    public partial class DataDisplay : Form
    {
        #region gridview Profesori data
        public string numeProf { get; set; }
        public string prenumeProf { get; set; }
        public string varstaProf { get; set; }
        public string salarProf { get; set; }   
        public int idMatProf { get; set; }  
        public int idProf { get; set; }
        #endregion

        #region gridview Elevi data
        public int idElev { get; set; }
        public string numeElev { get; set; }
        public string prenumeElev { get; set; }
        public string adresaElev { get; set; }
        public string numeMElev { get; set; }
        public string numeTElev { get; set; }
        public string CNP { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string clasaElev { get; set; }
        #endregion

        #region gridview Materii data
        public int idMaterie { get; set; }
        public string materie { get; set; }
        #endregion

        #region gridview Note data
        public int idNota { get; set; }
        public int valoareNota { get; set; }
        public int idMaterieNota { get; set; }
        public string clasaNotaUpd { get; set; }
        public string materieUpdate { get; set; }
        public string noteClasaUpdate { get; set; }
        public string numeElevNota { get; set; }
        public string prenumeElevNota { get; set; }
        public string numePNota { get; set; }
        public string prenumePNota { get; set; }
        #endregion

        public string sourceFile { get; set; }
        public string fileExt { get; set; }
        public DataDisplay()
        {
            InitializeComponent();
        }


        private void DataDisplay_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'liceuXDataSet4.tProfesori' table. You can move, or remove it, as needed.
            this.tProfesoriTableAdapter1.Fill(this.liceuXDataSet4.tProfesori);
            // TODO: This line of code loads data into the 'liceuXDataSet3.tNote' table. You can move, or remove it, as needed.
            this.tNoteTableAdapter.Fill(this.liceuXDataSet3.tNote);
            // TODO: This line of code loads data into the 'liceuXDataSet2.tMaterii' table. You can move, or remove it, as needed.
            this.tMateriiTableAdapter.Fill(this.liceuXDataSet2.tMaterii);
            // TODO: This line of code loads data into the 'liceuXDataSetElevi.tElevi' table. You can move, or remove it, as needed.
            this.tEleviTableAdapter1.Fill(this.liceuXDataSetElevi.tElevi);
            // TODO: This line of code loads data into the 'liceuXDataSet1.tElevi' table. You can move, or remove it, as needed.
            this.tEleviTableAdapter.Fill(this.liceuXDataSet1.tElevi);
            // TODO: This line of code loads data into the 'liceuXDataSet.tProfesori' table. You can move, or remove it, as needed.
            this.tProfesoriTableAdapter.Fill(this.liceuXDataSet.tProfesori);

            SqlConnection myDbConnection = new SqlConnection();
            myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

            SqlCommand cmd = new SqlCommand("SELECT * FROM tProfesori INNER JOIN tMaterii on tProfesori.ID_materie=tMaterii.ID", myDbConnection);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

          

            dataGridViewProfesori.DataSource = dt;
            dataGridViewProfesori.Columns["ID"].Visible = false;
            dataGridViewProfesori.Columns["nume"].HeaderText = "Nume";
            dataGridViewProfesori.Columns["prenume"].HeaderText = "Prenume";
            dataGridViewProfesori.Columns["Varsta"].HeaderText = "Vârstă";
            dataGridViewProfesori.Columns["salar"].HeaderText = "Salar";
            dataGridViewProfesori.Columns["pic_URL"].Visible = false;
            dataGridViewProfesori.Columns["ID_materie"].Visible = false;
            dataGridViewProfesori.Columns["ID1"].Visible = false;
            dataGridViewProfesori.Columns["materie"].HeaderText = "Materie";



            dataGridViewElevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewElevi.Columns[5].HeaderText = "Nume Tata";



            SqlCommand cmdNote = new SqlCommand("SELECT \r\n       N.ID,\r\n       E.nume, \r\n\t   E.prenume, \r\n\t   clasa, \r\n\t   nota, \r\n\t   M.materie,\r\n\t   N.ID_materie, \r\n\t   ID_profesor,\r\n\t   P.nume,\r\n\t   P.prenume\r\nFROM tElevi as E \r\nJOIN tNote as N on E.ID = N.ID_elev\r\nJOIN tMaterii as M on N.ID_materie = M.ID\r\nJOIN tProfesori as P on N.ID_profesor = P.ID", myDbConnection);
            SqlDataAdapter myDataAdapterNote = new SqlDataAdapter();
            myDataAdapterNote.SelectCommand = cmdNote;
            DataTable dtNote = new DataTable();
            myDataAdapterNote.Fill(dtNote);
            dataGridViewNote.DataSource = dtNote;
            dataGridViewNote.Columns[0].Visible = false;
            dataGridViewNote.Columns[1].HeaderText = "Nume Elev";
            dataGridViewNote.Columns[2].HeaderText = "Prenume Elev";
            dataGridViewNote.Columns[3].HeaderText = "Calasa";
            dataGridViewNote.Columns[4].HeaderText = "Nota";
            dataGridViewNote.Columns[5].HeaderText = "Materie";
            dataGridViewNote.Columns[6].Visible = false;
            dataGridViewNote.Columns[7].Visible = false;
            dataGridViewNote.Columns[8].HeaderText = "Nume Profesor";
            dataGridViewNote.Columns[9].HeaderText = "Prenume Profesor";

            dataGridViewElevi.Columns[0].Visible = false;

            SqlCommand cmdMaterii = new SqlCommand("SELECT\r\n     M.materie,\r\n     M.ID,\r\n\t P.ID,\r\n\t nume,\r\n\t prenume\r\nFROM tMaterii as M\r\nJOIN tProfesori as P on M.ID = P.ID_materie", myDbConnection);
            SqlDataAdapter myDataAdapterMaterii = new SqlDataAdapter();
            myDataAdapterMaterii.SelectCommand = cmdMaterii;
            DataTable dtMaterii = new DataTable();
            myDataAdapter.Fill(dtMaterii);
            dataGridViewMaterii.DataSource = dtMaterii;
            dataGridViewMaterii.Columns["ID"].Visible = false;
            dataGridViewMaterii.Columns["varsta"].Visible = false;
            dataGridViewMaterii.Columns["salar"].Visible = false;
            dataGridViewMaterii.Columns["ID_materie"].Visible = false;
            dataGridViewMaterii.Columns["ID1"].Visible = false;
            dataGridViewMaterii.Columns["materie"].DisplayIndex = 0;
            dataGridViewMaterii.Columns["materie"].HeaderText = "Materie";
            dataGridViewMaterii.Columns["nume"].HeaderText = "Nume";
            dataGridViewMaterii.Columns["prenume"].HeaderText = "Prenume";
            dataGridViewMaterii.Columns["pic_URL"].Visible = false;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes;
            dlgRes = MessageBox.Show("Doriți să închideți aplicația?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
        private void btnDataInsert_Click(object sender, EventArgs e)
        {
            DataAdd dataAddForm = new DataAdd();
            dataAddForm.ShowDialog();
        }
        private void dataGridViewProfesori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            int currentTabPage;
            currentTabPage = tabDataView.SelectedIndex;
            
            if (currentTabPage == 0)
            {
                updateProfesori updateProfesoriForm = new updateProfesori(numeProf, prenumeProf, varstaProf, salarProf, idMatProf, idProf);
                updateProfesoriForm.ShowDialog();
            } 
            if (currentTabPage == 1)
            {
                updateElevi updateEleviForm = new updateElevi(idElev, numeElev, prenumeElev, adresaElev, numeMElev, numeTElev, CNP, tel1, tel2, clasaElev);
                updateEleviForm.ShowDialog();
            }
            if (currentTabPage == 2)
            {
                updateMaterii updatePMateriiForm = new updateMaterii(idMaterie, materie);
                updatePMateriiForm.ShowDialog();
            }
            if (currentTabPage == 3)
            {
                updateNote updateNoteForm = new updateNote(idNota, valoareNota, materieUpdate, noteClasaUpdate, numeElevNota, prenumeElevNota, numePNota, prenumePNota);
                updateNoteForm.ShowDialog();
            }
        }
        private void dataGridViewMaterii_Click(object sender, EventArgs e)
        {

        }
        private void tabDataView_Click(object sender, EventArgs e)
        {
            
        }
        private void tabDataView_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

      
        private void dataGridViewProfesori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;

            idProf = int.Parse(dataGridViewProfesori.Rows[rowID].Cells[0].Value.ToString());
            numeProf = dataGridViewProfesori.Rows[rowID].Cells[1].Value.ToString();
            prenumeProf = dataGridViewProfesori.Rows[rowID].Cells[2].Value.ToString();
            varstaProf = dataGridViewProfesori.Rows[rowID].Cells[3].Value.ToString();
            salarProf = dataGridViewProfesori.Rows[rowID].Cells[4].Value.ToString();
            idMatProf = int.Parse(dataGridViewProfesori.Rows[rowID].Cells[5].Value.ToString());

            var imgURL = dataGridViewProfesori.Rows[rowID].Cells[6].Value.ToString();
            if (string.IsNullOrEmpty(imgURL))
            {
                imgURL = @"D:\x Projects\WebApp\LiceuApp\LiceuApp\Resorces\Pictures\def\user.png";
                picBoxProfesor.ImageLocation = imgURL;
            } 
            else
            {
                picBoxProfesor.ImageLocation = imgURL;
            }
        }

        private void dataGridViewProfesori_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewElevi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;

            idElev = int.Parse(dataGridViewElevi.Rows[rowID].Cells[0].Value.ToString());
            numeElev = dataGridViewElevi.Rows[rowID].Cells[1].Value.ToString();
            prenumeElev = dataGridViewElevi.Rows[rowID].Cells[2].Value.ToString();
            adresaElev = dataGridViewElevi.Rows[rowID].Cells[3].Value.ToString();
            numeMElev = dataGridViewElevi.Rows[rowID].Cells[4].Value.ToString();
            numeTElev = dataGridViewElevi.Rows[rowID].Cells[5].Value.ToString();
            CNP = dataGridViewElevi.Rows[rowID].Cells[6].Value.ToString();
            tel1 = dataGridViewElevi.Rows[rowID].Cells[7].Value.ToString();
            tel2 = dataGridViewElevi.Rows[rowID].Cells[8].Value.ToString();
            clasaElev = dataGridViewElevi.Rows[rowID].Cells[9].Value.ToString();
        }

        private void tabDataView_Click_1(object sender, EventArgs e)
        {
        }

        private void dataGridViewMaterii_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;

            idMaterie = int.Parse(dataGridViewMaterii.Rows[rowID].Cells[5].Value.ToString());
            materie = dataGridViewMaterii.Rows[rowID].Cells[7].Value.ToString();
        }

        private void dataGridViewNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            idNota = int.Parse(dataGridViewNote.Rows[rowID].Cells[0].Value.ToString());
            valoareNota = int.Parse(dataGridViewNote.Rows[rowID].Cells[4].Value.ToString());
            materieUpdate = dataGridViewNote.Rows[rowID].Cells[5].Value.ToString();
            noteClasaUpdate = dataGridViewNote.Rows[rowID].Cells[3].Value.ToString();
            numeElevNota = dataGridViewNote.Rows[rowID].Cells[1].Value.ToString();
            prenumeElevNota = dataGridViewNote.Rows[rowID].Cells[2].Value.ToString();
            numePNota = dataGridViewNote.Rows[rowID].Cells[8].Value.ToString();
            prenumePNota = dataGridViewNote.Rows[rowID].Cells[9].Value.ToString();

    }

        private void btnSelecPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdProfPic = new OpenFileDialog();
            ofdProfPic.Title = "Selectati poza";
            ofdProfPic.InitialDirectory = @"C:\";
            ofdProfPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofdProfPic.Multiselect = false;
            if (ofdProfPic.ShowDialog() == DialogResult.OK)
            {
                var filePath = ofdProfPic.FileName;
                FileInfo fi = new FileInfo(filePath);
                string extn = fi.Extension;
                fileExt = extn;

                sourceFile = filePath;
                label1.Text = filePath;
                picBoxProfesor.Image = new Bitmap(filePath);
            }
        }

        private void btnSavePic_Click(object sender, EventArgs e)
        {
            if (idProf == 0) {

                MessageBox.Show("Nu ati selectat profesorul!");

            } 
            if (sourceFile == string.Empty ) {

                MessageBox.Show("Nu ati selectat poza!");

            } 
            else
            {
                string fileName = sourceFile.ToString();
                string destFileName = Path.Combine(@"D:\x Projects\WebApp\LiceuApp\LiceuApp\Resorces\Pictures\Profesori\" + "ID_" + idProf + "_" + numeProf + prenumeProf + fileExt);

                if (System.IO.File.Exists(destFileName))
                {
                    System.IO.File.Delete(destFileName);
                    System.IO.File.Copy(fileName, destFileName);
                }
                else
                {
                    System.IO.File.Copy(fileName, destFileName);
                }

                SqlConnection myDbConnection = new SqlConnection();
                myDbConnection.ConnectionString = "Data Source=DESKTOP-99A38O7\\SQLEXPRESS;Initial Catalog=LiceuX;Integrated Security=True;";

                SqlCommand myInsert = new SqlCommand();
                myInsert.Connection = myDbConnection;
                myInsert.CommandText = "UPDATE tProfesori SET pic_URL = '" + destFileName.ToString() + "' WHERE ID = " + idProf;

                try
                {
                    myDbConnection.Open();
                    myInsert.ExecuteNonQuery();
                    myDbConnection.Close();
                    MessageBox.Show("Poza a fost salvata!");

                    DataDisplay dataDisplayForm = new DataDisplay();
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
