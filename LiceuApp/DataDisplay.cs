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
using System.Configuration;


namespace LiceuApp
{
    public partial class DataDisplay : Form
    {
        public string mainConn = ConfigurationManager.ConnectionStrings["LiceuAppConnectionString"].ConnectionString;
        SqlConnection sqlConn;

        private DataTable dt;
        private DataTable dtElevi;
        private DataTable dtNote;
        private DataTable dtMaterii;

        #region gridview Profesori data
        public string numeProf { get; set; }
        public string prenumeProf { get; set; }
        public string varstaProf { get; set; }
        public string salarProf { get; set; }
        public int idMatProf { get; set; }
        public int idProf { get; set; }
        public int memoRowID { get; set; }
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
        public int memoRowIDElev { get; set; }
        #endregion

        #region gridview Materii data
        public int idMaterie { get; set; }
        public string materie { get; set; }
        public int memoRowIDMaterii { get; set; }
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
        public int memoRowIDNote { get; set; }
        #endregion

        string appDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string picFolderPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Pictures");

        public string sourceFile { get; set; }
        public string fileExt { get; set; }
        public DataDisplay()
        {
            InitializeComponent();
            sqlConn = new SqlConnection(mainConn);
        }

        private void DataDisplay_Load(object sender, EventArgs e)

        {
            string mainConn = ConfigurationManager.ConnectionStrings["LiceuAppConnectionString"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainConn);

            string picFolderPathDummy = picFolderPath.ToString();

            #region Folder creation and check
            if (!Directory.Exists(picFolderPath))
            {
                Directory.CreateDirectory(picFolderPath);
            }
            if (!Directory.Exists(picFolderPath + "\\Profesori\\"))
            {
                Directory.CreateDirectory(picFolderPath + "\\Profesori\\");
            }
            if (!Directory.Exists(picFolderPath + "\\Elevi\\"))
            {
                Directory.CreateDirectory(picFolderPath + "\\Elevi\\");
            }
            #endregion

            #region button styling
            btnExit.BackColor = Color.FromArgb(100, Color.Red);
            btnExit.ForeColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, Color.Red);
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, Color.Red);
            btnExit.FlatStyle = FlatStyle.Flat;

