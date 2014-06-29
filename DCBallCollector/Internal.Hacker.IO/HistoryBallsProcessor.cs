using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internal.Hacker.Balls.Math;
using Internal.Hacker.IO.Model;

namespace Internal.Hacker.IO
{
    public class HistoryBallsProcessor
    {
        public HistoryBallsProcessor(string inputpath, string outputpath, string rawDatapath)
        {
            this.InputPath = inputpath;
            this.OutputPath = outputpath;
            this.RawDataPath = rawDatapath;
        }

        private string OutputPath { get; set; }

        private string InputPath { get; set; }

        private string RawDataPath { get; set; }

        private void GenerateInputData()
        {
            using (StreamReader rawReader = new StreamReader(this.RawDataPath, Encoding.UTF8))
            {
                string rawRecord = rawReader.ReadLine();

                if (File.Exists(this.InputPath))
                {
                    using (StreamReader inputReader = new StreamReader(this.InputPath, Encoding.UTF8))
                    {
                        while (rawRecord != null)
                        {
                            string inputRecord = inputReader.ReadLine();
                            var rawItems = rawRecord.Split(',');
                            var inputItems = !string.IsNullOrEmpty(inputRecord) ? inputRecord.Split(',') : null;

                            if (inputItems != null && string.Equals(rawItems[0], inputItems[0], StringComparison.OrdinalIgnoreCase))
                            {
                                for (int i = 2; i < 9; i++)
                                {
                                    if (int.Parse(rawItems[i]) != int.Parse(inputItems[i]))
                                    {
                                        throw new Exception(string.Format("raw1:{0}, new1: {1}", rawRecord, inputRecord));
                                    }
                                }

                                rawRecord = rawReader.ReadLine();

                                continue;
                            }
                            else if (inputRecord != null)
                            {
                                throw new Exception(string.Format("raw2:{0}, new2: {1}", rawRecord, inputRecord));
                            }

                            else
                            {
                                break;
                            }
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(this.InputPath, true, Encoding.UTF8))
                {
                    while (rawRecord != null)
                    {
                        if (!string.IsNullOrEmpty(rawRecord))
                        {
                            var rawItems = rawRecord.Split(',');

                            writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                                rawItems[0], DateTime.Parse(rawItems[1]).ToString("yyyy-MM-dd"), rawItems[2], rawItems[3], rawItems[4], rawItems[5], rawItems[6], rawItems[7], rawItems[8]));
                        }

                        rawRecord = rawReader.ReadLine();
                    }
                }
            }
        }

        public void ConbineHistortyBallsData()
        {
            GenerateInputData();

            using (StreamReader reader = new StreamReader(this.InputPath, Encoding.UTF8))
            {
                using (StreamWriter writer = new StreamWriter(this.OutputPath, false, Encoding.UTF8))
                {
                    string historyItem = string.Empty;

                    while (!reader.EndOfStream)
                    {
                        historyItem = reader.ReadLine();
                        HistoryBallItem ballItem = new HistoryBallItem(historyItem);
                        IList<string> redBalls = new List<string>();
                        foreach (var ballNumber in ballItem.RedBalls)
                        {
                            redBalls.Add(ConvertBallNumberToStr(ballNumber));
                        }

                        Console.WriteLine(String.Format("{0}", ballItem.PeriodNo));
                        for (int i = 1; i <= 6; i++)
                        {
                            IList<string> combination = Combination.CombineBalls(redBalls, 6, i);
                            foreach (var item in combination)
                            {
                                writer.WriteLine(String.Format("{0},{1},{2}", ballItem.PeriodNo, ballItem.DateNo, item));
                            }
                        }
                    }
                }
            }
        }

        private int ConvertBallStrToNumber(string ball)
        {
            if (ball[0] >= 'A')
            {
                return ball[0] - 'A' + 10;
            }
            else
            {
                return ball[0] - '0';
            }
        }

        private string ConvertBallNumberToStr(int ball)
        {
            if (ball < 10)
            {
                return ball.ToString();
            }
            else
            {
                return ((char)('A' + ball - 10)).ToString();
            }
        }
    }
}
