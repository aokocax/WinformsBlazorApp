using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace WinformsBlazorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            
            serviceCollection.AddBlazorWebView();

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Main>("#app");
        }
    }
}