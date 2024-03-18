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
using System.Drawing.Drawing2D;


namespace WindowsFormsApplication5
{
    public partial class Form4 : Form
    {
        SqlConnection bag = new SqlConnection("data source=DESKTOP-D6LS0RB\\SQLEXPRESS; initial catalog=SBS; integrated security=true");
        public Form4()
        {
            InitializeComponent();
        }
        int cooldown = 60;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int giris_hakki = 3;
        private void Form4_Load(object sender, EventArgs e)
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


            this.KeyPreview = true;
            textBox1.Select();
            label4.Text = giris_hakki.ToString();
            this.AcceptButton = flatButton1;

        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            flatButton1.BackColor = Color.Yellow;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            flatButton1.BackColor = Color.LightGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            flatButton1.BackColor = Color.White;
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

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {

        }

        public Point dragFormPoint { get; set; }

        public Point dragCursorPoint { get; set; }

        public bool dragging { get; set; }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox6.Left += 15;
            if (pictureBox6.Location.X > 250)
            {

                timer1.Enabled = false;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            timer2.Enabled = true;


        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox6.Left += -15;
            if (pictureBox6.Location.X <= 111)
            {
                timer2.Enabled = false;
            }
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

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox8.Left += 15;
            if (pictureBox8.Location.X > 250)
            {

                timer3.Enabled = false;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox8.Left += -15;
            if (pictureBox8.Location.X <= 111)
            {
                timer4.Enabled = false;
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            timer4.Enabled = true;
        }

        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox11.BackColor = Color.White;
            maskedTextBox1.PasswordChar = '\0';
        }

        private void pictureBox11_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox11.BackColor = Color.Gray;
            maskedTextBox1.PasswordChar = '•';
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.BackColor = Color.Silver;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.BackColor = Color.Transparent;
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox16_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {

        }
        int sayac = 0;
        private void timer5_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                radioButton1.BackColor = Color.FromArgb(64, 0, 0);
                radioButton2.BackColor = Color.FromArgb(64, 0, 0);
            }
            if (sayac == 2)
            {
                radioButton1.BackColor = Color.Transparent;
                radioButton2.BackColor = Color.Transparent;
            }
            if (sayac == 3)
            {
                radioButton1.BackColor = Color.FromArgb(64, 0, 0);
                radioButton2.BackColor = Color.FromArgb(64, 0, 0);
            }
            if (sayac == 4)
            {
                radioButton1.BackColor = Color.Transparent;
                radioButton2.BackColor = Color.Transparent;
            }
            if (sayac == 5)
            {
                radioButton1.BackColor = Color.FromArgb(64, 0, 0);
                radioButton2.BackColor = Color.FromArgb(64, 0, 0);
            }
            if (sayac == 6)
            {
                radioButton1.BackColor = Color.Transparent;
                radioButton2.BackColor = Color.Transparent;
            }
            if (sayac == 7)
            {
                radioButton1.BackColor = Color.FromArgb(64, 0, 0);
                radioButton2.BackColor = Color.FromArgb(64, 0, 0);
            }
            if (sayac == 8)
            {
                radioButton1.BackColor = Color.Transparent;
                radioButton2.BackColor = Color.Transparent;
            }
            if (sayac == 9)
            {
                timer5.Enabled = false;
                sayac = 0;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            cooldown = cooldown - 1;
            label6.Text = cooldown.ToString();
            if (cooldown == 0)
            {
                flatButton1.Enabled = true;
                pictureBox7.Visible = false;
                pictureBox7.SendToBack();
                label6.Visible = false;
                label6.SendToBack();
                timer6.Enabled = false;
                cooldown = 60;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Admin veya personel olduğunuzu belirtmelisiniz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer5.Enabled = true;
            }
            if ((radioButton1.Checked == true || radioButton2.Checked == true) && (textBox1.TextLength == 0 || maskedTextBox1.TextLength == 0)) 
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (radioButton1.Checked == true)
            {
                if (giris_hakki == 0)
                {
                    giris_hakki = giris_hakki - 1;
                    MessageBox.Show("Çok fazla hatalı giriş yapıldı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flatButton1.Enabled = false;
                    pictureBox7.Visible = true;
                    pictureBox7.BringToFront();
                    label6.Visible = true;
                    label6.BringToFront();
                    label6.Text = cooldown.ToString();
                    timer6.Enabled = true;
                    giris_hakki = 3;
                    label5.Visible = false;
                    label4.Visible = false;
                    label4.Text = giris_hakki.ToString();
                }
                else if (giris_hakki != 0)
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("select * from sifre s inner join yetki y on s.yetki_no=y.yetki_id where s.k_adi='" + textBox1.Text + "' and s.sifre='" + maskedTextBox1.Text + "' and y.yetki_ad='personel'", bag);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adap = new SqlDataAdapter();
                    adap.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    bag.Close();
                    if (dt.Rows.Count > 0)
                    {
                        Form1 frm = new Form1();
                        this.Hide();
                        frm.Show();
                        frm.contextMenuStrip1.Items[6].Enabled = false;
                    }
                    else
                    {
                        giris_hakki = giris_hakki - 1;
                        MessageBox.Show("Girdiğiniz kullanıcı adı veya şifre yanlış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        maskedTextBox1.Clear();
                        radioButton1.Checked = true;
                        label4.Text = (giris_hakki + 1).ToString();
                        label4.Visible = true;
                        label5.Visible = true;

                    }
                }
            }

            else if (radioButton2.Checked == true)
            {
                if (giris_hakki == 1)
                {
                    giris_hakki = giris_hakki - 1;
                    MessageBox.Show("Çok fazla hatalı giriş yapıldı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flatButton1.Enabled = false;
                    pictureBox7.Visible = true;
                    pictureBox7.BringToFront();
                    label6.Visible = true;
                    label6.BringToFront();
                    label6.Text = cooldown.ToString();
                    timer6.Enabled = true;
                    giris_hakki = 3;
                    label5.Visible = false;
                    label4.Visible = false;
                    label4.Text = giris_hakki.ToString();
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                    radioButton1.Checked = true;
                }
                else if (giris_hakki != 0)
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("select * from sifre s inner join yetki y on s.yetki_no=y.yetki_id where k_adi='" + textBox1.Text + "' and sifre='" + maskedTextBox1.Text + "' and y.yetki_ad='admin' ", bag);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adap = new SqlDataAdapter();
                    adap.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    bag.Close();
                    if (dt.Rows.Count > 0)
                    {
                        Form1 frm = new Form1();
                        this.Hide();
                        frm.Show();

                    }
                    else
                    {
                        giris_hakki = giris_hakki - 1;
                        MessageBox.Show("Giriş yapılamıyor.\nSebepler:\n•Yönetici olmayabilirsiniz.\n•Kullanıcı adınızı veya şifrenizi yanlış girmiş olabilirsiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        maskedTextBox1.Clear();
                        radioButton1.Checked = true;
                        label4.Text = (giris_hakki + 1).ToString();
                        label4.Visible = true;
                        label5.Visible = true;
                    }
                }
            }
        }
    }
}
