using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab_8._3__empirical_statistics_
{
    public partial class Form1 : BaseEditorForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double aProb) &&
                double.TryParse(textBox2.Text, out double bProb) &&
                double.TryParse(textBox3.Text, out double cProb) &&
                double.TryParse(textBox4.Text, out double dProb) &&
                double.TryParse(textBox6.Text, out double count) &&
                aProb > 0 &&
                bProb > 0 &&
                cProb > 0 &&
                dProb > 0 &&
                aProb + bProb + cProb + dProb <= 1)
            {
                var eProb = 1 - (aProb + bProb + cProb + dProb);
                textBox5.Text = Math.Round(eProb, 2).ToString();
                chart1.Series[0].Points.Clear();
                Random random = new();
                int aCount = 0;
                int bCount = 0;
                int cCount = 0;
                int dCount = 0;
                int eCount = 0;
                double current;
                for (int i = 0; i < (int)count; i++)
                {
                    current = random.NextDouble();

                    if (current < aProb)
                    {
                        aCount++;
                        continue;
                    }
                    current -= aProb;

                    if (current < bProb)
                    {
                        bCount++;
                        continue;
                    }
                    current -= bProb;

                    if (current < cProb)
                    {
                        cCount++;
                        continue;
                    }
                    current -= cProb;

                    if (current < dProb)
                    {
                        dCount++;
                        continue;
                    }

                    eCount ++;
                }
                var max = Math.Max(aCount, Math.Max(bCount, Math.Max(cCount, Math.Max(dCount, eCount)))) / count;
                chart1.ChartAreas[0].AxisY.Maximum = max;
                chart1.Series[0].Points.AddXY(1D, aCount / count);
                chart1.Series[0].Points.AddXY(2D, bCount / count);
                chart1.Series[0].Points.AddXY(3D, cCount / count);
                chart1.Series[0].Points.AddXY(4D, dCount / count);
                chart1.Series[0].Points.AddXY(5D, eCount / count);
            }
        }
    }
}
