using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PaxTestScanner
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private string _ScanValue;
        
        public string ScanValue
        {
            get { return _ScanValue; }
            set
            {
                _ScanValue = value;
                OnPropertyChanged(nameof(ScanValue));
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void BarcodeScanner_OnScanResult(ZXing.Result result)
        {
            Console.WriteLine("result: " + result);

            Device.BeginInvokeOnMainThread(async () =>
            {
                this.BarcodeScanner.IsAnalyzing = false;

                string barcode = result.Text;
                if (barcode.Length > 0)
                {
                    ScanValue = barcode;
                    resultText.Text = barcode;
                }

                this.BarcodeScanner.IsAnalyzing = true;

            });

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            resultText.Text = "";
        }
    }
}
