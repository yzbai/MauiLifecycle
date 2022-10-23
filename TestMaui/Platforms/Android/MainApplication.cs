using Android.App;
using Android.Content;
using Android.Runtime;

namespace TestMaui;

[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
        Console.WriteLine("[HB] [PlatformApplication] Construction");
    }

    public override void OnCreate()
    {
        Console.WriteLine("[HB] [PlatformApplication] OnCreate Begin");

        base.OnCreate();

        Console.WriteLine("[HB] [PlatformApplication] OnCreate End");
    }

    public override void OnTerminate()
    {
        Console.WriteLine("[HB] [PlatformApplication] OnTerminate Begin");
        base.OnTerminate();
        Console.WriteLine("[HB] [PlatformApplication] OnTerminate End");
    }

    public override void OnLowMemory()
    {
        Console.WriteLine("[HB] [PlatformApplication] OnLowMemory Begin");
        base.OnLowMemory();
        Console.WriteLine("[HB] [PlatformApplication] OnLowMemory End");
    }

    public override void OnTrimMemory(TrimMemory level)
    {
        Console.WriteLine("[HB] [PlatformApplication] OnTrimMemory Begin");
        base.OnTrimMemory(level);
        Console.WriteLine("[HB] [PlatformApplication] OnTrimMemory End");
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();


}
