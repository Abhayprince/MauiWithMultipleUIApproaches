namespace MauiWithMultipleUIApproaches;

public class CSharpPage : ContentPage
{
	int count = 0;
	public CSharpPage()
	{
		Title = "C# Page";
		var button = new Button
		{
            Text = "Click me",
        };
		button.Clicked += (sender, e) =>
		{
            count++;
            button.Text = $"You clicked {count} times.";
        };
		Content = new VerticalStackLayout
		{
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Spacing = 15,
			Children = {
				new Label 
				{ 
					HorizontalOptions = LayoutOptions.Center, 
					VerticalOptions = LayoutOptions.Center, 
					Text = "Welcome to .NET MAUI! C# Page",
					TextColor = Colors.Black,
				},
				button
			}
		};
	}
}