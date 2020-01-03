using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPatterns.ProxyDesignPattern
{
    class CommandExecutorImpl : ICommandExecutor
    {
        public void RunCommand(string cmd)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = cmd;
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine("Cmd Executed.");
        }
    }
}
