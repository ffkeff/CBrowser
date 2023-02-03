using System.Net;
using CBrowser.Logger;

namespace CBrowser.Core.PageLoader
{
    class PageLoader
    {
        private readonly HttpClient client;
        private string uri;
        public PageLoader(ILoaderSettings settings)
        {
            client = new HttpClient();
            uri = $"{settings.BaseUrl}/{settings.Prefix}";
        }

        public async Task<string> GetPageAsync()
        {
            var response = await client.GetAsync(uri);
            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                var source = await response.Content.ReadAsStringAsync();
                return source;
            }
            else
            {
                return null;
            }
        }
    }
}
