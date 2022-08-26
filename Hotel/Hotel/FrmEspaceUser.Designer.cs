namespace Hotel
{
    partial class FrmEspaceUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspaceUser));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.pcbClients = new System.Windows.Forms.PictureBox();
            this.pcbReservation = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(579, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.Location = new System.Drawing.Point(125, 284);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(109, 25);
            this.User.TabIndex = 12;
            this.User.Text = "Reservation";
            // 
            // pcbClients
            // 
            this.pcbClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbClients.Image = ((System.Drawing.Image)(resources.GetObject("pcbClients.Image")));
            this.pcbClients.Location = new System.Drawing.Point(541, 120);
            this.pcbClients.Name = "pcbClients";
            this.pcbClients.Size = new System.Drawing.Size(150, 150);
            this.pcbClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbClients.TabIndex = 11;
            this.pcbClients.TabStop = false;
            this.pcbClients.Click += new System.EventHandler(this.pcbClients_Click);
            // 
            // pcbReservation
            // 
            this.pcbReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbReservation.Image = ((System.Drawing.Image)(resources.GetObject("pcbReservation.Image")));
            this.pcbReservation.Location = new System.Drawing.Point(105, 120);
            this.pcbReservation.Name = "pcbReservation";
            this.pcbReservation.Size = new System.Drawing.Size(150, 150);
            this.pcbReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbReservation.TabIndex = 9;
            this.pcbReservation.TabStop = false;
            this.pcbReservation.Click += new System.EventHandler(this.pcbReservation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(220, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 58);
            this.label2.TabIndex = 16;
            this.label2.Text = "Espace User";
            // 
            // FrmEspaceUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.pcbClients);
            this.Controls.Add(this.pcbReservation);
            this.Name = "FrmEspaceUser";
            this.Text = "FrmEspaceUser";
            ((System.ComponentModel.ISupportInitialize)(this.pcbClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label User;
        private PictureBox pcbClients;
        private PictureBox pcbReservation;
        private Label label2;
    }
}