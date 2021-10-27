using System;
using System.IO;

namespace DesignPatterns.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        string path = "log.txt";

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        private Log() { }

        public void WriteLog(string message)
        {
            File.AppendAllText(path, message + Environment.NewLine);
        }
    }
}
