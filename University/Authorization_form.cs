using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Authorization_form : Form
    {
        

        public Authorization_form()
        {
            InitializeComponent();
        }

        public void error (string text)
        {
            var result = MessageBox.Show(text );
            this.Show();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization c = new Authorization();
            this.Hide();
            c.authorize(textBox1.Text, textBox2.Text);
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
