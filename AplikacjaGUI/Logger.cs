using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AplikacjaGUI
{
    class Logger
    {
        private readonly string MUTEX_GUID = "e1ffff8f-c91d-4188-9e82-c92ca5b1d057";
        private Mutex m_oLoggerMutex = null;
        private int liczbaDanych = 0;
        private String sciezka;

        public Logger(int a, String path)
        {
            m_oLoggerMutex = new Mutex(false, MUTEX_GUID);
            liczbaDanych = a;
            sciezka = path;
        }

        public void Log()
        {
            m_oLoggerMutex.WaitOne();
            {
                StreamWriter oFile = null;
                try
                {
                    oFile = File.AppendText(sciezka);
                    for (int i = 0; i < liczbaDanych; i++) {
                        oFile.WriteLine("Watek-" + Thread.CurrentThread.ManagedThreadId + " dana" + i);
                    }
                    oFile.Flush();
                }
                finally
                {
                    if (null != oFile)
                    {
                        oFile.Close();
                        oFile.Dispose();
                    }
                }
            }
            m_oLoggerMutex.ReleaseMutex();
        }
    }
}
