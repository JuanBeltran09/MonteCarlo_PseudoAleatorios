using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet .Numerics .RootFinding;
using MathNet.Numerics.Integration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace MonteCarlo_PseudoAleatorios
{
    public partial class Form1 : Form
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
            chart1.Series[0].Points.Clear();

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
                chart1.Series[0].Points.AddXY(i, arrayUn[i]);
            }

            if (unicos.Count == 22220)
            {
                repetidos.Text = "Se generaron correctamente los 22220 números aleatorios";
                generado = true;
            }
            else
            {
                repetidos.Text = "Solo se generaron correctamente " + unicos.Count + " números aleatorios";
            }

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            chart20.Series.Clear();
            chart200.Series.Clear();
            chart2000.Series.Clear();
            chart20000.Series.Clear();

            if (!generado)
            {
                advertencia.Text = "No has generado todos los números aleatorios";
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
            chart20.ChartAreas[0].AxisY.Minimum = 0;
            chart20.ChartAreas[0].AxisY.Maximum = 20;

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
            chart200.ChartAreas[0].AxisY.Minimum = 0;
            chart200.ChartAreas[0].AxisY.Maximum = 200;

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
            chart2000.ChartAreas[0].AxisY.Minimum = 0;
            chart2000.ChartAreas[0].AxisY.Maximum = 2000;

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
            chart20000.ChartAreas[0].AxisY.Minimum = 0;
            chart20000.ChartAreas[0].AxisY.Maximum = 20000;

        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            dvgResultados.Rows.Clear();

            if (!generado)
            {
                MessageBox.Show("No has generado todos los números aleatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double a = Brent.FindRoot(x => r(x) - g(x), -1.5, -0.5);
            double b = Brent.FindRoot(x => r(x) - h(x), 0.0, 0.5);

            double aReal = GaussLegendreRule.Integrate(x => r(x) - f(x), a, b, 50);

            areaReal.Text = ($"Area Real: {aReal}");

            int[] N = { 10, 100, 1000, 10000 };
            foreach (int n in N)
            {
                double areaEstimada = MonteCarloArea(a, b, n);
                areaNumAleatorios.Text = areaEstimada.ToString();
                double error = Math.Abs(aReal - areaEstimada);
                double errorPorcentual = (error / aReal) * 100;
                dvgResultados.Rows.Add(n, areaEstimada, error, errorPorcentual);
            }
        }

        static Func<double, double> r = x => -(0.5 * x) * (0.5 * x) * (0.5 * x) + 1; // superior
        static Func<double, double> f = x => x * x; // inferior
        static Func<double, double> g = x => -x * x + 1.5; // izquierda
        static Func<double, double> h = x => 3 * Math.Sin(x); // derecha

        private double MonteCarloArea(double a, double b, int numPuntos)
        {
            Random rand = new Random();
            int dentro = 0;
            int offset = rand.Next(0, arrayUn.Length);
            double minY = Brent.FindRoot(x => f(x) - h(x), -1.0, 0.0);
            double maxY = r(a);

            //areaReal.Text = ($"minY: {minY}, maxY: {maxY} , a: {a}, b: {b}");

            for (int i = 0; i < numPuntos; i++)
            {
                double x = a + (b - a) * arrayUn[(i + offset) % arrayUn.Length];
                double y = minY + (maxY - minY) * arrayUn[(i + offset) % arrayUn.Length];
                errorTeorico.Text = ($"x: {x}, y: {y}");
                if (EstaDentro(x, y)) dentro++;
            }

            ErrorReal.Text = ($"dentro: {dentro}");

            double areaRectangulo = (b - a) * (maxY - minY);
            return (dentro / (double)numPuntos) * areaRectangulo;
        }

        private bool EstaDentro(double x, double y)
        {
            return (y >= f(x) && y <= r(x));
        }

        private void Graficar_Click(object sender, EventArgs e)
        {

            chartGrafico.Series["Series1"].Points.Clear();
            chartGrafico.Series["Series2"].Points.Clear();
            chartGrafico.Series["Series3"].Points.Clear();
            chartGrafico.Series["Series4"].Points.Clear();

            // Definir las coordenadas del rectángulo
            double xMin = -0.866025;
            double xMax = 0.338128;
            double yMin = 0;
            double yMax = 1.039111;

            chartGrafico.Series["Series5"].Points.AddXY(xMin, yMax); 
            chartGrafico.Series["Series5"].Points.AddXY(xMax, yMax);
            chartGrafico2.Series["Series5"].Points.AddXY(xMin, yMax); 
            chartGrafico2.Series["Series5"].Points.AddXY(xMax, yMax);
            chartGrafico3.Series["Series5"].Points.AddXY(xMin, yMax); 
            chartGrafico3.Series["Series5"].Points.AddXY(xMax, yMax);
            chartGrafico4.Series["Series5"].Points.AddXY(xMin, yMax); 
            chartGrafico4.Series["Series5"].Points.AddXY(xMax, yMax);

            chartGrafico.Series["Series6"].Points.AddXY(xMin, yMin); 
            chartGrafico.Series["Series6"].Points.AddXY(xMax, yMin);
            chartGrafico2.Series["Series6"].Points.AddXY(xMin, yMin); 
            chartGrafico2.Series["Series6"].Points.AddXY(xMax, yMin);
            chartGrafico3.Series["Series6"].Points.AddXY(xMin, yMin); 
            chartGrafico3.Series["Series6"].Points.AddXY(xMax, yMin);
            chartGrafico4.Series["Series6"].Points.AddXY(xMin, yMin); 
            chartGrafico4.Series["Series6"].Points.AddXY(xMax, yMin);

            chartGrafico.Series["Series7"].Points.AddXY(xMin, yMin);
            chartGrafico.Series["Series7"].Points.AddXY(xMin, yMax);
            chartGrafico2.Series["Series7"].Points.AddXY(xMin, yMin); 
            chartGrafico2.Series["Series7"].Points.AddXY(xMin, yMax);
            chartGrafico3.Series["Series7"].Points.AddXY(xMin, yMin); 
            chartGrafico3.Series["Series7"].Points.AddXY(xMin, yMax);
            chartGrafico4.Series["Series7"].Points.AddXY(xMin, yMin);
            chartGrafico4.Series["Series7"].Points.AddXY(xMin, yMax);

            chartGrafico.Series["Series8"].Points.AddXY(xMax, yMin); 
            chartGrafico.Series["Series8"].Points.AddXY(xMax, yMax);
            chartGrafico2.Series["Series8"].Points.AddXY(xMax, yMin); 
            chartGrafico2.Series["Series8"].Points.AddXY(xMax, yMax);
            chartGrafico3.Series["Series8"].Points.AddXY(xMax, yMin); 
            chartGrafico3.Series["Series8"].Points.AddXY(xMax, yMax);
            chartGrafico4.Series["Series8"].Points.AddXY(xMax, yMin);
            chartGrafico4.Series["Series8"].Points.AddXY(xMax, yMax);

            for (double x = -0.866025; x <= 0; x += 0.001)
            {
                double y1 = x * x; // f(x) = x^2

                if (y1 >= 0 && y1 <= 0.75)
                {
                    chartGrafico.Series["Series1"].Points.AddXY(x, y1);
                    chartGrafico2.Series["Series1"].Points.AddXY(x, y1);
                    chartGrafico3.Series["Series1"].Points.AddXY(x, y1);
                    chartGrafico4.Series["Series1"].Points.AddXY(x, y1);
                }
            }

            for (double x = -0.866025; x <= -0.678887; x += 0.001)
            {
                double y2 = -Math.Pow(x, 2) + 1.5; // f(x) = -x^2 + 1.5

                if (y2 >= 0.75 && y2 <= 1.039111)
                {
                    chartGrafico.Series["Series2"].Points.AddXY(x, y2);
                    chartGrafico2.Series["Series2"].Points.AddXY(x, y2);
                    chartGrafico3.Series["Series2"].Points.AddXY(x, y2);
                    chartGrafico4.Series["Series2"].Points.AddXY(x, y2);
                }
            }

            for (double x = 0; x <= 0.338128; x += 0.001)
            {
                double y3 = 3 * Math.Sin(x); // f(x) = 3sin(x)

                if (y3 >= 0 && y3 <= 0.995167)
                {
                    chartGrafico.Series["Series3"].Points.AddXY(x, y3);
                    chartGrafico2.Series["Series3"].Points.AddXY(x, y3);
                    chartGrafico3.Series["Series3"].Points.AddXY(x, y3);
                    chartGrafico4.Series["Series3"].Points.AddXY(x, y3);
                }
            }

            for (double x = -0.678887; x <= 0.3338128; x += 0.001)
            {
                double y4 = -Math.Pow(0.5 * x, 3) + 1; // f(x) = -(0.5x)^3 + 1

                if (y4 >= 0.995167 && y4 <= 1.039111)
                {
                    chartGrafico.Series["Series4"].Points.AddXY(x, y4);
                    chartGrafico2.Series["Series4"].Points.AddXY(x, y4);
                    chartGrafico3.Series["Series4"].Points.AddXY(x, y4);
                    chartGrafico4.Series["Series4"].Points.AddXY(x, y4);
                }
            }


            // Crear la lista para almacenar las coordenadas
            List<(double x, double y)> coordenadas = new List<(double, double)>();
            List<(double x, double y)> coordenadas2= new List<(double, double)>();
            List<(double x, double y)> coordenadas3= new List<(double, double)>();
            List<(double x, double y)> coordenadas4= new List<(double, double)>();

            // Generar 10 coordenadas aleatorias a partir de arrayUn
            for (int i = 1; i < 20; i += 2)
            {
                coordenadas.Add((arrayUn[i - 1]-0.866025, arrayUn[i]));
            }

            // Generar 100 coordenadas aleatorias a partir de arrayUn
            for (int i = 21; i < 220; i += 2)
            {
                coordenadas2.Add((arrayUn[i - 1]-0.866025, arrayUn[i]));
            }

            // Generar 1000coordenadas aleatorias a partir de arrayUn
            for (int i = 221; i < 2220; i+= 2)
            {
                coordenadas3.Add((arrayUn[i - 1]-0.866025, arrayUn[i]));
            }

            // Generar 10000coordenadas aleatorias a partir de arrayUn
            for (int i = 2221; i < 22220; i+= 2)
            {
                coordenadas4.Add((arrayUn[i - 1]-0.866025, arrayUn[i]));
            }

            // Agregar los puntos a los gráficos
            foreach (var (x, y) in coordenadas)
            {
                chartGrafico.Series["SeriePuntos"].Points.AddXY(x, y);
            }

            foreach (var (x, y) in coordenadas2)
            {
                chartGrafico2.Series["SeriePuntos"].Points.AddXY(x, y);
            }

            foreach (var (x, y) in coordenadas3)
            {
                chartGrafico3.Series["SeriePuntos"].Points.AddXY(x, y);
            }

            foreach (var (x, y) in coordenadas4)
            {
                chartGrafico4.Series["SeriePuntos"].Points.AddXY(x, y);
            }
        }
    }
}
