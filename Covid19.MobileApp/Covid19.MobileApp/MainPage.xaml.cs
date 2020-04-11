using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Covid19.Log;
using Covid19.Log.Models;

namespace Covid19.MobileApp
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Global globalData = ReciveData.GetGlobal();
            Cases.Text = $"Cases: {globalData.Cases.ToString()}";
            Recovered.Text = $"Recovered: {globalData.Recovered.ToString()}";
            Deaths.Text = $"Deaths: {globalData.Deaths.ToString()}";
            MainFrame.IsVisible = true;
        }
    }
}
