using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace lab_8._3__empirical_statistics_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            chart1 = new Chart();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = Color.WhiteSmoke;
            chart1.BorderlineColor = Color.FromArgb(25, 23, 24);
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "0";
            chartArea1.AxisX.LineColor = SystemColors.AppWorkspace;
            chartArea1.AxisX.LineWidth = 3;
            chartArea1.AxisX.MajorGrid.LineColor = SystemColors.ControlDarkDark;
            chartArea1.AxisX.Maximum = 6D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TitleForeColor = SystemColors.AppWorkspace;
            chartArea1.AxisY.Interval = 0.03D;
            chartArea1.AxisY.LabelStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "0.00";
            chartArea1.AxisY.LineColor = SystemColors.AppWorkspace;
            chartArea1.AxisY.LineWidth = 3;
            chartArea1.AxisY.MajorGrid.LineColor = SystemColors.ControlDarkDark;
            chartArea1.AxisY.Maximum = 0.3D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TitleForeColor = SystemColors.AppWorkspace;
            chartArea1.BorderColor = SystemColors.AppWorkspace;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(12, 12);
            chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1026, 485);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(1142, 44);
            label1.Name = "label1";
            label1.Size = new Size(53, 33);
            label1.TabIndex = 1;
            label1.Text = "P 1";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 20.25F);
            button1.Location = new Point(1142, 416);
            button1.Name = "button1";
            button1.Size = new Size(115, 43);
            button1.TabIndex = 2;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 20.25F);
            textBox1.Location = new Point(1242, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 41);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 20.25F);
            textBox2.Location = new Point(1242, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 41);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(1142, 94);
            label2.Name = "label2";
            label2.Size = new Size(53, 33);
            label2.TabIndex = 4;
            label2.Text = "P 2";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 20.25F);
            textBox3.Location = new Point(1242, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 41);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(1142, 147);
            label3.Name = "label3";
            label3.Size = new Size(53, 33);
            label3.TabIndex = 6;
            label3.Text = "P 3";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 20.25F);
            textBox4.Location = new Point(1242, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 41);
            textBox4.TabIndex = 9;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1142, 200);
            label4.Name = "label4";
            label4.Size = new Size(53, 33);
            label4.TabIndex = 8;
            label4.Text = "P 4";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Font = new Font("Century Gothic", 20.25F);
            textBox5.Location = new Point(1242, 250);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 41);
            textBox5.TabIndex = 11;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1142, 256);
            label5.Name = "label5";
            label5.Size = new Size(53, 33);
            label5.TabIndex = 10;
            label5.Text = "P 5";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century Gothic", 20.25F);
            textBox6.Location = new Point(1314, 335);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 41);
            textBox6.TabIndex = 12;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(1044, 338);
            label6.Name = "label6";
            label6.Size = new Size(250, 33);
            label6.TabIndex = 13;
            label6.Text = "Размер выборки:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1427, 508);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
    }
}
