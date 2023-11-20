using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _66666666
{
    public partial class Form1 : Form
    {
        Student db = new Student(@"Data Source= DESKTOP-S50CD0Q\SQLEXPRESS; Initial Catalog= Student; Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int param = Convert.ToInt32(textBox1.Text);

            // Объявление переменной для хранения результата, возвращаемого процедурой
                        var custquery = db.GetStudentById(param);

            // Исполнение хранимой процедуры и отображение результата в диалоговом окне. 
          string msg = "";
            foreach (GetStudentByIdResult hehe in custquery)
            {
                msg = msg + hehe.Name + "\n";
            }
            if (msg == "")
                msg = "Ничего не найдено";
            MessageBox.Show(msg);

            // Очистка параметров
            param = 0;
            textBox1.Text = "";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int param = Convert.ToInt32(textBox1.Text);

                var custquery = db.GetStudentById(param);

                List<GetStudentByIdResult> test = new List<GetStudentByIdResult>();
                foreach (GetStudentByIdResult hehe in custquery)
                {
                    test.Add(hehe);

                }

                dataGridView1.DataSource = test;
            }
            catch { }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentByName form2 = new StudentByName();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubjectByName form2 = new SubjectByName();
            form2.Show();
        }
    }
}
