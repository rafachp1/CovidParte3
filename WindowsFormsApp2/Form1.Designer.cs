
namespace WindowsFormsApp2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar3 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar4 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 75);
            this.chart1.Name = "chart1";
            series3.BackImageTransparentColor = System.Drawing.Color.Black;
            series3.BackSecondaryColor = System.Drawing.Color.Transparent;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.Transparent;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Transparent;
            series3.MarkerColor = System.Drawing.Color.Transparent;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(373, 237);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de contagios Activos a Nivel mundial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estadísticas del Mes Abril";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 310);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(439, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vacunas Administradas en relación a República Dominicana";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(379, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 310);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(27, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 37);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(406, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(528, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "% de Personas completamente vacunadas de acuerdo a su población";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.FillThickness = 10;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(497, 436);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.guna2CircleProgressBar1.ProgressThickness = 13;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.ShowPercentage = true;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(80, 84);
            this.guna2CircleProgressBar1.TabIndex = 11;
            this.guna2CircleProgressBar1.Value = 1;
            // 
            // guna2CircleProgressBar2
            // 
            this.guna2CircleProgressBar2.FillThickness = 10;
            this.guna2CircleProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleProgressBar2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CircleProgressBar2.Location = new System.Drawing.Point(610, 436);
            this.guna2CircleProgressBar2.Name = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.guna2CircleProgressBar2.ProgressColor = System.Drawing.Color.DarkOrange;
            this.guna2CircleProgressBar2.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.guna2CircleProgressBar2.ProgressThickness = 13;
            this.guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar2.ShadowDecoration.Parent = this.guna2CircleProgressBar2;
            this.guna2CircleProgressBar2.ShowPercentage = true;
            this.guna2CircleProgressBar2.Size = new System.Drawing.Size(80, 84);
            this.guna2CircleProgressBar2.TabIndex = 12;
            this.guna2CircleProgressBar2.Value = 19;
            // 
            // guna2CircleProgressBar3
            // 
            this.guna2CircleProgressBar3.FillThickness = 10;
            this.guna2CircleProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleProgressBar3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CircleProgressBar3.Location = new System.Drawing.Point(715, 435);
            this.guna2CircleProgressBar3.Name = "guna2CircleProgressBar3";
            this.guna2CircleProgressBar3.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.guna2CircleProgressBar3.ProgressColor = System.Drawing.Color.SkyBlue;
            this.guna2CircleProgressBar3.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.guna2CircleProgressBar3.ProgressThickness = 13;
            this.guna2CircleProgressBar3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar3.ShadowDecoration.Parent = this.guna2CircleProgressBar3;
            this.guna2CircleProgressBar3.ShowPercentage = true;
            this.guna2CircleProgressBar3.Size = new System.Drawing.Size(80, 84);
            this.guna2CircleProgressBar3.TabIndex = 13;
            this.guna2CircleProgressBar3.Value = 5;
            // 
            // guna2CircleProgressBar4
            // 
            this.guna2CircleProgressBar4.FillThickness = 10;
            this.guna2CircleProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleProgressBar4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CircleProgressBar4.Location = new System.Drawing.Point(823, 436);
            this.guna2CircleProgressBar4.Name = "guna2CircleProgressBar4";
            this.guna2CircleProgressBar4.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.guna2CircleProgressBar4.ProgressColor = System.Drawing.Color.Yellow;
            this.guna2CircleProgressBar4.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.guna2CircleProgressBar4.ProgressThickness = 13;
            this.guna2CircleProgressBar4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar4.ShadowDecoration.Parent = this.guna2CircleProgressBar4;
            this.guna2CircleProgressBar4.ShowPercentage = true;
            this.guna2CircleProgressBar4.Size = new System.Drawing.Size(80, 84);
            this.guna2CircleProgressBar4.TabIndex = 14;
            this.guna2CircleProgressBar4.Value = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(934, 546);
            this.Controls.Add(this.guna2CircleProgressBar4);
            this.Controls.Add(this.guna2CircleProgressBar3);
            this.Controls.Add(this.guna2CircleProgressBar2);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mes de Abril";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar4;
    }
