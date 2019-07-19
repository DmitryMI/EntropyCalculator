using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntropyCalculator.EntropyAnalyzers;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace EntropyCalculator
{
    public partial class Plotter : Form
    {
        private Stream _stream;
        private PlotStyle _plotStyle;
        private PlotScale _plotScale;
        private IAnalysisResult<byte> _results;

        
        public Plotter(PlotStyle style, PlotScale scale)
        {
            _plotStyle = style;
            _plotScale = scale;
            InitializeComponent();
        }

        public Plotter(PlotStyle style, PlotScale scale, Stream inputStream)
        {
            _plotStyle = style;
            _plotScale = scale;
            Stream = inputStream;
            InitializeComponent();
        }

        public Stream Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }

        public void StartCalculation()
        {
            LaunchAnalyzer();
        }

        private async void LaunchAnalyzer()
        {
            EntropyAnalyzer analyzer = new EntropyAnalyzer();
            _results = await analyzer.AnalyzeAsync(Stream);
            //_results = analyzer.Analyze(Stream);

            PlotResults();

            Stream.Close();
        }

        private void PlotResults()
        {
            try
            {
                var model = new PlotModel
                {
                    Title = "Histogram", LegendPlacement = LegendPlacement.Outside,
                    LegendPosition = LegendPosition.RightTop, LegendOrientation = LegendOrientation.Vertical
                };
                OxyPlot.Series.RectangleBarSeries bars = new RectangleBarSeries();

                if (_plotScale == PlotScale.Log)
                {
                    throw new NotImplementedException("Logarithmic scale");
                    Axis yAxis = new LogarithmicAxis();
                    model.Axes.Add(yAxis);
                    yAxis.AbsoluteMinimum = 0;
                    yAxis.Minimum = 0;
                }

                for (int i = 0; i < _results.Length; i++)
                {
                    double height = GetHeight(i);

                    //HighLowItem chartItem = new HighLowItem(i, height, 0);
                    RectangleBarItem item = new RectangleBarItem(i, 0, i + 1, height);

                    bars.Items.Add(item);
                }

                model.Series.Add(bars);

                //model.Axes.Add(yAxis);

                HistogramDrawer.Model = model;

                HistogramDrawer.Visible = true;

                EntropyValueLabel.Text = _results.Entropy.ToString("0.00");

                
                ProcessUi();
            }
            catch (NotImplementedException e)
            {
                MessageBox.Show("This feature is not implemented: " + e.Message);
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void ProcessUi()
        {
            if (_plotScale == PlotScale.Log)
            {
                logToolStripMenuItem.Checked = true;
                linearToolStripMenuItem.Checked = false;
            }
            if (_plotScale == PlotScale.Linear)
            {
                logToolStripMenuItem.Checked = false;
                linearToolStripMenuItem.Checked = true;
            }

            if (_plotStyle == PlotStyle.Numbers)
            {
                numbersToolStripMenuItem.Checked = true;
                probabilityToolStripMenuItem.Checked = false;
            }
            else
            {
                numbersToolStripMenuItem.Checked = false;
                probabilityToolStripMenuItem.Checked = true;
            }
        }

        private double GetHeight(int i)
        {
            double height;
            switch (_plotStyle)
            {
                case PlotStyle.Numbers:
                    height = _results.GetCount((byte)i);
                    break;
                case PlotStyle.Probabilities:
                    height = _results.GetProbability((byte)i);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return height;
        }
        

        private void Plotter_Load(object sender, EventArgs e)
        {

        }

        private void NumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _plotStyle = PlotStyle.Numbers;
            PlotResults();
        }

        private void ProbabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _plotStyle = PlotStyle.Probabilities;
            PlotResults();
        }

        private void LinearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _plotScale = PlotScale.Linear;
            PlotResults();
        }

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _plotScale = PlotScale.Log;
            PlotResults();
        }
    }
}
