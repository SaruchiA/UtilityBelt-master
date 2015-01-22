using System;
using System.Globalization; //included for dateTime objects
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String format1 = "dd/MM/yy";
            String format2 = "dd/MMM/yyyy";
            String format3 = "MMM-dd-yyyy";

            textBox1.Text = DateParser(textBox1.Text, format1);
            textBox2.Text = DateParser(textBox2.Text, format2);
            textBox3.Text = DateParser(textBox3.Text, format3);

        }

        public String DateParser(String date1, String format1)
        {
            DateTime dtArg = new DateTime();
            if (DateTime.TryParseExact(date1, format1, new CultureInfo("en-US"), DateTimeStyles.None, out dtArg))
                return dtArg.ToLongDateString();
            else
                return "Please enter the date value in specified format";

        }
    }
}