using Microsoft.JSInterop;
using System.Threading.Tasks;
using Folio.Models;

namespace Folio.Client {

    public class BrowserService {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js) {
            _js = js;
        }

        public async Task<WindowDimensions> GetDimensions() {
            return await _js.InvokeAsync<WindowDimensions>("getDimensions");
        }

    }
}
