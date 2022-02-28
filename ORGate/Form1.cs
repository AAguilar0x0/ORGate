using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MLM;
using MathNet.Numerics.LinearAlgebra;

namespace ORGate
{
    public partial class Form1 : Form
    {
        string name = "OR Gate";
        int tr = 0;
        ANN or;
        List<Matrix<double>> X;
        List<Matrix<double>> Y;

        public Form1()
        {
            InitializeComponent();
            MinimumSize = Size;
            Text = name;
            status.Text = "";
            totalTraining.Text = tr.ToString();
            result.Text = "";
            or = new ANN(2, new int[] { 3 }, 2, name);
            X = new List<Matrix<double>>();
            X.Add(Matrix<double>.Build.DenseOfArray(new double[,] { { 0, 0 } }));
            X.Add(Matrix<double>.Build.DenseOfArray(new double[,] { { 0, 1 } }));
            X.Add(Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 0 } }));
            X.Add(Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 1 } }));
            Y = new List<Matrix<double>>();
            Y.Add(Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 0 } }));
            Y.Add(Matrix<double>.Build.DenseOfArray(new double[,] { { 0, 1 } }));
            Y.Add(Matrix<double>.Build.DenseOfArray(new double[,] { { 0, 1 } }));
            Y.Add(Matrix<double>.Build.DenseOfArray(new double[,] { { 0, 1 } }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iter = int.Parse(iterations.Text);
                tr += iter;
                status.Text = "Training...";
                status.Refresh();
                or.Train(X, Y, iter, 0.1);
                status.Text = "Trained";
                totalTraining.Text = tr.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid iteration");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix<double> Xi = Matrix<double>.Build.DenseOfArray(new double[,] { { double.Parse(term1.Text), double.Parse(term2.Text) } });
                Matrix<double> H = or.Infer(Xi);
                double max = H[0, 0];
                int argMax = 0;
                for (int x = 0; x < H.RowCount; x++)
                    for (int y = 0; y < H.ColumnCount; y++)
                    {
                        if (H[x, y] > max)
                        {
                            max = H[x, y];
                            argMax = y;
                        }
                    }
                result.Text = $"{argMax}\n{H}";
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tr = 0;
            or = new ANN(2, new int[] { 3 }, 2, name);
            result.Text = or.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = or.ToString();
        }
    }
}
