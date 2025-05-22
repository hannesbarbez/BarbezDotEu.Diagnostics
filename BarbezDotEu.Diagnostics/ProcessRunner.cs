// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics;

namespace BarbezDotEu.Diagnostics
{
    /// <summary>
    /// Provides methods to run external processes.
    /// </summary>
    public static class ProcessRunner
    {
        /// <summary>
        /// Opens the specified URI using the default process starter.
        /// </summary>
        /// <param name="fileNameOrUrlOrCommand">The URI to open.</param>
        public static void Start(string fileNameOrUrlOrCommand)
        {
            Process.Start(fileNameOrUrlOrCommand);
        }

        /// <summary>
        /// Runs an external process.
        /// </summary>
        /// <param name="appPath">The application path.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="awaitFinish">Whether to wait for the process to finish.</param>
        public static void RunExternalProcess(string appPath, string args, bool awaitFinish = false)
        {
            ProcessStartInfo info = new ProcessStartInfo(appPath, @args)
            {
                UseShellExecute = false,
            };

            Process p = new Process
            {
                StartInfo = info,
            };

            p.Start();
            if (awaitFinish)
                p.WaitForExit();
        }
    }
}
