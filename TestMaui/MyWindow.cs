using System.Text.Json;

namespace TestMaui;

public class MyWindow : Window
{
    public MyWindow()
    {
        Console.WriteLine("[HB] [Window] Construct");
    }

    public MyWindow(Page page) : base(page)
    {
        Console.WriteLine("[HB] [Window] Construct with page");
    }

    protected override void OnCreated()
    {
        Console.WriteLine("[HB] [Window] OnCreated Begin");
        base.OnCreated();
        Console.WriteLine("[HB] [Window] OnCreated End");

        Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
    }

    protected override void OnResumed()
    {
        Console.WriteLine("[HB] [Window] OnResumed Begin");
        base.OnResumed();
        Console.WriteLine("[HB] [Window] OnResumed End");

        Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
    }

    protected override void OnActivated()
    {
        Console.WriteLine("[HB] [Window] OnActivated Begin");
        base.OnActivated();
        Console.WriteLine("[HB] [Window] OnActivated End");
    }

    protected override void OnDeactivated()
    {
        Console.WriteLine("[HB] [Window] OnDeactivated Begin");
        base.OnDeactivated();
        Console.WriteLine("[HB] [Window] OnDeactivated End");
    }

    protected override void OnStopped()
    {
        Console.WriteLine("[HB] [Window] OnStopped Begin");
        base.OnStopped();
        Console.WriteLine("[HB] [Window] OnStopped End");

        Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
    }




    protected override void OnDestroying()
    {
        Console.WriteLine("[HB] [Window] OnDestroying Begin");
        base.OnDestroying();
        Console.WriteLine("[HB] [Window] OnDestroying End");
    }

    protected override void OnBackgrounding(IPersistedState state)
    {
        Console.WriteLine("[HB] [Window] OnBackgrounding Begin");
        base.OnBackgrounding(state);
        Console.WriteLine("[HB] [Window] OnBackgrounding End");
    }

    private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
    {
        Console.WriteLine("[HB] [Connectivity] ConnectivityChanged : " + JsonSerializer.Serialize(e));
    }
}
