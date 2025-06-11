using Microsoft.Maui.Controls;

namespace TabbedPages.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private void LearnMore_Clicked(object sender, EventArgs e)
    {
        // ???????? ??????? ?????
        DisplayAlert("More Info", "This is the About page with additional details.", "OK");
    }
}
