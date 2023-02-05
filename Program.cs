using CBrowser.Core.PageLoader;
using CBrowser.Core.PageSaver;

namespace CBrowser
{
    class CBrowser
    {
        public static void Main()
        {
            var form = new Form1();
            form.Text = "asdasdas";
            var settings = new LoaderSettings();
            settings.BaseUrl = "https://google.com";
            settings.Prefix = "";
            var pageStream = new PageLoader(settings);
            var page = pageStream.GetPageAsync();
            var pageDictionary = new PageSaver();
            pageDictionary.AddPage("google", page.Result);
            //Console.WriteLine(pageDictionary.GetPageByName("google"));
            //form.richTextBox1_TextChanged(page.Result);
        }
    }
}
