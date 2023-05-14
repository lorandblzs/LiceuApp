using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiceuApp
{
    public partial class updateNote : Form
    {
        public int idN { get; set; }
        public int valNota { get; set; }
        public string notaUpdt { get; set; }
        public string noteClasaUpdt { get; set; }
        public string numeENota { get; set; }
        public string prenumeENota { get; set; }
        public string numePN { get; set; }
        public string prenumePN { get; set; }
        public updateNote(int idNota, int valoareNota, string materieUpdate, string noteClasaUpdate, string numeElevNota, string prenumeElevNota, string numePNota, string prenumePNota)
        {
            InitializeComponent();
            this.idN = idNota;
            this.valNota = valoareNota;
            this.notaUpdt = materieUpdate;
            this.noteClasaUpdt = noteClasaUpdate;
            this.numeENota = numeElevNota;
            this.prenumeENota = prenumeElevNota;
            this.numePN = numePNota;
            this.prenumePN = prenumePNota;
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

        private void cmbBoxNota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void updateNote_Load(object sender, EventArgs e)
        {
            cmbBoxNota.Text = valNota.ToString();
            lblNotaUpdateMaterieTXT.Text = notaUpdt;
            lblNotaUpdateClasaTXT.Text = noteClasaUpdt;
            lblNotaUpdateNumeTXT.Text = numeENota + " " + prenumeENota;
            lblNotaUpdateNumeProfTXT.Text = numePN + " " + prenumePN;
        }
    }
}
