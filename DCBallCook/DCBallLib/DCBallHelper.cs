using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double.Color.Ball.Common
{
    public static class DCBallHelper
    {
        public static string DecodeBalls(string balls)
        {
            IList<int> ballsNo = new List<int>();

            for (int index = 0; index < balls.Length; index++) 
            {
                ballsNo.Add(DecodeBall(balls[index]));
            }

            return string.Join(",", ballsNo);
        }

        private static int DecodeBall(char ball)
        {
            if (ball >= 'A')
            {
                return ball - 'A' + 10;
            }
            else
            {
                return ball - '0';
            }
        }
    }
}
