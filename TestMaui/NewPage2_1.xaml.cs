namespace TestMaui;

public partial class NewPage2_1 : ContentPage
{
    const string PageName = nameof(NewPage2_1);
    public NewPage2_1()
    {
        InitializeComponent();


        this.Focused += NewPage_Focused;
        this.Unfocused += NewPage_Unfocused;

        this.Loaded += NewPage_Loaded;
        this.Unloaded += NewPage_Unloaded;

        this.LayoutChanged += NewPage_LayoutChanged;

        this.MeasureInvalidated += NewPage_MeasureInvalidated;

        this.SizeChanged += NewPage_SizeChanged;

        Console.WriteLine($"[HB] [{PageName}] Construction");

    }

    private void NewPage_SizeChanged(object sender, EventArgs e)
    {
        Console.WriteLine($"[HB] [{PageName}] NewPage_SizeChanged");
    }

    private void NewPage_MeasureInvalidated(object sender, EventArgs e)
    {
        Console.WriteLine($"[HB] [{PageName}] NewPage_MeasureInvalidated");
    }

    private void NewPage_LayoutChanged(object sender, EventArgs e)
    {
        Console.WriteLine($"[HB] [{PageName}] NewPage_LayoutChanged");
    }

    private void NewPage_Unloaded(object sender, EventArgs e)
    {
        Console.WriteLine($"[HB] [{PageName}] NewPage_Unloaded");
    }

    private void NewPage_Loaded(object sender, EventArgs e)
    {
        Console.WriteLine($"[HB] [{PageName}] NewPage_Loaded");
    }

    private void NewPage_Unfocused(object sender, FocusEventArgs e)
    {
        Console.WriteLine($"[HB] [{PageName}] NewPage_Unfocused");
    }

    private void NewPage_Focused(object sender, FocusEventArgs e)
    {
        Console.WriteLine($"[HB] [{PageName}] NewPage_Focused");
    }

    protected override void OnAppearing()
    {
        Console.WriteLine($"[HB] [{PageName}] OnAppearing Begin");

        base.OnAppearing();

        Console.WriteLine($"[HB] [{PageName}] OnAppearing End");
    }

    protected override void OnApplyTemplate()
    {
        Console.WriteLine($"[HB] [{PageName}] OnApplyTemplate Begin");
        base.OnApplyTemplate();
        Console.WriteLine($"[HB] [{PageName}] OnApplyTemplate End");
    }

    protected override void OnDisappearing()
    {
        Console.WriteLine($"[HB] [{PageName}] OnDisappearing Begin");
        base.OnDisappearing();
        Console.WriteLine($"[HB] [{PageName}] OnDisappearing End");
    }

    protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
    {
        Console.WriteLine($"[HB] [{PageName}] OnMeasure Begin");
        var s = base.OnMeasure(widthConstraint, heightConstraint);
        Console.WriteLine($"[HB] [{PageName}] OnMeasure End");
        return s;

    }

    protected override void OnSizeAllocated(double width, double height)
    {
        Console.WriteLine($"[HB] [{PageName}] OnSizeAllocated Begin");
        base.OnSizeAllocated(width, height);
        Console.WriteLine($"[HB] [{PageName}] OnSizeAllocated End");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        Console.WriteLine($"[HB] [{PageName}] OnNavigatedTo Begin");
        base.OnNavigatedTo(args);
        Console.WriteLine($"[HB] [{PageName}] OnNavigatedTo End");
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        Console.WriteLine($"[HB] [{PageName}] OnNavigatingFrom Begin");
        base.OnNavigatingFrom(args);
        Console.WriteLine($"[HB] [{PageName}] OnNavigatingFrom End");
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        Console.WriteLine($"[HB] [{PageName}] OnNavigatedFrom Begin");
        base.OnNavigatedFrom(args);
        Console.WriteLine($"[HB] [{PageName}] OnNavigatedFrom End");
    }

    ~NewPage2_1()
    {
        Console.WriteLine($"[HB] [{PageName}] ~(Desconstruction)");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//NewPage1/NewPage1_1");
    }
}