namespace Hotel
{
    partial class FrmAddOption
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(242, 49);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(268, 23);
            this.txtNom.TabIndex = 0;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(243, 103);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(267, 23);
            this.txtPrix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Le nom de l\'option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Le prix de l\'option";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(331, 191);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(179, 56);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(77, 191);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(179, 56);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FrmAddOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 259);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtNom);
            this.Name = "FrmAddOption";
            this.Text = "FrmAddOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPrix;
        private Label label1;
        private Label label2;
        private Button btnAjouter;
        private Button btnAnnuler;
    }
}