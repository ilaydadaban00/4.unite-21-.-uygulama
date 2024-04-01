using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_6_ve_7.uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Üzerimdedir.");
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Artık Üzerimde Değildir.");
        }

        private void btnBagla_Click(object sender, EventArgs e)
        {
            string[] veriler = { "C#", "java", "python" };
            listeveri.DataSource = veriler;

        }
    }
}
