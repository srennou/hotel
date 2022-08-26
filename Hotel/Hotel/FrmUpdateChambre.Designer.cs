namespace Hotel
{
    partial class FrmUpdateChambre
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnique3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 46);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(309, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 46);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Type";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(172, 101);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(292, 23);
            this.cbxType.TabIndex = 25;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(172, 54);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(292, 23);
            this.txtTelephone.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telephone";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(172, 145);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(292, 23);
            this.txtPrix.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Prix";
            // 
            // lblUnique3
            // 
            this.lblUnique3.AutoSize = true;
            this.lblUnique3.Location = new System.Drawing.Point(240, 9);
            this.lblUnique3.Name = "lblUnique3";
            this.lblUnique3.Size = new System.Drawing.Size(0, 15);
            this.lblUnique3.TabIndex = 31;
            this.lblUnique3.Visible = false;
            // 
            // FrmUpdateChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 276);
            this.Controls.Add(this.lblUnique3);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label2);
            this.Name = "FrmUpdateChambre";
            this.Text = "FrmUpdateChambre";
            this.Load += new System.EventHandler(this.FrmUpdateChambre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        public Label lblUnique3;
        private ComboBox cbxType;
        public TextBox txtTelephone;
        private TextBox txtPrix;
    }
}