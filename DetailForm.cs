using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ESRI.ArcGIS.Carto;

namespace ArcMapShowGridAddin
{
    delegate void ClearLinesDelegate();

    public partial class DetailForm : Form
    {
        

        double x_source;
        double y_source;
        internal ClearLinesDelegate clearLinesHandler;

        public DetailForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double xmap,ymap;
            if(Convert2Decimal(this.textBox1.Text,this.textBox2.Text,this.textBox3.Text,out xmap)&&Convert2Decimal(this.textBox4.Text,this.textBox5.Text,this.textBox6.Text,out ymap)){
                var pointpair = new string [4];
            pointpair[0] = x_source.ToString();
            pointpair[1] = y_source.ToString();
            pointpair[2] = xmap.ToString();
            pointpair[3] = ymap.ToString();
            gvPoints.Rows.Add(pointpair);
            }
            
        }

        public void AddPoints(double x, double y)
        {
            x_source = Math.Round(x,3);
            y_source = Math.Round(y,3);        
            this.lblXSource.Text = x_source.ToString();
            this.lblYSource.Text = y_source.ToString();
        }

        

        bool Convert2Decimal(string degree, string minute, string second,out double result)
        {
            double d,m,s;
            if(double.TryParse(degree,out d) && double.TryParse(minute,out m) && double.TryParse(second,out s))
            {
                result = Math.Round((d + m / 60 + s / 3600), 3) ;
                return true;
            }else
            {
                result = 0;
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gvPoints.Rows.Clear();
            clearLinesHandler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "txt|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream file = dlg.OpenFile();
                StreamWriter writer = new StreamWriter(file);
                foreach (DataGridViewRow row in gvPoints.Rows)
                {
                    string[] para= new string[4];
                    para[0] = (string)row.Cells[0].Value;
                    para[1] = (string)row.Cells[1].Value;
                    para[2] = (string)row.Cells[2].Value;
                    para[3] = (string)row.Cells[3].Value;
                    writer.WriteLine("{0} {1} {2} {3}", para);
                    
                }
                writer.Close();
            }
        }
    }
}
