namespace Hotel
{
    partial class FrmAddChambre
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
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(180, 100);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(292, 23);
            this.txtTelephone.TabIndex = 11;
            this.txtTelephone.TextChanged += new System.EventHandler(this.txtTelephone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telephone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(180, 53);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(292, 23);
            this.txtNum.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(134, 15);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Nombre de la Chambre:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(180, 147);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(292, 23);
            this.cbxType.TabIndex = 12;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(40, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(241, 46);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(308, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 46);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAddChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmAddChambre";
            this.Text = "FrmAddChambre";
            this.Load += new System.EventHandler(this.FrmAddChambre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTelephone;
        private Label label2;
        private TextBox txtNum;
        private Label lblEmail;
        private ComboBox cbxType;
        private Label label1;
        private Button btnCancel;
        private Button btnAdd;
    }
}