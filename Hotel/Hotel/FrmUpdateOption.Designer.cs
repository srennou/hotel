namespace Hotel
{
    partial class FrmUpdateOption
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
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUnique2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(259, 134);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(292, 23);
            this.txtPrix.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Prix";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(259, 85);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 23);
            this.txtNom.TabIndex = 24;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(121, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 15);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Nom";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(92, 193);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(241, 46);
            this.btnAnnuler.TabIndex = 35;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(403, 193);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 46);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUnique2
            // 
            this.lblUnique2.AutoSize = true;
            this.lblUnique2.Location = new System.Drawing.Point(365, 25);
            this.lblUnique2.Name = "lblUnique2";
            this.lblUnique2.Size = new System.Drawing.Size(0, 15);
            this.lblUnique2.TabIndex = 36;
            this.lblUnique2.Visible = false;
            // 
            // FrmUpdateOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 281);
            this.Controls.Add(this.lblUnique2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmUpdateOption";
            this.Text = "FrmModifierOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txtPrix;
        private Label label2;
        public TextBox txtNom;
        private Label lblEmail;
        private Button btnAnnuler;
        private Button btnUpdate;
        public Label lblUnique2;
    }
}