using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace lab_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.lab_1DataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Преподователь". При необходимости она может быть перемещена или удалена.
            this.преподовательTableAdapter.Fill(this.lab_1DataSet.Преподователь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.lab_1DataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Преподователь". При необходимости она может быть перемещена или удалена.
            this.преподовательTableAdapter.Fill(this.lab_1DataSet.Преподователь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.lab_1DataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.lab_1DataSet.Группа);

            /*
            string mybdpath = "C:\Users\aliev\Desktop\Базы данных\Лаб_раб\lab_1\lab_1.mdb";
            string conStr = "строка подключения" + mybdpath;
            OleDbConnection connection = new
            OleDbConnection(conStr); OleDbDataAdapter adapter = new
            OleDbDataAdapter(); connection.Open();
            OleDbCommand command = new OleDbCommand("SQL_запрос", connection); // добавляем текст SQL запроса
            connection.Close();
            adapter.SelectCommand = command; 
            DataSet dataSet = new
            DataSet();
            adapter.Fill(dataSet);
            название dataGridView.DataSource =
            dataSet.Tables[0]; adapter.Update(dataSet);
            */

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
