using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools;


public static class LogManager
{
    const string LogPath = "Log";
    private static string prefix = "\t";

    private static string getThisMonthDir()
    {
        string path = $@"{LogPath}\{DateTime.Now.Year}-{DateTime.Now.Month}";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        return path;
    }
    private static string getTodayFile()
    {
        string path = $@"{getThisMonthDir()}\{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}.txt";
        if (!File.Exists(path))
            File.Create(path).Close();
        return path;
    }

    public static void WriteToLog(string projectName, string funcName, string message)
    {
        using (StreamWriter sw = new StreamWriter(getTodayFile(), true))
        {
            sw.WriteLine($"{DateTime.Now}{prefix}{projectName}.{funcName} :\t{message}");
        }
    }

    public static void WriteToLogStart(string projectName, string funcName, string message)
    {
        WriteToLog(projectName, funcName, $"{message} start");
        prefix += "\t";
    }
    public static void WriteToLogEnd(string projectName, string funcName, string message)
    {
        prefix = prefix.Substring(1);
        WriteToLog(projectName, funcName, $"{message} end");
    }
    public static void ClearLog()
    {
        string y, m;
        string[] subDirectories = Directory.GetDirectories(LogPath);
        foreach (string subDirctory in subDirectories)
        {
            y = subDirctory.Substring(4, 4);
            m = subDirctory.Substring(9);
            if (twoMonthAgo(int.Parse(y), int.Parse(m)))
                Directory.Delete(subDirctory);

        }

    }
    public static bool twoMonthAgo(int year, int month)
    {
        DateTime date = new DateTime(year, month, 1);
        return date < DateTime.Now.AddMonths(-2);

    }


}
