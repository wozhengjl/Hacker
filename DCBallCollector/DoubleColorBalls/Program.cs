using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Internal.Hacker.IO;

namespace DoubleColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string historyBallsDataPath = ConfigurationManager.AppSettings["HistoryBallDataPath"];
                string outputBallsCombinationPath = ConfigurationManager.AppSettings["CombinationBallDataPath"];
                string rawBallsDataPath = ConfigurationManager.AppSettings["InputBallDataPath"];
                HistoryBallsProcessor historyDataProcessor = new HistoryBallsProcessor(historyBallsDataPath, outputBallsCombinationPath, rawBallsDataPath);
                historyDataProcessor.ConbineHistortyBallsData();
            }
            catch (Exception e) {
                Console.Write(e);
            }

            Console.Read();
        }
    }
}
