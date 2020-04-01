using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PBank pBank = new PBank();
            //输入密码
            Console.WriteLine("请输入密码");
            string Mima = Console.ReadLine();
            int mima = int.Parse(Mima);
            pBank.Mima = 123456;
            //密码正确。显示余额并取钱
            if (mima == 123456)
            {
                pBank.chunkuan();
                pBank.qukuan();
                pBank.yue();
                pBank.tuichu();
            }
            //密码错误。显示退出
            else
            {
                pBank.password();
            }
            
        }
    }
}
