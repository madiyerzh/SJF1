using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            data = new Data[0];
            listview();
        }
        private Data[] data;
        struct Data
        {
            public string nama;
            public int arrived, longt, waitt, restt, donet, startt, TA;
        }

        private void listview()
        {
            LV.Clear();
            LV.View = View.Details;
            LV.Columns.Add("Name of process", 80); 
            LV.Columns.Add("Arriving time", 80); 
            LV.Columns.Add("Duration of Execution", 80); 
            LV.Columns.Add("Start", 80); 
            LV.Columns.Add("Done", 80); 
            LV.Columns.Add("Wait", 80); 
            LV.Columns.Add("TA", 80);
            LV.GridLines = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); int arrived, longt;
            if (txtJlhproses.Text == "")
                MessageBox.Show("Input Number of Processes !!!");
            else
            {
                for (int i = 0; i < int.Parse(txtJlhproses.Text); i++)
                {
                    Array.Resize(ref data, data.Length + 1);
                    arrived = rnd.Next(1, 30);
                    longt = rnd.Next(1, 30);
                    LV.Items.Add(data[data.GetUpperBound(0)].nama = "Proses - " + (i + 1));
                    LV.Items[LV.Items.Count - 1].SubItems.Add(Convert.ToString((data[data.GetUpperBound(0)].arrived = arrived)));
                    LV.Items[LV.Items.Count - 1].SubItems.Add(Convert.ToString((data[data.GetUpperBound(0)].longt = longt)));
                }
                txtJlhproses.ResetText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listview();
            int WT, LE;
            string NP;
            float total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (data[i].longt < data[j].longt)
                    {
                        WT = data[j].arrived;
                        data[j].arrived = data[i].arrived;
                        data[i].arrived = WT;
                        NP = data[j].nama;
                        data[j].nama = data[i].nama;
                        data[i].nama = NP;
                        LE = data[j].longt;
                        data[j].longt = data[i].longt;
                        data[i].longt = LE;
                    }
                }
            }
            for (int r = 0; r < data.Length; r++)
            {
                if (r > 0)
                {
                    if (data[r].arrived <= data[r - 1].donet)
                    {
                        data[r].startt = data[r - 1].donet;
                    }
                    else
                    {
                        data[r].startt = data[r].arrived;
                    }
                }
                else
                    data[r].startt = data[r].arrived;

                data[r].donet = data[r].longt + data[r].startt;
                data[r].waitt = data[r].startt - data[r].arrived;
                data[r].TA = data[r].donet - data[r].arrived;
                total += data[r].TA;
            }
            txttotal.Text = total.ToString();
            txtrata.Text = (total / data.Length).ToString();
            for (int r = 0; r < data.Length; r++)
            {
                LV.Items.Add(data[r].nama);
                LV.Items[r].SubItems.Add(data[r].arrived.ToString());
                LV.Items[r].SubItems.Add(data[r].longt.ToString());
                LV.Items[r].SubItems.Add(data[r].startt.ToString());
                LV.Items[r].SubItems.Add(data[r].donet.ToString());
                LV.Items[r].SubItems.Add(data[r].waitt.ToString());
                LV.Items[r].SubItems.Add(data[r].TA.ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            data = new Data[0];
            txtrata.Clear();
            txttotal.Clear();
            listview();
        }

    }
}
