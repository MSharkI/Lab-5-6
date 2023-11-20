using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _66666666
{
    public partial class StudentByName : Form
    {
        public StudentByName()
        {
            InitializeComponent();
        }

        Student db = new Student(@"Data Source= DESKTOP-S50CD0Q\SQLEXPRESS; Initial Catalog= Student; Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string param = Convert.ToString(textBox1.Text);

                // Объявление переменной для хранения результата, возвращаемого процедурой
                var custquery = db.GetStudentByName(param);

                // Исполнение хранимой процедуры и отображение результата в диалоговом окне. 
                string msg = "";
                foreach (GetStudentByNameResult hehe in custquery)
                {
                    msg = msg + hehe.Name + "\n";
                }
                if (msg == "")
                    msg = "Ничего не найдено";
                MessageBox.Show(msg);

                // Очистка параметров
                param = "0";
                textBox1.Text = "";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string param = Convert.ToString(textBox1.Text);

                var custquery = db.GetStudentByName(param);

                List<GetStudentByNameResult> test = new List<GetStudentByNameResult>();
                foreach (GetStudentByNameResult hehe in custquery)
                {
                    test.Add(hehe);

                }

                dataGridView1.DataSource = test;
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
