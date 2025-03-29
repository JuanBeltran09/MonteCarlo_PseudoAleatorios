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

namespace MonteCarlo_PseudoAleatorios
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float[] arrayUn = new float[22221];
        bool generado = false;

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dvgAleatorios.Rows.Clear();

            int seed = Convert.ToInt32(txtSeed.Text);
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int m = Convert.ToInt32(txtM.Text);
            int iterations = 22220;

            //xn=(a*(xn-1)+b) mod m
            //un=xn/m

            float xn, un;
            xn = (a * seed + b) % m;
            un = xn / m;

            float[] arrayXn = new float[iterations + 1];
            

            HashSet<float> unicos = new HashSet<float>();

            arrayXn[0] = xn;

            for (int i = 1; i <= iterations; i++)
            {
                arrayXn[i] = (a * arrayXn[i - 1] + b) % m;

                bool agregado = unicos.Add(arrayXn[i]);

                if (!agregado)
                {
                    break; 
                }

                arrayUn[i] = arrayXn[i] / m;

                dvgAleatorios.Rows.Add(i, arrayXn[i], arrayUn[i]);
            }

            if (unicos.Count == arrayXn.Length)
            {
                repetidos.Text = "Se generaron correctamente los 22220 números aleatorios";
                generado = false;
            }
            else
            {
                repetidos.Text = "Solo se generaron correctamente "+unicos.Count+" números aleatorios";
            }

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            chart20.Series.Clear();
            chart200.Series.Clear();
            chart2000.Series.Clear();
            chart20000.Series.Clear();

            if (!generado) {
                advertencia.Text = "No has generado los números aleatorios";
                advertencia.Visible = true;
            }
            else { advertencia.Visible = false; }

            // Grafica para los 20 aleatorios

            int[] rangos20 = new int[5];

            for (int i = 0; i < 20; i++)
            {
                double un = arrayUn[i];

                if (un < 0.2)
                    rangos20[0]++;
                else if (un < 0.4)
                    rangos20[1]++;
                else if (un < 0.6)
                    rangos20[2]++;
                else if (un < 0.8)
                    rangos20[3]++;
                else
                    rangos20[4]++;
            }

            Series serie20 = new Series("Distribución");

            serie20.ChartType = SeriesChartType.Column;

            string[] etiquetas = { "0 – 0.2", "0.2 – 0.4", "0.4 – 0.6", "0.6 – 0.8", "0.8 – 1.0" };

            for (int i = 0; i < 5; i++)
            {
                serie20.Points.AddXY(etiquetas[i], rangos20[i]);
            }

            chart20.Series.Add(serie20);
            chart20.ChartAreas[0].AxisX.Title = "Rangos";
            chart20.ChartAreas[0].AxisY.Title = "Frecuencia";

            // Grafica para los 200 aleatorios

            int[] rangos200 = new int[5];

            for (int i = 20; i < 220; i++)
            {
                double un = arrayUn[i];

                if (un < 0.2)
                    rangos200[0]++;
                else if (un < 0.4)
                    rangos200[1]++;
                else if (un < 0.6)
                    rangos200[2]++;
                else if (un < 0.8)
                    rangos200[3]++;
                else
                    rangos200[4]++;
            }

            Series serie200 = new Series("Distribución");

            serie200.ChartType = SeriesChartType.Column;

            for (int i = 0; i < 5; i++)
            {
                serie200.Points.AddXY(etiquetas[i], rangos200[i]);
            }

            chart200.Series.Add(serie200);
            chart200.ChartAreas[0].AxisX.Title = "Rangos";
            chart200.ChartAreas[0].AxisY.Title = "Frecuencia";

            // Grafica para los 2000 aleatorios

            int[] rangos2000 = new int[5];

            for (int i = 220; i < 2220; i++)
            {
                double un = arrayUn[i];

                if (un < 0.2)
                    rangos2000[0]++;
                else if (un < 0.4)
                    rangos2000[1]++;
                else if (un < 0.6)
                    rangos2000[2]++;
                else if (un < 0.8)
                    rangos2000[3]++;
                else
                    rangos2000[4]++;
            }

            Series serie2000 = new Series("Distribución");

            serie2000.ChartType = SeriesChartType.Column;

            for (int i = 0; i < 5; i++)
            {
                serie2000.Points.AddXY(etiquetas[i], rangos2000[i]);
            }

            chart2000.Series.Add(serie2000);
            chart2000.ChartAreas[0].AxisX.Title = "Rangos";
            chart2000.ChartAreas[0].AxisY.Title = "Frecuencia";

            // Grafica para los 20000 aleatorios

            int[] rangos20000 = new int[5];

            for (int i = 2220; i < 22220; i++)
            {
                double un = arrayUn[i];

                if (un < 0.2)
                    rangos20000[0]++;
                else if (un < 0.4)
                    rangos20000[1]++;
                else if (un < 0.6)
                    rangos20000[2]++;
                else if (un < 0.8)
                    rangos20000[3]++;
                else
                    rangos20000[4]++;
            }

            Series serie20000 = new Series("Distribución");

            serie20000.ChartType = SeriesChartType.Column;

            for (int i = 0; i < 5; i++)
            {
                serie20000.Points.AddXY(etiquetas[i], rangos20000[i]);
            }

            chart20000.Series.Add(serie20000);
            chart20000.ChartAreas[0].AxisX.Title = "Rangos";
            chart20000.ChartAreas[0].AxisY.Title = "Frecuencia";

        }
    }
}
