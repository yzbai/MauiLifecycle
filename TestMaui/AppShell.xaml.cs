using System.Text.Json;

namespace TestMaui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Console.WriteLine("[HB] [Shell] Constructed");

        this.Loaded += AppShell_Loaded;
        this.Unloaded += AppShell_Unloaded;
        this.Focused += AppShell_Focused;
        this.Unfocused += AppShell_Unfocused;

        Routing.RegisterRoute(nameof(NewPage1_1), typeof(NewPage1_1));
        Routing.RegisterRoute(nameof(NewPage1_2), typeof(NewPage1_2));
        
    }

    private void AppShell_Unfocused(object sender, FocusEventArgs e)
    {
        Console.WriteLine("[HB] [Shell] AppShell_Unfocused");
    }

    private void AppShell_Unloaded(object sender, EventArgs e)
    {
        Console.WriteLine("[HB] [Shell] AppShell_Unloaded");
    }

    private void AppShell_Focused(object sender, FocusEventArgs e)
    {
        Console.WriteLine("[HB] [Shell] AppShell_Focused");
    }

    private void AppShell_Loaded(object sender, EventArgs e)
    {
        Console.WriteLine("[HB] [Shell] AppShell_Loaded");
    }

    protected override void OnAppearing()
    {
        Console.WriteLine("[HB] [Shell] OnAppearing Begin");
        base.OnAppearing();
        Console.WriteLine("[HB] [Shell] OnAppearing End");
    }

    protected override void OnDisappearing()
    {
        Console.WriteLine("[HB] [Shell] OnDisappearing Begin");
        base.OnDisappearing();
        Console.WriteLine("[HB] [Shell] OnDisappearing End");
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        Console.WriteLine("[HB] [Shell] OnNavigatingFrom Begin" );
        base.OnNavigatingFrom(args);
        Console.WriteLine("[HB] [Shell] OnNavigatingFrom End");
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        Console.WriteLine("[HB] [Shell] OnNavigatedFrom Begin");
        base.OnNavigatedFrom(args);
        Console.WriteLine("[HB] [Shell] OnNavigatedFrom End");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        Console.WriteLine("[HB] [Shell] OnNavigatedTo Begin");
        base.OnNavigatedTo(args);
        Console.WriteLine("[HB] [Shell] OnNavigatedTo End");
    }


    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        Console.WriteLine("[HB] [Shell] Shell.OnNavigating Begin :" + JsonSerializer.Serialize(args));
        base.OnNavigating(args);
        Console.WriteLine("[HB] [Shell] Shell.OnNavigating End :" + JsonSerializer.Serialize(args));
    }

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        Console.WriteLine("[HB] [Shell] Shell.OnNavigated Begin :" + JsonSerializer.Serialize(args));
        base.OnNavigated(args);
        Console.WriteLine("[HB] [Shell] Shell.OnNavigated End :" + JsonSerializer.Serialize(args));
    }

    ~AppShell()
    {
        Console.WriteLine("[HB] [Shell] ~(Desconstruction)");
    }
}
