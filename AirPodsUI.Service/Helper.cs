﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AirPodsUI.Service
{
    public static class Helper
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public static IntPtr ActiveWindowHandle
        {
            get
            {
                return GetForegroundWindow();
            }
        }

        public static void SetActiveWindow(IntPtr hWnd)
        {
            SetForegroundWindow(hWnd);
        }

        /// <summary>
        /// Get the AirPodsUI folder
        /// </summary>
        public static string AirPodsUIFolder { get; set; } = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\AirPodsUI\\";

        /// <summary>
        /// Get the PairedDevices.json file
        /// </summary>
        public static string PairedDevicesFile { get; set; } = $"{AirPodsUIFolder}PairedDevices.json";

        /// <summary>
        /// Get the AirPodsUI\Templates folder
        /// </summary>
        public static string TemplateFolder { get; set; } = $"{AirPodsUIFolder}Templates";

        /// <summary>
        /// Get the AirPodsUI\Assets folder
        /// </summary>
        public static string AssetsFolder { get; set; } = $"{AirPodsUIFolder}Assets";

        /// <summary>
        /// Get the AirPodsUI\Logs folder
        /// </summary>
        public static string LogsFolder { get; set; } = $"{AirPodsUIFolder}Logs";
    }
}