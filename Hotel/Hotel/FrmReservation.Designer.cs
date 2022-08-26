namespace Hotel
{
    partial class FrmReservation
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
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxMassage = new System.Windows.Forms.CheckBox();
            this.cbxGuid = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDinner = new System.Windows.Forms.CheckBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExite = new System.Windows.Forms.Button();
            this.dgvChambre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCIN
            // 
            this.txtCIN.Location = new System.Drawing.Point(576, 65);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.ReadOnly = true;
            this.txtCIN.Size = new System.Drawing.Size(292, 23);
            this.txtCIN.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "CIN";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(177, 127);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(292, 23);
            this.cbxType.TabIndex = 28;
            this.cbxType.SelectionChangeCommitted += new System.EventHandler(this.cbxType_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Type de Chambre";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(177, 216);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(292, 23);
            this.dtpStart.TabIndex = 30;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(177, 259);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(292, 23);
            this.dtpEnd.TabIndex = 31;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Date Debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Date Fin";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(705, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 46);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Submit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxMassage
            // 
            this.cbxMassage.AutoSize = true;
            this.cbxMassage.Location = new System.Drawing.Point(278, 340);
            this.cbxMassage.Name = "cbxMassage";
            this.cbxMassage.Size = new System.Drawing.Size(79, 19);
            this.cbxMassage.TabIndex = 36;
            this.cbxMassage.Text = "MASSAGE";
            this.cbxMassage.UseVisualStyleBackColor = true;
            // 
            // cbxGuid
            // 
            this.cbxGuid.AutoSize = true;
            this.cbxGuid.Location = new System.Drawing.Point(177, 340);
            this.cbxGuid.Name = "cbxGuid";
            this.cbxGuid.Size = new System.Drawing.Size(53, 19);
            this.cbxGuid.TabIndex = 37;
            this.cbxGuid.Text = "GUID";
            this.cbxGuid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Options";
            // 
            // cbxDinner
            // 
            this.cbxDinner.AutoSize = true;
            this.cbxDinner.Location = new System.Drawing.Point(401, 340);
            this.cbxDinner.Name = "cbxDinner";
            this.cbxDinner.Size = new System.Drawing.Size(68, 19);
            this.cbxDinner.TabIndex = 39;
            this.cbxDinner.Text = "DINNER";
            this.cbxDinner.UseVisualStyleBackColor = true;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(177, 65);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(292, 23);
            this.txtPrenom.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(177, 28);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(292, 23);
            this.txtNom.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Nom";
            // 
            // btnExite
            // 
            this.btnExite.Location = new System.Drawing.Point(705, 471);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(241, 46);
            this.btnExite.TabIndex = 50;
            this.btnExite.Text = "Exite";
            this.btnExite.UseVisualStyleBackColor = true;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // dgvChambre
            // 
            this.dgvChambre.AllowUserToAddRows = false;
            this.dgvChambre.AllowUserToDeleteRows = false;
            this.dgvChambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambre.Location = new System.Drawing.Point(489, 127);
            this.dgvChambre.Name = "dgvChambre";
            this.dgvChambre.ReadOnly = true;
            this.dgvChambre.RowTemplate.Height = 25;
            this.dgvChambre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChambre.Size = new System.Drawing.Size(446, 171);
            this.dgvChambre.TabIndex = 51;
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 529);
            this.Controls.Add(this.dgvChambre);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxGuid);
            this.Controls.Add(this.cbxMassage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txtCIN);
            this.Controls.Add(this.label5);
            this.Name = "FrmReservation";
            this.Text = "FrmReservation";
            this.Load += new System.EventHandler(this.FrmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txtCIN;
        private Label label5;
        public ComboBox cbxType;
        private Label label1;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private CheckBox cbxMassage;
        private CheckBox cbxGuid;
        private Label label4;
        private CheckBox cbxDinner;
        public TextBox txtPrenom;
        private Label label7;
        public TextBox txtNom;
        private Label label6;
        private Button btnExite;
        private DataGridView dgvChambre;
    }
}