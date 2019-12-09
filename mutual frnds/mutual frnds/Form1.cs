using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutual_frnds
{
    public partial class Form1 : Form
    {
        int numberOfPerson = -1;
        List<person> personStore = new List<person>();
        public Form1()
        {
            InitializeComponent();
        }
        private List<person>  xyz( person a)
        {
            List<person> test = new List<person>();
            foreach (person x in personStore )
            {
                if (x.Age == a.Age || x.City == a.City || x.Name == a.Name || x.Uni == a.Uni)
                    test.Add(x);
            }
            return test;
        }
        private void personGen(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Random r = new Random();
                Thread.Sleep(1);
                person temp = new person();
                temp.Name = stringGen(4);
                Thread.Sleep(1);
                temp.City = stringGen(4);
                Thread.Sleep(1);
                temp.Age = stringGen(4);
                Thread.Sleep(1);
                temp.Uni = stringGen(4);
                personStore.Add(temp);
            }
        }
        private string stringGen(int len)
        {
            string temp = "";
            Random r = new Random();
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                    temp = temp + (char)r.Next('A', 'E');
                else
                    temp = temp + (char)r.Next('a', 'e');
            }
            return temp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
                numberOfPerson = Convert.ToInt32(textBox1.Text);
            personStore.Clear();
            if (numberOfPerson != -1)
            {
                personGen(numberOfPerson);
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = personStore;
                dataGridView1.Show();
            }
            else
            {
                MessageBox.Show("enter number of persons");
            }


            foreach(person x in personStore)
            {
                x.Suguestions = xyz(x);
            }
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                dataGridView2.DataSource = "";
                dataGridView2.DataSource = personStore[e.RowIndex].Suguestions;
                dataGridView2.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
