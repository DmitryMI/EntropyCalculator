using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntropyCalculator
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
            PathBox.Text = OpenFileDialog.FileName;
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {
           
        }

        private void LaunchPlotter()
        {
            if (File.Exists(PathBox.Text))
            {

                FileStream fs = new FileStream(PathBox.Text, FileMode.Open);
                Plotter plotter = new Plotter(PlotStyle.Numbers, PlotScale.Linear, fs);
                plotter.Show();
                plotter.StartCalculation();
            }
            else
            {
                MessageBox.Show("Error: path does not exist of is not a file.", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            LaunchPlotter();
        }
    }
}
