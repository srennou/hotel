namespace Hotel
{
    partial class FrmChambre
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
            this.dgvChambre = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExite
            // 
            this.btnExite.Location = new System.Drawing.Point(609, 467);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(179, 56);
            this.btnExite.TabIndex = 9;
            this.btnExite.Text = "Exite";
            this.btnExite.UseVisualStyleBackColor = true;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.Location = new System.Drawing.Point(415, 467);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(179, 56);
            this.btnSuprimer.TabIndex = 8;
            this.btnSuprimer.Text = "Suprimer";
            this.btnSuprimer.UseVisualStyleBackColor = true;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(218, 467);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(179, 56);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 467);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(179, 56);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvChambre
            // 
            this.dgvChambre.AllowUserToAddRows = false;
            this.dgvChambre.AllowUserToDeleteRows = false;
            this.dgvChambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambre.Location = new System.Drawing.Point(21, 109);
            this.dgvChambre.Name = "dgvChambre";
            this.dgvChambre.ReadOnly = true;
            this.dgvChambre.RowTemplate.Height = 25;
            this.dgvChambre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChambre.Size = new System.Drawing.Size(767, 306);
            this.dgvChambre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(632, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "gestionnaire des chambres";
            // 
            // FrmChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.btnSuprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvChambre);
            this.Name = "FrmChambre";
            this.Text = "FrmChambre";
            this.Load += new System.EventHandler(this.FrmChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExite;
        private Button btnSuprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private DataGridView dgvChambre;
        private Label label2;
    }
}