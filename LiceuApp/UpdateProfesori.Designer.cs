﻿namespace LiceuApp
{
    partial class updateProfesori
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblSalar = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.lblMaterie = new System.Windows.Forms.Label();
            this.txtBoxNume = new System.Windows.Forms.TextBox();
            this.txtBoxPrenume = new System.Windows.Forms.TextBox();
            this.txtBoxSalar = new System.Windows.Forms.TextBox();
            this.txtBoxVarsta = new System.Windows.Forms.TextBox();
            this.comboBoxMaterii = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNume.Location = new System.Drawing.Point(18, 20);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(18, 46);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblSalar
            // 
            this.lblSalar.AutoSize = true;
            this.lblSalar.Location = new System.Drawing.Point(18, 72);
            this.lblSalar.Name = "lblSalar";
            this.lblSalar.Size = new System.Drawing.Size(31, 13);
            this.lblSalar.TabIndex = 2;
            this.lblSalar.Text = "Salar";
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Location = new System.Drawing.Point(18, 98);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(37, 13);
            this.lblVarsta.TabIndex = 3;
            this.lblVarsta.Text = "Vârstă";
            // 
            // lblMaterie
            // 
            this.lblMaterie.AutoSize = true;
            this.lblMaterie.Location = new System.Drawing.Point(18, 124);
            this.lblMaterie.Name = "lblMaterie";
            this.lblMaterie.Size = new System.Drawing.Size(42, 13);
            this.lblMaterie.TabIndex = 4;
            this.lblMaterie.Text = "Materie";
            // 
            // txtBoxNume
            // 
            this.txtBoxNume.Location = new System.Drawing.Point(77, 17);
            this.txtBoxNume.Name = "txtBoxNume";
            this.txtBoxNume.Size = new System.Drawing.Size(158, 20);
            this.txtBoxNume.TabIndex = 5;
            // 
            // txtBoxPrenume
            // 
            this.txtBoxPrenume.Location = new System.Drawing.Point(77, 43);
            this.txtBoxPrenume.Name = "txtBoxPrenume";
            this.txtBoxPrenume.Size = new System.Drawing.Size(158, 20);
            this.txtBoxPrenume.TabIndex = 6;
            // 
            // txtBoxSalar
            // 
            this.txtBoxSalar.Location = new System.Drawing.Point(77, 69);
            this.txtBoxSalar.Name = "txtBoxSalar";
            this.txtBoxSalar.Size = new System.Drawing.Size(158, 20);
            this.txtBoxSalar.TabIndex = 7;
            // 
            // txtBoxVarsta
            // 
            this.txtBoxVarsta.Location = new System.Drawing.Point(77, 95);
            this.txtBoxVarsta.Name = "txtBoxVarsta";
            this.txtBoxVarsta.Size = new System.Drawing.Size(158, 20);
            this.txtBoxVarsta.TabIndex = 8;
            // 
            // comboBoxMaterii
            // 
            this.comboBoxMaterii.FormattingEnabled = true;
            this.comboBoxMaterii.Location = new System.Drawing.Point(77, 121);
            this.comboBoxMaterii.Name = "comboBoxMaterii";
            this.comboBoxMaterii.Size = new System.Drawing.Size(158, 21);
            this.comboBoxMaterii.TabIndex = 9;
            this.comboBoxMaterii.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterii_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Salvează";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(80, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = " Înapoi";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(160, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Ieșire";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // updateProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxMaterii);
            this.Controls.Add(this.txtBoxVarsta);
            this.Controls.Add(this.txtBoxSalar);
            this.Controls.Add(this.txtBoxPrenume);
            this.Controls.Add(this.txtBoxNume);
            this.Controls.Add(this.lblMaterie);
            this.Controls.Add(this.lblVarsta);
            this.Controls.Add(this.lblSalar);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "updateProfesori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizare date profesori";
            this.Load += new System.EventHandler(this.updateProfesori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblSalar;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Label lblMaterie;
        private System.Windows.Forms.TextBox txtBoxNume;
        private System.Windows.Forms.TextBox txtBoxPrenume;
        private System.Windows.Forms.TextBox txtBoxSalar;
        private System.Windows.Forms.TextBox txtBoxVarsta;
        private System.Windows.Forms.ComboBox comboBoxMaterii;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}