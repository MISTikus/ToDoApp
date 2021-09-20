using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ToDoApp {
    public class Program {
        public static async Task Main(string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // ADD YOUR SERVICES HERE
            builder.Services.AddScoped<LocalStorageService>();
            builder.Services.AddScoped<InteropService>();
            // ADD YOUR SERVICES HERE

            await builder.Build().RunAsync();
        }
    }
}