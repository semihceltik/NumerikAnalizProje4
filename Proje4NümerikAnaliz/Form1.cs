using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje4NümerikAnaliz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(txtX0.Text);
            double y0 = double.Parse(txtY0.Text);
            double v0 = double.Parse(txtV0.Text);
            double h = double.Parse(txtStepSize.Text);
            int steps = int.Parse(txtSteps.Text);
            
            string method = cmbMethod.SelectedItem.ToString();
            List<(double x, double y, double v)> results;

            var memoryBefore = Process.GetCurrentProcess().PrivateMemorySize64;

            if (method == "Heun")
                results = SolveHeun(x0, y0, v0, h, steps);
            else if (method == "Midpoint")
                results = SolveMidpoint(x0, y0, v0, h, steps);
            else if (method == "Ralston")
                results = SolveRalston(x0, y0, v0, h, steps);
            else
                throw new Exception("Seçtiğin Metod Listede yok knk");

            var memoryAfter = Process.GetCurrentProcess().PrivateMemorySize64;

            DisplayResults(results);
            lblMemoryUsage.Text = $"Memory Usage: {(memoryAfter - memoryBefore) / 1024.0 / 1024.0} MB";
        }

        private List<(double x, double y, double v)> SolveHeun(double x0, double y0, double v0, double h, int steps)
        {
            var results = new List<(double x, double y, double v)>();
            double x = x0, y = y0, v = v0;

            for (int i = 0; i < steps; i++)
            {
                double k1y = h * v;
                double k1v = h * (Math.Cos(x) - Math.Sin(v) + Math.Exp(-y));

                double k2y = h * (v + k1v);
                double k2v = h * (Math.Cos(x + h) - Math.Sin(v + k1v) + Math.Exp(-(y + k1y)));

                y = y + 0.5 * (k1y + k2y);
                v = v + 0.5 * (k1v + k2v);
                x = x + h;

                results.Add((x, y, v));
            }

            return results;
        }

        private List<(double x, double y, double v)> SolveMidpoint(double x0, double y0, double v0, double h, int steps)
        {
            var results = new List<(double x, double y, double v)>();
            double x = x0, y = y0, v = v0;

            for (int i = 0; i < steps; i++)
            {
                double k1y = h * v;
                double k1v = h * (Math.Cos(x) - Math.Sin(v) + Math.Exp(-y));

                double k2y = h * (v + 0.5 * k1v);
                double k2v = h * (Math.Cos(x + 0.5 * h) - Math.Sin(v + 0.5 * k1v) + Math.Exp(-(y + 0.5 * k1y)));

                y = y + k2y;
                v = v + k2v;
                x = x + h;

                results.Add((x, y, v));
            }

            return results;
        }

        private List<(double x, double y, double v)> SolveRalston(double x0, double y0, double v0, double h, int steps)
        {
            var results = new List<(double x, double y, double v)>();
            double x = x0, y = y0, v = v0;

            for (int i = 0; i < steps; i++)
            {
                double k1y = h * v;
                double k1v = h * (Math.Cos(x) - Math.Sin(v) + Math.Exp(-y));

                double k2y = h * (v + 0.75 * k1v);
                double k2v = h * (Math.Cos(x + 0.75 * h) - Math.Sin(v + 0.75 * k1v) + Math.Exp(-(y + 0.75 * k1y)));

                y = y + (k1y + 2 * k2y) / 3;
                v = v + (k1v + 2 * k2v) / 3;
                x = x + h;

                results.Add((x, y, v));
            }

            return results;
        }

        private void DisplayResults(List<(double x, double y, double v)> results)
        {
            dgvResults.Rows.Clear();
            dgvResults.Rows.Add(cmbMethod.SelectedItem.ToString(), cmbMethod.SelectedItem.ToString(), cmbMethod.SelectedItem.ToString());
            foreach (var result in results)
            {
                dgvResults.Rows.Add(result.x, result.y, result.v);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvResults.Rows.Add(cmbMethod.SelectedItem.ToString(), cmbMethod.SelectedItem.ToString(), cmbMethod.SelectedItem.ToString());
        }
    }
}
    
        
    
