﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.DebugEngineHost
{
    public static class HostLogger
    {
        private static HostLogChannel s_natvisLogChannel;
        private static HostLogChannel s_engineLogChannel;

        private static string s_engingLogFile;

        public static void EnableHostLogging(Action<string> callback, LogLevel level = LogLevel.Information)
        {
            if (s_engineLogChannel == null)
            {
                s_engineLogChannel = new HostLogChannel(callback, null, level);
            }
        }

        public static void SetEngineLogFile(string logFile)
        {
            s_engingLogFile = logFile;
        }

        public static HostLogChannel GetEngineLogChannel()
        {
            return s_engineLogChannel;
        }

        public static HostLogChannel GetNatvisLogChannel()
        {
            return s_natvisLogChannel;
        }

        public static void Reset()
        {
            s_natvisLogChannel = null;
            s_engineLogChannel = null;
        }
    }
}
