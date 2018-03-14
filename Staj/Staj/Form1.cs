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
        }


        public List<DateTimePicker> dtps = new List<DateTimePicker>();

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            for (int j=0;j<(i-2);j++)
            {
                //MessageBox.Show(i.ToString());
                DateTime dtpGirme = Convert.ToDateTime(this.Controls["dtpGirme"].Text);
                DateTime dtpCixma = Convert.ToDateTime(this.Controls["dtpCixma"].Text);
                TimeSpan staj = dtpCixma.Date.Subtract(dtpGirme.Date);
            }
          
            TimeSpan staj1 = dtpCixma1.Value.Subtract(dtpGirme1.Value);
            int hours = staj1.Days*24;

            int year = Convert.ToInt32(hours / (365*24));

            int month = Convert.ToInt32(Math.Floor((hours-year*8760)/729.999));

            int days = Convert.ToInt32((hours - (year * 8760)-(month*729.999))/24);

            //MessageBox.Show(staj2.ToString());
            lblNetice.Text = (year + " il: " + month + " ay: " + days + " gün (±3 gün)");
        }

        public int i = 2;
        public int a = 64;
        public int b = 68;
        public int c = 115;


        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            if (i<=10)
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

            return lbl;
        }

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
            dtp.Name = "dtpGirme";
            //dtps.Add(Convert.ToDateTime(dtp.Name));
            return dtp;
        }

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
            dtp.Name = "dtpCixma";
            return dtp;
        }
    }
}