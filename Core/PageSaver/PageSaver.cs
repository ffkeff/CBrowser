namespace CBrowser.Core.PageSaver
{
    class PageSaver
    {
        private Dictionary<string, string> pageDictionary;
        public PageSaver()
        {
            pageDictionary = new Dictionary<string, string>();
        }

        public void AddPage(string name, string content)
        {
            pageDictionary[name] = content;
        }

        public void DeletePage(string name)
        {
            pageDictionary.Remove(name);
        }

        public string GetPageByName(string name)
        {
            return pageDictionary[name];
        }

        public void Dispose()
        {
            pageDictionary.Clear();
        }
    }
}
