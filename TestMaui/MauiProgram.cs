using Microsoft.Maui.LifecycleEvents;

namespace TestMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        Console.WriteLine("[HB] [ServiceContainer] CreateMauiApp. 这里的MauiApp就是一个ServiceContainer。");

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureLifecycleEvents(events =>
            {

                var platformApp = IPlatformApplication.Current;

#if ANDROID
                events.AddAndroid(builder =>
                {
                    builder.OnApplicationCreating(app =>
                        {
                            Console.WriteLine("[HB] [Lifecycle-Events] [PlatformApplication] Creating.");
                        });
                    builder.OnApplicationCreate(app =>
                        {
                            Console.WriteLine("[HB] [Lifecycle-Events] [PlatformApplication] Created.");
                        });

                    builder.OnApplicationLowMemory(app =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [PlatformApplication] LowMemory");
                    });
                    builder.OnApplicationTrimMemory((app, level) =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [PlatformApplication] LowMemory");
                    });

                    builder.OnStart(activity =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [Activity] OnStart");
                    });
                    builder.OnPostCreate((activity, bundld) =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [Activity] OnPostCreate");
                    });
                    builder.OnResume(activity =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [Activity] OnResume");
                    });

                    builder.OnPostResume(activity =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [Activity] OnPostResume");
                    });
                    builder.OnPause(activity =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [Activity] OnPause");
                    });
                    builder.OnStop(activity =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [Activity] OnStop");
                    });
                    builder.OnDestroy(activity =>
                    {
                        //好像并不可靠，还是去Activity中
                        Console.WriteLine("[HB] [Lifecycle-Events] [Activity]  OnDestroy");
                    });
                    builder.OnBackPressed(activity =>
                    {
                        Console.WriteLine("[HB] [Lifecycle-Events] [Activity] OnBackPressed");
                        return false;
                    });

                });
#endif
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<IMauiInitializeService, MauiInitializeService>();
        builder.Services.AddSingleton<IMauiInitializeScopedService, MauiInitializeScopedService>();



        return builder.Build();

    }


}

public class MauiInitializeService : IMauiInitializeService
{
    public void Initialize(IServiceProvider services)
    {
        Console.WriteLine("[HB] [ServiceContainer] 初始化容器 MauiInitializeService.");
    }
}

public class MauiInitializeScopedService : IMauiInitializeScopedService
{
    public void Initialize(IServiceProvider services)
    {
        Console.WriteLine("[HB] [ServiceContainer] 初始化容器Scope MauiInitializeScopedService.");

    }
}
