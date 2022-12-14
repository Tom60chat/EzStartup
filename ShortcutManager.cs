using IWshRuntimeLibrary;

namespace KatyCorp.Tools
{
    internal static class ShortcutManager
    {
        internal static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation, string arguments)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.IconLocation = targetFileLocation;           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Arguments = arguments;
            shortcut.Save();                                    // Save the shortcut
        }
    }
}