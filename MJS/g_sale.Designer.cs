using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class g_sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(g_sale));
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_shop = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txt_out_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_WK = new System.Windows.Forms.TextBox();
            this.txt_WP = new System.Windows.Forms.TextBox();
            this.txt_WY = new System.Windows.Forms.TextBox();
            this.txt_WC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Btn_BB = new FontAwesome.Sharp.IconButton();
            this.btn_cash = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.edit_goldprice_btn = new System.Windows.Forms.Button();
            this.txt_goldprice = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.pit_show = new System.Windows.Forms.PictureBox();
            this.label_gm = new System.Windows.Forms.Label();
            this.label_qty = new System.Windows.Forms.Label();
            this.label_goldtype = new System.Windows.Forms.Label();
            this.label_itemname = new System.Windows.Forms.Label();
            this.label_Item = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_gm = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_totalamt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pit_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.White;
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_date.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_date.ForeColor = System.Drawing.Color.Black;
            this.txt_date.Location = new System.Drawing.Point(10, 11);
            this.txt_date.Multiline = true;
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(106, 28);
            this.txt_date.TabIndex = 300;
            this.txt_date.TabStop = false;
            this.txt_date.Text = "date";
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.Color.White;
            this.txt_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_time.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_time.ForeColor = System.Drawing.Color.Black;
            this.txt_time.Location = new System.Drawing.Point(113, 11);
            this.txt_time.Multiline = true;
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(108, 28);
            this.txt_time.TabIndex = 300;
            this.txt_time.TabStop = false;
            this.txt_time.Text = "time";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(10, 42);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(237, 28);
            this.textBox3.TabIndex = 300;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "GS/101224-0001";
            // 
            // txt_shop
            // 
            this.txt_shop.BackColor = System.Drawing.Color.White;
            this.txt_shop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shop.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_shop.ForeColor = System.Drawing.Color.Black;
            this.txt_shop.Location = new System.Drawing.Point(369, 9);
            this.txt_shop.Multiline = true;
            this.txt_shop.Name = "txt_shop";
            this.txt_shop.ReadOnly = true;
            this.txt_shop.Size = new System.Drawing.Size(78, 28);
            this.txt_shop.TabIndex = 300;
            this.txt_shop.TabStop = false;
            this.txt_shop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(286, 9);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(78, 28);
            this.textBox5.TabIndex = 300;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Gold Sale";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(202, 9);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(78, 28);
            this.textBox6.TabIndex = 300;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "A Counter";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label12.Location = new System.Drawing.Point(13, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 310;
            this.label12.Text = "ဘားကုဒ်နံပါတ်";
            // 
            // txt_out_no
            // 
            this.txt_out_no.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_out_no.Location = new System.Drawing.Point(13, 101);
            this.txt_out_no.Name = "txt_out_no";
            this.txt_out_no.Size = new System.Drawing.Size(193, 30);
            this.txt_out_no.TabIndex = 306;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label7.Location = new System.Drawing.Point(488, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 316;
            this.label7.Text = "အရောင်း အလျော့တွက်";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label6.Location = new System.Drawing.Point(488, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 315;
            this.label6.Text = "ရွှေချိန်";
            // 
            // txt_WK
            // 
            this.txt_WK.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.txt_WK.Location = new System.Drawing.Point(621, 438);
            this.txt_WK.Name = "txt_WK";
            this.txt_WK.Size = new System.Drawing.Size(59, 35);
            this.txt_WK.TabIndex = 311;
            this.txt_WK.Text = "0";
            this.txt_WK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_WP
            // 
            this.txt_WP.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.txt_WP.Location = new System.Drawing.Point(686, 438);
            this.txt_WP.Name = "txt_WP";
            this.txt_WP.Size = new System.Drawing.Size(59, 35);
            this.txt_WP.TabIndex = 312;
            this.txt_WP.Text = "0";
            this.txt_WP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_WY
            // 
            this.txt_WY.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.txt_WY.Location = new System.Drawing.Point(749, 438);
            this.txt_WY.Name = "txt_WY";
            this.txt_WY.Size = new System.Drawing.Size(59, 35);
            this.txt_WY.TabIndex = 313;
            this.txt_WY.Text = "0";
            this.txt_WY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_WC
            // 
            this.txt_WC.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.txt_WC.Location = new System.Drawing.Point(811, 438);
            this.txt_WC.Name = "txt_WC";
            this.txt_WC.Size = new System.Drawing.Size(59, 35);
            this.txt_WC.TabIndex = 314;
            this.txt_WC.Text = "0";
            this.txt_WC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label13.Location = new System.Drawing.Point(635, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 22);
            this.label13.TabIndex = 326;
            this.label13.Text = "ကျပ်";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label29.Location = new System.Drawing.Point(708, 360);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 22);
            this.label29.TabIndex = 327;
            this.label29.Text = "ပဲ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label30.Location = new System.Drawing.Point(767, 359);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 22);
            this.label30.TabIndex = 328;
            this.label30.Text = "ရွေး";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label31.Location = new System.Drawing.Point(832, 359);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 22);
            this.label31.TabIndex = 329;
            this.label31.Text = "စိတ်";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label19.Location = new System.Drawing.Point(3, 585);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 22);
            this.label19.TabIndex = 340;
            this.label19.Text = "စုစုပေါင်း ကျသင့်ငွေ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label18.Location = new System.Drawing.Point(950, 591);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 22);
            this.label18.TabIndex = 339;
            this.label18.Text = "မှတ်ချက်";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label17.Location = new System.Drawing.Point(488, 540);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 22);
            this.label17.TabIndex = 338;
            this.label17.Text = "လက်ခ";
            // 
            // Btn_BB
            // 
            this.Btn_BB.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.Btn_BB.IconColor = System.Drawing.Color.Black;
            this.Btn_BB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_BB.IconSize = 25;
            this.Btn_BB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BB.Location = new System.Drawing.Point(3, 639);
            this.Btn_BB.Name = "Btn_BB";
            this.Btn_BB.Size = new System.Drawing.Size(218, 44);
            this.Btn_BB.TabIndex = 344;
            this.Btn_BB.Text = "BB";
            this.Btn_BB.UseVisualStyleBackColor = true;
            // 
            // btn_cash
            // 
            this.btn_cash.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_cash.IconColor = System.Drawing.Color.Black;
            this.btn_cash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cash.IconSize = 25;
            this.btn_cash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cash.Location = new System.Drawing.Point(220, 639);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(227, 44);
            this.btn_cash.TabIndex = 345;
            this.btn_cash.Text = "Cash";
            this.btn_cash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label1.Location = new System.Drawing.Point(488, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 334;
            this.label1.Text = "ကျသင့် အလျော့တွက်";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label5.Location = new System.Drawing.Point(950, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 346;
            this.label5.Text = "အခွန် ၁ %";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(1083, 406);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 30);
            this.textBox1.TabIndex = 347;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.edit_goldprice_btn);
            this.panel1.Controls.Add(this.txt_goldprice);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.txt_shop);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.pit_show);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txt_time);
            this.panel1.Controls.Add(this.txt_date);
            this.panel1.Controls.Add(this.label_gm);
            this.panel1.Controls.Add(this.label_qty);
            this.panel1.Controls.Add(this.label_goldtype);
            this.panel1.Controls.Add(this.label_itemname);
            this.panel1.Controls.Add(this.label_Item);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lbl_qty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_gm);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lbl_totalamt);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_out_no);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_cash);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Btn_BB);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txt_WC);
            this.panel1.Controls.Add(this.txt_WY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_WP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_WK);
            this.panel1.Location = new System.Drawing.Point(13, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 723);
            this.panel1.TabIndex = 348;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(734, 639);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(227, 44);
            this.iconButton2.TabIndex = 420;
            this.iconButton2.Text = "crystal print";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(488, 639);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(227, 44);
            this.iconButton1.TabIndex = 419;
            this.iconButton1.Text = "Save";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(779, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 418;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.textBox9.Location = new System.Drawing.Point(621, 323);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(194, 31);
            this.textBox9.TabIndex = 417;
            // 
            // edit_goldprice_btn
            // 
            this.edit_goldprice_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_goldprice_btn.BackgroundImage")));
            this.edit_goldprice_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_goldprice_btn.Location = new System.Drawing.Point(370, 103);
            this.edit_goldprice_btn.Name = "edit_goldprice_btn";
            this.edit_goldprice_btn.Size = new System.Drawing.Size(29, 23);
            this.edit_goldprice_btn.TabIndex = 416;
            this.edit_goldprice_btn.UseVisualStyleBackColor = true;
            // 
            // txt_goldprice
            // 
            this.txt_goldprice.Enabled = false;
            this.txt_goldprice.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.txt_goldprice.Location = new System.Drawing.Point(212, 100);
            this.txt_goldprice.Multiline = true;
            this.txt_goldprice.Name = "txt_goldprice";
            this.txt_goldprice.Size = new System.Drawing.Size(194, 31);
            this.txt_goldprice.TabIndex = 415;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox7.Location = new System.Drawing.Point(1083, 588);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(246, 54);
            this.textBox7.TabIndex = 413;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox4.Location = new System.Drawing.Point(623, 537);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 30);
            this.textBox4.TabIndex = 412;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Pyidaungsu", 27.75F);
            this.label33.Location = new System.Drawing.Point(126, 559);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 63);
            this.label33.TabIndex = 411;
            this.label33.Text = "0 Ks";
            // 
            // pit_show
            // 
            this.pit_show.Location = new System.Drawing.Point(127, 374);
            this.pit_show.Name = "pit_show";
            this.pit_show.Size = new System.Drawing.Size(199, 178);
            this.pit_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pit_show.TabIndex = 410;
            this.pit_show.TabStop = false;
            // 
            // label_gm
            // 
            this.label_gm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_gm.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_gm.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_gm.Location = new System.Drawing.Point(206, 240);
            this.label_gm.Name = "label_gm";
            this.label_gm.Size = new System.Drawing.Size(193, 34);
            this.label_gm.TabIndex = 409;
            this.label_gm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_qty
            // 
            this.label_qty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_qty.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_qty.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_qty.Location = new System.Drawing.Point(13, 240);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(193, 34);
            this.label_qty.TabIndex = 408;
            this.label_qty.Text = "1";
            this.label_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_goldtype
            // 
            this.label_goldtype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_goldtype.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_goldtype.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_goldtype.Location = new System.Drawing.Point(13, 317);
            this.label_goldtype.Name = "label_goldtype";
            this.label_goldtype.Size = new System.Drawing.Size(193, 34);
            this.label_goldtype.TabIndex = 407;
            this.label_goldtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_itemname
            // 
            this.label_itemname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_itemname.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_itemname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_itemname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_itemname.Location = new System.Drawing.Point(205, 167);
            this.label_itemname.Name = "label_itemname";
            this.label_itemname.Size = new System.Drawing.Size(193, 34);
            this.label_itemname.TabIndex = 406;
            this.label_itemname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Item
            // 
            this.label_Item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Item.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_Item.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Item.Location = new System.Drawing.Point(13, 167);
            this.label_Item.Name = "label_Item";
            this.label_Item.Size = new System.Drawing.Size(193, 34);
            this.label_Item.TabIndex = 405;
            this.label_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label38.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label38.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label38.Location = new System.Drawing.Point(812, 484);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(57, 39);
            this.label38.TabIndex = 404;
            this.label38.Text = "0";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label39.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label39.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label39.Location = new System.Drawing.Point(749, 484);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(57, 39);
            this.label39.TabIndex = 403;
            this.label39.Text = "0";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label40.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label40.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label40.Location = new System.Drawing.Point(686, 484);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(57, 39);
            this.label40.TabIndex = 402;
            this.label40.Text = "0";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label41.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label41.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label41.Location = new System.Drawing.Point(623, 484);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(57, 39);
            this.label41.TabIndex = 401;
            this.label41.Text = "0";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label37.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label37.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label37.Location = new System.Drawing.Point(812, 390);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 39);
            this.label37.TabIndex = 400;
            this.label37.Text = "0";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label36.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label36.Location = new System.Drawing.Point(749, 390);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(57, 39);
            this.label36.TabIndex = 399;
            this.label36.Text = "0";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label35.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label35.Location = new System.Drawing.Point(686, 390);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 39);
            this.label35.TabIndex = 398;
            this.label35.Text = "0";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label34.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label34.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label34.Location = new System.Drawing.Point(623, 390);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 39);
            this.label34.TabIndex = 397;
            this.label34.Text = "0";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label32.Location = new System.Drawing.Point(13, 286);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(97, 22);
            this.label32.TabIndex = 376;
            this.label32.Text = "အရောင်း ‌ရွှေရည်";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label28.Location = new System.Drawing.Point(488, 585);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(134, 22);
            this.label28.TabIndex = 374;
            this.label28.Text = "ပစ္စည်းတန်ဖိုး ကျသင့်ငွေ";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.textBox14.Enabled = false;
            this.textBox14.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox14.Location = new System.Drawing.Point(621, 582);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(187, 30);
            this.textBox14.TabIndex = 373;
            this.textBox14.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label27.Location = new System.Drawing.Point(950, 542);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 22);
            this.label27.TabIndex = 372;
            this.label27.Text = "စုစုပေါင်း ကျသင့်ငွေ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label26.Location = new System.Drawing.Point(950, 497);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 22);
            this.label26.TabIndex = 371;
            this.label26.Text = "လျှော့ပေးငွေ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label25.Location = new System.Drawing.Point(950, 365);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 22);
            this.label25.TabIndex = 370;
            this.label25.Text = "အလဲပါပြီး ကျသင့်ငွေ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label24.Location = new System.Drawing.Point(950, 321);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(127, 22);
            this.label24.TabIndex = 369;
            this.label24.Text = "အလဲတန်ဖိုး ကျသင့်ငွေ";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox13.Location = new System.Drawing.Point(1083, 539);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(191, 30);
            this.textBox13.TabIndex = 368;
            this.textBox13.TabStop = false;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox12.Location = new System.Drawing.Point(1083, 448);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(191, 30);
            this.textBox12.TabIndex = 367;
            this.textBox12.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox11.Location = new System.Drawing.Point(1083, 494);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(189, 30);
            this.textBox11.TabIndex = 366;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label23.Location = new System.Drawing.Point(950, 451);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 22);
            this.label23.TabIndex = 365;
            this.label23.Text = "အခွန်ပါပြီး ကျသင့်ငွေ";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox10.Location = new System.Drawing.Point(1083, 318);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(191, 30);
            this.textBox10.TabIndex = 364;
            this.textBox10.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox2.Location = new System.Drawing.Point(1083, 362);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 30);
            this.textBox2.TabIndex = 363;
            this.textBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.BackColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(453, 292);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(934, 2);
            this.label22.TabIndex = 362;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(453, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(2, 957);
            this.label21.TabIndex = 361;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label16.Location = new System.Drawing.Point(458, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 288;
            this.label16.Text = "TOTALQTY";
            // 
            // lbl_qty
            // 
            this.lbl_qty.BackColor = System.Drawing.Color.White;
            this.lbl_qty.Location = new System.Drawing.Point(527, 259);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(59, 33);
            this.lbl_qty.TabIndex = 2;
            this.lbl_qty.Text = "0";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(746, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 286;
            this.label4.Text = "TOTAL AMOUNT";
            // 
            // lbl_gm
            // 
            this.lbl_gm.BackColor = System.Drawing.Color.White;
            this.lbl_gm.Location = new System.Drawing.Point(660, 259);
            this.lbl_gm.Name = "lbl_gm";
            this.lbl_gm.Size = new System.Drawing.Size(86, 33);
            this.lbl_gm.TabIndex = 0;
            this.lbl_gm.Text = "0";
            this.lbl_gm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label20.Location = new System.Drawing.Point(592, 266);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 287;
            this.label20.Text = "TOTAL GM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(458, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(925, 251);
            this.dataGridView1.TabIndex = 359;
            // 
            // lbl_totalamt
            // 
            this.lbl_totalamt.BackColor = System.Drawing.Color.White;
            this.lbl_totalamt.Location = new System.Drawing.Point(844, 259);
            this.lbl_totalamt.Name = "lbl_totalamt";
            this.lbl_totalamt.Size = new System.Drawing.Size(131, 33);
            this.lbl_totalamt.TabIndex = 1;
            this.lbl_totalamt.Text = "0";
            this.lbl_totalamt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label11.Location = new System.Drawing.Point(208, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 22);
            this.label11.TabIndex = 358;
            this.label11.Text = "ဂရမ်ချိန်";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label15.Location = new System.Drawing.Point(480, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 22);
            this.label15.TabIndex = 352;
            this.label15.Text = "အရောင်း  ဂရမ်ချိန်";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label10.Location = new System.Drawing.Point(15, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 356;
            this.label10.Text = "အခုရေ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label3.Location = new System.Drawing.Point(212, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 349;
            this.label3.Text = "အရောင်း ရွှေစျေး";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label9.Location = new System.Drawing.Point(206, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 354;
            this.label9.Text = "ပစ္စည်းအမည်";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label8.Location = new System.Drawing.Point(15, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 22);
            this.label8.TabIndex = 352;
            this.label8.Text = "ပစ္စည်း";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // g_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1428, 735);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "g_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "g_sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pit_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txt_date;
        private TextBox txt_time;
        private TextBox textBox3;
        private TextBox txt_shop;
        private TextBox textBox5;
        private TextBox textBox6;
        private System.Windows.Forms.Timer timer1;
        private Label label12;
        private TextBox txt_out_no;
        private Label label7;
        private Label label6;
        private TextBox txt_WK;
        private TextBox txt_WP;
        private TextBox txt_WY;
        private TextBox txt_WC;
        private Label label13;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label19;
        private Label label18;
        private Label label17;
        private FontAwesome.Sharp.IconButton Btn_BB;
        private FontAwesome.Sharp.IconButton btn_cash;
        private Label label1;
        private Label label5;
        private TextBox textBox1;
        private Panel panel1;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label15;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label16;
        private Label lbl_gm;
        private Label label20;
        private Label lbl_totalamt;
        private Label lbl_qty;
        private Label label21;
        private Label label22;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private Label label23;
        private TextBox textBox10;
        private TextBox textBox2;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label28;
        private TextBox textBox14;
        private Label label32;
        private Label label34;
        private Label label_gm;
        private Label label_qty;
        private Label label_goldtype;
        private Label label_itemname;
        private Label label_Item;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label37;
        private Label label36;
        private Label label35;
        private PictureBox pit_show;
        private Label label33;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox txt_goldprice;
        private Button edit_goldprice_btn;
        private Button button1;
        private TextBox textBox9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}