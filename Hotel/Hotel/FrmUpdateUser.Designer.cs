namespace Hotel
{
    partial class FrmUpdateUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnUser = new System.Windows.Forms.RadioButton();
            this.rbnAdmin = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblUnique = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnUser);
            this.groupBox1.Controls.Add(this.rbnAdmin);
            this.groupBox1.Location = new System.Drawing.Point(543, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 72);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rbnUser
            // 
            this.rbnUser.AutoSize = true;
            this.rbnUser.Checked = true;
            this.rbnUser.Location = new System.Drawing.Point(57, 47);
            this.rbnUser.Name = "rbnUser";
            this.rbnUser.Size = new System.Drawing.Size(48, 19);
            this.rbnUser.TabIndex = 1;
            this.rbnUser.TabStop = true;
            this.rbnUser.Text = "User";
            this.rbnUser.UseVisualStyleBackColor = true;
            // 
            // rbnAdmin
            // 
            this.rbnAdmin.AutoSize = true;
            this.rbnAdmin.Location = new System.Drawing.Point(57, 22);
            this.rbnAdmin.Name = "rbnAdmin";
            this.rbnAdmin.Size = new System.Drawing.Size(61, 19);
            this.rbnAdmin.TabIndex = 0;
            this.rbnAdmin.Text = "Admin";
            this.rbnAdmin.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 23);
            this.txtEmail.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(171, 121);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(292, 23);
            this.txtPrenom.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(171, 72);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 23);
            this.txtNom.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 15);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Nom";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(171, 215);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(292, 23);
            this.txtTelephone.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telephone";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(543, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 46);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Le compte est active";
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Location = new System.Drawing.Point(600, 198);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(45, 19);
            this.chbActive.TabIndex = 31;
            this.chbActive.Text = "Oui";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(543, 375);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(241, 46);
            this.btnAnnuler.TabIndex = 33;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(33, 309);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 15);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "réinitialiser le mot de passe";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblUnique
            // 
            this.lblUnique.AutoSize = true;
            this.lblUnique.Location = new System.Drawing.Point(33, 269);
            this.lblUnique.Name = "lblUnique";
            this.lblUnique.Size = new System.Drawing.Size(0, 15);
            this.lblUnique.TabIndex = 35;
            this.lblUnique.Visible = false;
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUnique);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmUpdateUser";
            this.Text = "FrmUpdateUser";
            this.Load += new System.EventHandler(this.FrmUpdateUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rbnUser;
        private RadioButton rbnAdmin;
        public TextBox txtEmail;
        private Label label3;
        public TextBox txtPrenom;
        private Label label2;
        public TextBox txtNom;
        private Label lblEmail;
        public TextBox txtTelephone;
        private Label label4;
        private Button btnUpdate;
        private Label label1;
        private CheckBox chbActive;
        private LinkLabel llblResetPass;
        private Button btnAnnuler;
        private LinkLabel linkLabel1;
        public Label lblUnique;
    }
}