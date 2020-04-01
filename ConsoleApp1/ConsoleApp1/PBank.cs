using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PBank : Ibank,Ipassword 
    {
        int _mima;

        public int Mima { get => _mima; set => _mima = value; }

        public void chunkuan()
        {
            Console.WriteLine("正在存款");
        }

        public void password()
        {
            Console.WriteLine("密码错误，请重新输入密码！！！");
        }

        public void qukuan()
        {
            Console.WriteLine("正在取款");
        }

        public void yue()
        {
            Console.WriteLine("余额为***");
        }
        public void tuichu()
        {
            Console.WriteLine("取卡退出");
        }
    }
}
