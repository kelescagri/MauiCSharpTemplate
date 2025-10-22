using Microsoft.Maui.Controls;

namespace MauiCSharpTemplate;

public class MainPage : ContentPage
{
    int counter = 0;

    public MainPage()
    {
        Title = "C# Only MAUI App";

        var label = new Label
        {
            Text = "Hello from .NET MAUI (C# only)!",
            FontSize = 22,
            HorizontalOptions = LayoutOptions.Center
        };

        var button = new Button
        {
            Text = "Click me!",
            HorizontalOptions = LayoutOptions.Center
        };

        button.Clicked += async (s, e) =>
        {
            counter++;
            await DisplayAlert("Tapped!", $"You clicked {counter} times.", "OK");
        };

        Content = new VerticalStackLayout
        {
            Padding = 30,
            Spacing = 20,
            Children = { label, button }
        };
    }
}

