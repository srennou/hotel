namespace Hotel
{
    partial class FrmUpdateClient
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbnFemme = new System.Windows.Forms.RadioButton();
            this.rbnHomme = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(241, 46);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(423, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 46);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbnFemme
            // 
            this.rbnFemme.AutoSize = true;
            this.rbnFemme.Location = new System.Drawing.Point(275, 341);
            this.rbnFemme.Name = "rbnFemme";
            this.rbnFemme.Size = new System.Drawing.Size(65, 19);
            this.rbnFemme.TabIndex = 47;
            this.rbnFemme.Text = "Femme";
            this.rbnFemme.UseVisualStyleBackColor = true;
            // 
            // rbnHomme
            // 
            this.rbnHomme.AutoSize = true;
            this.rbnHomme.Checked = true;
            this.rbnHomme.Location = new System.Drawing.Point(275, 316);
            this.rbnHomme.Name = "rbnHomme";
            this.rbnHomme.Size = new System.Drawing.Size(69, 19);
            this.rbnHomme.TabIndex = 46;
            this.rbnHomme.TabStop = true;
            this.rbnHomme.Text = "Homme";
            this.rbnHomme.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Sexe";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(275, 263);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(292, 23);
            this.txtTelephone.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Telephone";
            // 
            // txtCIN
            // 
            this.txtCIN.Location = new System.Drawing.Point(275, 27);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.ReadOnly = true;
            this.txtCIN.Size = new System.Drawing.Size(292, 23);
            this.txtCIN.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "CIN";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(275, 218);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(292, 23);
            this.txtAdresse.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Adresse";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(275, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 23);
            this.txtEmail.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Email";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(275, 121);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(292, 23);
            this.txtPrenom.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(275, 72);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 23);
            this.txtNom.TabIndex = 34;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(137, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 15);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Nom";
            // 
            // FrmUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rbnFemme);
            this.Controls.Add(this.rbnHomme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmUpdateClient";
            this.Text = "FrmUpdateClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private RadioButton rbnFemme;
        private RadioButton rbnHomme;
        private Label label6;
        public TextBox txtTelephone;
        private Label label4;
        public TextBox txtCIN;
        private Label label5;
        public TextBox txtAdresse;
        private Label label1;
        public TextBox txtEmail;
        private Label label3;
        public TextBox txtPrenom;
        private Label label2;
        public TextBox txtNom;
        private Label lblEmail;
    }
}