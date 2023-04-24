﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS___PI___v2
{
    public class Logs
    {
        const string info = "info";
        const string warn = "warn";
        const string error = "error";
        const string fatal = "fatal";
        /// <summary>
         	/// Construção do log
         	/// </summary>
        /// 

        public Logs()
        {

        }

        public void SaveLog(string message)
        {
            string Ficheiro = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\logs.txt";
            StreamWriter file = new StreamWriter(Ficheiro, true, Encoding.Default);
            file.WriteLine(DateTime.Now + " > " + message);
            file.Dispose();
        }




        public void log(int tipo, string log)
        {
            string logando = "";
            switch (tipo)
            {
                case 0:
                    logando += info + " - " + log;
                    break;

                case 1:
                    logando += error + " - " + log;
                    break;

                case 2:
                    logando += warn + " - " + log;
                    break;

                case 3:
                    logando += fatal + " - " + log;
                    break;

                default: return;
            }
            SaveLog(logando);
        }
    }
}
