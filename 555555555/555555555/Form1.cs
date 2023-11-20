using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _555555555
{
    public partial class Form1 : Form
    {
        private DataClasses1DataContext CDStudentDataContextForm1 = new
DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void studentListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentListBindingSource.DataSource =
CDStudentDataContextForm1.StudentLists;
        }

        private void studentListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                CDStudentDataContextForm1.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var StudentQuery = from StudentList in CDStudentDataContextForm1.StudentLists
                               where StudentList.Surname == textBox1.Text
                               select StudentList;
            studentListBindingSource.DataSource = StudentQuery;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var StudentQuery = from StudentList in CDStudentDataContextForm1.StudentLists
                               select StudentList;
            studentListBindingSource.DataSource = StudentQuery;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
