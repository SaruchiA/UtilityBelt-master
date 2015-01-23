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
                DateTime age = AgeCalc(dob);
                textBox2.Text = String.Format("{1} months, {2} days & {0} years", age.Year, age.Year, age.Year);
                //String finalDate = textBox3.Text;
                //finalDate.ageCalc(dob);
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";                
            }
        }

        public int ageCalc(DateTime dob)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            TimeSpan span = today - dob;
            
            // because we start at year 1 for the Gregorian calendar, we must subtract a year here.
            DateTime finalDate = zeroTime + span;
            int years = finalDate.Year - 1;   
            textBox3 .Text = years +"years " ;

            textBox3.Text += (finalDate.Month) - 1 + "months ";
            textBox3.Text += (finalDate.Day) - 1 + "days ";
            return years;
        }

        //public DateTime AgeCalc(DateTime dob)
        //{
        //    DateTime zeroTime = new DateTime(1, 1, 1);

        //    DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        //    TimeSpan span = today - dob;

        //    // because we start at year 1 for the Gregorian calendar, we must subtract a year here.
        //    DateTime finalDate = zeroTime + span;
        //    return finalDate.AddYears(-1).AddMonths(-1).AddDays(-1);
        //}


        //public int ageCalculator(DateTime  dob)
        //{
        //    int  age;
        //    DateTime now = DateTime.Today;
        //    String totalAge;
        //    age = now.Year - dob.Year;
        //    TimeSpan diff = now - dob;
        //    int TempMonths;
        //    int TempYears;
        //    int TempDays;
        //    if (dob.Month > now.Month ) // now .Day >30
        //    {
        //        TempYears=age-1;
        //        TempMonths = (12 - dob.Month)+now.Month ;                
        //    }
        //    else
        //    {
        //        TempYears = now.Year - dob.Year;
        //        TempMonths = now.Month - dob.Month;                
        //    }

        //    if (dob.Date > now.Date)
        //    {
        //        TempDays = dob.Day - now.Day;
        //    }
        //    else
        //    {
        //        TempDays = now.Day - dob.Day;
        //    }
        //    //if (now .Month < dob .Month )
        //    totalAge = TempDays + " days ";
        //    //if (TempDays < 30)
        //    //{
        //    //    totalAge += (TempMonths-1) + "months ";
        //    //}
        //    //else
        //        totalAge += TempMonths + "months ";
        //    totalAge += TempYears + "years ";
        //    textBox3 .Text = totalAge;
            
        //   // age = now .CompareTo( dob) ;
        //    return TempYears;           
        //}

    }
}
