using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64_conversion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dob = new DateTime();
            if (DateTime.TryParseExact(textBox1.Text, "MM-dd-yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out dob))
            {
               textBox2 .Text = ageCalculator(dob)+"";
            }
        }

        public int ageCalculator(DateTime  dob)
        {
            int  age;
            DateTime now = DateTime.Today;
            //age= now.Year- dob.Year;
            age = now .CompareTo( dob) ;
            return age;           
        }

    }
}
