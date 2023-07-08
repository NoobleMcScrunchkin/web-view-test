using WinFormsApp;

// Development
// dotnet run

// Publishing
// dotnet restore "./web-view-test.csproj" --runtime win-x64
// dotnet publish "web-view-test.csproj" -c Release -o ./publish --no-restore --runtime win-x64 --self-contained true /p:PublishSingleFile=true

namespace web_view_test
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().RunAsync();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}