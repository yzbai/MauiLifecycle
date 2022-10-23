namespace TestMaui;

public partial class App : Application
{
    public App()
    {
        Console.WriteLine("[HB] [App] Construction Begin");

        InitializeComponent();

        MainPage = new AppShell();

        //app 建立完，才会去Activity

        Console.WriteLine("[HB] [App] Construction End");
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        Console.WriteLine("[HB] [App] CreateWindow");

        if (Windows.Count > 1)
            throw new NotImplementedException($"Either set {nameof(MainPage)} or override {nameof(App.CreateWindow)}.");

        if (Windows.Count > 0)
            return Windows[0];

        if (MainPage != null)
            return new MyWindow(MainPage);

        throw new NotImplementedException($"Either set {nameof(MainPage)} or override {nameof(App.CreateWindow)}.");
    }

    protected override void OnStart()
    {
        Console.WriteLine("[HB] [App] OnStart Begin");
        base.OnStart();
        //进入内存，不执行Resume

        //window存在

        Console.WriteLine("[HB] [App] OnStart End");

    }

    protected override void OnResume()
    {
        Console.WriteLine("[HB] [App] OnResume Begin");

        base.OnResume();

        Console.WriteLine("[HB] [App] OnResume End");
        //从后台来前台
    }

    protected override void OnSleep()
    {
        Console.WriteLine("[HB] [App] OnSleep Begin");
        base.OnSleep();
        //进入后台
        Console.WriteLine("[HB] [App] OnSleep End");
    }
}
