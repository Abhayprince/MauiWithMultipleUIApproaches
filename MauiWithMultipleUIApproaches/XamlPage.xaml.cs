namespace MauiWithMultipleUIApproaches;

public partial class XamlPage : ContentPage
{
	public XamlPage()
	{
		InitializeComponent();
	}
	int count = 0;
    private void btn_Clicked(object sender, EventArgs e)
    {
		count++;
		btn.Text = $"You clicked {count} times.";
    }
}