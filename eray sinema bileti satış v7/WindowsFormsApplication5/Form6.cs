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
using System.IO;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication5
{

    public partial class Form6 : Form
    {
        SqlConnection bag = new SqlConnection("data source=DESKTOP-D6LS0RB\\SQLEXPRESS; initial catalog=SBS; integrated security=true");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            GraphicsPath ellipseRadius = new GraphicsPath();
            ellipseRadius.StartFigure();
            ellipseRadius.AddArc(new Rectangle(0, 0, 20, 20), 180f, 90f);
            checked
            {
                ellipseRadius.AddLine(20, 0, this.flatButton1.Width - 20, 0);
                ellipseRadius.AddArc(new Rectangle(this.flatButton1.Width - 20, 0, 20, 20), -90f, 90f);
                ellipseRadius.AddLine(this.flatButton1.Width, 20, this.flatButton1.Width, this.flatButton1.Height - 20);
                ellipseRadius.AddArc(new Rectangle(this.flatButton1.Width - 20, this.flatButton1.Height - 20, 20, 20), 0f, 90f);
                ellipseRadius.AddLine(this.flatButton1.Width - 20, this.flatButton1.Height, 20, this.flatButton1.Height);
                ellipseRadius.AddArc(new Rectangle(0, this.flatButton1.Height - 20, 20, 20), 90f, 90f);
                ellipseRadius.CloseFigure();
                this.flatButton1.Region = new Region(ellipseRadius);
            }
            GraphicsPath ellipseRadius2 = new GraphicsPath();
            ellipseRadius2.AddArc(new Rectangle(0, 0, 20, 20), 180f, 90f);
            checked
            {
                ellipseRadius2.AddLine(20, 0, this.flatButton2.Width - 20, 0);
                ellipseRadius2.AddArc(new Rectangle(this.flatButton2.Width - 20, 0, 20, 20), -90f, 90f);
                ellipseRadius2.AddLine(this.flatButton2.Width, 20, this.flatButton2.Width, this.flatButton2.Height - 20);
                ellipseRadius2.AddArc(new Rectangle(this.flatButton2.Width - 20, this.flatButton2.Height - 20, 20, 20), 0f, 90f);
                ellipseRadius2.AddLine(this.flatButton2.Width - 20, this.flatButton2.Height, 20, this.flatButton2.Height);
                ellipseRadius2.AddArc(new Rectangle(0, this.flatButton2.Height - 20, 20, 20), 90f, 90f);
                ellipseRadius2.CloseFigure();
                this.flatButton2.Region = new Region(ellipseRadius2);
            }


            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            SqlCommand cmd = new SqlCommand("select birim_ad from birim order by birim_no", bag);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["birim_ad"]);
            }
            rd.Dispose();
            SqlCommand cmd2 = new SqlCommand("select yetki_ad from yetki order by yetki_id", bag);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                comboBox2.Items.Add(rd2["yetki_ad"]);
            }
            rd2.Dispose();
            SqlCommand cmd3 = new SqlCommand("select personel_ad,personel_soyad from personel order by personel_no", bag);
            SqlDataReader rd3 = cmd3.ExecuteReader();
            while (rd3.Read())
            {
                comboBox3.Items.Add(rd3["personel_ad"] + " " + rd3["personel_soyad"]);
            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        public Point dragFormPoint { get; set; }

        public Point dragCursorPoint { get; set; }

        public bool dragging { get; set; }

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

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into personel(personel_ad,personel_soyad,personel_dogum_tarihi,personel_maas,personel_tc_no,personel_tel_no,birim_no) values(@personel_ad,@personel_soyad,@personel_dogum_tarihi,@personel_maas,@personel_tc_no,@personel_tel_no,@birim_no)", bag);
            cmd.Parameters.Add("@personel_ad", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@personel_soyad", SqlDbType.VarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@personel_dogum_tarihi", SqlDbType.Date).Value = this.dateTimePicker1.Value.Date;
            cmd.Parameters.Add("@personel_maas", SqlDbType.Int).Value = Convert.ToInt32(textBox3.Text);
            cmd.Parameters.Add("@personel_tc_no", SqlDbType.VarChar).Value = maskedTextBox4.Text;
            cmd.Parameters.Add("@personel_tel_no", SqlDbType.VarChar).Value = maskedTextBox1.Text[1].ToString() + maskedTextBox1.Text[2].ToString() + maskedTextBox1.Text[3].ToString() + maskedTextBox1.Text[6].ToString() + maskedTextBox1.Text[7].ToString() + maskedTextBox1.Text[8].ToString() + maskedTextBox1.Text[10].ToString() + maskedTextBox1.Text[11].ToString() + maskedTextBox1.Text[12].ToString() + maskedTextBox1.Text[13].ToString();//(505) 505-5050
            cmd.Parameters.Add("@birim_no", SqlDbType.Int).Value = (Convert.ToInt32(comboBox1.SelectedIndex));
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarı ile eklendi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Parameters.Clear();
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            sfd.Title = "PERSONEL";
            daireFoto1.Image.Save("C:\\PERSONELLER\\" + maskedTextBox1.Text + ".jpg");


            button3.PerformClick();

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            //birim ekleme
            comboBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("select birim_ad from birim order by birim_no", bag);
            SqlDataReader rd = cmd.ExecuteReader();
            comboBox1.Items.Add("SEÇİNİZ...");
            comboBox1.SelectedIndex = 0;
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["birim_ad"]);
            }
            rd.Dispose();
            //yetki ekleme
            comboBox2.Items.Clear();
            SqlCommand cmd2 = new SqlCommand("select yetki_ad from yetki order by yetki_id", bag);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            comboBox2.Items.Add("SEÇİNİZ...");
            comboBox2.SelectedIndex = 0;
            while (rd2.Read())
            {
                comboBox2.Items.Add(rd2["yetki_ad"]);
            }
            rd2.Dispose();
            //personel ekleme
            comboBox3.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("select personel_ad,personel_soyad from personel order by personel_no", bag);
            SqlDataReader rd3 = cmd3.ExecuteReader();
            comboBox3.Items.Add("SEÇİNİZ...");
            comboBox3.SelectedIndex = 0;
            while (rd3.Read())
            {
                comboBox3.Items.Add(rd3["personel_ad"] + " " + rd3["personel_soyad"]);
            }
            rd3.Dispose();





            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void maskedTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Yalnızca sayı girişi yapabilirsiniz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Yalnızca sayı girişi yapabilirsiniz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Yalnızca sayı girişi yapabilirsiniz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Yalnızca harf girişi yapabilirsiniz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Yalnızca harf girişi yapabilirsiniz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            daireFoto1.BackColor = Color.LightCoral;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            daireFoto1.BackColor = Color.Transparent;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            daireFoto1.ImageLocation = openFileDialog1.FileName;
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

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            int selected = Int32.Parse(comboBox1.SelectedIndex.ToString());
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0 || maskedTextBox4.TextLength == 0 || maskedTextBox1.TextLength == 0 || selected == 0)
            {
                MessageBox.Show("Bütün alanların dolu olduğundan emin olun.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SqlCommand cmd = new SqlCommand("insert into personel(personel_ad,personel_soyad,personel_dogum_tarihi,personel_maas,personel_tc_no,personel_tel_no,birim_no) values(@personel_ad,@personel_soyad,@personel_dogum_tarihi,@personel_maas,@personel_tc_no,@personel_tel_no,@birim_no)", bag);
            cmd.Parameters.Add("@personel_ad", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@personel_soyad", SqlDbType.VarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@personel_dogum_tarihi", SqlDbType.Date).Value = this.dateTimePicker1.Value.Date;
            cmd.Parameters.Add("@personel_maas", SqlDbType.Int).Value = Convert.ToInt32(textBox3.Text);
            cmd.Parameters.Add("@personel_tc_no", SqlDbType.VarChar).Value = maskedTextBox4.Text;
            cmd.Parameters.Add("@personel_tel_no", SqlDbType.VarChar).Value = maskedTextBox1.Text[1].ToString() + maskedTextBox1.Text[2].ToString() + maskedTextBox1.Text[3].ToString() + maskedTextBox1.Text[6].ToString() + maskedTextBox1.Text[7].ToString() + maskedTextBox1.Text[8].ToString() + maskedTextBox1.Text[10].ToString() + maskedTextBox1.Text[11].ToString() + maskedTextBox1.Text[12].ToString() + maskedTextBox1.Text[13].ToString();//(505) 505-5050
            cmd.Parameters.Add("@birim_no", SqlDbType.Int).Value = (Convert.ToInt32(comboBox1.SelectedIndex));
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarı ile eklendi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Parameters.Clear();
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            sfd.Title = "PERSONEL";
            daireFoto1.Image.Save("C:\\PERSONELLER\\" + maskedTextBox1.Text + ".jpg");


            button3.PerformClick();

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            int selected2 = Int32.Parse(comboBox2.SelectedIndex.ToString());
            int selected3 = Int32.Parse(comboBox3.SelectedIndex.ToString());
            if (textBox5.TextLength == 0 || maskedTextBox3.TextLength == 0 || selected2 == 0 || selected3 == 0)
            {
                MessageBox.Show("Bütün alanların dolu olduğundan emin olun.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand cmd = new SqlCommand("insert into sifre(k_adi,sifre,p_no,yetki_no) values(@k_adi,@sifre,@p_no,@yetki_no)", bag);
            cmd.Parameters.Add("@k_adi", SqlDbType.VarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = maskedTextBox3.Text;
            cmd.Parameters.Add("@p_no", SqlDbType.Int).Value = comboBox2.SelectedIndex;
            cmd.Parameters.Add("@yetki_no", SqlDbType.Int).Value = comboBox3.SelectedIndex;
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarı ile eklendi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Parameters.Clear();
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
            button3.PerformClick();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' || e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
    }
}
