using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyCalculator.EntropyAnalyzers
{
    public class EntropyAnalysisResults<T> : IAnalysisResult<T>
    {
        private List<T> _valuesList;
        private List<int> _countList;

        public EntropyAnalysisResults()
        {
            _valuesList = new List<T>();
            _countList = new List<int>();
        }

        public EntropyAnalysisResults(IList<T> values, IList<int> countList)
        {
            _valuesList = new List<T>(values);
            _countList = new List<int>(countList);
        }

        public int TotalSumm => GetCountListSumm();

        public void Add(T value)
        {
            int index = _valuesList.IndexOf(value);
            if (index == -1)
            {
                _valuesList.Add(value);
                _countList.Add(1);
            }
            else
            {
                _countList[index]++;
            }
        }

        public void Add(T value, int count)
        {
            int index = _valuesList.IndexOf(value);
            if (index == -1)
            {
                _valuesList.Add(value);
                _countList.Add(count);
            }
            else
            {
                _countList[index] += count;
            }
        }

        public double Entropy => CalculateEntropy(2);

        public int GetCount(T value)
        {
            int count = GetCountInternal(value);

            if (count != -1)
                return count;

            throw new ArgumentOutOfRangeException(nameof(value));
        }

        public double GetProbability(T value)
        {
            int count = GetCountInternal(value);
            int countSumm = GetCountListSumm();

            if (count != -1)
            {
                return (double)count / countSumm;
            }

            throw new ArgumentOutOfRangeException(nameof(value));
        }

        private int GetCountListSumm()
        {
            int summ = 0;
            for (int i = 0; i < _countList.Count; i++)
            {
                summ += _countList[0];
            }

            return summ;
        }

        public int Length => _valuesList.Count;

        public int this[T value] => GetCount(value);

        private int GetCountInternal(T value)
        {
            int index = _valuesList.IndexOf(value);

            if (index != -1)
                return _countList[index];

            return -1;
        }

        private double CalculateEntropy(int logBase)
        {
            double summ = 0;
            double totalCount = GetCountListSumm();
            for (int i = 0; i < _countList.Count; i++)
            {
                double prob = (double) _countList[i] / totalCount;
                if (Math.Abs(prob) < 1e-6)
                    summ += 0;
                else
                {
                    summ += prob * Math.Log(prob, logBase);
                }
            }

            return -summ;
        }
    }
}
