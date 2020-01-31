using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//save
        {
            
            StreamWriter document1;
            FileInfo file = new FileInfo("C:\\Users\\СарксекеевЕ\\Desktop\\lmao.txt");
            document1 = file.AppendText();
            document1.WriteLine(textBox1.Text);
            document1.Close();
        }

        private void button3_Click(object sender, EventArgs e)//upload
        {
            FileInfo file = new FileInfo("C:\\Users\\СарксекеевЕ\\Desktop\\lmao.txt");
            if (!file.Exists)
            {
                MessageBox.Show("File does not exist");
            }
            else
            {
                StreamReader document1 = new StreamReader("C:\\Users\\СарксекеевЕ\\Desktop\\lmao.txt");
                string text = "";
                while (!document1.EndOfStream)
                {
                    text += document1.ReadLine();
                }
                label1.Text = text;
                document1.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            FileInfo file = new FileInfo("C:\\Users\\СарксекеевЕ\\Desktop\\lmao.txt");
            if(!file.Exists)
            {
                MessageBox.Show("File does not exist");
            }
            else
            {
                file.Delete();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Catalogs form = new Catalogs();
            form.ShowDialog();
        }
    }
}
