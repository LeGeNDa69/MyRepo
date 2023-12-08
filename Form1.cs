using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_4_Release
{
    public partial class Form1 : Form
    {
        public TransferOfImpurities Transfer = new TransferOfImpurities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "0";

            chart1.ChartAreas[0].AxisY.Maximum = TransferOfImpurities.GridSize;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = TransferOfImpurities.GridSize;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

            chart1.Series.RemoveAt(0);

            for (int i = 0; i < TransferOfImpurities.GridSize; i++)
            {
                System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series.Add(Series1);
            }

            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";
            chart1.Legends.Clear();
        }

        private void numericUpDownSimulationTime_ValueChanged(object sender, EventArgs e)
        {
            DisplaySources();
        }

        private void numericUpDownWindV_ValueChanged(object sender, EventArgs e)
        {
            TransferOfImpurities.WindV = (double)numericUpDownWindV.Value;
        }

        private void numericUpDownWindU_ValueChanged(object sender, EventArgs e)
        {
            TransferOfImpurities.WindU = (double)numericUpDownWindV.Value;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Transfer = new TransferOfImpurities(); 
            numericUpDownSimulationTime.Value = 0; 
            numericUpDownWindV.Value = 0; 
            numericUpDownWindU.Value = 0; 

            for (int i = 0; i < TransferOfImpurities.GridSize; i++)
            {
                chart1.Series[i].Points.Clear();
            }

            label5.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new DialogForm(Transfer, label5)).ShowDialog();
        }

        public void DisplaySources()
        {
            double simulationTime;

            try
            {
                simulationTime = double.Parse(numericUpDownSimulationTime.Text);
            }
            catch
            {
                simulationTime = 0.0;
            }

            for (int i = 0; i < TransferOfImpurities.GridSize; i++)
            {
                chart1.Series[i].Points.Clear();
            }

            foreach (var source in Transfer.Sources)
            {
                source.SimulateImpurityTransfer(simulationTime);

                for (int i = 0; i < TransferOfImpurities.GridSize; i++)
                {
                    for (int j = 0; j < TransferOfImpurities.GridSize; j++)
                    {
                        chart1.Series[i].Points.AddXY((double)j, source.Concentration[i, j]);
                    }
                }
            }
        }
    }
}

