using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyCalculator.EntropyAnalyzers
{
    interface IAnalysisResult<in T>
    {
        int GetCount(T value);
        double GetProbability(T value);
        int Length { get; }
        int TotalSumm { get; }
        void Add(T value);
        void Add(T value, int count);

        double Entropy { get; }
    }
}
