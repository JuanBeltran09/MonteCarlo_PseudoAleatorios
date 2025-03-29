namespace MonteCarlo_PseudoAleatorios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.repetidos = new System.Windows.Forms.Label();
            this.dvgAleatorios = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.advertencia = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.chart20000 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2000 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart200 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart20 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAleatorios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart20000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart20)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1481, 800);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.repetidos);
            this.tabPage1.Controls.Add(this.dvgAleatorios);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1473, 774);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 445);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1443, 320);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // repetidos
            // 
            this.repetidos.BackColor = System.Drawing.Color.LightBlue;
            this.repetidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repetidos.Location = new System.Drawing.Point(21, 407);
            this.repetidos.Name = "repetidos";
            this.repetidos.Size = new System.Drawing.Size(680, 23);
            this.repetidos.TabIndex = 20;
            this.repetidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvgAleatorios
            // 
            this.dvgAleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAleatorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.xn,
            this.un});
            this.dvgAleatorios.Location = new System.Drawing.Point(337, 17);
            this.dvgAleatorios.Name = "dvgAleatorios";
            this.dvgAleatorios.Size = new System.Drawing.Size(364, 367);
            this.dvgAleatorios.TabIndex = 18;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "Iteración";
            this.iteracion.Name = "iteracion";
            // 
            // xn
            // 
            this.xn.HeaderText = "Xn";
            this.xn.Name = "xn";
            // 
            // un
            // 
            this.un.HeaderText = "Un";
            this.un.Name = "un";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.txtM);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.txtSeed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 367);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARAMETROS";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Khaki;
            this.btnGenerar.Location = new System.Drawing.Point(88, 301);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(113, 40);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtM.Location = new System.Drawing.Point(147, 245);
            this.txtM.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(93, 20);
            this.txtM.TabIndex = 16;
            this.txtM.Text = "244944";
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Location = new System.Drawing.Point(147, 183);
            this.txtB.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(93, 20);
            this.txtB.TabIndex = 15;
            this.txtB.Text = "51749";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtA.Location = new System.Drawing.Point(147, 121);
            this.txtA.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(93, 20);
            this.txtA.TabIndex = 14;
            this.txtA.Text = "1597";
            // 
            // txtSeed
            // 
            this.txtSeed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeed.Location = new System.Drawing.Point(147, 59);
            this.txtSeed.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(93, 20);
            this.txtSeed.TabIndex = 13;
            this.txtSeed.Text = "1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "M";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.advertencia);
            this.tabPage2.Controls.Add(this.btnGraficar);
            this.tabPage2.Controls.Add(this.chart20000);
            this.tabPage2.Controls.Add(this.chart2000);
            this.tabPage2.Controls.Add(this.chart200);
            this.tabPage2.Controls.Add(this.chart20);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1473, 774);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // advertencia
            // 
            this.advertencia.BackColor = System.Drawing.Color.Yellow;
            this.advertencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertencia.Location = new System.Drawing.Point(17, 736);
            this.advertencia.Name = "advertencia";
            this.advertencia.Size = new System.Drawing.Size(1305, 23);
            this.advertencia.TabIndex = 5;
            this.advertencia.Text = "label5";
            this.advertencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.advertencia.Visible = false;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(1349, 346);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(100, 33);
            this.btnGraficar.TabIndex = 4;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // chart20000
            // 
            chartArea2.Name = "ChartArea1";
            this.chart20000.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart20000.Legends.Add(legend2);
            this.chart20000.Location = new System.Drawing.Point(686, 377);
            this.chart20000.Margin = new System.Windows.Forms.Padding(15);
            this.chart20000.Name = "chart20000";
            this.chart20000.Size = new System.Drawing.Size(636, 329);
            this.chart20000.TabIndex = 3;
            this.chart20000.Text = "chart5";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title1.Name = "Title1";
            title1.Text = "Distribución para 20000 Números";
            this.chart20000.Titles.Add(title1);
            // 
            // chart2000
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2000.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2000.Legends.Add(legend3);
            this.chart2000.Location = new System.Drawing.Point(20, 377);
            this.chart2000.Margin = new System.Windows.Forms.Padding(15);
            this.chart2000.Name = "chart2000";
            this.chart2000.Size = new System.Drawing.Size(636, 329);
            this.chart2000.TabIndex = 2;
            this.chart2000.Text = "chart4";
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            title2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title2.Name = "Title1";
            title2.Text = "Distribución para 2000 Números";
            this.chart2000.Titles.Add(title2);
            // 
            // chart200
            // 
            chartArea4.Name = "ChartArea1";
            this.chart200.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart200.Legends.Add(legend4);
            this.chart200.Location = new System.Drawing.Point(686, 18);
            this.chart200.Margin = new System.Windows.Forms.Padding(15);
            this.chart200.Name = "chart200";
            this.chart200.Size = new System.Drawing.Size(636, 329);
            this.chart200.TabIndex = 1;
            this.chart200.Text = "chart3";
            title3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            title3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title3.Name = "Title1";
            title3.Text = "Distribución para 200 Números";
            this.chart200.Titles.Add(title3);
            // 
            // chart20
            // 
            this.chart20.AccessibleName = "";
            chartArea5.Name = "ChartArea1";
            this.chart20.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart20.Legends.Add(legend5);
            this.chart20.Location = new System.Drawing.Point(20, 18);
            this.chart20.Margin = new System.Windows.Forms.Padding(15);
            this.chart20.Name = "chart20";
            this.chart20.Size = new System.Drawing.Size(636, 329);
            this.chart20.TabIndex = 0;
            this.chart20.Text = "Nombre";
            title4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            title4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title4.Name = "Title1";
            title4.Text = "Distribución para 20 Números";
            this.chart20.Titles.Add(title4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 799);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAleatorios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart20000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dvgAleatorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xn;
        private System.Windows.Forms.DataGridViewTextBoxColumn un;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label repetidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart20000;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2000;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart200;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart20;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label advertencia;
    }
}

