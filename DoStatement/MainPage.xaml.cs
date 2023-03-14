using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DoStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void showStepsClick(object sender, RoutedEventArgs e)
        {
            int amount = int.Parse(number.Text);
            steps.Text = string.Empty;
            string current = string.Empty;

            do
            {
                int nextDigit = amount % 8;
                amount /= 8;

                int digitCode = '0' + nextDigit;
                char digit = Convert.ToChar(digitCode);
                current = digit + current;
                steps.Text += current + "\n";
            }
            while (amount != 0);
        }
    }
}
