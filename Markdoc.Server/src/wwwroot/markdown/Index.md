# Welcome to Markdoc

The easy way on integrating **Markdown** two any Webpage using .NET Blazor

## Example
```c#
@using Markdoc.Core.Render

<MarkdocFile FilePath=wwwroot/markdown/Markdown.md/>
```

## Showcase

This page acts also as a Showcase of the capabilities.
The whole page is only a markdown file which gets rendered
with the above mentioned <MarkdocFile /> Component.

### Images
![Wallpaper Switzerland](/images/wallpaper.png)

### Lists

1. First item
2. Second item
3. Third item
    - Indented item
    - Indented item
4. Fourth item

### Html in Markdown

<p>Html paragraph follwed by a unordered list</p>
<ul>
    <li>Item 1</li>
    <li>Item 2</li>
    <li>Item 3</li>
</ul>
<p>Another paragraph followed by an image</p>
<img src="/images/wallpaper.jpg" width="45%">
<p>Button</p>
<input type="button" onclick="console.log('hello world from markdown!');">

### Links

My favorite search engine is [Duck Duck Go](https://duckduckgo.com).

## Code
```c#
using System.IO;

Console.WriteLine("C# is Awesome");
```