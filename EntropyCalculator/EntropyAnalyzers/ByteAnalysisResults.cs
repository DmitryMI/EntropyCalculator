using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyCalculator.EntropyAnalyzers
{
    class ByteAnalysisResults : IAnalysisResult<byte>
    {
        public const int ByteValuesRange = 256;

        private readonly int[] _counts;

        public ByteAnalysisResults()
        {
            _counts = new int[ByteValuesRange];
        }

        public int GetCount(byte value)
        {
            return _counts[value];
        }

        public double GetProbability(byte value)
        {
            return (double) GetCount(value) / GetCountListSumm();
        }

        public void Add(byte b, int count)
        {
            _counts[b] += count;
        }

        public double Entropy => CalculateEntropy();

        private double CalculateEntropy()
        {
            double summ = 0;
            double totalCounts = GetCountListSumm();
            for (int i = 0; i < _counts.Length; i++)
            {
                double prob = (double)_counts[i] / totalCounts;
                summ += prob * Math.Log(prob, _counts.Length);
            }

            return -summ;
        }

        private int GetCountListSumm()
        {
            int summ = 0;
            for (int i = 0; i < _counts.Length; i++)
            {
                summ += _counts[0];
            }

            return summ;
        }

        public int TotalSumm => GetCountListSumm();

        public void Add(byte b)
        {
            _counts[b]++;
        }

        public int Length => ByteValuesRange;
    }
}
