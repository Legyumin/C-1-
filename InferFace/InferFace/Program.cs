﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{

    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0}{1}", DateTime.Now.ToShortTimeString(), message);
        }

        class ClimateMonitor
        {
            private ILogger logger;
            public ClimateMonitor(ILogger logger)
            {
                this.logger = logger;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
