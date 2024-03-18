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
using Microsoft.PointOfService;


namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("data source = DESKTOP-D6LS0RB\\SQLEXPRESS; initial catalog=SBS; integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            D31.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D31.Enabled = false;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            F54.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F54.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            A3.BackColor = Color.Red;
            A3.Enabled = false;
            if (checkBox1.Checked == true)
                label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            else
                label16.Text = (Convert.ToDouble(label16.Text) + 40).ToString();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            F53.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F53.Enabled = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            F52.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F52.Enabled = false;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            F51.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F51.Enabled = false;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            F50.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F50.Enabled = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            F49.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F49.Enabled = false;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            F48.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F48.Enabled = false;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            F47.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F47.Enabled = false;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            F46.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F46.Enabled = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            F45.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            F45.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            E44.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            E44.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            E43.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            E43.Enabled = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            E42.BackColor = Color.Red;

            if (checkBox1.Checked == true)
                label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            else
                label16.Text = (Convert.ToDouble(label16.Text) + 40).ToString();
            E42.Enabled = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            E41.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            E41.Enabled = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            E40.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            E40.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            E39.BackColor = Color.Red;
            if (checkBox1.Checked == true)
                label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            else
                label16.Text = (Convert.ToDouble(label16.Text) + 40).ToString();
            E39.Enabled = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            E38.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            E38.Enabled = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            E37.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            E37.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            D36.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D36.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            D35.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D35.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            D34.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D34.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            D33.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString(); D33.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            D32.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D32.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            D30.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D30.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            D29.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D29.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            D28.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D28.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            D27.BackColor = Color.Red;

            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            D27.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            C26.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            C26.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            C25.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            C25.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            C24.BackColor = Color.Red;
            if (checkBox1.Checked == true)
                label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            else
                label16.Text = (Convert.ToDouble(label16.Text) + 40).ToString();
            C24.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            C23.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            C23.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            C22.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            C22.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            C21.BackColor = Color.Red;
            if (checkBox1.Checked == true)
                label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            else
                label16.Text = (Convert.ToDouble(label16.Text) + 40).ToString();
            C21.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            C20.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            C20.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            C19.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            C19.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            B18.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B18.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            B17.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B17.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            B16.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B16.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            B15.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B15.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            B14.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B14.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            B13.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B13.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            B12.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B12.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            B11.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B11.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B10.BackColor = Color.Red;
            B10.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            B9.BackColor = Color.Red;
            B9.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            A8.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            A8.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            A7.BackColor = Color.Red;
            A7.Enabled = false;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            A5.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            A5.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            A4.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            A4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A2.BackColor = Color.Red;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            A2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A1.BackColor = Color.Red;

            A1.Enabled = false;
            if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else if (checkBox1.Checked == true) label16.Text = (Convert.ToDouble(label16.Text) + 10).ToString(); else label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        PosPrinter poscihazi;
        private void button61_Click(object sender, EventArgs e)
        {
            if (label16.Text == "0")
            {
                MessageBox.Show("Hiçbir seçim yapmadan bilet kesemezsiniz.", "HATA");
                return;
            }
            SqlCommand cmd = new SqlCommand("insert into bilet(sinema_id,film_no,tarih,personel_no,salon_no,film_seans_id) values(@sinema_id,@film_no,@tarih,@personel_no,@salon_no,@film_seans_id)", baglanti);
            cmd.Parameters.Add("@sinema_id", SqlDbType.Int).Value = 0;






            var explorer = new PosExplorer();
            var deviceInfo = explorer.GetDevice(DeviceType.PosPrinter);
            if (deviceInfo == null)
            {
                MessageBox.Show("Yazıcı bulunamadı!");
                return;
            }
            poscihazi = (PosPrinter)explorer.CreateInstance(deviceInfo);
            poscihazi.Open();
            poscihazi.Claim(500);
            poscihazi.DeviceEnabled = true;

            poscihazi.StatusUpdateEvent += (s, evt) =>
            {
                if (evt.Status == PosPrinter.StatusCoverOpen)
                {
                    MessageBox.Show("Yazıcının kağıt kapağı açıldı","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                if (evt.Status == PosPrinter.StatusCoverOK)
                {
                    MessageBox.Show("Yazıcının kağıt kapağı kapandı","BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (evt.Status == PosPrinter.StatusJournalCartridgeEmpty)
                {
                    MessageBox.Show("Yazıcının kartuşu bitmek üzere","DİKKAT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            };
            poscihazi.PrintNormal(PrinterStation.Slip, "ÖRNEK RESTORAN" + Environment.NewLine);
            poscihazi.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);
            poscihazi.PrintNormal(PrinterStation.Slip, "HESAP ADI\t: MURAT YILMAZ" + Environment.NewLine);
            poscihazi.PrintNormal(PrinterStation.Slip, "HESAP KODU\t: 000002" + Environment.NewLine);
            poscihazi.PrintNormal(PrinterStation.Slip, "BAKİYE\t\t: 16,20 [B]" + Environment.NewLine);
            poscihazi.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);


            poscihazi.PrintBarCode(PrinterStation.Slip, "123456789", BarCodeSymbology.Ean128, 40, 200, 1, BarCodeTextPosition.Above);
            poscihazi.CutPaper(100);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void button64_Click(object sender, EventArgs e)
        {

        }

        private void button64_Click_1(object sender, EventArgs e)
        {

        }

        private void iptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filmleriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filmSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void seanslarıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void seansSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

            }
        }

        private void biletKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilet kesiliyor. Lütfen bekleyin", "BİLGİLENDİRME");
        }

        public void iptalEtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label30.Text = "0";
            label31.Text = "0";
            foreach (var ctl in panel1.Controls.OfType<Button>())
            {
                if (ctl.Enabled == false)
                {
                    ctl.Enabled = true;
                    ctl.BackColor = Color.FromArgb(128, 255, 128);
                    label16.Text = (0).ToString();
                }
            }
            if (baglanti.State == ConnectionState.Broken || baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand cmd = new SqlCommand("select ak.koltuk_sıra from seans s inner join film_seans fs on s.seans_id=fs.seans_id inner join film f on f.film_id=fs.filmm_id inner join bilet b on b.film_no=f.film_id inner join alinan_koltuk ak on ak.bilet_no=b.bilet_no where f.film_ad='" + label34.Text + "' and s.seans='" + seans + "'", baglanti);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                foreach (var ctl in panel1.Controls.OfType<Button>())
                {
                    if (rd["koltuk_sıra"].ToString() == ctl.Name)
                    {
                        ctl.PerformClick();
                    }
                }
            }
            rd.Close();
            label16.Text = 0.ToString();
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }

        }

        private void sinemaKartÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button62_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        { 
            radioButton2.Checked = true;
            if (baglanti.State == ConnectionState.Broken || baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            //filmleri ekleme
            int btnlocationy = -1, btnlocationx = 248, sayac = 0; string film_adi;
            SqlCommand komut = new SqlCommand("select * from film", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                sayac++;
                film_adi = (rd["film_ad"]).ToString();
                Button btn = new Button();
                btn.Click += new EventHandler(btn_Click);
                btn.BackColor = Color.FromArgb(180, 0, 0);
                btn.Width = 50;
                btn.Height = 101;
                btn.Name = sayac.ToString();
                btn.Location = new Point(btnlocationx, btnlocationy);
                btnlocationy = btnlocationy + btn.Height;
                btn.FlatStyle = FlatStyle.Flat;
                panel2.Controls.Add(btn);
                PictureBox pct = new PictureBox();
                pct.Location = new Point(10, btnlocationy + -95);
                pct.Width = 65;
                pct.Height = 90;
                pct.ImageLocation = @"" + rd["film_foto"].ToString() + "";
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                panel2.Controls.Add(pct);
                pct.BringToFront();
                PictureBox pct2 = new PictureBox();
                pct2.BackColor = Color.Gold;
                pct2.Width = 298;
                pct2.Height = 1;
                pct2.Location = new Point(0, btnlocationy);
                panel2.Controls.Add(pct2);
                PictureBox pct3 = new PictureBox();
                pct3.BackColor = Color.Gold;
                pct3.Width = 1;
                pct3.Height = 101;
                pct3.Location = new Point(btnlocationx, btnlocationy - 101);
                panel2.Controls.Add(pct3);
                pct3.BringToFront();
                Label lb = new Label();
                lb.AutoSize = true;
                lb.Location = new Point(80, btnlocationy + -70);
                lb.Text = "" + rd["film_ad"].ToString() + "";
                lb.ForeColor = Color.Gold;
                lb.Font = new Font("Palatino Linotype", 13);
                panel2.Controls.Add(lb);
                lb.BringToFront();
            }
            rd.Close();
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
        string seans;

        public int clickedbutton;

        void btn_Click(object sender, EventArgs e)
        {
            label45.Visible = true;
            panel5.Visible = true;
            contextMenuStrip1.Items[3].PerformClick();
            int btnlocationy = -1, btnlocationx = 198, sayac = 0;
            int butonisim = 0;
            foreach(var ctl in panel2.Controls.OfType<Button>())
            {
                ctl.BackColor = Color.FromArgb(180, 0, 0);
            }
            ((Button)sender).BackColor = Color.FromArgb(0, 140, 0);
            butonisim = Convert.ToInt32(((Button)sender).Name);
            clickedbutton = butonisim;
            if (baglanti.State == ConnectionState.Broken || baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select s.salon from film f inner join salon s on f.film_salon=s.salon_no where film_id=" + butonisim + "", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while(rdr.Read())
            {
                label13.Text = rdr["salon"].ToString();
            }
            rdr.Close();
            komut.Parameters.Clear();
            SqlCommand cmd = new SqlCommand("select * from film", baglanti);
            SqlDataAdapter adap = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            pictureBox22.ImageLocation = @"" + dt.Rows[butonisim - 1]["film_foto"] + "";
            label34.Text = (dt.Rows[butonisim - 1]["film_ad"]).ToString();
            label36.Text = (dt.Rows[butonisim - 1]["film_tur"]).ToString();
            label38.Text = (dt.Rows[butonisim - 1]["film_cıkıs_tarihi"]).ToString();
            label39.Text = (dt.Rows[butonisim - 1]["film_sure"]).ToString();
            label41.Text = (dt.Rows[butonisim - 1]["film_yapimci"]).ToString();
            label44.Text = (dt.Rows[butonisim - 1]["film_acıklama"]).ToString();
            adap.Dispose();
            cmd.Parameters.Clear();
            dt.Clear();
            cmd.CommandText = "select s.seans,d.durum from seans s inner join film_seans fs on s.seans_id=fs.seans_id inner join durum d on d.durum_id=fs.durum_no where fs.filmm_id=" + butonisim + "";
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            panel4.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sayac++;
                Button btn = new Button();
                btn.Click += new EventHandler(bt_Click);
                btn.BackColor = Color.FromArgb(180, 0, 0);
                btn.Width = 50;
                btn.Height = 101;
                btn.Name = sayac.ToString();
                btn.Location = new Point(btnlocationx, btnlocationy);
                btnlocationy = btnlocationy + btn.Height;
                btn.FlatStyle = FlatStyle.Flat;
                panel4.Controls.Add(btn);
                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = "" + dt.Rows[i]["seans"].ToString() + "";
                seans = "" + dt.Rows[i]["seans"].ToString() + "";
                lb.ForeColor = Color.Gold;
                lb.Font = new Font("Palatino Linotype", 25);
                lb.Location = new Point(20, btnlocationy - 97);
                panel4.Controls.Add(lb);
                lb.BringToFront();
                Label lb2 = new Label();
                lb2.AutoSize = true;
                lb2.Location = new Point(20, btnlocationy - 45);
                lb2.Text = "" + dt.Rows[i]["durum"].ToString() + "";
                lb2.ForeColor = Color.Gold;
                lb2.Font = new Font("Palatino Linotype", 17);
                panel4.Controls.Add(lb2);
                lb2.BringToFront();
                PictureBox pct2 = new PictureBox();
                pct2.BackColor = Color.Gold;
                pct2.Width = 300;
                pct2.Height = 1;
                pct2.Location = new Point(0, btnlocationy - 1);
                panel4.Controls.Add(pct2);
                pct2.BringToFront();
                PictureBox pct3 = new PictureBox();
                pct3.BackColor = Color.Gold;
                pct3.Width = 1;
                pct3.Height = 101;
                pct3.Location = new Point(btnlocationx, btnlocationy - 101);
                panel4.Controls.Add(pct3);
                pct3.BringToFront();
            }

            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
        public void bt_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[3].PerformClick();
            ((Button)sender).BackColor = Color.FromArgb(0, 140, 0);
            label45.Visible = false;
            panel5.Visible = false;
            if (baglanti.State == ConnectionState.Broken || baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand cmd = new SqlCommand("select ak.koltuk_sıra from seans s inner join film_seans fs on s.seans_id=fs.seans_id inner join film f on f.film_id=fs.filmm_id inner join bilet b on b.film_no=f.film_id inner join alinan_koltuk ak on ak.bilet_no=b.bilet_no where f.film_ad='" + label34.Text + "' and s.seans='" + seans + "'", baglanti);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                foreach (var ctl in panel1.Controls.OfType<Button>())
                {
                    if (rd["koltuk_sıra"].ToString() == ctl.Name)
                    {
                        ctl.PerformClick();
                    }
                }
            }
            rd.Close();
            label16.Text = 0.ToString();
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }



        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button6.Text = (5).ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button6.Text = (7).ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                button6.Text = (8).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label10.Text = (Int32.Parse(label10.Text) + 1).ToString();
            }
            if (radioButton2.Checked == true)
            {
                label11.Text = (Int32.Parse(label11.Text) + 1).ToString();
            }
            if (radioButton3.Checked == true)
            {
                label12.Text = (Int32.Parse(label12.Text) + 1).ToString();
            }
            label16.Text = (Convert.ToInt32(label16.Text) + Convert.ToInt32(button6.Text)).ToString();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && label10.Text != (0).ToString())
            {
                label10.Text = (Int32.Parse(label10.Text) - 1).ToString();
                label16.Text = (Convert.ToDouble(label16.Text) - Convert.ToDouble(button6.Text)).ToString();
            }
            else if (radioButton1.Checked == true && label10.Text == (0).ToString())
            {
                MessageBox.Show("Bu üründen zaten almadınız.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (radioButton2.Checked == true && label11.Text != (0).ToString())
            {
                label11.Text = (Int32.Parse(label11.Text) - 1).ToString();
                label16.Text = (Convert.ToDouble(label16.Text) - Convert.ToDouble(button6.Text)).ToString();
            }
            else if (radioButton2.Checked == true && label11.Text == (0).ToString())
            {
                MessageBox.Show("Bu üründen zaten almadınız.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton3.Checked == true && label12.Text != (0).ToString())
            {
                label12.Text = (Int32.Parse(label12.Text) - 1).ToString();
                label16.Text = (Convert.ToDouble(label16.Text) - Convert.ToDouble(button6.Text)).ToString();
            }
            else if (radioButton3.Checked == true && label12.Text == (0).ToString())
            {
                MessageBox.Show("Bu üründen zaten almadınız.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label16_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(label16.Text) < 0)
                label16.Text = (0).ToString();
        }

        private void salon1_Enter(object sender, EventArgs e)
        {

        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            A1.BackColor = Color.Yellow;

        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            A1.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            A2.BackColor = Color.Yellow;
        }
        private void b2_MouseLeave(object sender, EventArgs e)
        {
            A2.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void b3_MouseEnter(object sender, EventArgs e)
        {
            A3.BackColor = Color.Yellow;

        }

        private void b3_MouseLeave(object sender, EventArgs e)
        {
            A3.BackColor = Color.FromArgb(128, 255, 128);
        }
        private void b4_MouseEnter(object sender, EventArgs e)
        {
            A4.BackColor = Color.Yellow;

        }

        private void b4_MouseLeave(object sender, EventArgs e)
        {
            A4.BackColor = Color.FromArgb(128, 255, 128);
        }
        private void b5_MouseEnter(object sender, EventArgs e)
        {
            A5.BackColor = Color.Yellow;

        }

        private void b5_MouseLeave(object sender, EventArgs e)
        {
            A5.BackColor = Color.FromArgb(128, 255, 128);
        }
        private void b6_MouseEnter(object sender, EventArgs e)
        {
            A6.BackColor = Color.Yellow;

        }

        private void b6_MouseLeave(object sender, EventArgs e)
        {
            A6.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void b1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            A6.BackColor = Color.Red;
            if (checkBox1.Checked == true)
                label16.Text = (Convert.ToDouble(label16.Text) + 20).ToString();
            else
                label16.Text = (Convert.ToDouble(label16.Text) + 40).ToString();
            A6.Enabled = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public Point dragCursorPoint { get; set; }

        public Point dragFormPoint { get; set; }

        public bool dragging { get; set; }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void label9_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox16_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightGray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button6.Text = "5";
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button6.Text = "7";
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                button6.Text = "8";
            }
        }

        private void label13_TextChanged(object sender, EventArgs e)
        {

            if (label13.Text == 2.ToString())
            {
                F45.Visible = false;
                F46.Visible = false;
                F47.Visible = false;
                F48.Visible = false;
                F49.Visible = false;
                F50.Visible = false;
                F51.Visible = false;
                F52.Visible = false;
                F53.Visible = false;
                F54.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                k.Visible = false;
                label22.Visible = true;
                label21.Visible = true;
                label20.Visible = true;
                label19.Visible = true;
                label28.Visible = false;
            }
            else if (label13.Text == 1.ToString())
            {
                F45.Visible = true;
                F46.Visible = true;
                F47.Visible = true;
                F48.Visible = true;
                F49.Visible = true;
                F50.Visible = true;
                F51.Visible = true;
                F52.Visible = true;
                F53.Visible = true;
                F54.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                k.Visible = true;
                label22.Visible = false;
                label21.Visible = false;
                label20.Visible = false;
                label19.Visible = false;
                label28.Visible = true;
            }
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label30.Text = (Int32.Parse(label30.Text) + 1).ToString();
            label16.Text = (Convert.ToInt32(label16.Text) + Convert.ToInt32(button2.Text)).ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (label30.Text != "0")
            {
                label30.Text = (Int32.Parse(label30.Text) - 1).ToString();
                label16.Text = (Convert.ToInt32(label16.Text) - Convert.ToInt32(button2.Text)).ToString();
            }
            else if (label30.Text == "0")
            {
                MessageBox.Show("Bu üründen zaten almadınız.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label31.Text = (Int32.Parse(label31.Text) + 1).ToString();
            label16.Text = (Convert.ToInt32(label16.Text) + Convert.ToInt32(button4.Text)).ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (label31.Text != "0")
            {
                label31.Text = (Int32.Parse(label31.Text) - 1).ToString();
                label16.Text = (Convert.ToInt32(label16.Text) - Convert.ToInt32(button4.Text)).ToString();
            }
            else if (label31.Text == "0")
            {
                MessageBox.Show("Bu üründen zaten almadınız.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void güncellemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            this.Hide();
            frm.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}