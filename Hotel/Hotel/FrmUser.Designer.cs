namespace Hotel
{
    partial class FrmUser
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSuprimer = new System.Windows.Forms.Button();
            this.btnExite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(25, 102);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(767, 306);
            this.dgvUser.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(25, 460);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(179, 56);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(222, 460);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(179, 56);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.Location = new System.Drawing.Point(419, 460);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(179, 56);
            this.btnSuprimer.TabIndex = 3;
            this.btnSuprimer.Text = "Suprimer";
            this.btnSuprimer.UseVisualStyleBackColor = true;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnExite
            // 
            this.btnExite.Location = new System.Drawing.Point(613, 460);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(179, 56);
            this.btnExite.TabIndex = 4;
            this.btnExite.Text = "Exite";
            this.btnExite.UseVisualStyleBackColor = true;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(646, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "gestionnaire d\'utilisateurs";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.btnSuprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvUser);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUser;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSuprimer;
        private Button btnExite;
        private Label label2;
    }
}