            btnSelecPic.BackColor = Color.FromArgb(150, 88, 176, 50);
            btnSelecPic.ForeColor = Color.White;
            btnSelecPic.FlatAppearance.BorderSize = 0;
            btnSelecPic.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 88, 176, 50);
            btnSelecPic.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 88, 176, 50);
            btnSelecPic.FlatStyle = FlatStyle.Flat;

            btnSelectPicElev.BackColor = Color.FromArgb(150, 88, 176, 50);
            btnSelectPicElev.ForeColor = Color.White;
            btnSelectPicElev.FlatAppearance.BorderSize = 0;
            btnSelectPicElev.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 88, 176, 50);
            btnSelectPicElev.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 88, 176, 50);
            btnSelectPicElev.FlatStyle = FlatStyle.Flat;

            btnDataInsert.BackColor = Color.FromArgb(150, 88, 176, 50);
            btnDataInsert.ForeColor = Color.White;
            btnDataInsert.FlatAppearance.BorderSize = 0;
            btnDataInsert.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 88, 176, 50);
            btnDataInsert.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 88, 176, 50);
            btnDataInsert.FlatStyle = FlatStyle.Flat;

            btnModifica.BackColor = Color.FromArgb(150, 88, 176, 50);
            btnModifica.ForeColor = Color.White;
            btnModifica.FlatAppearance.BorderSize = 0;
            btnModifica.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 88, 176, 50);
            btnModifica.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 88, 176, 50);
            btnModifica.FlatStyle = FlatStyle.Flat;

            btnSterge.BackColor = Color.FromArgb(100, Color.Red);
            btnSterge.ForeColor = Color.White;
            btnSterge.FlatAppearance.BorderSize = 0;
            btnSterge.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, Color.Red);
            btnSterge.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, Color.Red);
            btnSterge.FlatStyle = FlatStyle.Flat;
            #endregion

            #region fill datatable Profesori
            SqlCommand cmd = new SqlCommand("SELECT * FROM tProfesori INNER JOIN tMaterii on tProfesori.ID_materie=tMaterii.ID", sqlConn);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = cmd;
            dt = new DataTable();
            myDataAdapter.Fill(dt);

            dataGridViewProfesori.DataSource = dt;
            dataGridViewProfesori.Columns["ID"].Visible = false;
            dataGridViewProfesori.Columns["nume"].HeaderText = "Nume";
            dataGridViewProfesori.Columns["prenume"].HeaderText = "Prenume";
            dataGridViewProfesori.Columns["Varsta"].Visible = false;
            dataGridViewProfesori.Columns["salar"].Visible = false;
            dataGridViewProfesori.Columns["pic_URL"].Visible = false;
            dataGridViewProfesori.Columns["ID_materie"].Visible = false;
            dataGridViewProfesori.Columns["ID1"].Visible = false;
            dataGridViewProfesori.Columns["materie"].HeaderText = "Materie";
            #endregion

            #region fill DataGridView Elevi
            SqlCommand cmdElevi = new SqlCommand("SELECT * FROM tElevi", sqlConn);
            SqlDataAdapter myDataAdapterElevi = new SqlDataAdapter();
            myDataAdapterElevi.SelectCommand = cmdElevi;
            dtElevi = new DataTable();
            myDataAdapterElevi.Fill(dtElevi);

            dataGridViewElevi.DataSource = dtElevi;

           
            dataGridViewElevi.Columns["nume"].HeaderText = "Nume";
            dataGridViewElevi.Columns["prenume"].HeaderText = "Prenume";
            dataGridViewElevi.Columns["adresa"].Visible = false;
            dataGridViewElevi.Columns["nume_mama"].Visible = false;
            dataGridViewElevi.Columns["nume_tata"].Visible = false;
            dataGridViewElevi.Columns["telefon_1"].Visible = false;
            dataGridViewElevi.Columns["telefon_2"].Visible = false;
            dataGridViewElevi.Columns["clasa"].Visible = false;
            dataGridViewElevi.Columns["pic_URL"].Visible = false;
            //dataGridViewElevi.Columns[0].Visible = false;
            dataGridViewElevi.Columns["ID"].Visible = false;

      

            #endregion

            dataGridViewElevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            #region fill DataGridView Note
            SqlCommand cmdNote = new SqlCommand("SELECT        \r\n\tN.ID,\r\n\tE.nume,\r\n\tE.prenume,\r\n\tclasa,\r\n\tnota, \r\n\tM.materie,\r\n\tN.ID_materie, \r\n\tID_profesor,\r\n\tP.nume,\r\n\tP.prenume,\r\n\tN.ID_elev\r\n\tFROM tElevi as E \r\n\tJOIN tNote as N on E.ID = N.ID_elev\r\n\tJOIN tMaterii as M on N.ID_materie = M.ID\r\n\tJOIN tProfesori as P on N.ID_profesor = P.ID", sqlConn);
            SqlDataAdapter myDataAdapterNote = new SqlDataAdapter();
            myDataAdapterNote.SelectCommand = cmdNote;
            dtNote = new DataTable();
            myDataAdapterNote.Fill(dtNote);

            dataGridViewNote.DataSource = dtNote;
            dataGridViewNote.Columns["ID"].Visible = false;
            dataGridViewNote.Columns[1].HeaderText = "Nume Elev";
            dataGridViewNote.Columns[2].HeaderText = "Prenume Elev";
            dataGridViewNote.Columns[3].HeaderText = "Calasa";
            dataGridViewNote.Columns[4].HeaderText = "Nota";
            dataGridViewNote.Columns[5].HeaderText = "Materie";
            dataGridViewNote.Columns[6].Visible = false;
            dataGridViewNote.Columns[7].Visible = false;
            dataGridViewNote.Columns[8].HeaderText = "Nume Profesor";
            dataGridViewNote.Columns[9].HeaderText = "Prenume Profesor";
            dataGridViewNote.Columns["ID_elev"].Visible = false;
            #endregion

            #region fill DataGridView Materii
            SqlCommand cmdMaterii = new SqlCommand("SELECT\r\n     M.materie,\r\n     M.ID,\r\n\t P.ID,\r\n\t nume,\r\n\t prenume\r\nFROM tMaterii as M\r\nJOIN tProfesori as P on M.ID = P.ID_materie", sqlConn);
            SqlDataAdapter myDataAdapterMaterii = new SqlDataAdapter();
            myDataAdapterMaterii.SelectCommand = cmdMaterii;
            dtMaterii = new DataTable();
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
            #endregion

            #region filter datagridview prof
            if (idProf == 0) {}
            else
            {
                dataGridViewProfesori.ClearSelection();
                dataGridViewProfesori.CurrentRow.Selected = false; 
                if (memoRowID <= 0 || memoRowID >= dataGridViewProfesori.Rows.Count) {}
                else
                {
                    dataGridViewProfesori.Rows[memoRowID].Selected = true;
                }
            }

            DataColumn dcRowString = dt.Columns.Add("rowStr", typeof(string));
            foreach (DataRow dataRow in dt.Rows)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataColumn column in dt.Columns)
                {
                    // Check if the column is selected
                    if (dataGridViewProfesori.Columns[column.ColumnName].Visible)
                    {
                        sb.Append(dataRow[column].ToString());
                        sb.Append("\t");
                    }
                }
                dataRow[dcRowString] = sb.ToString();
            }
            dataGridViewProfesori.Columns["rowStr"].Visible = false;
            #endregion

            #region filter datagridview elevi
            if (idElev != 0)
            {
                dataGridViewElevi.ClearSelection();
                if (dataGridViewElevi.CurrentRow != null)
                {
                    dataGridViewElevi.CurrentRow.Selected = false;
                }
                if (memoRowIDElev > 0 && memoRowIDElev < dataGridViewElevi.Rows.Count)
                {
                    dataGridViewElevi.Rows[memoRowIDElev].Selected = true;
                }
            }

            DataColumn dcRowStringElevi = dtElevi.Columns.Add("rowStr", typeof(string));
            foreach (DataRow dataRow in dtElevi.Rows)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataColumn column in dtElevi.Columns)
                {
                    // Check if the column is selected
                    if (dataGridViewElevi.Columns[column.ColumnName].Visible)
                    {
                        sb.Append(dataRow[column].ToString());
                        sb.Append("\t");
                    }
                }
                dataRow[dcRowStringElevi] = sb.ToString();
            }
            dataGridViewElevi.Columns["rowStr"].Visible = false;
            #endregion

            #region filter materii
            if (idMaterie == 0) { }
            else
            {
                dataGridViewMaterii.ClearSelection();
                dataGridViewMaterii.CurrentRow.Selected = false;
                if (memoRowIDMaterii <= 0 || memoRowIDMaterii >= dataGridViewMaterii.Rows.Count) { }
                else
                {
                    dataGridViewMaterii.Rows[memoRowIDMaterii].Selected = true;
                }
            }

            DataColumn dcRowStringMaterii = dtMaterii.Columns.Add("rowStr", typeof(string));
            foreach (DataRow dataRow in dtMaterii.Rows)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataColumn column in dtMaterii.Columns)
                {
                    // Check if the column is selected
                    if (dataGridViewMaterii.Columns[column.ColumnName].Visible)
                    {
                        sb.Append(dataRow[column].ToString());
                        sb.Append("\t");
                    }
                }
                dataRow[dcRowStringMaterii] = sb.ToString();
            }
            dataGridViewMaterii.Columns["rowStr"].Visible = false;
            #endregion

            #region note filter
            //if (idNota == 0) { }
            //else
            //{
            //    dataGridViewNote.ClearSelection();
            //    dataGridViewNote.CurrentRow.Selected = false;
            //    if (memoRowIDNote <= 0 || memoRowIDNote >= dataGridViewNote.Rows.Count) { }
            //    else
            //    {
            //        dataGridViewNote.Rows[memoRowIDNote].Selected = true;
            //    }
            //}
            if (idNota != 0)
            {
                dataGridViewNote.ClearSelection();
                if (dataGridViewNote.CurrentRow != null)
                {
                    dataGridViewNote.CurrentRow.Selected = false;
                }
                if (memoRowIDNote > 0 && memoRowIDNote < dataGridViewNote.Rows.Count)
                {
                    dataGridViewNote.Rows[memoRowIDNote].Selected = true;
                    dataGridViewNote.FirstDisplayedScrollingRowIndex = memoRowIDNote;
                }
            }

            DataColumn dcRowStringNote = dtNote.Columns.Add("rowStr", typeof(string));
            foreach (DataRow dataRow in dtNote.Rows)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataColumn column in dtNote.Columns)
                {
                    // Check if the column is selected
                    if (dataGridViewNote.Columns[column.ColumnName].Visible)
                    {
                        sb.Append(dataRow[column].ToString());
                        sb.Append("\t");
                    }
                }
                dataRow[dcRowStringNote] = sb.ToString();
            }
            dataGridViewNote.Columns["rowStr"].Visible = false;
            #endregion
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

        private void dataGridViewProfesori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string picFolderPathDummy = picFolderPath.ToString();
            int rowID = e.RowIndex;

            memoRowID = rowID;

            if (e.RowIndex == -1) return;

            idProf = int.Parse(dataGridViewProfesori.Rows[rowID].Cells[0].Value.ToString());
            numeProf = dataGridViewProfesori.Rows[rowID].Cells[1].Value.ToString();
            prenumeProf = dataGridViewProfesori.Rows[rowID].Cells[2].Value.ToString();
            varstaProf = dataGridViewProfesori.Rows[rowID].Cells[3].Value.ToString();
            salarProf = dataGridViewProfesori.Rows[rowID].Cells[4].Value.ToString();
            idMatProf = int.Parse(dataGridViewProfesori.Rows[rowID].Cells[5].Value.ToString());

            lblTabProfNumeDSP.Visible = true;
            lblTabProfNumeDSP.Text = numeProf;
            lblTabProfPrenumeDSP.Visible = true;
            lblTabProfPrenumeDSP.Text = prenumeProf;
            lblTabProfMaterieDSP.Visible = true;
            lblTabProfMaterieDSP.Text = dataGridViewProfesori.Rows[rowID].Cells["materie"].Value.ToString();
            lblTabProfVarstaDSP.Visible = true;
            lblTabProfVarstaDSP.Text = varstaProf;
            lbltabProfSalarDSP.Visible = true;
            lbltabProfSalarDSP.Text = salarProf;

            var imgURL = dataGridViewProfesori.Rows[rowID].Cells[6].Value.ToString();
            var tempIMGURL = Path.Combine(picFolderPathDummy + imgURL);
            Image defaultImage = Properties.Resources.user_green;

            if (string.IsNullOrEmpty(imgURL) || !System.IO.File.Exists(tempIMGURL))
            {
                picBoxProfesor.Image = defaultImage;
            }
            else
            {
                picBoxProfesor.ImageLocation = tempIMGURL;
            }
        }

        private void dataGridViewElevi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string picFolderPathDummyElev = picFolderPath.ToString();
            int rowID = e.RowIndex;

            memoRowIDElev = rowID;
            if (e.RowIndex == -1) return;

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


            lblNumeElevDsiplay.Text = numeElev;
            lblNumeElevDsiplay.Visible = true;
            lblPrenumeElevDisplay.Text = prenumeElev;
            lblPrenumeElevDisplay.Visible = true;
            lblAdresaDisplay.Text = adresaElev;
            lblAdresaDisplay.Visible = true;
            lblNumeMamaDisplay.Text = numeMElev;
            lblNumeMamaDisplay.Visible = true;
            lblNumeTataDisplay.Text = numeTElev;
            lblNumeTataDisplay.Visible = true;
            lblCNPDisplay.Text = CNP;
            lblCNPDisplay.Visible = true;
            lblTel1Display.Text = tel1;
            lblTel1Display.Visible = true;
            lblTel2Display.Text = tel2;
            lblTel2Display.Visible = true;
            lblClasaDisplay.Text = clasaElev;
            lblClasaDisplay.Visible = true;

            int currentTabPage = tabDataView.SelectedIndex;
            if (currentTabPage == 1)
            {
                int targetID = idElev;
                var rows = dtNote.AsEnumerable().Where(row => row.Field<int>("ID") == targetID);

                if (rows.Any())
                {
                    double average = rows.Average(row => row.Field<int>("nota"));
                    lblMediaNumberDsplay.Text = average.ToString();
                }
                else
                {
                    lblMediaNumberDsplay.Text = "Elevul nu are note";
                }
                lblMediaNumberDsplay.Visible = true;
            }

            var imgURLElev = dataGridViewElevi.Rows[rowID].Cells[10].Value.ToString();
            var tempIMGURLElev = Path.Combine(picFolderPathDummyElev + imgURLElev);
            Image defaultImage = Properties.Resources.user_green;

            if (string.IsNullOrEmpty(imgURLElev) || !System.IO.File.Exists(tempIMGURLElev))
            {
                picBoxElev.Image = defaultImage;
            }
            else
            {
                picBoxElev.ImageLocation = tempIMGURLElev;
            }
        }

        private void dataGridViewMaterii_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            memoRowIDMaterii = rowID;

            if (e.RowIndex == -1) return;

            idMaterie = int.Parse(dataGridViewMaterii.Rows[rowID].Cells[5].Value.ToString());
            materie = dataGridViewMaterii.Rows[rowID].Cells["materie"].Value.ToString();
        }

        private void dataGridViewNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            memoRowIDNote = rowID;

            if (e.RowIndex == -1) return;

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
                picBoxProfesor = default;

                if (idProf == 0)
                {
                    MessageBox.Show("Nu ati selectat profesorul!");
                }
                if (sourceFile == string.Empty)
                {
                    MessageBox.Show("Nu ati selectat poza!");
                }
                else
                {
                    string fileName = sourceFile.ToString();
                    string destFileName = Path.Combine(picFolderPath + "\\Profesori\\" + "ID_" + idProf + "_" + numeProf + prenumeProf + fileExt);
                    string picStringDB = "\\Profesori\\" + "ID_" + idProf + "_" + numeProf + prenumeProf + fileExt;

                    if (System.IO.File.Exists(destFileName))
                    {
                        System.IO.File.Delete(destFileName);
                        System.IO.File.Copy(fileName, destFileName);
                    }
                    else
                    {
                        System.IO.File.Copy(fileName, destFileName);
                    }

                    SqlCommand myInsert = new SqlCommand();
                    myInsert.Connection = sqlConn;
                    myInsert.CommandText = "UPDATE tProfesori SET pic_URL = '" + picStringDB + "' WHERE ID = " + idProf;

                    try
                    {
                        sqlConn.Open();
                        myInsert.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("Poza a fost salvata!");
                        DataDisplay dataDisplayForm = new DataDisplay();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[rowStr] LIKE '%{0}%'", txtBoxFilter.Text);
        }

        private void txtBoxFilter_Click(object sender, EventArgs e)
        {
            if (txtBoxFilter.Text == "...")
            {
                txtBoxFilter.Text = "";
            }
        }

        private void txtBoxEleviFilter_TextChanged(object sender, EventArgs e)
        {
            dtElevi.DefaultView.RowFilter = string.Format("[rowStr] LIKE '%{0}%'", txtBoxEleviFilter.Text);
        }

        private void txtBoxEleviFilter_Click(object sender, EventArgs e)
        {
            if (txtBoxEleviFilter.Text == "...")
            {
                txtBoxEleviFilter.Text = "";
            }
        }

        private void btnSelectPicElev_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdElevPic = new OpenFileDialog();
            ofdElevPic.Title = "Selectati poza";
            ofdElevPic.InitialDirectory = @"C:\";
            ofdElevPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofdElevPic.Multiselect = false;
            if (ofdElevPic.ShowDialog() == DialogResult.OK)
            {
                var filePath = ofdElevPic.FileName;
                FileInfo fi = new FileInfo(filePath);
                string extn = fi.Extension;
                fileExt = extn;
                sourceFile = filePath;
                picBoxElev = default;
                if (idElev == 0)
                {
                    MessageBox.Show("Nu ati selectat elevul!");
                }
                if (sourceFile == string.Empty)
                {
                    MessageBox.Show("Nu ati selectat poza!");
                }
                else
                {
                    string fileName = sourceFile.ToString();
                    string destFileName = Path.Combine(picFolderPath + "\\Elevi\\" + "ID_" + idElev + "_" + numeElev + prenumeElev + fileExt);
                    string dbEntry = "\\Elevi\\" + "ID_" + idElev + "_" + numeElev + prenumeElev + fileExt;

                    if (System.IO.File.Exists(destFileName))
                    {
                        System.IO.File.Delete(destFileName);
                        System.IO.File.Copy(fileName, destFileName);
                    }
                    else
                    {
                        System.IO.File.Copy(fileName, destFileName);
                    }

                    SqlCommand myInsert = new SqlCommand();
                    myInsert.Connection = sqlConn;
                    myInsert.CommandText = "UPDATE tElevi SET pic_URL = '" + dbEntry.ToString() + "' WHERE ID = " + idElev;

                    try
                    {
                        sqlConn.Open();
                        myInsert.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("Poza a fost salvata!");
                        DataDisplay dataDisplayForm = new DataDisplay();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int currentTabPage;
            currentTabPage = tabDataView.SelectedIndex;

            if (currentTabPage == 0)
            {
                DialogResult dlgRes;
                dlgRes = MessageBox.Show("Sigur doriți să ștergeți datele?\r\nAceastă acțiune este ireversibilă.\r\nInformațiile vor fi șterse definitiv!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgRes == DialogResult.Yes)
                {
                    SqlCommand dbDelete = new SqlCommand();
                    dbDelete.Connection = sqlConn;
                    dbDelete.CommandText = "DELETE FROM tProfesori WHERE ID=" + idProf;

                    try
                    {
                        sqlConn.Open();
                        dbDelete.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("Datele au fost sterse!");
                        DataDisplay dataDisplayForm = new DataDisplay();
                        memoRowID = 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    this.Show();
                }
            }
            if (currentTabPage == 1)
            {
                DialogResult dlgRes;
                dlgRes = MessageBox.Show("Sigur doriți să ștergeți datele?\r\nAceastă acțiune este ireversibilă.\r\nInformațiile vor fi șterse definitiv!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgRes == DialogResult.Yes)
                {
                    SqlCommand dbDelete = new SqlCommand();
                    dbDelete.Connection = sqlConn;
                    dbDelete.CommandText = "DELETE FROM tElevi WHERE ID=" + idElev;

                    try
                    {
                        sqlConn.Open();
                        dbDelete.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("Datele au fost sterse!");
                        DataDisplay dataDisplayForm = new DataDisplay();
                        memoRowID = 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    this.Show();
                }
            }
            if (currentTabPage == 2)
            {
                DialogResult dlgRes;
                dlgRes = MessageBox.Show("Sigur doriți să ștergeți datele?\r\nAceastă acțiune este ireversibilă.\r\nInformațiile vor fi șterse definitiv!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgRes == DialogResult.Yes)
                {
                    SqlCommand dbDelete = new SqlCommand();
                    dbDelete.Connection = sqlConn;
                    dbDelete.CommandText = "DELETE FROM tMaterii WHERE ID=" + idMaterie;

                    try
                    {
                        sqlConn.Open();
                        dbDelete.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("Materia a fost stearsa");
                        DataDisplay dataDisplayForm = new DataDisplay();
                        memoRowID = 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    this.Show();
                }
            }
            if (currentTabPage == 3)
            {
                DialogResult dlgRes;
                dlgRes = MessageBox.Show("Sigur doriți să ștergeți datele?\r\nAceastă acțiune este ireversibilă.\r\nInformațiile vor fi șterse definitiv!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgRes == DialogResult.Yes)
                {
                    SqlCommand dbDelete = new SqlCommand();
                    dbDelete.Connection = sqlConn;
                    dbDelete.CommandText = "DELETE FROM tNote WHERE ID=" + idNota;

                    try
                    {
                        sqlConn.Open();
                        dbDelete.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("Nota a fost steards!");
                        DataDisplay dataDisplayForm = new DataDisplay();
                        memoRowID = 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void textMateriiFilter_TextChanged(object sender, EventArgs e)
        {
            dtMaterii.DefaultView.RowFilter = string.Format("[rowStr] LIKE '%{0}%'", textMateriiFilter.Text);
        }

        private void textMateriiFilter_Click(object sender, EventArgs e)
        {
            if (textMateriiFilter.Text == "...")
            {
                textMateriiFilter.Text = "";
            }
        }

        private void textBoxNoteFilter_TextChanged(object sender, EventArgs e)
        {
            dtNote.DefaultView.RowFilter = string.Format("[rowStr] LIKE '%{0}%'", textBoxNoteFilter.Text);
        }
        private void textBoxNoteFilter_Click_1(object sender, EventArgs e)
        {
            if (textBoxNoteFilter.Text == "...")
            {
                textBoxNoteFilter.Text = "";
            }
        }
    }
}
