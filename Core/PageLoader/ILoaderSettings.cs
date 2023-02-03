namespace CBrowser.Core.PageLoader
{
    interface ILoaderSettings
    {
        string BaseUrl { get; set; }

        string Prefix { get; set; }
    }
}
