using System;
using System.IO;

namespace Tools
{
    public class Log
    {
        private static Log _instance = null;
        string path;
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            // Solución trabajo con hilos o asincronismo
            lock (_protect)
            {
                if (_instance == null)
                    _instance = new Log(path: path);
            }

            return _instance;
        }

        private Log(string path) { this.path = path; }

        public void WriteLog(string message)
        {
            File.AppendAllText(path, message + Environment.NewLine);
        }
    }
}
