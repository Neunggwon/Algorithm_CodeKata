using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//평균 구하기
namespace CodeKata
{
    public class Solution_12
    {

        public double solution(int[] arr)
        {
            double answer = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                answer += arr[i];
            }
            return answer / arr.Length;
        }
    }
}
