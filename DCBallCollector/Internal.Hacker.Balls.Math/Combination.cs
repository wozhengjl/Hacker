using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Hacker.Balls.Math
{
    public class Combination
    {
        /// <summary>
        /// all combination of balls list, Cn/m
        /// </summary>
        /// <param name="balls">balls list</param>
        /// <param name="n">Cn/m</param>
        /// <param name="m">Cn/m</param>
        /// <returns></returns>
        public static IList<string> CombineBalls(IList<string> balls, int n, int m)
        {
            IList<string> ballCombination = new List<string>();
            if (m == 1)
            {
                return balls;
            }
            else if (n == m)
            {
                StringBuilder ballCombinationStr = new StringBuilder();
                foreach (string ball in balls)
                {
                    ballCombinationStr.Append(ball);
                }
                ballCombination.Add(ballCombinationStr.ToString());
                return ballCombination;
            }
            else
            {
                foreach (string ball in balls)
                {
                    var newBalls = balls.Where(ball2 => (string.Compare(ball2, ball) > 0));
                    IList<string> combinePartBalls = CombineBalls(newBalls.ToList(), n - 1, m - 1);
                    foreach (var combinePartBall in combinePartBalls)
                    {
                        ballCombination.Add(String.Format("{0}{1}", ball, combinePartBall));
                    }
                }
                return ballCombination;
            }
        }
    }
}
