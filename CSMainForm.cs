using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Constructor
{

    public partial class CSMainForm : Form
    {
        //small define
        bool inDev = Properties.Settings.Default.APP_INDEV;

        // MAJOR = 741/1000
        // MINOR = 741/100
        // PATCH = (741/10)%10
        // BUILD = 741%10
        struct Version
        {
            public int MAJOR;
            public int MINOR;
            public int PATCH;
            public int BUILD;

            public Version(int number)
            {
                this.MAJOR = number / 1000;
                this.MINOR = number / 100;
                this.PATCH = (number / 10) % 10;
                this.BUILD = number % 10;
            }
        }
        Version appVersion;

        // Main init body
        public CSMainForm()
        {
            // Init app
            LogInfo(ConsoleColor.Magenta, "[CSInit]: ", "Application initialize started...\n");
            string programmName = Properties.Settings.Default.APP_NAME;
            appVersion = new Version(Properties.Settings.Default.APP_VER);

            // Init all UI
            LogInfo(ConsoleColor.Magenta, "[CSInit]: ", "WinForms initialize started...\n");
            InitializeComponent();
            // Change label color & text
            LogInfo(ConsoleColor.Magenta, "[CSInit]: ", "Change application title & info...\n");
            Log("\n");
            Label programmText = (Label)this.Controls[3].Controls[0];

            programmText.Text = programmName + " - "
                + appVersion.MAJOR + "."
                + appVersion.MINOR + ""
                + appVersion.PATCH + " ";
            this.Text = programmName;

            if (inDev)
            {
                LogInfo(ConsoleColor.Red, "(IN-DEV): ", "Dev mode detected... Enable dev enviroments\n");
                // Change title
                programmText.Text = programmText.Text + " (IN-DEV)";
                this.Text = this.Text + " (IN-DEV)";
                // TODO: Maybe later i add to helpful enviroment
            }
            LogInfo(ConsoleColor.Cyan, "[CSInfo]: ", 
                "App title: " + programmText.Text
                + "\n          Process name: " + programmName + "\n"
                );
            Log("\n");
            LogInfo(ConsoleColor.Green, "[CSInitResult]: ", "Initialization is done!\n");
        }
        
        // It need for open console
        // SHITY METHOD. DONT USE!!!!!!!!
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();
        
        /// <summary>
        /// Debug Logger
        /// </summary>
        private void Log(string txt, ConsoleColor col = ConsoleColor.White)
        {
#if DEBUG
            Console.ForegroundColor = col;
            Console.Write(txt);
#endif
        }
        private void LogInfo(ConsoleColor col, string prefix, string txt)
        {
#if DEBUG
            Log(prefix, col);
            Log(txt);
#endif
        }

        // It used only in CSCtrl_OnMouseMove
        Point oldMousePos;
        /// <summary>
        /// Move window, when mouse left btn is pressed
        /// </summary>
        private void CSCtrl_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left   += e.X - oldMousePos.X;
                this.Top    += e.Y - oldMousePos.Y;
            }
        }
        /// <summary>
        /// ...
        /// </summary>
        private void CSCtrl_OnMouseDown(object sender, MouseEventArgs e)
        {
            oldMousePos = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Fade object timer
        /// </summary>
        private void CSFadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                CSFadeTimer.Stop();
            }
            else
            {
                this.Opacity += 0.05;
            }
        }
        /// <summary>
        /// Close focus
        /// </summary>
        private void CSCtrl_OnCloseFocus(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(255, 128, 128);
        }
        /// <summary>
        /// Close unfocus
        /// </summary>
        private void CSCtrl_OnCloseUnfocus(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(32, 34, 37);
        }
    }
}
