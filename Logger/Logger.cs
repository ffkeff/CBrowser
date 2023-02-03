namespace CBrowser.Logger
{
    class Logger
    {
        private readonly StreamWriter writer;
        private string LogPath { get; set; }
        Logger(string LogPath)
        {
            this.LogPath = LogPath;
            writer = new StreamWriter(LogPath);
        }

        public void AddLog(params string[] args)
        {
            foreach (var arg in args)
            {
                writer.WriteLine(arg);
            }
            writer.WriteLine();
        }

        public void Dispose()
        {
            writer.Dispose();
        }
    }
}
