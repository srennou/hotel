namespace Hotel
{
    partial class FrmUpdateGuid
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
            this.lblUnique = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnique
            // 
            this.lblUnique.AutoSize = true;
            this.lblUnique.Location = new System.Drawing.Point(51, 277);
            this.lblUnique.Name = "lblUnique";
            this.lblUnique.Size = new System.Drawing.Size(0, 15);
            this.lblUnique.TabIndex = 44;
            this.lblUnique.Visible = false;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(189, 223);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(292, 23);
            this.txtTelephone.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 23);
            this.txtEmail.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Email";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(189, 129);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(292, 23);
            this.txtPrenom.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(189, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 23);
            this.txtNom.TabIndex = 37;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(51, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 15);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Nom";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(189, 352);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(292, 46);
            this.btnAnnuler.TabIndex = 46;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(292, 46);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmUpdateGuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 404);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUnique);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmUpdateGuid";
            this.Text = "FrmUpdateGuid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lblUnique;
        public TextBox txtTelephone;
        private Label label4;
        public TextBox txtEmail;
        private Label label3;
        public TextBox txtPrenom;
        private Label label2;
        public TextBox txtNom;
        private Label lblEmail;
        private Button btnAnnuler;
        private Button btnUpdate;
    }
}