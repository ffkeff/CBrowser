using CBrowser.Core.PageLoader;
using CBrowser.Core.PageSaver;

namespace CBrowser
{
    class CBrowser
    {
        public static void Main()
        {
            var settings = new LoaderSettings();
            settings.BaseUrl = "https://google.com";
            settings.Prefix = "";
            var pageStream = new PageLoader(settings);
            var page = pageStream.GetPageAsync().ToString();
            var pageDictionary = new PageSaver();
            pageDictionary.AddPage("google", page);
            Console.WriteLine(pageDictionary.GetPageByName("google"));
        }
    }
}
