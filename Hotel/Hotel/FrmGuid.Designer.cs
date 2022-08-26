namespace Hotel
{
    partial class FrmGuid
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
            this.dgvGuid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExite
            // 
            this.btnExite.Location = new System.Drawing.Point(609, 448);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(179, 56);
            this.btnExite.TabIndex = 9;
            this.btnExite.Text = "Exite";
            this.btnExite.UseVisualStyleBackColor = true;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.Location = new System.Drawing.Point(415, 448);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(179, 56);
            this.btnSuprimer.TabIndex = 8;
            this.btnSuprimer.Text = "Suprimer";
            this.btnSuprimer.UseVisualStyleBackColor = true;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(218, 448);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(179, 56);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 448);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(179, 56);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvGuid
            // 
            this.dgvGuid.AllowUserToAddRows = false;
            this.dgvGuid.AllowUserToDeleteRows = false;
            this.dgvGuid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuid.Location = new System.Drawing.Point(21, 90);
            this.dgvGuid.Name = "dgvGuid";
            this.dgvGuid.ReadOnly = true;
            this.dgvGuid.RowTemplate.Height = 25;
            this.dgvGuid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuid.Size = new System.Drawing.Size(767, 306);
            this.dgvGuid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(323, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "Guides";
            // 
            // FrmGuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.btnSuprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvGuid);
            this.Name = "FrmGuid";
            this.Text = "FrmGuid";
            this.Load += new System.EventHandler(this.FrmGuid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExite;
        private Button btnSuprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private DataGridView dgvGuid;
        private Label label2;
    }
}