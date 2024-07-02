using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_shop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hide_pass = new System.Windows.Forms.PictureBox();
            this.unhide_pass = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unhide_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shop";
            // 
            // combo_shop
            // 
            this.combo_shop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_shop.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_shop.FormattingEnabled = true;
            this.combo_shop.Location = new System.Drawing.Point(112, 83);
            this.combo_shop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_shop.Name = "combo_shop";
            this.combo_shop.Size = new System.Drawing.Size(67, 30);
            this.combo_shop.TabIndex = 1;
            this.combo_shop.SelectedIndexChanged += new System.EventHandler(this.combo_shop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "If  You Don\'t  Have Account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(255, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sign Up";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(112, 181);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '#';
            this.txt_password.Size = new System.Drawing.Size(191, 34);
            this.txt_password.TabIndex = 3;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(112, 130);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(191, 34);
            this.txt_username.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(125, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.hide_pass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.unhide_pass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.combo_shop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(943, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(352, 318);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // hide_pass
            // 
            this.hide_pass.Image = ((System.Drawing.Image)(resources.GetObject("hide_pass.Image")));
            this.hide_pass.Location = new System.Drawing.Point(269, 184);
            this.hide_pass.Name = "hide_pass";
            this.hide_pass.Size = new System.Drawing.Size(31, 26);
            this.hide_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide_pass.TabIndex = 13;
            this.hide_pass.TabStop = false;
            this.hide_pass.Click += new System.EventHandler(this.hide_pass_Click);
            // 
            // unhide_pass
            // 
            this.unhide_pass.Image = ((System.Drawing.Image)(resources.GetObject("unhide_pass.Image")));
            this.unhide_pass.Location = new System.Drawing.Point(269, 184);
            this.unhide_pass.Name = "unhide_pass";
            this.unhide_pass.Size = new System.Drawing.Size(31, 26);
            this.unhide_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unhide_pass.TabIndex = 12;
            this.unhide_pass.TabStop = false;
            this.unhide_pass.Click += new System.EventHandler(this.unhide_pass_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 441);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unhide_pass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox combo_shop;
        private System.Windows.Forms.Timer timer2;
        private GroupBox groupBox1;
        private PictureBox unhide_pass;
        private PictureBox hide_pass;
    }
}