using EggShipUWP.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
        }

        private void Orbit_Loaded()
        {
        }

        private async void RebootPressed(object sender, RoutedEventArgs e)
        {
            // Colonists
            Util.TextPrinter(RemainingInfoTxt, ".....");
            // Scanners
            Util.TextPrinter(AtmosphereInfoTxt, ".....");
            Util.TextPrinter(GravityInfoTxt, ".....");
            Util.TextPrinter(TemperatureInfoTxt, ".....");
            Util.TextPrinter(WaterInfoTxt, ".....");
            Util.TextPrinter(MineralsInfoTxt, ".....");
            // Systems
            Util.TextPrinter(LandingInfoTxt, ".....");
            Util.TextPrinter(ConstructionInfoTxt, ".....");
            // Databases
            Util.TextPrinter(ScientificInfoTxt, ".....");
            Util.TextPrinter(CulturalInfoTxt, ".....");

            await Task.Delay(2000);

            // Colonists
            Util.TextPrinter(RemainingInfoTxt, ShipStatus.Instance.Colonists.ToString());
            // Scanners
            Util.TextPrinter(AtmosphereInfoTxt, ShipStatus.Instance.AtmosphereScanner.ToString() + "%");
            Util.TextPrinter(GravityInfoTxt, ShipStatus.Instance.GravityScanner.ToString() + "%");
            Util.TextPrinter(TemperatureInfoTxt, ShipStatus.Instance.TemperatureScanner.ToString() + "%");
            Util.TextPrinter(WaterInfoTxt, ShipStatus.Instance.WaterScanner.ToString() + "%");
            Util.TextPrinter(MineralsInfoTxt, ShipStatus.Instance.MineralsScanner.ToString() + "%");
            // Systems
            Util.TextPrinter(LandingInfoTxt, ShipStatus.Instance.LandingSystem.ToString() + "%");
            Util.TextPrinter(ConstructionInfoTxt, ShipStatus.Instance.ConstructionSystem.ToString() + "%");
            // Databases
            Util.TextPrinter(ScientificInfoTxt, ShipStatus.Instance.ScientificDatabase.ToString() + "%");
            Util.TextPrinter(CulturalInfoTxt, ShipStatus.Instance.CulturalDatabase.ToString() + "%");
        }
    }
}
