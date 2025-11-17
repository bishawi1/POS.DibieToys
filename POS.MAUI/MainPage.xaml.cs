using POS.Shared.DTOs;

namespace POS.MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;
            
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            Client.UnitRepository oUnit=new Client.UnitRepository();
            ResultModel result = await oUnit.getAllAsync();
            if (result != null)
            {
                if(result.StatusCode == "200"){

                }
            }
        }
    }
}
