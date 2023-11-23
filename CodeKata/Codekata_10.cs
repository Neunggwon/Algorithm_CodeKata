using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//배열의 평균값
namespace CodeKata
{
    public class Solution_10
    {
        public class Solution {
            public double solution(int[] numbers)
            {
                double sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                double answer = sum/ numbers.Length;
                return Math.Round(answer);
            }
        }
    }
}
