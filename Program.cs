using System;

namespace SkyrimSELauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var startupPath = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetEntryAssembly().Location);
            var programPath = System.IO.Path.Combine(startupPath, "SkyrimSELauncher_Exec");

            System.Diagnostics.Process.Start(programPath);
            
        }
    }
}
