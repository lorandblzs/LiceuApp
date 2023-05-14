namespace LiceuApp
{
    partial class updateMaterii
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
            this.lblMateriiUpdate = new System.Windows.Forms.Label();
            this.txtBoxMateriiUpdate = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMateriiUpdate
            // 
            this.lblMateriiUpdate.AutoSize = true;
            this.lblMateriiUpdate.Location = new System.Drawing.Point(48, 111);
            this.lblMateriiUpdate.Name = "lblMateriiUpdate";
            this.lblMateriiUpdate.Size = new System.Drawing.Size(42, 13);
            this.lblMateriiUpdate.TabIndex = 0;
            this.lblMateriiUpdate.Text = "Materie";
            // 
            // txtBoxMateriiUpdate
            // 
            this.txtBoxMateriiUpdate.Location = new System.Drawing.Point(96, 108);
            this.txtBoxMateriiUpdate.Name = "txtBoxMateriiUpdate";
            this.txtBoxMateriiUpdate.Size = new System.Drawing.Size(157, 20);
            this.txtBoxMateriiUpdate.TabIndex = 1;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(30, 34);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(324, 39);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "Atenție!\r\nAceastă fereastră este doar pentru corectarea erorilor gramaticale. \r\nM" +
    "ateria aparținând unui profesor trebuie actualizată în fila Profesori!";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Ieșire";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(197, 351);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = " Înapoi";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Salvează";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // updateMaterii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 391);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtBoxMateriiUpdate);
            this.Controls.Add(this.lblMateriiUpdate);
            this.MaximumSize = new System.Drawing.Size(380, 430);
            this.MinimumSize = new System.Drawing.Size(380, 430);
            this.Name = "updateMaterii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizare materii";
            this.Load += new System.EventHandler(this.updateMaterii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateriiUpdate;
        private System.Windows.Forms.TextBox txtBoxMateriiUpdate;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}