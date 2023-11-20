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
    public partial class Form2 : Form
    {
        private DataClasses2DataContext CDStudentDataContextForm2 = new
DataClasses2DataContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void subjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            subjectBindingSource.DataSource =
CDStudentDataContextForm2.Subjects;
        }

        private void subjectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                CDStudentDataContextForm2.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
