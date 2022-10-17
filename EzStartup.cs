using System;
using System.Diagnostics;
using System.IO;

namespace KatyCorp.Tools
{
    public class EzStartup
    {
        static readonly Process process = Process.GetCurrentProcess();
        const string argument = "-Hide";

        public static void SetStartup()
        {
            var oldStartupFile = GetStartupFilePath().Replace(".lnk",".url");
            if (File.Exists(oldStartupFile))
                File.Delete(oldStartupFile);

            ShortcutManager.CreateShortcut(Path.GetFileNameWithoutExtension(process.MainModule.FileName), Path.GetDirectoryName(GetStartupFilePath()), process.MainModule.FileName, argument);
        }

        public static void RemoveStartup() => File.Delete(GetStartupFilePath());

        public static bool IsStartupSet() => File.Exists(GetStartupFilePath());

        public static bool IsStartAtStartup()
        {
            Console.WriteLine(Environment.CommandLine);
            return Environment.CommandLine.Contains(argument);
        }

        public static string GetStartupFilePath() => Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Startup),
                Path.GetFileNameWithoutExtension(process.MainModule.FileName) + ".lnk");
    }
}
