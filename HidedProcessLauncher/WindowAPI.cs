using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace HidedProcessLauncher
{
    static class WindowAPI
    {
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        private const int SW_FORZE_MINIMIZE = 11;
        private const int SW_MAXIMIZED = 3;
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);


        /// <summary>
        /// This function hides the Window
        /// </summary>
        /// <param name="hwnd">Window handle</param>
        /// <returns></returns>
        public static int HideMainWindow(IntPtr hwnd)
        {
            ShowWindow(hwnd.ToInt32(), SW_FORZE_MINIMIZE);
            return ShowWindow(hwnd.ToInt32(), SW_HIDE);
        }

        /// <summary>
        /// This function shows the Window
        /// </summary>
        /// <param name="hwnd">Window handle</param>
        /// <returns></returns>
        public static int ShowMainWindow(IntPtr hwnd)
        {
            ShowWindow(hwnd.ToInt32(), SW_MAXIMIZED);
            return ShowWindow(hwnd.ToInt32(), SW_SHOW);
        }
    }
}
