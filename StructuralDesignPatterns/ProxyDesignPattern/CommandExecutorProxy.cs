using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPatterns.ProxyDesignPattern
{
    class CommandExecutorProxy : ICommandExecutor
    {

        private bool isAdmin;
        private ICommandExecutor executor;

        public CommandExecutorProxy(string user, string pwd)
        {
            if ("Admin".Equals(user) && "".Equals(pwd))
                isAdmin = true;
            executor = new CommandExecutorImpl();
        }

        public void RunCommand(string cmd)
        {
            if (isAdmin)
                executor.RunCommand(cmd);
            else
            {
                if (cmd.Trim().StartsWith("rm"))
                    throw new Exception("rm Command is not allowed.");
                else
                    executor.RunCommand(cmd);
            }
        }
    }
}
