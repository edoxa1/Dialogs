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
    public partial class Catalogs : Form
    {
        public Catalogs()
        {
            InitializeComponent();
        }

        private void Catalogs_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\BanJutsu");//создать директорию
            Directory.CreateDirectory("C:\\BanJutsu\\Папка первый");//создать директорию
            Directory.CreateDirectory("C:\\BanJutsu\\Папка второй");//создать директорию
            DirectoryInfo papka = new DirectoryInfo("C:\\Казалось бы");
            if (papka.Exists)
            {
                
            }
            else
            {
                papka.Create();
            }
            string[] catalog = Directory.GetDirectories("C:\\");
            foreach (string dir in catalog)
            {
                label1.Text += dir + "\n";
            }
            File.Create("C:\\BanJutsu\\Иди поспи.png");
            FileInfo inf = new FileInfo("C:\\BanJutsu\\");
            Tasks form2 = new Tasks();
            form2.ShowDialog();
        }
    }
}
