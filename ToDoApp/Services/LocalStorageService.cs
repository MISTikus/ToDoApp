using Microsoft.JSInterop;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace ToDoApp {
    public class LocalStorageService {
        private const string getFunctionName = "localStorage.getItem";
        private const string setFunctionName = "localStorage.setItem";

        private readonly IJSRuntime js;

        public event EventHandler<string> KeyDataChanged;

        public LocalStorageService(IJSRuntime js) {
            this.js = js;
        }

        public async Task<T> GetAsync<T>(string key) => default;
        public async Task SetAsync<T>(string key, T value) {}
    }
}