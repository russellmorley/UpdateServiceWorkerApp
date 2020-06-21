﻿using System;
using System.Diagnostics;
using System.Text;

namespace Updater.Process
{
    internal static class Utilities
    {
        internal static int ExecuteCommand(string command, string arguments, ref StringBuilder standardOutput, string workingDir = null)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = command;
            processStartInfo.Arguments = arguments;
            //processStartInfo.RedirectStandardOutput = true;
            //processStartInfo.CreateNoWindow = false;
            //processStartInfo.UseShellExecute = false;
            if (workingDir != null)
            {
                processStartInfo.WorkingDirectory = workingDir;
            }
            //processStartInfo.RedirectStandardError = true;
            var proc = new System.Diagnostics.Process
            {
                StartInfo = processStartInfo
            };

            using (proc)
            {
                proc.Start();
                //standardOutput.AppendLine(proc.StandardOutput.ReadToEnd() + Environment.NewLine);
                //standardOutput.AppendLine(proc.StandardError.ReadToEnd());
                //proc.WaitForExit();
                return 0;// proc.ExitCode;
            }
        }
    }
}