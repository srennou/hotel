namespace Hotel
{
    partial class FrmAddUser
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
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnUser = new System.Windows.Forms.RadioButton();
            this.rbnAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnActive = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(164, 86);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(292, 23);
            this.txtPrenom.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(164, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 23);
            this.txtNom.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Nom";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(164, 183);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(292, 23);
            this.txtPass.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(164, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(164, 284);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(292, 23);
            this.txtTelephone.TabIndex = 15;
            this.txtTelephone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telephone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(164, 235);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '●';
            this.txtConfPass.Size = new System.Drawing.Size(292, 23);
            this.txtConfPass.TabIndex = 13;
            this.txtConfPass.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirme Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnUser);
            this.groupBox1.Controls.Add(this.rbnAdmin);
            this.groupBox1.Location = new System.Drawing.Point(536, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 72);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rbnUser
            // 
            this.rbnUser.AutoSize = true;
            this.rbnUser.Location = new System.Drawing.Point(57, 47);
            this.rbnUser.Name = "rbnUser";
            this.rbnUser.Size = new System.Drawing.Size(48, 19);
            this.rbnUser.TabIndex = 1;
            this.rbnUser.TabStop = true;
            this.rbnUser.Text = "User";
            this.rbnUser.UseVisualStyleBackColor = true;
            // 
            // rbnAdmin
            // 
            this.rbnAdmin.AutoSize = true;
            this.rbnAdmin.Location = new System.Drawing.Point(57, 22);
            this.rbnAdmin.Name = "rbnAdmin";
            this.rbnAdmin.Size = new System.Drawing.Size(61, 19);
            this.rbnAdmin.TabIndex = 0;
            this.rbnAdmin.TabStop = true;
            this.rbnAdmin.Text = "Admin";
            this.rbnAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnActive);
            this.groupBox2.Location = new System.Drawing.Point(536, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 72);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active";
            // 
            // rbnActive
            // 
            this.rbnActive.AutoSize = true;
            this.rbnActive.Location = new System.Drawing.Point(57, 22);
            this.rbnActive.Name = "rbnActive";
            this.rbnActive.Size = new System.Drawing.Size(44, 19);
            this.rbnActive.TabIndex = 0;
            this.rbnActive.TabStop = true;
            this.rbnActive.Text = "Oui";
            this.rbnActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(536, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 46);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(536, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(241, 46);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmAddUser";
            this.Text = "FrmAddUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPrenom;
        private Label label2;
        private TextBox txtNom;
        private Label lblEmail;
        private TextBox txtPass;
        private Label label1;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelephone;
        private Label label4;
        private TextBox txtConfPass;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rbnUser;
        private RadioButton rbnAdmin;
        private GroupBox groupBox2;
        private RadioButton rbnActive;
        private Button btnAdd;
        private Button btnCancel;
    }
}