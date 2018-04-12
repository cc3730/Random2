﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 將所有號碼加入 List 中
            List<int> members = new List<int>();

            for(int i = 1; i <= 42; i++)
            {
                members.Add(i);
            }

            // 隨機挑出一個印出
            Random rand = new Random();

            for(int i = 0; i < 6; i++)
            {
                int r = rand.Next(1, members.Count);
                Console.Write(members[r] + " ");
                
                // 並從 List 中刪除
                members.RemoveAt(r);
            }
            
            // 暫停畫面
            Console.ReadKey();
        }
    }
}
