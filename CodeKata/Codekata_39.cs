using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//최대공약수와 최소공배수

namespace CodeKata
{
    public class Solution_39
    {
        public int[] solution(int n, int m)
        {
            int[] answer = new int[2];
            int a = n;
            int b = m;
            int temp = 0;
            while (m > 0)
            {
                temp = n % m;
                n = m;
                m = temp;
            }
            answer[0] = n;
            answer[1] = a * b / n;
            return answer;
        }
    }
}
