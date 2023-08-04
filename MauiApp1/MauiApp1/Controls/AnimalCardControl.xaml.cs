using MauiApp1.Common;

namespace MauiApp1.Controls;

public partial class AnimalCardControl : ContentView
{
    public static readonly BindableProperty AnimalImageSelectionProperty = BindableProperty.Create(nameof(AnimalImageSelection), typeof(AnimalImageType), typeof(AnimalCardControl), AnimalImageType.None);

    public AnimalCardControl()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public AnimalImageType AnimalImageSelection
    {
        get => (AnimalImageType)GetValue(AnimalImageSelectionProperty);
        set => SetValue(AnimalImageSelectionProperty, value);
    }

}
