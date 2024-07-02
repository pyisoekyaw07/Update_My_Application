using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;


namespace MJS
{

    public partial class g_sale : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        public g_sale()
        {
            InitializeComponent();
        }
        private void g_sale_Load(object sender, EventArgs e)
        {
            txt_shop.Text = login.shopvalue;
            getgoldprice();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_BB_Click(object sender, EventArgs e)
        {
            Form formbackground = new Form();
            try
            {
                using (BB_Form bB_Form = new BB_Form())
                {
                    formbackground.StartPosition = FormStartPosition.Manual;
                    formbackground.FormBorderStyle = FormBorderStyle.None;
                    formbackground.Opacity = .70d;
                    formbackground.BackColor = Color.Black;
                    formbackground.WindowState = FormWindowState.Maximized;
                    formbackground.TopMost = true;
                    formbackground.Location = this.Location;
                    formbackground.ShowInTaskbar = false;
                    formbackground.Show();

                    bB_Form.Owner = formbackground;
                    bB_Form.ShowDialog();

                    formbackground.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formbackground.Dispose(); }


        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            Form formbackground = new Form();
            try
            {
                using (payment_form pay_Form = new payment_form())
                {
                    formbackground.StartPosition = FormStartPosition.Manual;
                    formbackground.FormBorderStyle = FormBorderStyle.None;
                    formbackground.Opacity = .70d;
                    formbackground.BackColor = Color.Black;
                    formbackground.WindowState = FormWindowState.Maximized;
                    formbackground.TopMost = true;
                    formbackground.Location = this.Location;
                    formbackground.ShowInTaskbar = false;
                    formbackground.Show();

                    pay_Form.Owner = formbackground;
                    pay_Form.ShowDialog();

                    formbackground.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formbackground.Dispose(); }
        }

        private void txt_out_no_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (txt_out_no.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select Image,Item,Itemname,Gm,GoldType from closing_stock where ProductID=@ProductID", con);
                cmd.Parameters.AddWithValue("@ProductID", txt_out_no.Text);
                SqlDataReader da = cmd.ExecuteReader();
                byte[] imagedata = null;
                while (da.Read())
                {
                    imagedata = (byte[])da.GetValue(0);
                    label_Item.Text = da.GetValue(1).ToString();
                    label_itemname.Text = da.GetValue(2).ToString();
                    label_gm.Text = da.GetValue(3).ToString();
                    label_goldtype.Text = da.GetValue(4).ToString();


                }
                if (imagedata != null)
                {
                    using (MemoryStream ms = new MemoryStream(imagedata))
                    {
                        Image image = Image.FromStream(ms);

                        PictureBox pictureBox = new PictureBox();
                        pit_show.Image = image;
                    }
                }
                con.Close();

            }

        }

        public void getgoldprice()
        {

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select Top(1) Gold_Price from goldprice order by Gold_Price desc", con);
            SqlDataReader gp = cmd2.ExecuteReader();
            if (gp.Read())
            {
                txt_goldprice.Text = gp.GetValue(0).ToString();
                txt_goldprice.Text = string.Format("{0:n0}", double.Parse(txt_goldprice.Text));
            }
            con.Close();
        }

        private int clickCount = 0;
        private void edit_goldprice_btn_Click(object sender, EventArgs e)
        {
            clickCount++;

            // Toggle TextBox enabled state based on the click count
            if (clickCount % 2 == 1)
            {
                // Enable TextBox on odd clicks
                txt_goldprice.Enabled = true;
            }
            else
            {
                // Disable TextBox on even clicks
                txt_goldprice.Enabled = false;
            }

        }

        private Bitmap memoryImage;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
        }

        ReportDocument rd;
        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult rel=MessageBox.Show("Do you want to print?","Voucher Print",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rel == DialogResult.Yes)
            {
                try 
                {
                    rd=new ReportDocument();
                    rd.Load(Application.StartupPath+ "//Reports//test.rpt");
                    /*crystalreportvi*/
                    /*rd.SetDataSource()*/
                
                }catch { }
            
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            outvoucher outvoucher = new outvoucher();
            outvoucher.ShowDialog();
        }
    }
}
