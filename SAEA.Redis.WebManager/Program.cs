﻿using SAEA.Common;
using SAEA.MVC;
using System.Diagnostics;

namespace SAEA.WebRedisManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.Title = "WebRedisManagerService";

            SAEAMvcApplication mvcApplication = new SAEAMvcApplication(false, false, 10240, 1);

            mvcApplication.Start();

            ConsoleHelper.WriteLine("WebRedisManager服务已启动");

            ConsoleHelper.WriteLine("服务地址：http://localhost:39654/html/index.html");

            try
            {
                Process.Start("http://localhost:39654/html/index.html");
            }
            catch { }            

            ConsoleHelper.WriteLine("回车退出服务...");

            ConsoleHelper.ReadLine();
        }
    }
}
