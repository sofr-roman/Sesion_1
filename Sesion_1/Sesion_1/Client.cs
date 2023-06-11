using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_1
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sesion_1DataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.sesion_1DataSet.Tovar);

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X,
                (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e) // Кнопка отвечающая за возвращение на авторизацию
        {
            Auto auto = new Auto();
            auto.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Выбор кнопки и описания.
        {
            if (comboBox1.SelectedItem.ToString() == "B320R5")
            {
                pictureBox1.Image = Properties.Resources.B320R5;
                label1.Text = "Женские Ботинки демисезонные kari";
            }
            if (comboBox1.SelectedItem.ToString() == "D329H3")
            {
                pictureBox1.Image = Properties.Resources.D329H3;
                label1.Text = "Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый";
            }
            if (comboBox1.SelectedItem.ToString() == "D572U8")
            {
                pictureBox1.Image = Properties.Resources.D572U8;
                label1.Text = "Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный";
            }
            if (comboBox1.SelectedItem.ToString() == "F572H7")
            {
                pictureBox1.Image = Properties.Resources.F572H7;
                label1.Text = "Мужские ботинки Рос-Обувь кожаные с натуральным мехом";
            }
            if (comboBox1.SelectedItem.ToString() == "F635R4")
            {
                pictureBox1.Image = Properties.Resources.F635R4;
                label1.Text = "B3430/14 Полуботинки мужские Rieker";
            }
            if (comboBox1.SelectedItem.ToString() == "G432E4")
            {
                pictureBox1.Image = Properties.Resources.G432E4;
                label1.Text = "129615-4 Кроссовки мужские";
            }
            if (comboBox1.SelectedItem.ToString() == "G783F5")
            {
                pictureBox1.Image = Properties.Resources.G783F5;
                label1.Text = "Туфли Marco Tozzi женские летние, размер 39, цвет черный";
            }
            if (comboBox1.SelectedItem.ToString() == "H782T5")
            {
                pictureBox1.Image = Properties.Resources.H782T5;
                label1.Text = "Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый";
            }
            if (comboBox1.SelectedItem.ToString() == "J384T6")
            {
                pictureBox1.Image = Properties.Resources.J384T6;
                label1.Text = "Туфли Rieker женские демисезонные, размер 41, цвет коричневый";
            }
            if (comboBox1.SelectedItem.ToString() == "D329H3")
            {
                pictureBox1.Image = Properties.Resources.D329H3;
                label1.Text = "Туфли kari женские TR-YR-413017, размер 37, цвет: черный";
            }
        }
    }
}