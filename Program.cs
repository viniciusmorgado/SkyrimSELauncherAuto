using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SkyrimSELauncher
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        static void Main(string[] args)
        {
            var startupPath = System.IO.Path.GetDirectoryName
            (
                System.Reflection.Assembly.GetEntryAssembly().Location
            );
            var programPath = System.IO.Path.Combine(startupPath, "skse64_loader.exe");

            System.Diagnostics.Process.Start(programPath);
            IntPtr h = Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow(h, 0);
                
                while (true)
                {
                    System.Threading.Thread.Sleep(1);
                }
        }
    }
}
