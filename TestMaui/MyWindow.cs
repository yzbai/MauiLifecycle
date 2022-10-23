namespace TestMaui;

public class MyWindow : Window
{
    public MyWindow()
    {
        Backgrounding += MyWindow_Backgrounding;

        
        Console.WriteLine("[HB] [Window] Construct");
    }

    private void MyWindow_Backgrounding(object sender, BackgroundingEventArgs e)
    {
        Console.WriteLine("[HB] [Window] Backgrounding");
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
    }

    protected override void OnResumed()
    {
        Console.WriteLine("[HB] [Window] OnResumed Begin");
        base.OnResumed();
        Console.WriteLine("[HB] [Window] OnResumed End");
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
}
