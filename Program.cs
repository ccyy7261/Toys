using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            //设置数据保存路径123
            Path_File.CreatPath();
            //初始化功能列表
            Function_Group.Init();
            //入口
            Start();

            Console.ReadKey();
        }


        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("请从选择下方列表中的功能,输入功能名称运行:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var item in Function_Group.Functions)
            {
                Console.WriteLine(item.Key);
            }
            SelectFunction();
        }

        public static void SelectFunction()
        {
            string _name = Console.ReadLine();
            if (Function_Group.Functions.ContainsKey(_name) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("无法识别用户输入,请重新输入功能名称:");
                SelectFunction();
            }
            else
            {


            }

        }

    }
}
