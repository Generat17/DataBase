using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.lab_1DataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.lab_1DataSet.Группа);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            группаTableAdapter.Update(lab_1DataSet);
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab_1DataSet);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); 
            f.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
