﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库物料管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            方法类.operateSQL operSQL = new 方法类.operateSQL();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            operSQL.AttachDB();
            Application.Run(new login());
        }
    }
}
