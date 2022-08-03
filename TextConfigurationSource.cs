namespace HelloApp
{
    public class TextConfigurationSource:IConfigurationSource
    {
        public string FilePath { get; set; }
        public TextConfigurationSource(string filePath)
        {
            FilePath = filePath;
        }
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            string filePach = builder.GetFileProvider().GetFileInfo(FilePath).PhysicalPath;
            return new TextConfigurationProvider(filePach);
        }
    }
}
