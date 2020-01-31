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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int count = 0;
                StreamReader stream = new StreamReader(openFileDialog1.FileName);
                string names = "";
                while (!stream.EndOfStream)
                {
                    names += stream.ReadLine();
                }

                foreach(char dir in names)
                {
                    if(dir == 'a')
                    {
                        count++;
                    }
                }
                MessageBox.Show(count.ToString());
                stream.Close();
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
