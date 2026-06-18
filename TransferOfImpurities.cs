using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Release
{
    public class TransferOfImpurities
    {
        public static int GridSize { get; set; }
        public static double StepX { get; set; }
        public static double StepY { get; set; }
        public static double TimeStep {  get; set; }
        public static double WindAlpha { get; set; }
        public static double WindU { get; set; }
        public static double WindV { get; set;}

        public List<Source> Sources;

        public TransferOfImpurities()
        {
            GridSize = 49;
            StepX = 0.5;
            StepY = 0.5;
            TimeStep = 0.05;
            WindAlpha = 0.5;
            WindU = 0.0;
            WindV = 0.0;
            Sources = new List<Source>();
        }

        public static Source NewSource(int x, int y, int value)
        {
            return new Source(x, y, value);
        }

        public class Source
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Value { get; set; }

            public double[,] Concentration { get; set; }
            public Source(int x, int y, int value)
            {
                X = x;
                Y = y;
                Value = value;
                Concentration = new double[GridSize + 1, GridSize + 1];
                InitializeConcentration();
            }
            private void InitializeConcentration()
            {
                for (int i = 1; i < GridSize; i++)
                {
                    for (int j = 1; j < GridSize; j++)
                    {
                        Concentration[i, j] = 0.0;
                    }
                }
            }

            private double GetValue(int i, int j)
            {
                if (X == i && Y == j)
                    return Value;
                else
                    return 0.0;
            }

            private double CalculateWindMassFlow(int i, int j)
            {
                double M1, M2, M3, M4;

                if (WindU > 0)
                    M1 = Concentration[i, j] * WindU * TimeStep;
                else
                    M1 = Concentration[i + 1, j] * WindU * TimeStep;

                if (WindU < 0)
                    M2 = Concentration[i, j] * WindU * TimeStep;
                else
                    M2 = Concentration[i - 1, j] * WindU * TimeStep;

                if (WindV > 0)
                    M3 = Concentration[i, j] * WindV * TimeStep;
                else
                    M3 = Concentration[i, j + 1] * WindV * TimeStep;

                if (WindV < 0)
                    M4 = Concentration[i, j] * WindV * TimeStep;
                else
                    M4 = Concentration[i, j - 1] * WindV * TimeStep;

                return 1.0 / (StepX * StepY) * (M1 - M2 + M3 - M4);
            }

            private double CalculateDiffusion(int i, int j)
            {
                return TimeStep / (StepX * StepX) * (Concentration[i + 1, j] - 4 * Concentration[i, j]
                    + Concentration[i - 1, j] + Concentration[i, j + 1] + Concentration[i, j - 1]);
            }

            public void SimulateImpurityTransfer(double simulationTime)
            {
                double currentTime = 0.0;

                double[,] currentConcentration = new double[GridSize + 1, GridSize + 1];

                do
                {   
                    for (int i = 1; i < GridSize; i++)
                    {
                        for (int j = 1; j < GridSize; j++)
                        {
                            currentConcentration[i, j] = Concentration[i, j] - CalculateWindMassFlow(i, j)
                                + CalculateDiffusion(i, j) + TimeStep * (GetValue(i, j) - WindAlpha * Concentration[i, j]);

                        }
                    }
                    currentTime += TimeStep;
                } while (currentTime < simulationTime);

                for (int i = 1; i < GridSize; i++)
                {
                    for (int j = 1; j < GridSize; j++)
                    {
                        Concentration[i, j] = currentConcentration[i, j];
                    }
                }
            }

        }
    }
}
