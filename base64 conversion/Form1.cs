using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64_conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2 .Text = Utilities.Base64.Decode(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Utilities.Base64.Encode(textBox1.Text);            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            textBox1.Text = dt.ToString("ddd.MMMM.yyy hh mm ss zz gg"  );

            DateTimeOffset dt2 = new DateTimeOffset();
            dt2.ToString("ddd.MMMM.yyy hh mm ss zz gg");
            textBox2.Text = dt2.ToString("ddd.MMMM.yyy hh mm ss zz gg");
        }
    }
}
