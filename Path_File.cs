using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Path_File
    {
        //数据保存路径
        public static string Path = @"D:\Temp_Toys";
        
        public static void CreatPath()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("推荐使用默认路径:\"D:\\Temp_Toys\" ... 或者输入\"自定义\"来设置路径");
            string _r = Console.ReadLine();
            if (_r == "自定义")
            {
                CreatCustom();
            }
            else
            {
                CreatDefault();
            }
        }
        //系统 默认
        public static void CreatDefault()
        {
            if (Directory.Exists(@"D:"))
            {
                if (Directory.Exists(@"D:\Temp_Toys") == false)
                {
                    Path = @"D:\Temp_Toys";
                    try
                    {
                        int b = 0;
                        int a = 1 / b;
                        Directory.CreateDirectory(Path);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("数据文件夹\"{0}\"创建成功！", Path);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("创建文件夹\"{0}\"异常:{1}", Path, ex);
                        CreatCustom();
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("确认数据保存路径:\"{0}\"", Path);
                }
            }
            else 
            {
                CreatCustom();
            }
            
        }
        //用户 自定义
        public static void CreatCustom()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("请指定一个路径保存数据 ... 例: D:\\Temp_Toys");
            Path = Console.ReadLine();
            if (Directory.Exists(Path))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("确认数据保存路径:\"{0}\"", Path);
                return;
            }
            try
            {
                Directory.CreateDirectory(Path);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("文件夹\"{0}\"创建成功！", Path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("创建文件夹\"{0}\"异常:{1}", Path, ex);
                CreatCustom();
            }
        }

    }

}

