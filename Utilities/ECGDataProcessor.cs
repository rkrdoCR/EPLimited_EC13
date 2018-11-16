using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Utilities
{
    public class ECGDataProcessor
    {
        private string _outputDir;
        private string _sourceFilesDir;
        private IEnumerable<string> _allSources;
        private IEnumerable<string> _allConverted;

        public Dictionary<string, int[]> TestData { get; private set; }

        public ECGDataProcessor()
        {
            _outputDir = Path.Combine(Environment.CurrentDirectory, @"ConvertedSources");
            _sourceFilesDir = Path.Combine(Environment.CurrentDirectory, @"SourceFiles");

            _allSources = Directory.GetFiles(_sourceFilesDir).Where(f => f.ToLower().EndsWith(".dat"));

            Directory.CreateDirectory(_outputDir);
            Convert_dat_To_txt();
            _allConverted = Directory.GetFiles(_outputDir);

            TestData = LoadDataFromConvertedFiles();
        }

        private Dictionary<string, int[]> LoadDataFromConvertedFiles()
        {
            Dictionary<string, int[]> result = new Dictionary<string, int[]>();

            foreach (var source in _allConverted)
            {
                string fileName = Path.GetFileNameWithoutExtension(source);
                byte[] fileBytes = File.ReadAllBytes(source);
                List<byte> byteList = new List<byte>();

                using (MemoryStream memory = new MemoryStream(fileBytes))
                {
                    using (BinaryReader reader = new BinaryReader(memory))
                    {
                        for (int i = 0; i < fileBytes.Length; i++)
                        {
                            byteList.Add(reader.ReadByte());
                        }
                    }
                }
                int[] values = Encoding.Default.GetString(byteList.ToArray()).Split(',').Select(s => int.Parse(s)).ToArray();
                result.Add(fileName, values);
            }
            return result;
        }

        public void Convert_dat_To_txt()
        {
            foreach (var source in _allSources)
            {
                string fileName = string.Format("{0}.txt", Path.GetFileNameWithoutExtension(source));

                byte[] fileBytes = File.ReadAllBytes(source);
                List<byte> byteList = new List<byte>();

                using (MemoryStream memory = new MemoryStream(fileBytes))
                {
                    using (BinaryReader reader = new BinaryReader(memory))
                    {
                        for (int i = 0; i < fileBytes.Length; i++)
                        {
                            byteList.Add(reader.ReadByte());
                        }
                    }
                }

                var outputPath = Path.Combine(_outputDir, fileName);
                File.WriteAllText(outputPath, string.Join(",", byteList));
            }
        }
    }
}
