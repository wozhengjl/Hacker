using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Hacker.IO.Model
{
    internal class HistoryBallItem
    {
        private IList<int> redBalls = new List<int>();

        public HistoryBallItem(string historyBallStr)
        {
            string[] strs = historyBallStr.Split(',');
            for (int i = 0; i < strs.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        this.PeriodNo = strs[i];
                        break;
                    case 1:
                        this.DateNo = DateTime.Parse(strs[i]);
                        break;
                    case 8:
                        this.BlueBall = int.Parse(strs[i]);
                        break;
                    default:
                        this.RedBalls.Add(int.Parse(strs[i]));
                        break;
                }
            }
        }

        internal IList<int> RedBalls
        {
            get
            {
                return this.redBalls;
            }
        }

        internal int BlueBall
        {
            get;
            set;
        }

        internal DateTime DateNo
        {
            get;
            set;
        }

        internal string PeriodNo
        {
            get;
            set;
        }
    }
}
