namespace LiceuApp
{
    partial class DataAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataAdd));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxIDMaterie = new System.Windows.Forms.ComboBox();
            this.textBoxSalar = new System.Windows.Forms.TextBox();
            this.textBoxVarsta = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.lblMaterie = new System.Windows.Forms.Label();
            this.lblSalar = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNumeMama = new System.Windows.Forms.Label();
            this.lblNumeTata = new System.Windows.Forms.Label();
            this.txtBoxNumeMama = new System.Windows.Forms.TextBox();
            this.txtBoxNumeTata = new System.Windows.Forms.TextBox();
            this.comboBoxClasa = new System.Windows.Forms.ComboBox();
            this.lblClasa = new System.Windows.Forms.Label();
            this.txtBoxCNP = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtBoxAdresa = new System.Windows.Forms.TextBox();
            this.txtBoxNumeElev = new System.Windows.Forms.TextBox();
            this.lblNumeElev = new System.Windows.Forms.Label();
            this.lblPrenumeElev = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.txtBoxTel2 = new System.Windows.Forms.TextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.txtBoxTel1 = new System.Windows.Forms.TextBox();
            this.txtBoxPrenumeElev = new System.Windows.Forms.TextBox();
            this.txtBoxMaterieAdd = new System.Windows.Forms.TextBox();
            this.lblMaterieAdd = new System.Windows.Forms.Label();
            this.lblClasaNoteAddText = new System.Windows.Forms.Label();
            this.lblClasaNoteAdd = new System.Windows.Forms.Label();
            this.lblCNPNotaAddCNP = new System.Windows.Forms.Label();
            this.lblCNPElevNotaAdd = new System.Windows.Forms.Label();
            this.comboBoxProfesorNotaAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxNoteAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterieNotaAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxElevID = new System.Windows.Forms.ComboBox();
            this.lblProfesorNotaAdd = new System.Windows.Forms.Label();
            this.lblNotaAdd = new System.Windows.Forms.Label();
            this.lblMaterieNotaAdd = new System.Windows.Forms.Label();
            this.lblNumeElevNotaAdd = new System.Windows.Forms.Label();
            this.tabControlDataAdd = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabProfesori = new System.Windows.Forms.TabPage();
            this.tabElevi = new System.Windows.Forms.TabPage();
            this.tabMaterii = new System.Windows.Forms.TabPage();
            this.tabNote = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlDataAdd.SuspendLayout();
            this.tabProfesori.SuspendLayout();
            this.tabElevi.SuspendLayout();
            this.tabMaterii.SuspendLayout();
            this.tabNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(644, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxIDMaterie
            // 
            this.comboBoxIDMaterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboBoxIDMaterie.CausesValidation = false;
            this.comboBoxIDMaterie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDMaterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxIDMaterie.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxIDMaterie.FormattingEnabled = true;
            this.comboBoxIDMaterie.Location = new System.Drawing.Point(180, 184);
            this.comboBoxIDMaterie.Name = "comboBoxIDMaterie";
            this.comboBoxIDMaterie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDMaterie.TabIndex = 9;
            // 
            // textBoxSalar
            // 
            this.textBoxSalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.textBoxSalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSalar.ForeColor = System.Drawing.Color.White;
            this.textBoxSalar.Location = new System.Drawing.Point(180, 158);
            this.textBoxSalar.Name = "textBoxSalar";
            this.textBoxSalar.Size = new System.Drawing.Size(121, 20);
            this.textBoxSalar.TabIndex = 8;
            this.textBoxSalar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalar_KeyPress);
            // 
            // textBoxVarsta
            // 
            this.textBoxVarsta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.textBoxVarsta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarsta.ForeColor = System.Drawing.Color.White;
            this.textBoxVarsta.Location = new System.Drawing.Point(180, 132);
            this.textBoxVarsta.Name = "textBoxVarsta";
            this.textBoxVarsta.Size = new System.Drawing.Size(121, 20);
            this.textBoxVarsta.TabIndex = 7;
            this.textBoxVarsta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarsta_KeyPress);
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.textBoxPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrenume.ForeColor = System.Drawing.Color.White;
            this.textBoxPrenume.Location = new System.Drawing.Point(180, 106);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrenume.TabIndex = 6;
            // 
            // textBoxNume
            // 
            this.textBoxNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.textBoxNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNume.ForeColor = System.Drawing.Color.White;
            this.textBoxNume.Location = new System.Drawing.Point(180, 80);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(121, 20);
            this.textBoxNume.TabIndex = 5;
            // 
            // lblMaterie
            // 
            this.lblMaterie.AutoSize = true;
            this.lblMaterie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblMaterie.Location = new System.Drawing.Point(97, 185);
            this.lblMaterie.Name = "lblMaterie";
            this.lblMaterie.Size = new System.Drawing.Size(66, 20);
            this.lblMaterie.TabIndex = 4;
            this.lblMaterie.Text = "Materie:";
            // 
            // lblSalar
            // 
            this.lblSalar.AutoSize = true;
            this.lblSalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblSalar.Location = new System.Drawing.Point(97, 158);
            this.lblSalar.Name = "lblSalar";
            this.lblSalar.Size = new System.Drawing.Size(50, 20);
            this.lblSalar.TabIndex = 3;
            this.lblSalar.Text = "Salar:";
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarsta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblVarsta.Location = new System.Drawing.Point(97, 132);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(60, 20);
            this.lblVarsta.TabIndex = 2;
            this.lblVarsta.Text = "Varstă:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblPrenume.Location = new System.Drawing.Point(97, 106);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(77, 20);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblNume.Location = new System.Drawing.Point(97, 80);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(55, 20);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(565, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Adaugă";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // lblNumeMama
            // 
            this.lblNumeMama.AutoSize = true;
            this.lblNumeMama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeMama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblNumeMama.Location = new System.Drawing.Point(20, 203);
            this.lblNumeMama.Name = "lblNumeMama";
            this.lblNumeMama.Size = new System.Drawing.Size(97, 16);
            this.lblNumeMama.TabIndex = 0;
            this.lblNumeMama.Text = "Nume mamă:";
            // 
            // lblNumeTata
            // 
            this.lblNumeTata.AutoSize = true;
            this.lblNumeTata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeTata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblNumeTata.Location = new System.Drawing.Point(20, 229);
            this.lblNumeTata.Name = "lblNumeTata";
            this.lblNumeTata.Size = new System.Drawing.Size(81, 16);
            this.lblNumeTata.TabIndex = 0;
            this.lblNumeTata.Text = "Nume tată:";
            // 
            // txtBoxNumeMama
            // 
            this.txtBoxNumeMama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxNumeMama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNumeMama.ForeColor = System.Drawing.Color.White;
            this.txtBoxNumeMama.Location = new System.Drawing.Point(123, 199);
            this.txtBoxNumeMama.Name = "txtBoxNumeMama";
            this.txtBoxNumeMama.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumeMama.TabIndex = 1;
            // 
            // txtBoxNumeTata
            // 
            this.txtBoxNumeTata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxNumeTata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNumeTata.ForeColor = System.Drawing.Color.White;
            this.txtBoxNumeTata.Location = new System.Drawing.Point(123, 225);
            this.txtBoxNumeTata.Name = "txtBoxNumeTata";
            this.txtBoxNumeTata.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumeTata.TabIndex = 1;
            // 
            // comboBoxClasa
            // 
            this.comboBoxClasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboBoxClasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClasa.ForeColor = System.Drawing.Color.White;
            this.comboBoxClasa.FormattingEnabled = true;
            this.comboBoxClasa.Items.AddRange(new object[] {
            "9A",
            "9B",
            "9C",
            "9D",
            "9E",
            "10A",
            "10B",
            "10C",
            "10D",
            "10E",
            "11A",
            "11B",
            "11C",
            "11D",
            "11E",
            "12A",
            "12B",
            "12C",
            "12D",
            "12E"});
            this.comboBoxClasa.Location = new System.Drawing.Point(333, 158);
            this.comboBoxClasa.Name = "comboBoxClasa";
            this.comboBoxClasa.Size = new System.Drawing.Size(54, 21);
            this.comboBoxClasa.TabIndex = 6;
            // 
            // lblClasa
            // 
            this.lblClasa.AutoSize = true;
            this.lblClasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblClasa.Location = new System.Drawing.Point(336, 136);
            this.lblClasa.Name = "lblClasa";
            this.lblClasa.Size = new System.Drawing.Size(47, 16);
            this.lblClasa.TabIndex = 0;
            this.lblClasa.Text = "Clasă";
            // 
            // txtBoxCNP
            // 
            this.txtBoxCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxCNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCNP.ForeColor = System.Drawing.Color.White;
            this.txtBoxCNP.Location = new System.Drawing.Point(92, 136);
            this.txtBoxCNP.Name = "txtBoxCNP";
            this.txtBoxCNP.Size = new System.Drawing.Size(199, 20);
            this.txtBoxCNP.TabIndex = 1;
            this.txtBoxCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCNP_KeyPress);
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblCNP.Location = new System.Drawing.Point(22, 140);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(42, 16);
            this.lblCNP.TabIndex = 0;
            this.lblCNP.Text = "CNP:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblAdresa.Location = new System.Drawing.Point(22, 163);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(61, 16);
            this.lblAdresa.TabIndex = 0;
            this.lblAdresa.Text = "Adresă:";
            // 
            // txtBoxAdresa
            // 
            this.txtBoxAdresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxAdresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAdresa.ForeColor = System.Drawing.Color.White;
            this.txtBoxAdresa.Location = new System.Drawing.Point(92, 162);
            this.txtBoxAdresa.Name = "txtBoxAdresa";
            this.txtBoxAdresa.Size = new System.Drawing.Size(199, 20);
            this.txtBoxAdresa.TabIndex = 1;
            // 
            // txtBoxNumeElev
            // 
            this.txtBoxNumeElev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxNumeElev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNumeElev.ForeColor = System.Drawing.Color.White;
            this.txtBoxNumeElev.Location = new System.Drawing.Point(94, 74);
            this.txtBoxNumeElev.Name = "txtBoxNumeElev";
            this.txtBoxNumeElev.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumeElev.TabIndex = 1;
            // 
            // lblNumeElev
            // 
            this.lblNumeElev.AutoSize = true;
            this.lblNumeElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeElev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblNumeElev.Location = new System.Drawing.Point(20, 75);
            this.lblNumeElev.Name = "lblNumeElev";
            this.lblNumeElev.Size = new System.Drawing.Size(51, 16);
            this.lblNumeElev.TabIndex = 0;
            this.lblNumeElev.Text = "Nume:";
            // 
            // lblPrenumeElev
            // 
            this.lblPrenumeElev.AutoSize = true;
            this.lblPrenumeElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenumeElev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblPrenumeElev.Location = new System.Drawing.Point(20, 99);
            this.lblPrenumeElev.Name = "lblPrenumeElev";
            this.lblPrenumeElev.Size = new System.Drawing.Size(72, 16);
            this.lblPrenumeElev.TabIndex = 0;
            this.lblPrenumeElev.Text = "Prenume:";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblTel1.Location = new System.Drawing.Point(236, 77);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(76, 16);
            this.lblTel1.TabIndex = 0;
            this.lblTel1.Text = "Telefon 1:";
            // 
            // txtBoxTel2
            // 
            this.txtBoxTel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTel2.ForeColor = System.Drawing.Color.White;
            this.txtBoxTel2.Location = new System.Drawing.Point(315, 96);
            this.txtBoxTel2.Name = "txtBoxTel2";
            this.txtBoxTel2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTel2.TabIndex = 1;
            this.txtBoxTel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTel2_KeyPress);
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblTel2.Location = new System.Drawing.Point(236, 99);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(76, 16);
            this.lblTel2.TabIndex = 0;
            this.lblTel2.Text = "Telefon 2:";
            // 
            // txtBoxTel1
            // 
            this.txtBoxTel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTel1.ForeColor = System.Drawing.Color.White;
            this.txtBoxTel1.Location = new System.Drawing.Point(315, 74);
            this.txtBoxTel1.Name = "txtBoxTel1";
            this.txtBoxTel1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTel1.TabIndex = 1;
            this.txtBoxTel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTel1_KeyPress);
            // 
            // txtBoxPrenumeElev
            // 
            this.txtBoxPrenumeElev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxPrenumeElev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPrenumeElev.ForeColor = System.Drawing.Color.White;
            this.txtBoxPrenumeElev.Location = new System.Drawing.Point(94, 96);
            this.txtBoxPrenumeElev.Name = "txtBoxPrenumeElev";
            this.txtBoxPrenumeElev.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrenumeElev.TabIndex = 1;
            // 
            // txtBoxMaterieAdd
            // 
            this.txtBoxMaterieAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxMaterieAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMaterieAdd.ForeColor = System.Drawing.Color.White;
            this.txtBoxMaterieAdd.Location = new System.Drawing.Point(196, 144);
            this.txtBoxMaterieAdd.Name = "txtBoxMaterieAdd";
            this.txtBoxMaterieAdd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMaterieAdd.TabIndex = 1;
            // 
            // lblMaterieAdd
            // 
            this.lblMaterieAdd.AutoSize = true;
            this.lblMaterieAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterieAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblMaterieAdd.Location = new System.Drawing.Point(124, 144);
            this.lblMaterieAdd.Name = "lblMaterieAdd";
            this.lblMaterieAdd.Size = new System.Drawing.Size(66, 20);
            this.lblMaterieAdd.TabIndex = 0;
            this.lblMaterieAdd.Text = "Materie:";
            // 
            // lblClasaNoteAddText
            // 
            this.lblClasaNoteAddText.AutoSize = true;
            this.lblClasaNoteAddText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasaNoteAddText.ForeColor = System.Drawing.Color.White;
            this.lblClasaNoteAddText.Location = new System.Drawing.Point(185, 84);
            this.lblClasaNoteAddText.Name = "lblClasaNoteAddText";
            this.lblClasaNoteAddText.Size = new System.Drawing.Size(115, 20);
            this.lblClasaNoteAddText.TabIndex = 4;
            this.lblClasaNoteAddText.Text = "Selectati elevul";
            // 
            // lblClasaNoteAdd
            // 
            this.lblClasaNoteAdd.AutoSize = true;
            this.lblClasaNoteAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasaNoteAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblClasaNoteAdd.Location = new System.Drawing.Point(105, 83);
            this.lblClasaNoteAdd.Name = "lblClasaNoteAdd";
            this.lblClasaNoteAdd.Size = new System.Drawing.Size(53, 20);
            this.lblClasaNoteAdd.TabIndex = 3;
            this.lblClasaNoteAdd.Text = "Clasa:";
            // 
            // lblCNPNotaAddCNP
            // 
            this.lblCNPNotaAddCNP.AutoSize = true;
            this.lblCNPNotaAddCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPNotaAddCNP.ForeColor = System.Drawing.Color.White;
            this.lblCNPNotaAddCNP.Location = new System.Drawing.Point(185, 62);
            this.lblCNPNotaAddCNP.Name = "lblCNPNotaAddCNP";
            this.lblCNPNotaAddCNP.Size = new System.Drawing.Size(115, 20);
            this.lblCNPNotaAddCNP.TabIndex = 4;
            this.lblCNPNotaAddCNP.Text = "Selectati elevul";
            // 
            // lblCNPElevNotaAdd
            // 
            this.lblCNPElevNotaAdd.AutoSize = true;
            this.lblCNPElevNotaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPElevNotaAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblCNPElevNotaAdd.Location = new System.Drawing.Point(105, 61);
            this.lblCNPElevNotaAdd.Name = "lblCNPElevNotaAdd";
            this.lblCNPElevNotaAdd.Size = new System.Drawing.Size(49, 20);
            this.lblCNPElevNotaAdd.TabIndex = 3;
            this.lblCNPElevNotaAdd.Text = "CNP: ";
            // 
            // comboBoxProfesorNotaAdd
            // 
            this.comboBoxProfesorNotaAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboBoxProfesorNotaAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfesorNotaAdd.Enabled = false;
            this.comboBoxProfesorNotaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProfesorNotaAdd.ForeColor = System.Drawing.Color.White;
            this.comboBoxProfesorNotaAdd.FormattingEnabled = true;
            this.comboBoxProfesorNotaAdd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxProfesorNotaAdd.Location = new System.Drawing.Point(181, 217);
            this.comboBoxProfesorNotaAdd.Name = "comboBoxProfesorNotaAdd";
            this.comboBoxProfesorNotaAdd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProfesorNotaAdd.TabIndex = 2;
            // 
            // comboBoxNoteAdd
            // 
            this.comboBoxNoteAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboBoxNoteAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoteAdd.Enabled = false;
            this.comboBoxNoteAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNoteAdd.ForeColor = System.Drawing.Color.White;
            this.comboBoxNoteAdd.FormattingEnabled = true;
            this.comboBoxNoteAdd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNoteAdd.Location = new System.Drawing.Point(181, 164);
            this.comboBoxNoteAdd.Name = "comboBoxNoteAdd";
            this.comboBoxNoteAdd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoteAdd.TabIndex = 2;
            this.comboBoxNoteAdd.SelectedIndexChanged += new System.EventHandler(this.comboBoxNoteAdd_SelectedIndexChanged);
            // 
            // comboBoxMaterieNotaAdd
            // 
            this.comboBoxMaterieNotaAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboBoxMaterieNotaAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterieNotaAdd.Enabled = false;
            this.comboBoxMaterieNotaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMaterieNotaAdd.ForeColor = System.Drawing.Color.White;
            this.comboBoxMaterieNotaAdd.FormattingEnabled = true;
            this.comboBoxMaterieNotaAdd.Location = new System.Drawing.Point(181, 190);
            this.comboBoxMaterieNotaAdd.Name = "comboBoxMaterieNotaAdd";
            this.comboBoxMaterieNotaAdd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterieNotaAdd.TabIndex = 2;
            this.comboBoxMaterieNotaAdd.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterieNotaAdd_SelectedIndexChanged);
            // 
            // comboBoxElevID
            // 
            this.comboBoxElevID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.comboBoxElevID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxElevID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxElevID.ForeColor = System.Drawing.Color.White;
            this.comboBoxElevID.FormattingEnabled = true;
            this.comboBoxElevID.Location = new System.Drawing.Point(181, 36);
            this.comboBoxElevID.Name = "comboBoxElevID";
            this.comboBoxElevID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxElevID.TabIndex = 2;
            this.comboBoxElevID.SelectedIndexChanged += new System.EventHandler(this.comboBoxElevID_SelectedIndexChanged);
            // 
            // lblProfesorNotaAdd
            // 
            this.lblProfesorNotaAdd.AutoSize = true;
            this.lblProfesorNotaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesorNotaAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblProfesorNotaAdd.Location = new System.Drawing.Point(105, 219);
            this.lblProfesorNotaAdd.Name = "lblProfesorNotaAdd";
            this.lblProfesorNotaAdd.Size = new System.Drawing.Size(73, 20);
            this.lblProfesorNotaAdd.TabIndex = 0;
            this.lblProfesorNotaAdd.Text = "Profesor:";
            // 
            // lblNotaAdd
            // 
            this.lblNotaAdd.AutoSize = true;
            this.lblNotaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblNotaAdd.Location = new System.Drawing.Point(105, 165);
            this.lblNotaAdd.Name = "lblNotaAdd";
            this.lblNotaAdd.Size = new System.Drawing.Size(47, 20);
            this.lblNotaAdd.TabIndex = 0;
            this.lblNotaAdd.Text = "Notă:";
            // 
            // lblMaterieNotaAdd
            // 
            this.lblMaterieNotaAdd.AutoSize = true;
            this.lblMaterieNotaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterieNotaAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblMaterieNotaAdd.Location = new System.Drawing.Point(105, 192);
            this.lblMaterieNotaAdd.Name = "lblMaterieNotaAdd";
            this.lblMaterieNotaAdd.Size = new System.Drawing.Size(66, 20);
            this.lblMaterieNotaAdd.TabIndex = 0;
            this.lblMaterieNotaAdd.Text = "Materie:";
            // 
            // lblNumeElevNotaAdd
            // 
            this.lblNumeElevNotaAdd.AutoSize = true;
            this.lblNumeElevNotaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeElevNotaAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.lblNumeElevNotaAdd.Location = new System.Drawing.Point(105, 37);
            this.lblNumeElevNotaAdd.Name = "lblNumeElevNotaAdd";
            this.lblNumeElevNotaAdd.Size = new System.Drawing.Size(43, 20);
            this.lblNumeElevNotaAdd.TabIndex = 0;
            this.lblNumeElevNotaAdd.Text = "Elev:";
            // 
            // tabControlDataAdd
            // 
            this.tabControlDataAdd.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlDataAdd.Controls.Add(this.tabProfesori);
            this.tabControlDataAdd.Controls.Add(this.tabElevi);
            this.tabControlDataAdd.Controls.Add(this.tabMaterii);
            this.tabControlDataAdd.Controls.Add(this.tabNote);
            this.tabControlDataAdd.ItemSize = new System.Drawing.Size(180, 80);
            this.tabControlDataAdd.Location = new System.Drawing.Point(27, 46);
            this.tabControlDataAdd.Name = "tabControlDataAdd";
            this.tabControlDataAdd.SelectedIndex = 0;
            this.tabControlDataAdd.Size = new System.Drawing.Size(613, 326);
            this.tabControlDataAdd.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlDataAdd.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.tabControlDataAdd.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlDataAdd.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControlDataAdd.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlDataAdd.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlDataAdd.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlDataAdd.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlDataAdd.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControlDataAdd.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlDataAdd.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlDataAdd.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControlDataAdd.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlDataAdd.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControlDataAdd.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.tabControlDataAdd.TabButtonSize = new System.Drawing.Size(180, 80);
            this.tabControlDataAdd.TabIndex = 10;
            this.tabControlDataAdd.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabProfesori
            // 
            this.tabProfesori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabProfesori.Controls.Add(this.textBoxNume);
            this.tabProfesori.Controls.Add(this.lblNume);
            this.tabProfesori.Controls.Add(this.lblPrenume);
            this.tabProfesori.Controls.Add(this.textBoxPrenume);
            this.tabProfesori.Controls.Add(this.textBoxSalar);
            this.tabProfesori.Controls.Add(this.comboBoxIDMaterie);
            this.tabProfesori.Controls.Add(this.lblSalar);
            this.tabProfesori.Controls.Add(this.textBoxVarsta);
            this.tabProfesori.Controls.Add(this.lblVarsta);
            this.tabProfesori.Controls.Add(this.lblMaterie);
            this.tabProfesori.Location = new System.Drawing.Point(184, 4);
            this.tabProfesori.Margin = new System.Windows.Forms.Padding(0);
            this.tabProfesori.Name = "tabProfesori";
            this.tabProfesori.Size = new System.Drawing.Size(425, 318);
            this.tabProfesori.TabIndex = 0;
            this.tabProfesori.Text = "Profesori";
            // 
            // tabElevi
            // 
            this.tabElevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabElevi.Controls.Add(this.lblNumeMama);
            this.tabElevi.Controls.Add(this.lblNumeTata);
            this.tabElevi.Controls.Add(this.comboBoxClasa);
            this.tabElevi.Controls.Add(this.txtBoxNumeMama);
            this.tabElevi.Controls.Add(this.txtBoxCNP);
            this.tabElevi.Controls.Add(this.txtBoxNumeTata);
            this.tabElevi.Controls.Add(this.lblClasa);
            this.tabElevi.Controls.Add(this.lblCNP);
            this.tabElevi.Controls.Add(this.txtBoxNumeElev);
            this.tabElevi.Controls.Add(this.lblAdresa);
            this.tabElevi.Controls.Add(this.txtBoxAdresa);
            this.tabElevi.Controls.Add(this.lblNumeElev);
            this.tabElevi.Controls.Add(this.lblPrenumeElev);
            this.tabElevi.Controls.Add(this.lblTel1);
            this.tabElevi.Controls.Add(this.txtBoxTel2);
            this.tabElevi.Controls.Add(this.lblTel2);
            this.tabElevi.Controls.Add(this.txtBoxPrenumeElev);
            this.tabElevi.Controls.Add(this.txtBoxTel1);
            this.tabElevi.Location = new System.Drawing.Point(184, 4);
            this.tabElevi.Margin = new System.Windows.Forms.Padding(0);
            this.tabElevi.Name = "tabElevi";
            this.tabElevi.Size = new System.Drawing.Size(425, 318);
            this.tabElevi.TabIndex = 1;
            this.tabElevi.Text = "Elevi";
            // 
            // tabMaterii
            // 
            this.tabMaterii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabMaterii.Controls.Add(this.txtBoxMaterieAdd);
            this.tabMaterii.Controls.Add(this.lblMaterieAdd);
            this.tabMaterii.Location = new System.Drawing.Point(184, 4);
            this.tabMaterii.Margin = new System.Windows.Forms.Padding(0);
            this.tabMaterii.Name = "tabMaterii";
            this.tabMaterii.Size = new System.Drawing.Size(425, 318);
            this.tabMaterii.TabIndex = 2;
            this.tabMaterii.Text = "Materii";
            // 
            // tabNote
            // 
            this.tabNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabNote.Controls.Add(this.lblClasaNoteAddText);
            this.tabNote.Controls.Add(this.lblNumeElevNotaAdd);
            this.tabNote.Controls.Add(this.lblClasaNoteAdd);
            this.tabNote.Controls.Add(this.lblMaterieNotaAdd);
            this.tabNote.Controls.Add(this.lblCNPNotaAddCNP);
            this.tabNote.Controls.Add(this.lblNotaAdd);
            this.tabNote.Controls.Add(this.lblCNPElevNotaAdd);
            this.tabNote.Controls.Add(this.lblProfesorNotaAdd);
            this.tabNote.Controls.Add(this.comboBoxProfesorNotaAdd);
            this.tabNote.Controls.Add(this.comboBoxElevID);
            this.tabNote.Controls.Add(this.comboBoxNoteAdd);
            this.tabNote.Controls.Add(this.comboBoxMaterieNotaAdd);
            this.tabNote.Location = new System.Drawing.Point(184, 4);
            this.tabNote.Margin = new System.Windows.Forms.Padding(0);
            this.tabNote.Name = "tabNote";
            this.tabNote.Size = new System.Drawing.Size(425, 318);
            this.tabNote.TabIndex = 3;
            this.tabNote.Text = "Note";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(27, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 25);
            this.panel1.TabIndex = 11;
            // 
            // DataAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(669, 414);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlDataAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adăugare date";
            this.Load += new System.EventHandler(this.DataAdd_Load);
            this.tabControlDataAdd.ResumeLayout(false);
            this.tabProfesori.ResumeLayout(false);
            this.tabProfesori.PerformLayout();
            this.tabElevi.ResumeLayout(false);
            this.tabElevi.PerformLayout();
            this.tabMaterii.ResumeLayout(false);
            this.tabMaterii.PerformLayout();
            this.tabNote.ResumeLayout(false);
            this.tabNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxIDMaterie;
        private System.Windows.Forms.TextBox textBoxSalar;
        private System.Windows.Forms.TextBox textBoxVarsta;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label lblMaterie;
        private System.Windows.Forms.Label lblSalar;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxNumeTata;
        private System.Windows.Forms.TextBox txtBoxNumeMama;
        private System.Windows.Forms.TextBox txtBoxTel2;
        private System.Windows.Forms.TextBox txtBoxTel1;
        private System.Windows.Forms.TextBox txtBoxAdresa;
        private System.Windows.Forms.TextBox txtBoxCNP;
        private System.Windows.Forms.TextBox txtBoxPrenumeElev;
        private System.Windows.Forms.TextBox txtBoxNumeElev;
        private System.Windows.Forms.Label lblNumeTata;
        private System.Windows.Forms.Label lblNumeMama;
        private System.Windows.Forms.Label lblClasa;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblPrenumeElev;
        private System.Windows.Forms.Label lblNumeElev;
        private System.Windows.Forms.ComboBox comboBoxClasa;
        private System.Windows.Forms.TextBox txtBoxMaterieAdd;
        private System.Windows.Forms.Label lblMaterieAdd;
        private System.Windows.Forms.ComboBox comboBoxProfesorNotaAdd;
        private System.Windows.Forms.ComboBox comboBoxNoteAdd;
        private System.Windows.Forms.ComboBox comboBoxMaterieNotaAdd;
        private System.Windows.Forms.ComboBox comboBoxElevID;
        private System.Windows.Forms.Label lblProfesorNotaAdd;
        private System.Windows.Forms.Label lblNotaAdd;
        private System.Windows.Forms.Label lblMaterieNotaAdd;
        private System.Windows.Forms.Label lblNumeElevNotaAdd;
        private System.Windows.Forms.Label lblCNPNotaAddCNP;
        private System.Windows.Forms.Label lblCNPElevNotaAdd;
        private System.Windows.Forms.Label lblClasaNoteAddText;
        private System.Windows.Forms.Label lblClasaNoteAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabControlDataAdd;
        private System.Windows.Forms.TabPage tabProfesori;
        private System.Windows.Forms.TabPage tabElevi;
        private System.Windows.Forms.TabPage tabMaterii;
        private System.Windows.Forms.TabPage tabNote;
        private System.Windows.Forms.Panel panel1;
    }
}