namespace Demo;

public partial class SimpleHamburgerPage : FlyoutPage
{
    public SimpleHamburgerPage()
    {
        InitializeComponent();
    }

    void OnPage1Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Page1());
    }

    void OnPage2Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Page2());
    }

    void OnPage3Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Page3());
    }
}