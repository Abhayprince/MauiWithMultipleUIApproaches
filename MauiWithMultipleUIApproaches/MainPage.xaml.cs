namespace MauiWithMultipleUIApproaches;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void XamlButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new XamlPage());
    }
    private void BlazorButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BlazorPage());
    }
    private void CSharpButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CSharpPage());
    }
}
