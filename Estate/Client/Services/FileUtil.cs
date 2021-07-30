using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Client.Services
{
    public static class FileUtil
    {
        public static ValueTask<object> SaveAs(this IJSRuntime js, string fileName, byte[] data)
            => js.InvokeAsync<object>("saveAsFile", fileName, Convert.ToBase64String(data));
    }
}
