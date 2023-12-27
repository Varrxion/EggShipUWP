using EggShipUWP.Common;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EggShipUWP
{
    /// <summary>
    /// Game title page
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            //start and set dark
            this.InitializeComponent();
            this.RequestedTheme = ElementTheme.Dark;

            //key listeners
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Util.TextPrinter(TitleTxt, "E G G S H I P");
            Util.TextPrinter(InstructionTxt, "Press Enter to Start");

            // Register the KeyDown event listener
            Windows.UI.Core.CoreWindow.GetForCurrentThread().KeyDown += CoreWindow_KeyDown;
        }

        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            if (Frame.CurrentSourcePageType == typeof(MainPage))
            {
                // Handle the key press event
                if (args.VirtualKey == Windows.System.VirtualKey.Enter)
                {
                    // Navigate to the SecondPage
                    Frame.Navigate(typeof(Orbit));
                }
            }
        }
    }
}
