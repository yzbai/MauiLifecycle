using System.Text.Json;



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

        this.PageAppearing += App_PageAppearing;
        this.PageDisappearing += App_PageDisappearing;

        this.ModalPushing += App_ModalPushing;
        this.ModalPushed += App_ModalPushed;
        this.ModalPopping += App_ModalPopping;
        this.ModalPopped += App_ModalPopped;
    }

    private void App_ModalPopping(object sender, ModalPoppingEventArgs e)
    {
        Console.WriteLine("[HB] [App] ModalPopping");
    }

    private void App_ModalPopped(object sender, ModalPoppedEventArgs e)
    {
        Console.WriteLine("[HB] [App] ModalPopped");
    }


    private void App_ModalPushed(object sender, ModalPushedEventArgs e)
    {
        Console.WriteLine("[HB] [App] ModalPushed");
    }

    private void App_ModalPushing(object sender, ModalPushingEventArgs e)
    {
        Console.WriteLine("[HB] [App] ModalPusing");
    }

    private void App_PageDisappearing(object sender, Page e)
    {
        Console.WriteLine("[HB] [App] PageDisappearing");
    }

    private void App_PageAppearing(object sender, Page e)
    {
        Console.WriteLine("[HB] [App] PageAppearing");
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        Console.WriteLine("[HB] [App] CreateWindow");

        if (Windows.Count > 1)
            throw new NotImplementedException($"Either set {nameof(MainPage)} or override {nameof(App.CreateWindow)}.");

        if (Windows.Count > 0)
            return Windows[0];

        if (MainPage != null)
        {
            var window = new MyWindow(MainPage);



            return window;
        }

        throw new NotImplementedException($"Either set {nameof(MainPage)} or override {nameof(App.CreateWindow)}.");
    }

    //Window.Created
    //启动方式1：从新启动
    protected override void OnStart()
    {
        Console.WriteLine("[HB] [App] OnStart Begin");
        base.OnStart();
        //进入内存，不执行Resume

        //window存在

        Console.WriteLine("[HB] [App] OnStart End");

    }

    

    //Window.Resumed
    //启动方式2：恢复中启动
    protected override void OnResume()
    {
        Console.WriteLine("[HB] [App] OnResume Begin");

        base.OnResume();

        Console.WriteLine("[HB] [App] OnResume End");
        //从后台来前台

    }

    //Window.Stopped
    //结束方式：
    protected override void OnSleep()
    {
        Console.WriteLine("[HB] [App] OnSleep Begin");
        base.OnSleep();
        //进入后台
        Console.WriteLine("[HB] [App] OnSleep End");

    }


}
