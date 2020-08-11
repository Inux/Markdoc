using System;
using System.IO;
using Markdig;

namespace Markdoc.Core.Markdown
{
    public class Reader
    {
        private readonly string _filePath;
        private readonly Markdig.MarkdownPipeline _pipeline = new Markdig.MarkdownPipelineBuilder().UseAdvancedExtensions().Build();

        public Reader(string filePath)
        {
            _filePath = filePath;
        }

        public string ToHtml()
        {
            var markdown = File.ReadAllText(_filePath);
            return Markdig.Markdown.ToHtml(markdown, _pipeline);
        }
    }
}