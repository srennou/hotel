namespace Hotel
{
    partial class FrmEspaceAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspaceAdmin));
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.pcbChambre = new System.Windows.Forms.PictureBox();
            this.pcbGuid = new System.Windows.Forms.PictureBox();
            this.pcbOption = new System.Windows.Forms.PictureBox();
            this.User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGuid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOption)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbUser
            // 
            this.pcbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbUser.Image = ((System.Drawing.Image)(resources.GetObject("pcbUser.Image")));
            this.pcbUser.Location = new System.Drawing.Point(52, 117);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(150, 150);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUser.TabIndex = 0;
            this.pcbUser.TabStop = false;
            this.pcbUser.Click += new System.EventHandler(this.pcbUser_Click);
            // 
            // pcbChambre
            // 
            this.pcbChambre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbChambre.Image = ((System.Drawing.Image)(resources.GetObject("pcbChambre.Image")));
            this.pcbChambre.Location = new System.Drawing.Point(596, 117);
            this.pcbChambre.Name = "pcbChambre";
            this.pcbChambre.Size = new System.Drawing.Size(150, 150);
            this.pcbChambre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbChambre.TabIndex = 1;
            this.pcbChambre.TabStop = false;
            this.pcbChambre.Click += new System.EventHandler(this.pcbChambre_Click);
            // 
            // pcbGuid
            // 
            this.pcbGuid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbGuid.Image = ((System.Drawing.Image)(resources.GetObject("pcbGuid.Image")));
            this.pcbGuid.Location = new System.Drawing.Point(414, 117);
            this.pcbGuid.Name = "pcbGuid";
            this.pcbGuid.Size = new System.Drawing.Size(150, 150);
            this.pcbGuid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGuid.TabIndex = 2;
            this.pcbGuid.TabStop = false;
            this.pcbGuid.Click += new System.EventHandler(this.pcbGuid_Click);
            // 
            // pcbOption
            // 
            this.pcbOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbOption.Image = ((System.Drawing.Image)(resources.GetObject("pcbOption.Image")));
            this.pcbOption.Location = new System.Drawing.Point(232, 117);
            this.pcbOption.Name = "pcbOption";
            this.pcbOption.Size = new System.Drawing.Size(150, 150);
            this.pcbOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOption.TabIndex = 3;
            this.pcbOption.TabStop = false;
            this.pcbOption.Click += new System.EventHandler(this.pcbOption_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.Location = new System.Drawing.Point(97, 281);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(50, 25);
            this.User.TabIndex = 4;
            this.User.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(459, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guide";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(625, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chambre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(187, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 58);
            this.label4.TabIndex = 17;
            this.label4.Text = "Espace Admin";
            // 
            // FrmEspaceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.pcbOption);
            this.Controls.Add(this.pcbGuid);
            this.Controls.Add(this.pcbChambre);
            this.Controls.Add(this.pcbUser);
            this.Name = "FrmEspaceAdmin";
            this.Text = "FrmEspaceAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGuid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbUser;
        private PictureBox pcbChambre;
        private PictureBox pcbGuid;
        private PictureBox pcbOption;
        private Label User;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}