using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sesion_1
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void guna2ControlBox1_Click(object sender, EventArgs e) //Кнопка отвечающая за закрытие программы
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X,
                (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sesion_1DataSet1.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter1.Fill(this.sesion_1DataSet1.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sesion_1DataSet.sclad". При необходимости она может быть перемещена или удалена.
            this.scladTableAdapter.Fill(this.sesion_1DataSet.sclad);

        }

        private void guna2Button1_Click(object sender, EventArgs e) //Кнопка отвечающая за скрытие элементов
        {
            guna2Button1.Hide();
            guna2Button2.Show();
            dataGridView1.Show();
            dataGridView2.Hide();
            guna2Button5.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e) //Кнопка отвечающая за скрытие элементов
        {
            guna2Button1.Show();
            guna2Button2.Hide();
            dataGridView1.Hide();
            dataGridView2.Show();
            guna2Button5.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e) //Кнопка отвечающая за возвращение на авторизацию
        {
            Auto auto = new Auto();
            auto.Show();
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e) //Кнопка отвечающая за удаление
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            MessageBox.Show("Вы действительно хотите удалить данный товар", "Вопрос", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                dataGridView2.Rows.RemoveAt(index);
                this.scladTableAdapter.Fill(this.sesion_1DataSet.sclad);
            }
            else if (DialogResult == DialogResult.No)
            {
                Close();
            }
        }
    }
}