using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            lables.Add(lbl1);
            Cixmatps.Add(dtpGirme1);
            Girmedtps.Add(dtpGirme1);
        }

        List<Label> lables = new List<Label>();
        List<DateTimePicker> Cixmatps = new List<DateTimePicker>();
        List<DateTimePicker> Girmedtps = new List<DateTimePicker>();

        //Adding new internship block 
        public int i = 2;
        public int a = 64;
        public int b = 68;
        public int c = 115;
        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            if (i <= 10)
            {
                addNewdtp1();
                addNewdtp2();
                addNewlbl1();
                btnElaveEt.Top = a;
                btnHesabla.Top = c;
                lblCemText.Top = c;
                lblNetice.Top = c;
                this.Height = this.Height + 30;

                i++;
                a = a + 30;
                b = b + 30;
                c = c + 30;
            }
        }

        //Adding new lable
        public System.Windows.Forms.Label addNewlbl1()
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            this.Controls.Add(lbl);
            lbl.Top = b;
            lbl.Left = 13;
            lbl.Width = 147;
            lbl.Height = 20;
            lbl.Name = "lbl" + i;
            lbl.Text = i.ToString();
            lables.Add(lbl);
            return lbl;
        }

        //Adding new DateTimePicker
        public System.Windows.Forms.DateTimePicker addNewdtp1()
        {
            System.Windows.Forms.DateTimePicker dtp = new System.Windows.Forms.DateTimePicker();
            this.Controls.Add(dtp);
            dtp.CustomFormat = "dd.MM.yyyy";
            dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtp.Top = a;
            dtp.Left = 32;
            dtp.Width = 147;
            dtp.Height = 20;
            dtp.Name = "dtpGirme" + i;
            Girmedtps.Add(dtp);
            return dtp;
        }

        //Adding new DateTimePicker
        public System.Windows.Forms.DateTimePicker addNewdtp2()
        {
            System.Windows.Forms.DateTimePicker dtp = new System.Windows.Forms.DateTimePicker();
            this.Controls.Add(dtp);
            dtp.CustomFormat = "dd.MM.yyyy";
            dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtp.Top = a;
            dtp.Left = 205;
            dtp.Width = 147;
            dtp.Height = 20;
            dtp.Name = "dtpCixma" + i;
            Cixmatps.Add(dtp);
            return dtp;
        }

        List<int> years = new List<int>();
        List<int> months = new List<int>();
        List<int> days = new List<int>();

        // Recuitment date variables
        int İseGirmeİli = 0;
        int İseGirmeAyi = 0;
        int İseGirmeGunu = 0;

        // Deactivation date variables
        int İsdenCixmaİli = 0;
        int İsdenCixmaAyi = 0;
        int İsdenCixmaGunu = 0;

        //Year
        int year = 0;

        //Month
        int month = 0;

        //Day
        int day = 0;

        //Colculating years, months and days between dates
        List<DateTime> dates = new List<DateTime>();
        private void colculateInternship()
        {
            dates.Clear();
            years.Clear();
            months.Clear();
            days.Clear();
            foreach (Control item in this.Controls)
            {                
                if (item is DateTimePicker)
                {
                    dates.Add(((DateTimePicker)item).Value);
                }
            }

            for (int i = 0; i < dates.Count; i+=2)
            {
                DateTime qebulIli = dates[i];
                DateTime cixmaIli = dates[i+1];
                assignDates(qebulIli, cixmaIli);

                years.Add(ColculateYear());
                months.Add(ColculateMonth());
                days.Add(ColculateDay());
            }
        }


        //Getting data from datetimepickers
        private void assignDates(DateTime qebulIli, DateTime cixmaIli)
        {
            // Birinci ise girme tarixi
            İseGirmeİli = qebulIli.Year;
            İseGirmeAyi = qebulIli.Month;
            İseGirmeGunu = qebulIli.Day;

            // Birinci isden Cixma tarixi
            İsdenCixmaİli = cixmaIli.Year;
            İsdenCixmaAyi = cixmaIli.Month;
            İsdenCixmaGunu = cixmaIli.Day;
        }

        //Calculate Years between dates
        public int ColculateYear()
        {
            //assignDates();
            if (İsdenCixmaAyi < İseGirmeAyi)
            {
                year = (İsdenCixmaİli - İseGirmeİli) - 1;
            }
            else if (İsdenCixmaAyi == İseGirmeAyi)
            {
                if (İsdenCixmaGunu < İseGirmeGunu)
                {
                    year = (İsdenCixmaİli - İseGirmeİli) - 1;
                }
                else
                {
                    year = (İsdenCixmaİli - İseGirmeİli);
                }
            }
            else
            {
                year = (İsdenCixmaİli - İseGirmeİli);
            }
            return year;
        }

        //Calculate Months between dates
        public int ColculateMonth()
        {
            //assignDates();
            if (İsdenCixmaAyi > İseGirmeAyi)
            {
                if (İsdenCixmaGunu < İseGirmeGunu)
                {
                    month = İsdenCixmaAyi - İseGirmeAyi - 1;
                }
                else
                {
                    month = İsdenCixmaAyi - İseGirmeAyi;
                }
            }
            else if (İsdenCixmaAyi == İseGirmeAyi)
            {
                if (İsdenCixmaGunu < İseGirmeGunu)
                {
                    month = 11;
                }
                else
                {
                    month = 0;
                }
            }
            else
            {
                if (İsdenCixmaGunu < İseGirmeGunu)
                {
                    month = (12 - İseGirmeAyi) + (İsdenCixmaAyi - 1);
                }
                else
                {
                    month = (12 - İseGirmeAyi) + İsdenCixmaAyi;
                }
            }
            return month;
        }

        //Calculate Days between dates
        public int ColculateDay()
        {
            //assignDates();
            if (İsdenCixmaGunu < İseGirmeGunu)
            {
                if ((İseGirmeAyi ==1)|| (İseGirmeAyi == 3)|| (İseGirmeAyi == 5)|| (İseGirmeAyi == 7)|| (İseGirmeAyi == 8)|| (İseGirmeAyi == 10)|| (İseGirmeAyi == 12))
                {
                    day = (31 - İseGirmeGunu) + İsdenCixmaGunu;
                }
                else if((İseGirmeAyi == 4) || (İseGirmeAyi == 6) || (İseGirmeAyi == 9) || (İseGirmeAyi == 11))
                {
                    day = (30 - İseGirmeGunu) + İsdenCixmaGunu;
                }
                else
                {
                    int i = 2000;
                    while (i< İseGirmeİli)
                    {
                        i = i + 4;
                        if (İseGirmeİli==i)
                        {
                            day = (29 - İseGirmeGunu) + İsdenCixmaGunu;                            
                        }
                        else
                        {
                            day = (28 - İseGirmeGunu) + İsdenCixmaGunu;                            
                        }                        
                    }
                }
            }
            else
            {
                day =İsdenCixmaGunu- İseGirmeGunu;
            }
            return day;
        }

        //Calculate Internship
        private void btnHesabla_Click(object sender, EventArgs e)
        {
            colculateInternship();
            int sumYears = 0;
            int sumMonths = 0;
            int sumDays = 0;

            int realSumYears = 0;
            int realSumMonths = 0;
            int realSumDays = 0;
            for (int i = 0; i <years.Count; i++)
            {
                sumYears += years[i];
                sumMonths += months[i];
                sumDays += days[i];
            }
            if (sumDays >= 30)
            {
                sumMonths +=Convert.ToInt32(Math.Floor(sumDays / 30.0));

                realSumDays = Convert.ToInt32((sumDays % 30));
            }
            else
            {
                realSumDays = sumDays;
            }

            if (sumMonths>=12)
            {
                realSumYears = sumYears+(sumMonths/12);
                realSumMonths = (sumMonths % 12);
            }
            else
            {
                realSumYears = sumYears;
                realSumMonths = sumMonths;
            }            

            lblNetice.Text = (realSumYears + " il: " + realSumMonths + " ay: " + realSumDays + " gün");
        }
    }
}