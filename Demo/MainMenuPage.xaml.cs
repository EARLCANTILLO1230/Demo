namespace Demo;

public partial class MainMenuPage : ContentPage
{
    public MainMenuPage()
    {
        InitializeComponent();
    }

    private async void RegularPages_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page1());
    }

    private async void TabPages_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TabPage());
    }

    private async void FlyoutPages_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SimpleHamburgerPage());
    }
}