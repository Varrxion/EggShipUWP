using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace EggShipUWP
{
    internal static class Util
    {
        public static async void TextPrinter(TextBlock target, string text)
        {
            int index = 0;
            while (index <= text.Length)
            {
                target.Text = text.Substring(0, index);
                index++;
                await Task.Delay(200);
            }
        }
    }
}
