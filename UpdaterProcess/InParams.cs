﻿using System;
using System.IO;
using System.Windows.Markup;

namespace Updater.Process
{
    internal class InParams
    {
        internal int ProcessId { get; set; }
        internal DirectoryInfo SourceDirInfo { get; set; }
        internal DirectoryInfo TargetDirInfo { get; set; }
        internal string StopCommandFileName { get; set; }
        internal string StopCommandArguments { get; set; }
        internal bool StopCommandWaitForExit { get; set; }
        internal string StartCommandFileName { get; set; }
        internal string StartCommandArguments { get; set; }
        internal bool StartCommandWaitForExit { get; set; }

        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0:
                        {
                            ProcessId = int.Parse(value);
                            break;
                        }
                    case 1:
                        {
                            DirectoryInfo sourceDir = new DirectoryInfo(value);
                            if (sourceDir.Exists)
                            {
                                SourceDirInfo = sourceDir;
                            }
                            else
                            {
                                throw new Exception($"SourceDir doesn't exist: {value}");
                            }
                            break;
                        }
                    case 2:
                        {
                            DirectoryInfo targetDir = new DirectoryInfo(value);
                            if (targetDir.Exists)
                            {
                                TargetDirInfo = targetDir;
                            }
                            else
                            {
                                throw new Exception($"TargetDir doesn't exist: {value}");
                            }
                            break;
                        }
                    case 3:
                        {
                            StopCommandFileName = value;
                            break;
                        }
                    case 4:
                        {
                            StopCommandArguments = value;
                            break;
                        }
                    case 5:
                        {
                            StopCommandWaitForExit = bool.Parse(value);
                            break;
                        }
                    case 6:
                        {
                            StartCommandFileName = value;
                            break;
                        }
                    case 7:
                        {
                            StartCommandArguments = value;
                            break;
                        }
                    case 8:
                        {
                            StartCommandWaitForExit = bool.Parse(value);
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        internal bool HasStartCommand() => !string.IsNullOrEmpty(StartCommandFileName);

        internal bool HasStopCommand() => !string.IsNullOrEmpty(StopCommandFileName);
    }
}
