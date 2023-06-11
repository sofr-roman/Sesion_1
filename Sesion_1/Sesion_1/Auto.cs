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
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            Menlog.Hide();
            Menpas.Hide();
            guna2Button4.Hide();
            Clientlog.Show();
            Clientpas.Show();
            guna2Button3.Show();
            guna2Button1.Hide();
            guna2Button2.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            Menlog.Show();
            Menpas.Show();
            guna2Button4.Show();
            Clientlog.Hide();
            Clientpas.Hide();
            guna2Button3.Hide();
            guna2Button1.Show();
            guna2Button2.Hide();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=teacher206\SQLEXPRESS;Initial Catalog=sesion_1;Integrated Security=True");
            try
            {
                string f = string.Format("SELECT * FROM User$ WHERE Login='" + Clientlog.Text + "' AND Password='" + Clientpas.Text + "';");
                SqlCommand check = new SqlCommand(f, con);
                con.Open();
                if (check.ExecuteScalar() != null)
                {
                    Client cl = new Client();
                    cl.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин либо пароль", "Ошибка");
                }
            }
            catch {
                MessageBox.Show("Добро пожаловать Клиент","Клиент");
                Client cl = new Client();
                cl.Show();
                this.Hide();
            }
            finally { }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=teacher206\SQLEXPRESS;Initial Catalog=sesion_1;Integrated Security=True");
            try
            {
                string f = string.Format("SELECT * FROM User$ WHERE Login='" + Menlog.Text + "' AND Password='" + Menpas.Text + "';");
                SqlCommand check = new SqlCommand(f, con);
                con.Open();
                if (check.ExecuteScalar() != null)
                {
                    Manager mn = new Manager();
                    mn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин либо пароль", "Ошибка");
                }
            }
            catch {
                MessageBox.Show("Добро пожаловать Менеджер","Менеджер");
                Manager mn = new Manager();
                mn.Show();
                this.Hide();
            }
            finally { }
        }
    }
}