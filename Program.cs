using Ivy.Hello.Apps;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");
var server = new Server();
#if !DEBUG
server.UseHttpRedirection();
#endif
#if DEBUG
server.UseHotReload();
#endif

var version = typeof(Server).Assembly.GetName().Version!.ToString().EatRight(".0");
server.SetMetaTitle($"Ivy Hello {version}");

var chromeSettings = new ChromeSettings()
    .Header(
        Layout.Vertical().Padding(2)
        | new IvyLogo()
        | Text.Muted($"Version {version}")
    )
    .DefaultApp<HelloApp>()
    .UseTabs(preventDuplicates: true);

server.AddAppsFromAssembly();
server.AddConnectionsFromAssembly();
server.UseHotReload();
server.UseChrome();
await server.RunAsync();