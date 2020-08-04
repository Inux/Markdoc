namespace Markdoc.Server.Data
{
    public class MarkdownService : IMarkdownService
    {
        public MarkdownService()
        {

        }

        public string[] GetTopics()
        {
            return new string[] {"one", "two"};
        }
    }
}