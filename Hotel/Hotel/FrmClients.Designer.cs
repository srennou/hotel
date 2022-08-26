namespace Hotel
{
    partial class FrmClients
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
            this.btnExite = new System.Windows.Forms.Button();
            this.btnSuprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.lblCIN = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExite
            // 
            this.btnExite.Location = new System.Drawing.Point(34, 487);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(179, 56);
            this.btnExite.TabIndex = 9;
            this.btnExite.Text = "Exite";
            this.btnExite.UseVisualStyleBackColor = true;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.Location = new System.Drawing.Point(622, 101);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(179, 56);
            this.btnSuprimer.TabIndex = 8;
            this.btnSuprimer.Text = "Suprimer";
            this.btnSuprimer.UseVisualStyleBackColor = true;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(437, 101);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(179, 56);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(252, 101);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(179, 56);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(34, 163);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowTemplate.Height = 25;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(767, 306);
            this.dgvClient.TabIndex = 5;
            // 
            // txtCIN
            // 
            this.txtCIN.Location = new System.Drawing.Point(68, 104);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(158, 23);
            this.txtCIN.TabIndex = 10;
            // 
            // lblCIN
            // 
            this.lblCIN.AutoSize = true;
            this.lblCIN.Location = new System.Drawing.Point(24, 112);
            this.lblCIN.Name = "lblCIN";
            this.lblCIN.Size = new System.Drawing.Size(27, 15);
            this.lblCIN.TabIndex = 11;
            this.lblCIN.Text = "CIN";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(68, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 24);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(622, 487);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(179, 56);
            this.btnReservation.TabIndex = 13;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "gestionnaire des clients";
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCIN);
            this.Controls.Add(this.txtCIN);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.btnSuprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvClient);
            this.Name = "FrmClients";
            this.Text = "FrmClients";
            this.Load += new System.EventHandler(this.FrmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExite;
        private Button btnSuprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private DataGridView dgvClient;
        private TextBox txtCIN;
        private Label lblCIN;
        private Button btnSearch;
        private Button btnReservation;
        private Label label2;
    }
}