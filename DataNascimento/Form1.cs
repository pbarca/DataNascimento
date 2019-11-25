using System;
using System.Windows.Forms;

namespace DataNascimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataNascimento dn = new DataNascimento();
        private void Button1_Click(object sender, EventArgs e)
        {
            dn.recebe = textBox1.Text;
            label1.Text = dn.envia;
        }
    }
}
