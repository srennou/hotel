namespace Hotel
{
    partial class FrmResetPass
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
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccepte = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblUnique = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(198, 133);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '●';
            this.txtConfPass.Size = new System.Drawing.Size(292, 23);
            this.txtConfPass.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Confirme Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(198, 81);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(292, 23);
            this.txtPass.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password";
            // 
            // btnAccepte
            // 
            this.btnAccepte.Location = new System.Drawing.Point(318, 207);
            this.btnAccepte.Name = "btnAccepte";
            this.btnAccepte.Size = new System.Drawing.Size(241, 46);
            this.btnAccepte.TabIndex = 20;
            this.btnAccepte.Text = "Accepter";
            this.btnAccepte.UseVisualStyleBackColor = true;
            this.btnAccepte.Click += new System.EventHandler(this.btnAccepte_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(32, 207);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(241, 46);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblUnique
            // 
            this.lblUnique.AutoSize = true;
            this.lblUnique.Location = new System.Drawing.Point(12, 180);
            this.lblUnique.Name = "lblUnique";
            this.lblUnique.Size = new System.Drawing.Size(0, 15);
            this.lblUnique.TabIndex = 36;
            this.lblUnique.Visible = false;
            // 
            // FrmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 290);
            this.Controls.Add(this.lblUnique);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAccepte);
            this.Controls.Add(this.txtConfPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Name = "FrmResetPass";
            this.Text = "FrmResetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtConfPass;
        private Label label5;
        private TextBox txtPass;
        private Label label1;
        private Button btnAccepte;
        private Button btnAnnuler;
        public Label lblUnique;
    }
}