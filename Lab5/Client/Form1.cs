using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var s = new ServiceReference1.Service1Client();
            dataGridView1.DataSource = s.GetData();
            dataGridView1.Columns[0].HeaderText = "Код аренды";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Дата рождения";
            dataGridView1.Columns[3].HeaderText = "Фирма автомобиля";
            dataGridView1.Columns[4].HeaderText = "Модель автомобиля";
            dataGridView1.Columns[5].HeaderText = "Дата взятия";
            dataGridView1.Columns[6].HeaderText = "Дата сдачи";
            dataGridView1.Columns[7].HeaderText = "Цена аренды за день";
            dataGridView1.Columns[8].HeaderText = "Кол-во дней аренды";
            dataGridView1.Columns[9].HeaderText = "Итогавая цена";
            dataGridView1.Update();

            comboBox1.DataSource = s.FillFIO();
            comboBox1.DisplayMember = "FIO";
            comboBox1.ValueMember = "ID_FIO";
            comboBox2.DataSource = s.FillAvto();
            comboBox2.DisplayMember = "Model_avto";
            comboBox2.ValueMember = "ID_AVTO";
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            var s = new ServiceReference1.Service1Client();
            string ID_FIO = comboBox1.SelectedValue.ToString();
            string ID_AVTO = comboBox2.SelectedValue.ToString();
            string Data_vzitia = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string Data_zdachi = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            s.NewRec(ID_FIO, ID_AVTO, Data_vzitia, Data_zdachi);
            Form1_Load(sender, e);
        }

        private void FioCombo_Click(object sender, EventArgs e)
        {

        }

        private void DicCombo_Click(object sender, EventArgs e)
        {

        }
    }
}
