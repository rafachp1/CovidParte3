using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            String[] serie = { "Estados Unidos", "Francia", "Brasil", "India", "Bélgica" };
            int[] contagios = { 6873631, 4621544, 1254973, 1165720, 839627 };


           

            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < serie.Length; i++)
            {
               
                chart1.Series["Series1"].Points.AddXY(serie[i],contagios[i]);

            }

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {



        }

       
    }
}
