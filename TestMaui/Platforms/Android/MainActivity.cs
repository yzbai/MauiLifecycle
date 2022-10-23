using Android.App;
using Android.Content.PM;
using Android.OS;

namespace TestMaui;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        Console.WriteLine("[HB] [Activity] OnCreate Begin");
        base.OnCreate(savedInstanceState);
        Console.WriteLine("[HB] [Activity] OnCreate End");
    }

    public override void OnAttachedToWindow()
    {
        Console.WriteLine("[HB] [Activity] OnAttachToWindow Begin");

        base.OnAttachedToWindow();

        Console.WriteLine("[HB] [Activity] OnAttachToWindow End");
    }


    public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
    {
        Console.WriteLine("[HB] [Activity] OnCreate PersistableBundle Begin");

        base.OnCreate(savedInstanceState, persistentState);

        Console.WriteLine("[HB] [Activity] OnCreate PersistableBundle End");
    }

    protected override void OnResume()
    {
        Console.WriteLine("[HB] [Activity] OnResume Begin");
        base.OnResume();
        Console.WriteLine("[HB] [Activity] OnResume End");
    }

    protected override void OnPostCreate(Bundle savedInstanceState)
    {
        Console.WriteLine("[HB] [Activity] OnPostCreate Begin");
        base.OnPostCreate(savedInstanceState);
        Console.WriteLine("[HB] [Activity] OnPostCreate End");
    }

    protected override void OnPause()
    {
        Console.WriteLine("[HB] [Activity] OnPause Begin");
        base.OnPause();
        Console.WriteLine("[HB] [Activity] OnPause End");
    }

    protected override void OnStop()
    {
        Console.WriteLine("[HB] [Activity] OnStop Begin");
        base.OnStop();
        Console.WriteLine("[HB] [Activity] OnStop End");
    }

    protected override void OnPostResume()
    {
        Console.WriteLine("[HB] [Activity] OnPostResume Begin");
        base.OnPostResume();
        Console.WriteLine("[HB] [Activity] OnPostResume  End");
    }

    protected override void OnRestart()
    {
        Console.WriteLine("[HB] [Activity] OnRestart  Begin");
        base.OnRestart();
        Console.WriteLine("[HB] [Activity] OnRestart  End");
    }

    protected override void OnDestroy()
    {
        Console.WriteLine("[HB] [Activity] OnDestroy  Begin");
        base.OnDestroy();
        Console.WriteLine("[HB] [Activity] OnDestroy  End");
    }

}
