using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//부족한 금액 계산하기

namespace CodeKata
{
    class Solution_35
    {
        public long solution(int price, int money, int count)
        {
            int totalCost = 0;
            for (int i = 1; i <= count; i++)
            {
                totalCost += price * i;
            }
            return (money > totalCost) ? 0 : totalCost - money;
        }
    }
}
