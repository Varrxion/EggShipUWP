using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EggShipUWP
{
    /// <summary>
    /// This page handles the "orbit" event
    /// </summary>
    public sealed partial class Orbit : Page
    {
        public Orbit()
        {
            //start and set dark
            this.InitializeComponent();
            this.RequestedTheme = ElementTheme.Dark;

            //timers
            textTimer = new DispatcherTimer();
            textTimer.Interval = TimeSpan.FromMilliseconds(150);
            textTimer.Start();
        }

        private string titleText = "E G G S H I P";
        private string instructionText = "Press Enter to Start";
        private int currentTextIndex = 0;
        private bool[] timerflags = { false, false };
        private DispatcherTimer textTimer;
    }
}
