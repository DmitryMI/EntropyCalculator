using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyCalculator.EntropyAnalyzers
{
    class EntropyAnalyzer
    {
        public const int BufferSize = 1024 * 1024;

        private struct AnalyzerArgs<T>
        {
            public Stream Stream;
            public IAnalysisResult<T> Results;
        }

        public EntropyAnalyzer()
        {

        }

        public Task<IAnalysisResult<byte>> AnalyzeAsync(Stream inStream)
        {
            Task<IAnalysisResult<byte>> task = new Task<IAnalysisResult<byte>>(AnalyzeWithResults, inStream);
            task.Start();

            return task;
        }

        public IAnalysisResult<byte> Analyze(Stream inputStream)
        {
            return AnalyzeWithResults(inputStream);
        }

        private IAnalysisResult<byte> AnalyzeWithResults(object streamWrapped)
        {
            Stream stream = (Stream) streamWrapped;
            ByteAnalysisResults results = new ByteAnalysisResults();
            AnalyzerArgs<byte> args = new AnalyzerArgs<byte>();
            args.Stream = stream;
            args.Results = results;

            AnalyzeByteStream(args);

            return results;
        }

        private void AnalyzeByteStream(object argsWrapped)
        {
            AnalyzerArgs<byte> args = (AnalyzerArgs<byte>) argsWrapped;
            Stream inputStream = args.Stream;
            IAnalysisResult<byte> results = args.Results;

            byte[] buffer = new byte[BufferSize];
            int readBytes;

            do
            {
                readBytes = inputStream.Read(buffer, 0, BufferSize);

                for (int i = 0; i < readBytes; i++)
                {
                    results.Add(buffer[i]);
                }

            } while (readBytes > 0);
        }

        
    }
}
