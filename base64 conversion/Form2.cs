using System;
using System.Globalization;
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
            String date1 = textBox1.Text;
            String date2 = textBox2.Text;
            String date3 = textBox3.Text;

            DateTime dt1 = Convert.ToDateTime (date1);
            DateTime dt2 = Convert.ToDateTime(date2);
            DateTime dt3 = Convert.ToDateTime(date3);

            String format1="dd/MM/yy";
            String format2 = "dd/MMM/yyyy";
            String format3 = "MMM-dd-yyyy";

            //String dt1_fromatStr = dt1.ToString(format1);
            //if (DateTime.TryParseExact(date1,  out dt1)) 
                 if (DateTime .TryParseExact (date1 ,format1 ,new CultureInfo("en-US"),DateTimeStyles.None ,out dt1 ))
            
            //if (textBox1.Text != "" && date1  == dt1_fromatStr)
            //{
                textBox1.Text = dt1.ToLongDateString();
           // }
            else
                MessageBox.Show(" please enter the value in Date Format: dd/MM/yy in place of " + textBox1.Text);                  

           
            String dt2_fromatStr = dt2.ToString(format2);

            if (textBox2.Text != "" && date2  == dt2_fromatStr)
            {
                textBox2.Text = dt2.ToLongDateString();
            }
            else
                MessageBox.Show(" please enter the value in Date Format: dd/MMM/yyyy in place of " + textBox2.Text);

            
            String dt3_fromatStr = dt3.ToString(format3);

            if (textBox3.Text != "" && date3  == dt3_fromatStr)
            {
                textBox3.Text = dt3.ToLongDateString();
            }
            else
                MessageBox.Show(" please enter the value in Date Format: MMM-dd-yyyy in place of " +textBox3 .Text  );

        }
    }
}
